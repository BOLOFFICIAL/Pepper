using System;
using System.Collections.Generic;
using System.Drawing;
using Yolov5Net.Scorer;
using Yolov5Net.Scorer.Models;
using Pepper;

namespace Yolov5Net.App
{
    public class ImageYolo
    {
        public static Image GetImage(Image image)
        {
            return EditImage(image);
        }
        public static Image EditImage(Image image)
        {
            using var scorer = new YoloScorer<YoloCocoP5Model>(@"C:\Users\Bolofficial\Downloads\YoloV5s_DC.onnx");
            List<YoloPrediction> predictions = scorer.Predict(image);
            using var graphics = Graphics.FromImage(image);
            foreach (var prediction in predictions)
            {
                if (MainForm.labels.Contains(prediction.Label.Name)&& prediction.Score>0.5) 
                {
                    double score = Math.Round(prediction.Score, 2);

                    graphics.DrawRectangles(new Pen(prediction.Label.Color, 5),
                        new[] { prediction.Rectangle });

                    var (x, y) = (prediction.Rectangle.X - 3, prediction.Rectangle.Y - 23);
                    var size = 16 * (int)((image.Width * image.Height) / 2073600);
                    if (size < 16) 
                    {
                        size = 16;
                    }
                    graphics.DrawString($"{prediction.Label.Name.ToUpper().First()} ({score})",
                    new Font("Consolas", size, GraphicsUnit.Pixel), new SolidBrush(prediction.Label.Color),
                    new PointF(x, y));
                }
            }
            return image;
        }
    }
}
