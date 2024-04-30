using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public static class ImageUtil
    {
        public static string ImageToString(Image image)
        {
            if (image == null) return string.Empty;
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Jpeg);
            byte[] bytes = memoryStream.ToArray();
            return Convert.ToBase64String(bytes);
        }

        public static Image StringToImage(string str)
        {
            byte[] bytes = Convert.FromBase64String(str);
            MemoryStream memoryStream = new MemoryStream(bytes);
            return Image.FromStream(memoryStream);
        }

        public static Image UploadImage()
        {
            OpenFileDialog opnfd = new OpenFileDialog
            {
                InitialDirectory = "C:/sample",
                Title = "Select image to be uploaded",
                Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"
            };
            while (true)
            {
                if (opnfd.ShowDialog() == DialogResult.OK)
                {
                    return new Bitmap(opnfd.FileName);
                }
                MessageBox.Show("Please upload an image.");
            }
        }

        public static List<Image> UploadImages(int noImages)
        {
            List<Image> images = new List<Image>();
            OpenFileDialog opnfd = new OpenFileDialog
            {
                InitialDirectory = "C://Desktop",
                Title = "Select images to be uploaded",
                Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"
            };
            while (images.Count < noImages)
            {
                if (opnfd.ShowDialog() == DialogResult.OK)
                {
                    images.Add(new Bitmap(opnfd.FileName));
                    MessageBox.Show("Please upload more images.");
                }
                else
                {
                    MessageBox.Show("Please upload images.");
                }
            }
            return images;
        }

        public static Image AutoFitPictureBox(PictureBox pictureBox, Image image)
        {
            // Resize the image to fit the dimensions of the PictureBox
            float ratio = Math.Min((float)pictureBox.Width / image.Width, (float)pictureBox.Height / image.Height);
            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);
            return new Bitmap(image, newWidth, newHeight);
        }
    }
}
