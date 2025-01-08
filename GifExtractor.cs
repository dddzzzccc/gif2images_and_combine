using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Text;

namespace gif2images
{
    public class GifExtractor
    {
        public static void ExtractFrames(string gifFilePath, string outputDirectory)
        {
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

             using (var image = Image.FromFile(gifFilePath))
            {
                FrameDimension frameDimension = new FrameDimension(image.FrameDimensionsList[0]);
                int frameCount = image.GetFrameCount(frameDimension);
                int fps = 24; // 假设帧率为24FPS，可以读取GIF图片元数据进行自动获取

                for (int i = 0; i < frameCount; i++)
                {
                    image.SelectActiveFrame(frameDimension, i);
                    string frameFileName = Path.Combine(outputDirectory, $"frame_{i:D3}.png");
                    using(Bitmap frame = new Bitmap(image))
                    {
                        // 计算当前帧的时间
                        double timeInSeconds = (double)i / fps;

                        // 在图片上绘制时间戳
                        DrawTimestamp(frame, timeInSeconds);
                        frame.Save(frameFileName, ImageFormat.Png);
                    }

                    Console.WriteLine($"Saved frame {i + 1}/{frameCount} to {frameFileName}");
                }
            }
              Console.WriteLine("Done!");
        }


         public static void DrawTimestamp(Bitmap image, double timeInSeconds)
        {
            using (Graphics g = Graphics.FromImage(image))
            {
                g.TextRenderingHint = TextRenderingHint.AntiAlias; // 抗锯齿，让文字更平滑

                string timestamp = $"{timeInSeconds:F2} s"; // 时间戳字符串，保留两位小数
                Font font = new Font("Arial", 96);
                SizeF textSize = g.MeasureString(timestamp, font); // 获取文字的尺寸

                // 计算时间戳的位置 (右下角，留出一些边距)
                float x = image.Width - textSize.Width - 5;
                float y = image.Height - textSize.Height - 5;

                // 背景色
                using (SolidBrush bgBrush = new SolidBrush(Color.FromArgb(128, Color.White)))
                {
                     g.FillRectangle(bgBrush, x-2, y-2, textSize.Width+4, textSize.Height+4);
                }

                // 文字颜色
                using (SolidBrush textBrush = new SolidBrush(Color.Black))
                {
                    g.DrawString(timestamp, font, textBrush, x, y);
                }
            }
        }
    }
}