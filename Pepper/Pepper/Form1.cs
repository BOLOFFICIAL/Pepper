using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Media;

namespace Pepper
{
    public partial class MainForm : Form
    {
        #region Переменные

        private bool wrap = false;                  // Маленькон или большое окно программы
        private bool play = false;                  // Идет проигрывание видео или нет
        private double frames = 0;                  // Кард на котором видео сейчас
        private System.Drawing.Point mouseOffset;   // Позиция мышки   
        private bool start = false;                 // Выбран фаил или нет
        private double frame_count = 0;             // Общее количество кадров в видео
        private bool ispicture = false;             // Выбранный фаил видео или нет
        private int speed_animation = 1;            // Скорость анимации открытия и закрытия панелей
        private bool isMouseDown = false;           // Нажата мыш или нет
        private bool open_settings = false;         // Открыты настойки или нет
        private VideoCapture capture = null;        // Объект выбранного видео
        private string application_puth = "";       // Путь где расположен .exe фаил
        private SoundPlayer soundplayer = null;     // Объект звукового проигрывателя
        private Setting setting = new Setting();    // Объект настроек
        private string directory = "";
        private List<string> files_directory = null;
        public static List<string> labels = null;
        private int index_file_in_directory = 0;

        #endregion

        #region main - Общие методы

        public MainForm()
        {
            InitializeComponent();
            Initialization();
        }

        private void Initialization()
        {
            labels = new List<string>();
            panel_settings.Location = new System.Drawing.Point(0, panel_menu.Height);
            openFileDialog1.FileName = "";
            application_puth = Application.StartupPath;
            setting = new Setting();
            button_pause.Text = "Просмотр";
            if (File.Exists(application_puth + @"\BadPepper.json"))
            {
                setting = JsonConvert.DeserializeObject<Setting>(File.ReadAllText(application_puth + @"\BadPepper.json"));
            }

            Recovery();
        }

        private void Recovery()
        {
            setting = (setting is null) ? new Setting() : setting;
            textBox_path.Text = setting.path;
            numericUpDown_speed.Value = setting.speed;
            if (setting.theme)
            {
                radioButton_light.Checked = true;
                LightTheme();
            }
            else
            {
                radioButton_dark.Checked = true;
                DarkTheme();
            }
            checkBox_rot.Checked = setting.rot;
            checkBox_alternariosis.Checked = setting.alternariosis;
            checkBox_cracking_pulp.Checked = setting.cracking_pulp;
            checkBox_qualitative.Checked = setting.qualitative;
            labels = setting.labels;
        }

        private void Sound(string sound)
        {
            switch (sound)
            {
                case "Error": soundplayer = new SoundPlayer(Properties.Resources.error); break;
                case "Touch": soundplayer = new SoundPlayer(Properties.Resources.navedenie); break;
                case "Picture": soundplayer = new SoundPlayer(Properties.Resources.picture); break;
                case "Click": soundplayer = new SoundPlayer(Properties.Resources.nagatie); break;
            }
            soundplayer.Play();
        }

