using System.Drawing.Imaging;

namespace gif2images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtInputGif.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                   txtOutputDir.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            string inputGif = txtInputGif.Text;
            string outputDir = txtOutputDir.Text;

            if (string.IsNullOrEmpty(inputGif) || string.IsNullOrEmpty(outputDir))
            {
                 MessageBox.Show("Please select input GIF file and output directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
            }

            if (!File.Exists(inputGif))
            {
                MessageBox.Show($"Error: Input file '{inputGif}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             try
            {
                GifExtractor.ExtractFrames(inputGif, outputDir);
                MessageBox.Show("GIF frames extracted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.txtOutputDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }


        private void btnCreateCombinedImage_Click(object sender, EventArgs e)
        {
            string inputGif = txtInputGif.Text;
            string outputDir = txtOutputDir.Text;

            if (string.IsNullOrEmpty(inputGif) || string.IsNullOrEmpty(outputDir))
            {
                MessageBox.Show("Please select input GIF file and output directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             if (!File.Exists(inputGif))
            {
                MessageBox.Show($"Error: Input file '{inputGif}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtStartFrame.Text, out int startFrame) ||
                !int.TryParse(txtEndFrame.Text, out int endFrame) ||
                !int.TryParse(txtStep.Text, out int step) )
            {
                MessageBox.Show("Please enter valid integers for start frame, end frame, and step.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


             if (startFrame < 0 || endFrame < 0 || step <= 0)
            {
                MessageBox.Show("Start frame and end frame must be non-negative and step must be positive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             try
            {
               CreateCombinedImage(inputGif, outputDir, startFrame, endFrame, step);
               MessageBox.Show("Combined image created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         private void CreateCombinedImage(string gifFilePath, string outputDir, int startFrame, int endFrame, int step)
        {
           using (var image = Image.FromFile(gifFilePath))
            {
                FrameDimension frameDimension = new FrameDimension(image.FrameDimensionsList[0]);
                int frameCount = image.GetFrameCount(frameDimension);
                 int fps = 24; // 假设帧率为24FPS，可以读取GIF图片元数据进行自动获取

                if (startFrame >= frameCount || endFrame >= frameCount || startFrame > endFrame)
                {
                     throw new ArgumentException("Invalid frame range.");
                }

                int combinedWidth = 0;
                int frameHeight = 0;
                List<Bitmap> framesToCombine = new List<Bitmap>();

                 // 添加起始帧
                image.SelectActiveFrame(frameDimension, startFrame);
                Bitmap startBitmap = new Bitmap(image);
                double startTime = (double)startFrame/fps;
                GifExtractor.DrawTimestamp(startBitmap, startTime);
                framesToCombine.Add(startBitmap);
                 combinedWidth += startBitmap.Width;
                 frameHeight = startBitmap.Height;
                
               // 添加中间帧
                if(startFrame != endFrame){
                   for (int i = startFrame+step; i < endFrame; i+=step)
                    {
                        image.SelectActiveFrame(frameDimension, i);
                        Bitmap currentBitmap = new Bitmap(image);
                        double currentTime = (double)i/fps;
                        GifExtractor.DrawTimestamp(currentBitmap, currentTime);
                        framesToCombine.Add(currentBitmap);
                        combinedWidth += currentBitmap.Width;
                    }
                }
               
                // 添加结束帧
                if(!framesToCombine.Any(bitmap => bitmap.Width == endFrame))
                {
                  image.SelectActiveFrame(frameDimension, endFrame);
                    Bitmap endBitmap = new Bitmap(image);
                    double endTime = (double)endFrame/fps;
                    GifExtractor.DrawTimestamp(endBitmap, endTime);
                     framesToCombine.Add(endBitmap);
                     combinedWidth += endBitmap.Width;
                }

                // 创建新图片
                Bitmap combinedImage = new Bitmap(combinedWidth, frameHeight);

                using (Graphics g = Graphics.FromImage(combinedImage))
                {
                     int xOffset = 0;
                    foreach (Bitmap frame in framesToCombine)
                    {
                        g.DrawImage(frame, xOffset, 0);
                        xOffset += frame.Width;
                        frame.Dispose();
                    }
                }
                
                  string combinedFileName = Path.Combine(outputDir, $"combined_frames_{startFrame}_to_{endFrame}_step_{step}.png");
                 combinedImage.Save(combinedFileName, ImageFormat.Png);
                 combinedImage.Dispose();
           }

        }
    }
}