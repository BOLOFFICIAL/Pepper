using System.Resources;

namespace Pepper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        
        //private void InitializeComponent()
        //{
        //    this.button_wrap = new System.Windows.Forms.Button();
        //    this.button_unwrap = new System.Windows.Forms.Button();
        //    this.button_close = new System.Windows.Forms.Button();
        //    this.panel_main = new System.Windows.Forms.Panel();
        //    this.panel_menu = new System.Windows.Forms.Panel();
        //    this.panel_settings = new System.Windows.Forms.Panel();
        //    this.checkBox_qualitative = new System.Windows.Forms.CheckBox();
        //    this.checkBox_cracking_pulp = new System.Windows.Forms.CheckBox();
        //    this.checkBox_alternariosis = new System.Windows.Forms.CheckBox();
        //    this.checkBox_rot = new System.Windows.Forms.CheckBox();
        //    this.radioButton_dark = new System.Windows.Forms.RadioButton();
        //    this.radioButton_light = new System.Windows.Forms.RadioButton();
        //    this.label_theme = new System.Windows.Forms.Label();
        //    this.label_peppers = new System.Windows.Forms.Label();
        //    this.numericUpDown_speed = new System.Windows.Forms.NumericUpDown();
        //    this.label_speed = new System.Windows.Forms.Label();
        //    this.textBox_path = new System.Windows.Forms.TextBox();
        //    this.label_path = new System.Windows.Forms.Label();
        //    this.label_app = new System.Windows.Forms.Label();
        //    this.button_save_settings = new System.Windows.Forms.Button();
        //    this.tableLayoutPanel_menu = new System.Windows.Forms.TableLayoutPanel();
        //    this.button_open = new System.Windows.Forms.Button();
        //    this.button_settings = new System.Windows.Forms.Button();
        //    this.label_title = new System.Windows.Forms.Label();
        //    this.panel_view = new System.Windows.Forms.Panel();
        //    this.tableLayoutPanel_view = new System.Windows.Forms.TableLayoutPanel();
        //    this.button_save_picture = new System.Windows.Forms.Button();
        //    this.button_right = new System.Windows.Forms.Button();
        //    this.button_pause = new System.Windows.Forms.Button();
        //    this.button_left = new System.Windows.Forms.Button();
        //    this.button_close_view = new System.Windows.Forms.Button();
        //    this.pictureBox_view = new System.Windows.Forms.PictureBox();
        //    this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        //    this.panel_main.SuspendLayout();
        //    this.panel_menu.SuspendLayout();
        //    this.panel_settings.SuspendLayout();
        //    ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_speed)).BeginInit();
        //    this.tableLayoutPanel_menu.SuspendLayout();
        //    this.panel_view.SuspendLayout();
        //    this.tableLayoutPanel_view.SuspendLayout();
        //    ((System.ComponentModel.ISupportInitialize)(this.pictureBox_view)).BeginInit();
        //    this.SuspendLayout();
        //    // 
        //    // button_wrap
        //    // 
        //    this.button_wrap.AutoSize = true;
        //    this.button_wrap.BackColor = System.Drawing.SystemColors.Control;
        //    this.button_wrap.FlatAppearance.BorderSize = 0;
        //    this.button_wrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.button_wrap.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold);
        //    this.button_wrap.ForeColor = System.Drawing.Color.DarkRed;
        //    this.button_wrap.Location = new System.Drawing.Point(791, 0);
        //    this.button_wrap.Margin = new System.Windows.Forms.Padding(0);
        //    this.button_wrap.Name = "button_wrap";
        //    this.button_wrap.Size = new System.Drawing.Size(33, 33);
        //    this.button_wrap.TabIndex = 0;
        //    this.button_wrap.TabStop = false;
        //    this.button_wrap.Text = "🗕";
        //    this.button_wrap.UseVisualStyleBackColor = false;
        //    this.button_wrap.Click += new System.EventHandler(this.button_wrap_Click);
        //    // 
        //    // button_unwrap
        //    // 
        //    this.button_unwrap.AutoSize = true;
        //    this.button_unwrap.BackColor = System.Drawing.SystemColors.Control;
        //    this.button_unwrap.FlatAppearance.BorderSize = 0;
        //    this.button_unwrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.button_unwrap.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        //    this.button_unwrap.ForeColor = System.Drawing.Color.DarkRed;
        //    this.button_unwrap.Location = new System.Drawing.Point(824, 0);
        //    this.button_unwrap.Margin = new System.Windows.Forms.Padding(0);
        //    this.button_unwrap.Name = "button_unwrap";
        //    this.button_unwrap.Size = new System.Drawing.Size(33, 33);
        //    this.button_unwrap.TabIndex = 0;
        //    this.button_unwrap.TabStop = false;
        //    this.button_unwrap.Text = "🗖";
        //    this.button_unwrap.UseVisualStyleBackColor = false;
        //    this.button_unwrap.Click += new System.EventHandler(this.button_unwrap_Click);
        //    // 
        //    // button_close
        //    // 
        //    this.button_close.AutoSize = true;
        //    this.button_close.BackColor = System.Drawing.SystemColors.Control;
        //    this.button_close.FlatAppearance.BorderSize = 0;
        //    this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.button_close.Font = new System.Drawing.Font("Cascadia Mono", 8.25F);
        //    this.button_close.ForeColor = System.Drawing.Color.DarkRed;
        //    this.button_close.Location = new System.Drawing.Point(857, 0);
        //    this.button_close.Margin = new System.Windows.Forms.Padding(0);
        //    this.button_close.Name = "button_close";
        //    this.button_close.Size = new System.Drawing.Size(33, 33);
        //    this.button_close.TabIndex = 0;
        //    this.button_close.TabStop = false;
        //    this.button_close.Text = "❌";
        //    this.button_close.UseVisualStyleBackColor = false;
        //    this.button_close.Click += new System.EventHandler(this.button_close_Click);
        //    // 
        //    // panel_main
        //    // 
        //    this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        //    | System.Windows.Forms.AnchorStyles.Left)
        //    | System.Windows.Forms.AnchorStyles.Right)));
        //    this.panel_main.BackColor = System.Drawing.SystemColors.ButtonFace;
        //    this.panel_main.Controls.Add(this.panel_menu);
        //    this.panel_main.Controls.Add(this.panel_view);
        //    this.panel_main.Location = new System.Drawing.Point(0, 33);
        //    this.panel_main.Margin = new System.Windows.Forms.Padding(0);
        //    this.panel_main.Name = "panel_main";
        //    this.panel_main.Size = new System.Drawing.Size(890, 489);
        //    this.panel_main.TabIndex = 3;
        //    // 
        //    // panel_menu
        //    // 
        //    this.panel_menu.BackColor = System.Drawing.SystemColors.ButtonFace;
        //    this.panel_menu.Controls.Add(this.panel_settings);
        //    this.panel_menu.Controls.Add(this.tableLayoutPanel_menu);
        //    this.panel_menu.Dock = System.Windows.Forms.DockStyle.Right;
        //    this.panel_menu.Location = new System.Drawing.Point(0, 0);
        //    this.panel_menu.Margin = new System.Windows.Forms.Padding(0);
        //    this.panel_menu.Name = "panel_menu";
        //    this.panel_menu.Size = new System.Drawing.Size(890, 489);
        //    this.panel_menu.TabIndex = 1;
        //    // 
        //    // panel_settings
        //    // 
        //    this.panel_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        //    | System.Windows.Forms.AnchorStyles.Left)
        //    | System.Windows.Forms.AnchorStyles.Right)));
        //    this.panel_settings.BackColor = System.Drawing.SystemColors.Control;
        //    this.panel_settings.Controls.Add(this.checkBox_qualitative);
        //    this.panel_settings.Controls.Add(this.checkBox_cracking_pulp);
        //    this.panel_settings.Controls.Add(this.checkBox_alternariosis);
        //    this.panel_settings.Controls.Add(this.checkBox_rot);
        //    this.panel_settings.Controls.Add(this.radioButton_dark);
        //    this.panel_settings.Controls.Add(this.radioButton_light);
        //    this.panel_settings.Controls.Add(this.label_theme);
        //    this.panel_settings.Controls.Add(this.label_peppers);
        //    this.panel_settings.Controls.Add(this.numericUpDown_speed);
        //    this.panel_settings.Controls.Add(this.label_speed);
        //    this.panel_settings.Controls.Add(this.textBox_path);
        //    this.panel_settings.Controls.Add(this.label_path);
        //    this.panel_settings.Controls.Add(this.label_app);
        //    this.panel_settings.Controls.Add(this.button_save_settings);
        //    this.panel_settings.Location = new System.Drawing.Point(0, 0);
        //    this.panel_settings.Name = "panel_settings";
        //    this.panel_settings.Size = new System.Drawing.Size(890, 489);
        //    this.panel_settings.TabIndex = 1;
        //    // 
        //    // checkBox_qualitative
        //    // 
        //    this.checkBox_qualitative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        //    | System.Windows.Forms.AnchorStyles.Right)));
        //    this.checkBox_qualitative.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.checkBox_qualitative.Location = new System.Drawing.Point(27, 408);
        //    this.checkBox_qualitative.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.checkBox_qualitative.Name = "checkBox_qualitative";
        //    this.checkBox_qualitative.Size = new System.Drawing.Size(1011, 35);
        //    this.checkBox_qualitative.TabIndex = 16;
        //    this.checkBox_qualitative.Text = "Качественные";
        //    this.checkBox_qualitative.UseVisualStyleBackColor = true;
        //    // 
        //    // checkBox_cracking_pulp
        //    // 
        //    this.checkBox_cracking_pulp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        //    | System.Windows.Forms.AnchorStyles.Right)));
        //    this.checkBox_cracking_pulp.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.checkBox_cracking_pulp.Location = new System.Drawing.Point(27, 367);
        //    this.checkBox_cracking_pulp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.checkBox_cracking_pulp.Name = "checkBox_cracking_pulp";
        //    this.checkBox_cracking_pulp.Size = new System.Drawing.Size(1011, 35);
        //    this.checkBox_cracking_pulp.TabIndex = 15;
        //    this.checkBox_cracking_pulp.Text = "Растресканные до мякоти";
        //    this.checkBox_cracking_pulp.UseVisualStyleBackColor = true;
        //    // 
        //    // checkBox_alternariosis
        //    // 
        //    this.checkBox_alternariosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        //    | System.Windows.Forms.AnchorStyles.Right)));
        //    this.checkBox_alternariosis.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.checkBox_alternariosis.Location = new System.Drawing.Point(27, 325);
        //    this.checkBox_alternariosis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.checkBox_alternariosis.Name = "checkBox_alternariosis";
        //    this.checkBox_alternariosis.Size = new System.Drawing.Size(1011, 35);
        //    this.checkBox_alternariosis.TabIndex = 14;
        //    this.checkBox_alternariosis.Text = "Альтернариозные";
        //    this.checkBox_alternariosis.UseVisualStyleBackColor = true;
        //    // 
        //    // checkBox_rot
        //    // 
        //    this.checkBox_rot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        //    | System.Windows.Forms.AnchorStyles.Right)));
        //    this.checkBox_rot.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.checkBox_rot.Location = new System.Drawing.Point(27, 284);
        //    this.checkBox_rot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.checkBox_rot.Name = "checkBox_rot";
        //    this.checkBox_rot.Size = new System.Drawing.Size(1011, 35);
        //    this.checkBox_rot.TabIndex = 13;
        //    this.checkBox_rot.Text = "Гнилые";
        //    this.checkBox_rot.UseVisualStyleBackColor = true;
        //    // 
        //    // radioButton_dark
        //    // 
        //    this.radioButton_dark.AutoSize = true;
        //    this.radioButton_dark.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.radioButton_dark.Location = new System.Drawing.Point(294, 132);
        //    this.radioButton_dark.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.radioButton_dark.Name = "radioButton_dark";
        //    this.radioButton_dark.Size = new System.Drawing.Size(127, 25);
        //    this.radioButton_dark.TabIndex = 11;
        //    this.radioButton_dark.Text = "Темная тема";
        //    this.radioButton_dark.UseVisualStyleBackColor = true;
        //    this.radioButton_dark.Click += new System.EventHandler(this.radioButton_dark_Click);
        //    // 
        //    // radioButton_light
        //    // 
        //    this.radioButton_light.AutoSize = true;
        //    this.radioButton_light.Checked = true;
        //    this.radioButton_light.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.radioButton_light.Location = new System.Drawing.Point(150, 132);
        //    this.radioButton_light.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.radioButton_light.Name = "radioButton_light";
        //    this.radioButton_light.Size = new System.Drawing.Size(136, 25);
        //    this.radioButton_light.TabIndex = 10;
        //    this.radioButton_light.TabStop = true;
        //    this.radioButton_light.Text = "Светлая тема";
        //    this.radioButton_light.UseVisualStyleBackColor = true;
        //    this.radioButton_light.Click += new System.EventHandler(this.radioButton_light_Click);
        //    // 
        //    // label_theme
        //    // 
        //    this.label_theme.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.label_theme.Location = new System.Drawing.Point(0, 132);
        //    this.label_theme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        //    this.label_theme.Name = "label_theme";
        //    this.label_theme.Size = new System.Drawing.Size(140, 29);
        //    this.label_theme.TabIndex = 7;
        //    this.label_theme.Text = "Оформление";
        //    this.label_theme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //    // 
        //    // label_peppers
        //    // 
        //    this.label_peppers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        //    | System.Windows.Forms.AnchorStyles.Right)));
        //    this.label_peppers.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.label_peppers.Location = new System.Drawing.Point(0, 222);
        //    this.label_peppers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        //    this.label_peppers.Name = "label_peppers";
        //    this.label_peppers.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
        //    this.label_peppers.Size = new System.Drawing.Size(890, 40);
        //    this.label_peppers.TabIndex = 6;
        //    this.label_peppers.Text = "Перцы";
        //    this.label_peppers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //    // 
        //    // numericUpDown_speed
        //    // 
        //    this.numericUpDown_speed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        //    | System.Windows.Forms.AnchorStyles.Left) 
        //    | System.Windows.Forms.AnchorStyles.Right)));
        //    this.numericUpDown_speed.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.numericUpDown_speed.Location = new System.Drawing.Point(150, 90);
        //    this.numericUpDown_speed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.numericUpDown_speed.Minimum = new decimal(new int[] {
        //    1,
        //    0,
        //    0,
        //    0});
        //    this.numericUpDown_speed.Name = "numericUpDown_speed";
        //    this.numericUpDown_speed.Size = new System.Drawing.Size(736, 26);
        //    this.numericUpDown_speed.TabIndex = 5;
        //    this.numericUpDown_speed.Value = new decimal(new int[] {
        //    1,
        //    0,
        //    0,
        //    0});
        //    // 
        //    // label_speed
        //    // 
        //    this.label_speed.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.label_speed.Location = new System.Drawing.Point(0, 84);
        //    this.label_speed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        //    this.label_speed.Name = "label_speed";
        //    this.label_speed.Size = new System.Drawing.Size(140, 40);
        //    this.label_speed.TabIndex = 4;
        //    this.label_speed.Text = "Промотка";
        //    this.label_speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //    // 
        //    // textBox_path
        //    // 
        //    this.textBox_path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        //    | System.Windows.Forms.AnchorStyles.Left) 
        //    | System.Windows.Forms.AnchorStyles.Right)));
        //    this.textBox_path.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.textBox_path.Location = new System.Drawing.Point(150, 48);
        //    this.textBox_path.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.textBox_path.Name = "textBox_path";
        //    this.textBox_path.Size = new System.Drawing.Size(736, 26);
        //    this.textBox_path.TabIndex = 3;
        //    this.textBox_path.Text = "C:\\";
        //    // 
        //    // label_path
        //    // 
        //    this.label_path.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.label_path.Location = new System.Drawing.Point(0, 44);
        //    this.label_path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        //    this.label_path.Name = "label_path";
        //    this.label_path.Size = new System.Drawing.Size(144, 40);
        //    this.label_path.TabIndex = 2;
        //    this.label_path.Text = "Сохранение";
        //    this.label_path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //    // 
        //    // label_app
        //    // 
        //    this.label_app.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        //    | System.Windows.Forms.AnchorStyles.Right)));
        //    this.label_app.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.label_app.Location = new System.Drawing.Point(0, 3);
        //    this.label_app.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        //    this.label_app.Name = "label_app";
        //    this.label_app.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
        //    this.label_app.Size = new System.Drawing.Size(890, 40);
        //    this.label_app.TabIndex = 1;
        //    this.label_app.Text = "Приложение";
        //    this.label_app.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //    // 
        //    // button_save_settings
        //    // 
        //    this.button_save_settings.Dock = System.Windows.Forms.DockStyle.Bottom;
        //    this.button_save_settings.FlatAppearance.BorderSize = 0;
        //    this.button_save_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.button_save_settings.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.button_save_settings.Location = new System.Drawing.Point(0, 431);
        //    this.button_save_settings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.button_save_settings.Name = "button_save_settings";
        //    this.button_save_settings.Size = new System.Drawing.Size(890, 58);
        //    this.button_save_settings.TabIndex = 0;
        //    this.button_save_settings.TabStop = false;
        //    this.button_save_settings.Text = "Сохранить";
        //    this.button_save_settings.UseVisualStyleBackColor = true;
        //    this.button_save_settings.Click += new System.EventHandler(this.button_save_settings_Click);
        //    // 
        //    // tableLayoutPanel_menu
        //    // 
        //    this.tableLayoutPanel_menu.ColumnCount = 3;
        //    this.tableLayoutPanel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        //    this.tableLayoutPanel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 292F));
        //    this.tableLayoutPanel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        //    this.tableLayoutPanel_menu.Controls.Add(this.button_open, 1, 1);
        //    this.tableLayoutPanel_menu.Controls.Add(this.button_settings, 1, 3);
        //    this.tableLayoutPanel_menu.Controls.Add(this.label_title, 0, 2);
        //    this.tableLayoutPanel_menu.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.tableLayoutPanel_menu.Location = new System.Drawing.Point(0, 0);
        //    this.tableLayoutPanel_menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.tableLayoutPanel_menu.Name = "tableLayoutPanel_menu";
        //    this.tableLayoutPanel_menu.RowCount = 4;
        //    this.tableLayoutPanel_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
        //    this.tableLayoutPanel_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
        //    this.tableLayoutPanel_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        //    this.tableLayoutPanel_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
        //    this.tableLayoutPanel_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
        //    this.tableLayoutPanel_menu.Size = new System.Drawing.Size(890, 489);
        //    this.tableLayoutPanel_menu.TabIndex = 0;
        //    // 
        //    // button_open
        //    // 
        //    this.button_open.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.button_open.FlatAppearance.BorderSize = 0;
        //    this.button_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.button_open.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.button_open.Location = new System.Drawing.Point(303, 61);
        //    this.button_open.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.button_open.Name = "button_open";
        //    this.button_open.Size = new System.Drawing.Size(284, 52);
        //    this.button_open.TabIndex = 0;
        //    this.button_open.TabStop = false;
        //    this.button_open.Text = "Выбрать";
        //    this.button_open.UseVisualStyleBackColor = true;
        //    this.button_open.Click += new System.EventHandler(this.button_open_Click);
        //    // 
        //    // button_settings
        //    // 
        //    this.tableLayoutPanel_menu.SetColumnSpan(this.button_settings, 3);
        //    this.button_settings.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.button_settings.FlatAppearance.BorderSize = 0;
        //    this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.button_settings.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.button_settings.Location = new System.Drawing.Point(4, 427);
        //    this.button_settings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.button_settings.Name = "button_settings";
        //    this.button_settings.Size = new System.Drawing.Size(882, 59);
        //    this.button_settings.TabIndex = 0;
        //    this.button_settings.TabStop = false;
        //    this.button_settings.Text = "Настройки";
        //    this.button_settings.UseVisualStyleBackColor = true;
        //    this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
        //    // 
        //    // label_title
        //    // 
        //    this.label_title.AutoSize = true;
        //    this.tableLayoutPanel_menu.SetColumnSpan(this.label_title, 3);
        //    this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.label_title.Font = new System.Drawing.Font("Segoe Print", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.label_title.ForeColor = System.Drawing.Color.DarkRed;
        //    this.label_title.Location = new System.Drawing.Point(4, 116);
        //    this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        //    this.label_title.Name = "label_title";
        //    this.label_title.Padding = new System.Windows.Forms.Padding(0, 17, 0, 0);
        //    this.label_title.Size = new System.Drawing.Size(882, 308);
        //    this.label_title.TabIndex = 1;
        //    this.label_title.Text = "BadPepper";
        //    this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        //    // 
        //    // panel_view
        //    // 
        //    this.panel_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        //    | System.Windows.Forms.AnchorStyles.Left)
        //    | System.Windows.Forms.AnchorStyles.Right)));
        //    this.panel_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
        //    this.panel_view.Controls.Add(this.tableLayoutPanel_view);
        //    this.panel_view.Location = new System.Drawing.Point(0, 0);
        //    this.panel_view.Margin = new System.Windows.Forms.Padding(0);
        //    this.panel_view.Name = "panel_view";
        //    this.panel_view.Size = new System.Drawing.Size(600, 486);
        //    // 
        //    // tableLayoutPanel_view
        //    // 
        //    this.tableLayoutPanel_view.ColumnCount = 5;
        //    this.tableLayoutPanel_view.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
        //    this.tableLayoutPanel_view.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
        //    this.tableLayoutPanel_view.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        //    this.tableLayoutPanel_view.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
        //    this.tableLayoutPanel_view.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
        //    this.tableLayoutPanel_view.Controls.Add(this.button_save_picture, 4, 1);
        //    this.tableLayoutPanel_view.Controls.Add(this.button_right, 3, 1);
        //    this.tableLayoutPanel_view.Controls.Add(this.button_pause, 2, 1);
        //    this.tableLayoutPanel_view.Controls.Add(this.button_left, 1, 1);
        //    this.tableLayoutPanel_view.Controls.Add(this.button_close_view, 0, 1);
        //    this.tableLayoutPanel_view.Controls.Add(this.pictureBox_view, 0, 0);
        //    this.tableLayoutPanel_view.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.tableLayoutPanel_view.Location = new System.Drawing.Point(0, 0);
        //    this.tableLayoutPanel_view.Margin = new System.Windows.Forms.Padding(0);
        //    this.tableLayoutPanel_view.Name = "tableLayoutPanel_view";
        //    this.tableLayoutPanel_view.RowCount = 2;
        //    this.tableLayoutPanel_view.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        //    this.tableLayoutPanel_view.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
        //    this.tableLayoutPanel_view.Size = new System.Drawing.Size(600, 486);
        //    this.tableLayoutPanel_view.TabIndex = 1;
        //    // 
        //    // button_save_picture
        //    // 
        //    this.button_save_picture.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.button_save_picture.FlatAppearance.BorderSize = 0;
        //    this.button_save_picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.button_save_picture.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.button_save_picture.Location = new System.Drawing.Point(429, 431);
        //    this.button_save_picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.button_save_picture.Name = "button_save_picture";
        //    this.button_save_picture.Size = new System.Drawing.Size(167, 52);
        //    this.button_save_picture.TabIndex = 0;
        //    this.button_save_picture.TabStop = false;
        //    this.button_save_picture.Text = "Сохранить";
        //    this.button_save_picture.UseVisualStyleBackColor = true;
        //    this.button_save_picture.Click += new System.EventHandler(this.button_save_picture_Click);
        //    // 
        //    // button_right
        //    // 
        //    this.button_right.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.button_right.FlatAppearance.BorderSize = 0;
        //    this.button_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.button_right.Font = new System.Drawing.Font("Cascadia Mono Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        //    this.button_right.Location = new System.Drawing.Point(394, 431);
        //    this.button_right.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.button_right.Name = "button_right";
        //    this.button_right.Size = new System.Drawing.Size(27, 52);
        //    this.button_right.TabIndex = 0;
        //    this.button_right.TabStop = false;
        //    this.button_right.Text = "ᐅ";
        //    this.button_right.UseVisualStyleBackColor = true;
        //    this.button_right.Click += new System.EventHandler(this.button_right_Click);
        //    // 
        //    // button_pause
        //    // 
        //    this.button_pause.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.button_pause.FlatAppearance.BorderSize = 0;
        //    this.button_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.button_pause.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.button_pause.Location = new System.Drawing.Point(214, 431);
        //    this.button_pause.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.button_pause.Name = "button_pause";
        //    this.button_pause.Size = new System.Drawing.Size(172, 52);
        //    this.button_pause.TabIndex = 0;
        //    this.button_pause.TabStop = false;
        //    this.button_pause.Text = "Просмотр";
        //    this.button_pause.UseVisualStyleBackColor = true;
        //    this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
        //    // 
        //    // button_left
        //    // 
        //    this.button_left.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.button_left.FlatAppearance.BorderSize = 0;
        //    this.button_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.button_left.Font = new System.Drawing.Font("Cascadia Mono Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        //    this.button_left.Location = new System.Drawing.Point(179, 431);
        //    this.button_left.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.button_left.Name = "button_left";
        //    this.button_left.Size = new System.Drawing.Size(27, 52);
        //    this.button_left.TabIndex = 0;
        //    this.button_left.TabStop = false;
        //    this.button_left.Text = "ᐊ";
        //    this.button_left.UseVisualStyleBackColor = true;
        //    this.button_left.Click += new System.EventHandler(this.button_left_Click);
        //    // 
        //    // button_close_view
        //    // 
        //    this.button_close_view.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.button_close_view.FlatAppearance.BorderSize = 0;
        //    this.button_close_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.button_close_view.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    this.button_close_view.Location = new System.Drawing.Point(4, 431);
        //    this.button_close_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        //    this.button_close_view.Name = "button_close_view";
        //    this.button_close_view.Size = new System.Drawing.Size(167, 52);
        //    this.button_close_view.TabIndex = 0;
        //    this.button_close_view.TabStop = false;
        //    this.button_close_view.Text = "Закрыть";
        //    this.button_close_view.UseVisualStyleBackColor = true;
        //    this.button_close_view.Click += new System.EventHandler(this.button_close_view_Click);
        //    // 
        //    // pictureBox_view
        //    // 
        //    this.pictureBox_view.BackColor = System.Drawing.Color.DarkGray;
        //    this.tableLayoutPanel_view.SetColumnSpan(this.pictureBox_view, 5);
        //    this.pictureBox_view.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.pictureBox_view.Location = new System.Drawing.Point(0, 0);
        //    this.pictureBox_view.Margin = new System.Windows.Forms.Padding(0);
        //    this.pictureBox_view.Name = "pictureBox_view";
        //    this.pictureBox_view.Size = new System.Drawing.Size(600, 428);
        //    this.pictureBox_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        //    this.pictureBox_view.TabIndex = 6;
        //    this.pictureBox_view.TabStop = false;
        //    // 
        //    // openFileDialog1
        //    // 
        //    this.openFileDialog1.FileName = "openFileDialog1";
        //    this.openFileDialog1.Filter = "Video&Picture|*.mp4;*.mov;*.avi;*.jpg;*.png;*.jpeg";
        //    // 
        //    // MainForm
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(890, 520);
        //    this.Controls.Add(this.panel_main);
        //    this.Controls.Add(this.button_close);
        //    this.Controls.Add(this.button_unwrap);
        //    this.Controls.Add(this.button_wrap);
        //    this.DoubleBuffered = true;
        //    this.ForeColor = System.Drawing.Color.Black;
        //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        //    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        //    this.Name = "MainForm";
        //    this.Text = "BadPepper";
        //    this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
        //    this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
        //    this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
        //    this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
        //    this.panel_main.ResumeLayout(false);
        //    this.panel_menu.ResumeLayout(false);
        //    this.panel_settings.ResumeLayout(false);
        //    this.panel_settings.PerformLayout();
        //    ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_speed)).EndInit();
        //    this.tableLayoutPanel_menu.ResumeLayout(false);
        //    this.tableLayoutPanel_menu.PerformLayout();
        //    this.panel_view.ResumeLayout(false);
        //    this.tableLayoutPanel_view.ResumeLayout(false);
        //    ((System.ComponentModel.ISupportInitialize)(this.pictureBox_view)).EndInit();
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_wrap = new System.Windows.Forms.Button();
            this.button_unwrap = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.checkBox_detection = new System.Windows.Forms.CheckBox();
            this.checkBox_qualitative = new System.Windows.Forms.CheckBox();
            this.checkBox_cracking_pulp = new System.Windows.Forms.CheckBox();
            this.checkBox_alternariosis = new System.Windows.Forms.CheckBox();
            this.checkBox_rot = new System.Windows.Forms.CheckBox();
            this.radioButton_dark = new System.Windows.Forms.RadioButton();
            this.radioButton_light = new System.Windows.Forms.RadioButton();
            this.label_theme = new System.Windows.Forms.Label();
            this.label_peppers = new System.Windows.Forms.Label();
            this.numericUpDown_speed = new System.Windows.Forms.NumericUpDown();
            this.label_speed = new System.Windows.Forms.Label();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label_path = new System.Windows.Forms.Label();
            this.label_app = new System.Windows.Forms.Label();
            this.button_save_settings = new System.Windows.Forms.Button();
            this.tableLayoutPanel_menu = new System.Windows.Forms.TableLayoutPanel();
            this.button_open = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_view = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_view = new System.Windows.Forms.TableLayoutPanel();
            this.button_save_picture = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_close_view = new System.Windows.Forms.Button();
            this.pictureBox_view = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_main.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_speed)).BeginInit();
            this.tableLayoutPanel_menu.SuspendLayout();
            this.panel_view.SuspendLayout();
            this.tableLayoutPanel_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_view)).BeginInit();
            this.SuspendLayout();
            // 
            // button_wrap
            // 
            this.button_wrap.AutoSize = true;
            this.button_wrap.BackColor = System.Drawing.SystemColors.Control;
            this.button_wrap.FlatAppearance.BorderSize = 0;
            this.button_wrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_wrap.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_wrap.ForeColor = System.Drawing.Color.DarkRed;
            this.button_wrap.Location = new System.Drawing.Point(791, 0);
            this.button_wrap.Margin = new System.Windows.Forms.Padding(0);
            this.button_wrap.Name = "button_wrap";
            this.button_wrap.Size = new System.Drawing.Size(33, 33);
            this.button_wrap.TabIndex = 0;
            this.button_wrap.TabStop = false;
            this.button_wrap.Text = "🗕";
            this.button_wrap.UseVisualStyleBackColor = false;
            this.button_wrap.Click += new System.EventHandler(this.button_wrap_Click);
            // 
            // button_unwrap
            // 
            this.button_unwrap.AutoSize = true;
            this.button_unwrap.BackColor = System.Drawing.SystemColors.Control;
            this.button_unwrap.FlatAppearance.BorderSize = 0;
            this.button_unwrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_unwrap.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_unwrap.ForeColor = System.Drawing.Color.DarkRed;
            this.button_unwrap.Location = new System.Drawing.Point(824, 0);
            this.button_unwrap.Margin = new System.Windows.Forms.Padding(0);
            this.button_unwrap.Name = "button_unwrap";
            this.button_unwrap.Size = new System.Drawing.Size(33, 33);
            this.button_unwrap.TabIndex = 0;
            this.button_unwrap.TabStop = false;
            this.button_unwrap.Text = "🗖";
            this.button_unwrap.UseVisualStyleBackColor = false;
            this.button_unwrap.Click += new System.EventHandler(this.button_unwrap_Click);
            // 
            // button_close
            // 
            this.button_close.AutoSize = true;
            this.button_close.BackColor = System.Drawing.SystemColors.Control;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_close.ForeColor = System.Drawing.Color.DarkRed;
            this.button_close.Location = new System.Drawing.Point(857, 0);
            this.button_close.Margin = new System.Windows.Forms.Padding(0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(33, 33);
            this.button_close.TabIndex = 0;
            this.button_close.TabStop = false;
            this.button_close.Text = "❌";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_main.Controls.Add(this.panel_menu);
            this.panel_main.Controls.Add(this.panel_view);
            this.panel_main.Location = new System.Drawing.Point(0, 33);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(890, 489);
            this.panel_main.TabIndex = 3;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_menu.Controls.Add(this.panel_settings);
            this.panel_menu.Controls.Add(this.tableLayoutPanel_menu);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(890, 489);
            this.panel_menu.TabIndex = 1;
            // 
            // panel_settings
            // 
            this.panel_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_settings.BackColor = System.Drawing.SystemColors.Control;
            this.panel_settings.Controls.Add(this.checkBox_detection);
            this.panel_settings.Controls.Add(this.checkBox_qualitative);
            this.panel_settings.Controls.Add(this.checkBox_cracking_pulp);
            this.panel_settings.Controls.Add(this.checkBox_alternariosis);
            this.panel_settings.Controls.Add(this.checkBox_rot);
            this.panel_settings.Controls.Add(this.radioButton_dark);
            this.panel_settings.Controls.Add(this.radioButton_light);
            this.panel_settings.Controls.Add(this.label_theme);
            this.panel_settings.Controls.Add(this.label_peppers);
            this.panel_settings.Controls.Add(this.numericUpDown_speed);
            this.panel_settings.Controls.Add(this.label_speed);
            this.panel_settings.Controls.Add(this.textBox_path);
            this.panel_settings.Controls.Add(this.label_path);
            this.panel_settings.Controls.Add(this.label_app);
            this.panel_settings.Controls.Add(this.button_save_settings);
            this.panel_settings.Location = new System.Drawing.Point(0, 0);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(890, 489);
            this.panel_settings.TabIndex = 1;
            // 
            // checkBox_detection
            // 
            this.checkBox_detection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_detection.Checked = true;
            this.checkBox_detection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_detection.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_detection.Location = new System.Drawing.Point(20, 230);
            this.checkBox_detection.Name = "checkBox_detection";
            this.checkBox_detection.Size = new System.Drawing.Size(867, 35);
            this.checkBox_detection.TabIndex = 0;
            this.checkBox_detection.Text = "Распознавать";
            this.checkBox_detection.CheckedChanged += new System.EventHandler(this.checkBox_detection_CheckedChanged);
            // 
            // checkBox_qualitative
            // 
            this.checkBox_qualitative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_qualitative.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_qualitative.Location = new System.Drawing.Point(20, 379);
            this.checkBox_qualitative.Name = "checkBox_qualitative";
            this.checkBox_qualitative.Size = new System.Drawing.Size(867, 30);
            this.checkBox_qualitative.TabIndex = 16;
            this.checkBox_qualitative.Text = "(Q)Качественны ";
            this.checkBox_qualitative.UseVisualStyleBackColor = true;
            this.checkBox_qualitative.CheckedChanged += new System.EventHandler(this.checkBox_qualitative_CheckedChanged);
            // 
            // checkBox_cracking_pulp
            // 
            this.checkBox_cracking_pulp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_cracking_pulp.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_cracking_pulp.Location = new System.Drawing.Point(20, 343);
            this.checkBox_cracking_pulp.Name = "checkBox_cracking_pulp";
            this.checkBox_cracking_pulp.Size = new System.Drawing.Size(867, 30);
            this.checkBox_cracking_pulp.TabIndex = 15;
            this.checkBox_cracking_pulp.Text = "(C)Растресканные до мякоти";
            this.checkBox_cracking_pulp.UseVisualStyleBackColor = true;
            this.checkBox_cracking_pulp.CheckedChanged += new System.EventHandler(this.checkBox_cracking_pulp_CheckedChanged);
            // 
            // checkBox_alternariosis
            // 
            this.checkBox_alternariosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_alternariosis.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_alternariosis.Location = new System.Drawing.Point(20, 307);
            this.checkBox_alternariosis.Name = "checkBox_alternariosis";
            this.checkBox_alternariosis.Size = new System.Drawing.Size(867, 30);
            this.checkBox_alternariosis.TabIndex = 14;
            this.checkBox_alternariosis.Text = "(A)Альтернариозные";
            this.checkBox_alternariosis.UseVisualStyleBackColor = true;
            this.checkBox_alternariosis.CheckedChanged += new System.EventHandler(this.checkBox_alternariosis_CheckedChanged);
            // 
            // checkBox_rot
            // 
            this.checkBox_rot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_rot.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_rot.Location = new System.Drawing.Point(20, 271);
            this.checkBox_rot.Name = "checkBox_rot";
            this.checkBox_rot.Size = new System.Drawing.Size(867, 30);
            this.checkBox_rot.TabIndex = 13;
            this.checkBox_rot.Text = "(R)Гнилые";
            this.checkBox_rot.UseVisualStyleBackColor = true;
            this.checkBox_rot.CheckedChanged += new System.EventHandler(this.checkBox_rot_CheckedChanged);
            // 
            // radioButton_dark
            // 
            this.radioButton_dark.AutoSize = true;
            this.radioButton_dark.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_dark.Location = new System.Drawing.Point(129, 145);
            this.radioButton_dark.Name = "radioButton_dark";
            this.radioButton_dark.Size = new System.Drawing.Size(82, 25);
            this.radioButton_dark.TabIndex = 11;
            this.radioButton_dark.Text = "Темная";
            this.radioButton_dark.UseVisualStyleBackColor = true;
            this.radioButton_dark.Click += new System.EventHandler(this.radioButton_dark_Click);
            // 
            // radioButton_light
            // 
            this.radioButton_light.AutoSize = true;
            this.radioButton_light.Checked = true;
            this.radioButton_light.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_light.Location = new System.Drawing.Point(129, 114);
            this.radioButton_light.Name = "radioButton_light";
            this.radioButton_light.Size = new System.Drawing.Size(91, 25);
            this.radioButton_light.TabIndex = 10;
            this.radioButton_light.TabStop = true;
            this.radioButton_light.Text = "Светлая";
            this.radioButton_light.UseVisualStyleBackColor = true;
            this.radioButton_light.Click += new System.EventHandler(this.radioButton_light_Click);
            // 
            // label_theme
            // 
            this.label_theme.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_theme.Location = new System.Drawing.Point(0, 114);
            this.label_theme.Name = "label_theme";
            this.label_theme.Size = new System.Drawing.Size(120, 56);
            this.label_theme.TabIndex = 7;
            this.label_theme.Text = "Тема";
            this.label_theme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_peppers
            // 
            this.label_peppers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_peppers.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_peppers.Location = new System.Drawing.Point(0, 192);
            this.label_peppers.Name = "label_peppers";
            this.label_peppers.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label_peppers.Size = new System.Drawing.Size(890, 35);
            this.label_peppers.TabIndex = 6;
            this.label_peppers.Text = "Перцы";
            this.label_peppers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_speed
            // 
            this.numericUpDown_speed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_speed.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_speed.Location = new System.Drawing.Point(129, 78);
            this.numericUpDown_speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_speed.Name = "numericUpDown_speed";
            this.numericUpDown_speed.Size = new System.Drawing.Size(749, 26);
            this.numericUpDown_speed.TabIndex = 5;
            this.numericUpDown_speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_speed
            // 
            this.label_speed.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_speed.Location = new System.Drawing.Point(0, 73);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(120, 35);
            this.label_speed.TabIndex = 4;
            this.label_speed.Text = "Промотка";
            this.label_speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_path
            // 
            this.textBox_path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_path.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_path.Location = new System.Drawing.Point(129, 42);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(749, 26);
            this.textBox_path.TabIndex = 3;
            this.textBox_path.Text = "C:\\";
            // 
            // label_path
            // 
            this.label_path.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_path.Location = new System.Drawing.Point(0, 38);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(123, 35);
            this.label_path.TabIndex = 2;
            this.label_path.Text = "Сохранение";
            this.label_path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_app
            // 
            this.label_app.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_app.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_app.Location = new System.Drawing.Point(0, 3);
            this.label_app.Name = "label_app";
            this.label_app.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label_app.Size = new System.Drawing.Size(890, 35);
            this.label_app.TabIndex = 1;
            this.label_app.Text = "Приложение";
            this.label_app.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_save_settings
            // 
            this.button_save_settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_save_settings.FlatAppearance.BorderSize = 0;
            this.button_save_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_settings.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_save_settings.Location = new System.Drawing.Point(0, 439);
            this.button_save_settings.Name = "button_save_settings";
            this.button_save_settings.Size = new System.Drawing.Size(890, 50);
            this.button_save_settings.TabIndex = 0;
            this.button_save_settings.TabStop = false;
            this.button_save_settings.Text = "Сохранить";
            this.button_save_settings.UseVisualStyleBackColor = true;
            this.button_save_settings.Click += new System.EventHandler(this.button_save_settings_Click);
            // 
            // tableLayoutPanel_menu
            // 
            this.tableLayoutPanel_menu.ColumnCount = 3;
            this.tableLayoutPanel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_menu.Controls.Add(this.button_open, 1, 1);
            this.tableLayoutPanel_menu.Controls.Add(this.button_settings, 1, 3);
            this.tableLayoutPanel_menu.Controls.Add(this.label_title, 0, 2);
            this.tableLayoutPanel_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_menu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_menu.Name = "tableLayoutPanel_menu";
            this.tableLayoutPanel_menu.RowCount = 4;
            this.tableLayoutPanel_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel_menu.Size = new System.Drawing.Size(890, 489);
            this.tableLayoutPanel_menu.TabIndex = 0;
            // 
            // button_open
            // 
            this.button_open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_open.FlatAppearance.BorderSize = 0;
            this.button_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_open.Location = new System.Drawing.Point(323, 53);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(244, 44);
            this.button_open.TabIndex = 0;
            this.button_open.TabStop = false;
            this.button_open.Text = "Выбрать";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_settings
            // 
            this.tableLayoutPanel_menu.SetColumnSpan(this.button_settings, 3);
            this.button_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_settings.Location = new System.Drawing.Point(3, 436);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(884, 50);
            this.button_settings.TabIndex = 0;
            this.button_settings.TabStop = false;
            this.button_settings.Text = "Настройки";
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.tableLayoutPanel_menu.SetColumnSpan(this.label_title, 3);
            this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_title.Font = new System.Drawing.Font("Segoe Print", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.ForeColor = System.Drawing.Color.DarkRed;
            this.label_title.Location = new System.Drawing.Point(3, 100);
            this.label_title.Name = "label_title";
            this.label_title.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label_title.Size = new System.Drawing.Size(884, 333);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "BadPepper";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_view
            // 
            this.panel_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.panel_view.Controls.Add(this.tableLayoutPanel_view);
            this.panel_view.Location = new System.Drawing.Point(0, 0);
            this.panel_view.Margin = new System.Windows.Forms.Padding(0);
            this.panel_view.Name = "panel_view";
            this.panel_view.Size = new System.Drawing.Size(600, 486);
            this.panel_view.TabIndex = 0;
            // 
            // tableLayoutPanel_view
            // 
            this.tableLayoutPanel_view.ColumnCount = 5;
            this.tableLayoutPanel_view.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_view.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_view.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_view.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_view.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_view.Controls.Add(this.button_save_picture, 4, 1);
            this.tableLayoutPanel_view.Controls.Add(this.button_right, 3, 1);
            this.tableLayoutPanel_view.Controls.Add(this.button_pause, 2, 1);
            this.tableLayoutPanel_view.Controls.Add(this.button_left, 1, 1);
            this.tableLayoutPanel_view.Controls.Add(this.button_close_view, 0, 1);
            this.tableLayoutPanel_view.Controls.Add(this.pictureBox_view, 0, 0);
            this.tableLayoutPanel_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_view.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_view.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_view.Name = "tableLayoutPanel_view";
            this.tableLayoutPanel_view.RowCount = 2;
            this.tableLayoutPanel_view.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_view.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_view.Size = new System.Drawing.Size(600, 486);
            this.tableLayoutPanel_view.TabIndex = 1;
            // 
            // button_save_picture
            // 
            this.button_save_picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_save_picture.FlatAppearance.BorderSize = 0;
            this.button_save_picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_picture.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_save_picture.Location = new System.Drawing.Point(453, 439);
            this.button_save_picture.Name = "button_save_picture";
            this.button_save_picture.Size = new System.Drawing.Size(144, 44);
            this.button_save_picture.TabIndex = 0;
            this.button_save_picture.TabStop = false;
            this.button_save_picture.Text = "Сохранить";
            this.button_save_picture.UseVisualStyleBackColor = true;
            this.button_save_picture.Click += new System.EventHandler(this.button_save_picture_Click);
            // 
            // button_right
            // 
            this.button_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_right.FlatAppearance.BorderSize = 0;
            this.button_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_right.Font = new System.Drawing.Font("Cascadia Mono Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_right.Location = new System.Drawing.Point(423, 439);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(24, 44);
            this.button_right.TabIndex = 0;
            this.button_right.TabStop = false;
            this.button_right.Text = "ᐅ";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_pause
            // 
            this.button_pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_pause.FlatAppearance.BorderSize = 0;
            this.button_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pause.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_pause.Location = new System.Drawing.Point(183, 439);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(234, 44);
            this.button_pause.TabIndex = 0;
            this.button_pause.TabStop = false;
            this.button_pause.Text = "Просмотр";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_left
            // 
            this.button_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_left.FlatAppearance.BorderSize = 0;
            this.button_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_left.Font = new System.Drawing.Font("Cascadia Mono Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_left.Location = new System.Drawing.Point(153, 439);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(24, 44);
            this.button_left.TabIndex = 0;
            this.button_left.TabStop = false;
            this.button_left.Text = "ᐊ";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_close_view
            // 
            this.button_close_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_close_view.FlatAppearance.BorderSize = 0;
            this.button_close_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close_view.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_close_view.Location = new System.Drawing.Point(3, 439);
            this.button_close_view.Name = "button_close_view";
            this.button_close_view.Size = new System.Drawing.Size(144, 44);
            this.button_close_view.TabIndex = 0;
            this.button_close_view.TabStop = false;
            this.button_close_view.Text = "Закрыть";
            this.button_close_view.UseVisualStyleBackColor = true;
            this.button_close_view.Click += new System.EventHandler(this.button_close_view_Click);
            // 
            // pictureBox_view
            // 
            this.pictureBox_view.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel_view.SetColumnSpan(this.pictureBox_view, 5);
            this.pictureBox_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_view.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_view.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_view.Name = "pictureBox_view";
            this.pictureBox_view.Size = new System.Drawing.Size(600, 436);
            this.pictureBox_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_view.TabIndex = 6;
            this.pictureBox_view.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Video&Picture|*.mp4;*.mov;*.avi;*.jpg;*.png;*.jpeg";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 520);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_unwrap);
            this.Controls.Add(this.button_wrap);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "BadPepper";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.panel_main.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel_settings.ResumeLayout(false);
            this.panel_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_speed)).EndInit();
            this.tableLayoutPanel_menu.ResumeLayout(false);
            this.tableLayoutPanel_menu.PerformLayout();
            this.panel_view.ResumeLayout(false);
            this.tableLayoutPanel_view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_main;
        private Button button_close;
        private Button button_unwrap;
        private Button button_wrap;
        private Panel panel_menu;
        private Panel panel_settings;
        private Panel panel_view;
        private Label label_peppers;
        private Label label_theme;
        private Label label_speed;
        private Label label_path;
        private Label label_app;
        private RadioButton radioButton_dark;
        private RadioButton radioButton_light;
        private CheckBox checkBox_qualitative;
        private CheckBox checkBox_cracking_pulp;
        private CheckBox checkBox_alternariosis;
        private CheckBox checkBox_rot;
        private NumericUpDown numericUpDown_speed;
        private TextBox textBox_path;
        private Button button_save_settings;
        private OpenFileDialog openFileDialog1;
        private TableLayoutPanel tableLayoutPanel_menu;
        private Button button_open;
        private Label label_title;
        private Button button_settings;
        private TableLayoutPanel tableLayoutPanel_view;
        private Button button_save_picture;
        private Button button_right;
        private Button button_pause;
        private Button button_left;
        private PictureBox pictureBox_view;
        private Button button_close_view;
        private CheckBox checkBox_detection;
    }
}