        public List<string> GetFilesInDirectory(string directoryPath)
        {
            List<string> fileList = new List<string>();
            try
            {
                string[] fileEntries = Directory.GetFiles(directoryPath);
                foreach (string fileName in fileEntries)
                {
                    var type = new FileInfo(fileName).Extension;
                    if (type == ".jpg" || type == ".png" || type == ".jpeg")
                    {
                        fileList.Add(fileName);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return fileList;
        }

        #endregion

        #region window - Методы взаимодействия с окном

        private void button_wrap_Click(object sender, EventArgs e)
        {
            Sound("Click");
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_unwrap_Click(object sender, EventArgs e)
        {
            Sound("Click");
            bool video = play;
            play = false;
            this.WindowState = wrap ? FormWindowState.Normal : FormWindowState.Maximized;
            wrap = !wrap;
            if (!open_settings)
            {
                panel_settings.Location = new System.Drawing.Point(0, panel_menu.Height);
            }
            if (!start)
            {
                OpenMenu();
            }
            if (start)
            {
                play = video;
            }
            button_close.Location = new System.Drawing.Point(this.Width - 33, 0);
            button_unwrap.Location = new System.Drawing.Point(this.Width - 66, 0);
            button_wrap.Location = new System.Drawing.Point(this.Width - 99, 0);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Sound("Click");
            this.Close();
        }

        #endregion

        #region moving - Методы перемещения окна программы

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new System.Drawing.Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                System.Drawing.Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        #endregion

        #region menu - Методы меню  

        private void button_open_Click(object sender, EventArgs e)
        {
            Sound("Click");
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    directory = new FileInfo(openFileDialog1.FileName).DirectoryName;
                    files_directory = GetFilesInDirectory(directory);
                    index_file_in_directory = files_directory.IndexOf(openFileDialog1.FileName);
                    label_title.Visible = false;
                    capture = new VideoCapture(openFileDialog1.FileName);
                    frame_count = capture.FrameCount;
                    var type = new FileInfo(openFileDialog1.FileName).Extension;
                    if (type == ".jpg" || type == ".png" || type == ".jpeg")
                    {
                        ispicture = true;
                    }
                    else
                    {
                        ispicture = false;
                    }
                    if (ispicture)
                    {
                        button_pause.Enabled = (checkBox_detection.Checked) ? true : false;
                        pictureBox_view.Image = Image.FromFile(openFileDialog1.FileName);
                        button_pause.Text = "Распознать";
                        capture.Dispose();
                        capture = null;
                    }
                    else
                    {
                        button_pause.Enabled = true;
                        button_left.Visible = true;
                        button_pause.Text = "Просмотр";
                        button_right.Visible = true;
                        capture.Grab();
                        capture.Set(CaptureProperty.PosFrames, frames);
                        frames = 1;
                        using (Mat frame = new Mat())
                        {
                            capture.Read(frame);
                            pictureBox_view.Image = BitmapConverter.ToBitmap(frame);
                        }
                    }
                    start = true;
                    CloseMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка открытия", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenMenu(bool fast = true)
        {
            if (!fast)
            {
                speed_animation = wrap ? 10 : 5;
                while (panel_menu.Width < this.Width)
                {
                    panel_menu.Width += speed_animation;
                }
                return;
            }
            panel_menu.Width = this.Width;
        }

        private void CloseMenu()
        {
            panel_menu.Width = 290;
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            Sound("Click");
            OpenSettings();
        }

        #endregion

        #region settings - Методы настроек

        private void OpenSettings()
        {
            //Replase();
            open_settings = true;
            speed_animation = wrap ? 5 : 2;
            while (panel_settings.Location.Y > 0)
            {
                panel_settings.Location = new System.Drawing.Point(0, panel_settings.Location.Y - speed_animation);
            }
        }

        private void CheckBoxLabels(string label)
        {
            labels = (labels is null) ? new List<string>() : labels;
            if (labels.Contains(label))
            {
                labels.Remove(label);
            }
            else
            {
                labels.Add(label);
            }
        }

        private void checkBox_rot_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxLabels("rot");
        }

        private void checkBox_alternariosis_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxLabels("alternariosis");
        }

        private void checkBox_cracking_pulp_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxLabels("cracking to pulp");
        }

        private void checkBox_qualitative_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxLabels("qualitative");
        }

        private void checkBox_detection_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_detection.Checked)
            {
                checkBox_rot.Visible = true;
                checkBox_qualitative.Visible = true;
                checkBox_alternariosis.Visible = true;
                checkBox_cracking_pulp.Visible = true;
                button_pause.Enabled = true;
            }
            else
            {
                checkBox_rot.Visible = false;
                checkBox_qualitative.Visible = false;
                checkBox_alternariosis.Visible = false;
                checkBox_cracking_pulp.Visible = false;
                if (ispicture)
                {
                    button_pause.Enabled = false;
                }
            }
        }

