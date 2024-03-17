
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
namespace ImageResize
{
    

    public partial class Form1 : Form
    {
        private Bitmap originalImage;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image files (*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(dlg.FileName);
                    pictureBox1.Image = originalImage;
                }
            }
        }

        private void btnDownscale_Click(object sender, EventArgs e)
        {
            float scaleFactor = float.Parse(txtScaleFactor.Text) / 100f;
            Bitmap downscaledImage = DownscaleImage(originalImage, scaleFactor);
            pictureBox1.Image = downscaledImage;
        }

        private Bitmap DownscaleImage(Bitmap originalImage, float scaleFactor)
        {
            int newWidth = (int)(originalImage.Width * scaleFactor);
            int newHeight = (int)(originalImage.Height * scaleFactor);
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            Rectangle newRect = new Rectangle(0, 0, newWidth, newHeight);

         
            BitmapData originalData = originalImage.LockBits(new Rectangle(0, 0, originalImage.Width, originalImage.Height), ImageLockMode.ReadOnly, originalImage.PixelFormat);
            BitmapData resizedData = resizedImage.LockBits(newRect, ImageLockMode.WriteOnly, resizedImage.PixelFormat);

          
            int bytesPerPixel = Image.GetPixelFormatSize(originalImage.PixelFormat) / 8;
            byte[] originalPixels = new byte[originalData.Stride * originalImage.Height];
            byte[] resizedPixels = new byte[resizedData.Stride * newHeight];

            
            System.Runtime.InteropServices.Marshal.Copy(originalData.Scan0, originalPixels, 0, originalPixels.Length);

            
            Parallel.For(0, newHeight, y =>
            {
                int newY = (int)(y / scaleFactor);
                for (int x = 0; x < newWidth; x++)
                {
                    int newX = (int)(x / scaleFactor);
                    for (int c = 0; c < bytesPerPixel; c++)
                    {
                        int originalIndex = (newY * originalData.Stride) + (newX * bytesPerPixel) + c;
                        int resizedIndex = (y * resizedData.Stride) + (x * bytesPerPixel) + c;
                        resizedPixels[resizedIndex] = originalPixels[originalIndex];
                    }
                }
            });

            System.Runtime.InteropServices.Marshal.Copy(resizedPixels, 0, resizedData.Scan0, resizedPixels.Length);
            originalImage.UnlockBits(originalData);
            resizedImage.UnlockBits(resizedData);

            return resizedImage;
        }

    }

}