        private void Replase()
        {
            if (start)
            {
                int x = 20;
                checkBox_rot.Location = new System.Drawing.Point(x, 271);
                checkBox_alternariosis.Location = new System.Drawing.Point(x, 307);
                checkBox_cracking_pulp.Location = new System.Drawing.Point(x, 343);
                checkBox_qualitative.Location = new System.Drawing.Point(x, 379);

                label_theme.Height = 56;
                radioButton_dark.Location = new System.Drawing.Point(129, 145);
            }
            else
            {
                int y = 271;
                checkBox_rot.Location = new System.Drawing.Point(20, 271);
                checkBox_alternariosis.Location = new System.Drawing.Point(140, y);
                checkBox_cracking_pulp.Location = new System.Drawing.Point(339, y);
                checkBox_qualitative.Location = new System.Drawing.Point(612, y);

                label_theme.Height = 25;
                radioButton_dark.Location = new System.Drawing.Point(271, 114);
            }
        }

        private void CloseSettings()
        {
            open_settings = false;
            speed_animation = wrap ? 3 : 1;
            while (panel_settings.Location.Y < panel_menu.Height)
            {
                panel_settings.Location = new System.Drawing.Point(0, panel_settings.Location.Y + speed_animation);
            }
        }

        private void button_save_settings_Click(object sender, EventArgs e)
        {
            Sound("Click");
            CloseSettings();
            Save_Setting();
        }

        private void Save_Setting()
        {
            setting.path = textBox_path.Text;
            setting.speed = (int)numericUpDown_speed.Value;
            setting.theme = radioButton_light.Checked ? true : false;
            setting.rot = checkBox_rot.Checked;
            setting.alternariosis = checkBox_alternariosis.Checked;
            setting.cracking_pulp = checkBox_cracking_pulp.Checked;
            setting.qualitative = checkBox_qualitative.Checked;
            setting.labels = labels;
            using (var sw = new StreamWriter(Application.StartupPath + @"\BadPepper.json"))
            {
                var json = JToken.Parse(JsonConvert.SerializeObject(setting));
                sw.WriteLine(json);
            }
        }

        private void radioButton_light_Click(object sender, EventArgs e)
        {
            Sound("Click");
            if (!setting.theme)
            {
                LightTheme();
                setting.theme = true;
            }
        }

        private void radioButton_dark_Click(object sender, EventArgs e)
        {
            Sound("Click");
            if (setting.theme)
            {
                DarkTheme();
                setting.theme = false;
            }
        }

        private void DarkTheme()
        {
            UpdateTheme(
                System.Drawing.Color.FromArgb(80, 80, 80),      //серый
                System.Drawing.Color.FromArgb(250, 250, 250),   //белый
                System.Drawing.Color.FromArgb(40, 40, 40));     //темносерый
        }

        private void LightTheme()
        {
            UpdateTheme(
                System.Drawing.Color.FromArgb(250, 250, 250),   //белый
                System.Drawing.Color.FromArgb(80, 80, 80),      //серый
                System.Drawing.Color.FromArgb(200, 200, 200));  //светлосерый
        }

        private void UpdateTheme(System.Drawing.Color color_1, System.Drawing.Color color_2, System.Drawing.Color color_3)
        {
            panel_main.BackColor = color_1;
            panel_menu.BackColor = color_1;
            panel_view.BackColor = color_1;

            this.ForeColor = color_2;
            button_close.ForeColor = color_2;
            button_wrap.ForeColor = color_2;
            button_unwrap.ForeColor = color_2;

            panel_settings.BackColor = color_3;
            this.BackColor = color_3;
            button_close.BackColor = color_3;
            button_wrap.BackColor = color_3;
            button_unwrap.BackColor = color_3;
        }

        #endregion

        #region view - Методы просмотра

        private void button_close_view_Click(object sender, EventArgs e)
        {
            Sound("Click");
            Save_Setting();
            CloseSettings();
            OpenMenu(false);
            start = false;
            label_title.Visible = true;
            if (!ispicture)
            {
                capture.Dispose();
                capture = null;
            }
            if (button_pause.Text == "Остановить")
            {
                play = false;
            }
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            Sound("Click");
            if (button_pause.Text == "Просмотр" && frames < frame_count)
            {
                play = true;
                ReadFrames();
                button_pause.Text = "Остановить";
                return;
            }
            if (button_pause.Text == "Остановить")
            {
                play = false;
                button_pause.Text = "Просмотр";
                return;
            }
            if (button_pause.Text == "Распознать")
            {
                pictureBox_view.Image = (checkBox_detection.Checked) ? Yolov5Net.App.ImageYolo.GetImage(Image.FromFile(openFileDialog1.FileName)) : Image.FromFile(openFileDialog1.FileName);
            }
        }

        private async void ReadFrames()
        {
            try
            {
                using (Mat frame = new Mat())
                {
                    while (play && frames < frame_count)
                    {
                        frames += ((checkBox_detection.Checked && labels.Count > 0)) ? 10 : 1;
                        capture.Set(CaptureProperty.PosFrames, frames);
                        capture.Read(frame);
                        if (frame.Empty())
                        {
                            continue;
                        }
                        pictureBox_view.Image = ((checkBox_detection.Checked && labels.Count > 0)) ? Yolov5Net.App.ImageYolo.GetImage(BitmapConverter.ToBitmap(frame)) : (BitmapConverter.ToBitmap(frame));
                        await Task.Delay(1);
                    }
                    if (!(frames < frame_count))
                    {
                        if (button_pause.Text == "Остановить")
                        {
                            play = false;
                            button_pause.Text = "Просмотр";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            Sound("Click");
            if (ispicture)
            {
                try
                {
                    index_file_in_directory--;
                    if (index_file_in_directory < 0)
                    {
                        index_file_in_directory = 0;
                    }
                    else
                    {
                        pictureBox_view.Image = Image.FromFile(files_directory[index_file_in_directory]);
                        openFileDialog1.FileName = files_directory[index_file_in_directory];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(index_file_in_directory + "\n" + ex.Message);
                }
                return;
            }
            using (Mat frame = new Mat())
            {
                frames -= (int)numericUpDown_speed.Value;
                if (frames < 0)
                {
                    frames = 0;
                }
                capture.Set(CaptureProperty.PosFrames, frames);
                capture.Read(frame);
                pictureBox_view.Image = (checkBox_detection.Checked && labels.Count > 0) ? Yolov5Net.App.ImageYolo.GetImage(BitmapConverter.ToBitmap(frame)) : (BitmapConverter.ToBitmap(frame));
            }
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            Sound("Click");

            if (ispicture)
            {
                try
                {
                    index_file_in_directory++;
                    if (index_file_in_directory > files_directory.Count - 1)
                    {
                        index_file_in_directory = files_directory.Count - 1;
                    }
                    else
                    {
                        pictureBox_view.Image = Image.FromFile(files_directory[index_file_in_directory]);
                        openFileDialog1.FileName = files_directory[index_file_in_directory];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(index_file_in_directory + "\n" + ex.Message);
                }
                return;
            }
            using (Mat frame = new Mat())
            {
                frames += (int)numericUpDown_speed.Value;
                if (frames > frame_count)
                {
                    frames = frame_count;
                }
                capture.Set(CaptureProperty.PosFrames, frames);
                capture.Read(frame);
                pictureBox_view.Image = (checkBox_detection.Checked && labels.Count > 0) ? Yolov5Net.App.ImageYolo.GetImage(BitmapConverter.ToBitmap(frame)) : (BitmapConverter.ToBitmap(frame));
            }
        }

        private async void button_save_picture_Click(object sender, EventArgs e)
        {
            Sound("Click");
            System.Drawing.Image tmp_image = null;
            bool video = play;
            play = false;
            await Task.Delay(1);
            tmp_image = pictureBox_view.Image;
            if (textBox_path.Text != null && textBox_path.Text.Length > 0)
            {
                try
                {
                    string filename = $@"{textBox_path.Text}\BadPepper_{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}{DateTime.Now.Millisecond}.jpg";
                    pictureBox_view.Image.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
                    pictureBox_view.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_view.Image = Properties.Resources.flash;
                    Sound("Picture");
                    await Task.Delay(50);
                    pictureBox_view.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox_view.Image = tmp_image;
                }
                catch
                {
                    Sound("Error");
                    MessageBox.Show("Не удалось сохранить картинку");
                }
            }
            else
            {
                MessageBox.Show("Необходимо в настройках указать папку сохранения");
            }
            play = video;
            ReadFrames();
        }
        #endregion
    }
}