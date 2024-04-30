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
        public static byte[] ImageToByte(Image image)
        {
            if (image == null) return null;
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }

        public static Image ByteToImage(byte[] bytes)
        {
            MemoryStream memoryStream = new MemoryStream(bytes);
            return Image.FromStream(memoryStream);
        }

        public static Image UploadImage()
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.InitialDirectory = "C://Desktop";
            opnfd.Title = "Select image to be uploaded";
            opnfd.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            while (true)
            {
                if (opnfd.ShowDialog() == DialogResult.OK)
                {
                    return new Bitmap(opnfd.FileName);
                }
                MessageBox.Show("Please upload image.");
            }
        }

        public static List<Image> UploadImages(int noImages)
        {
            List<Image> images = new List<Image>();
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.InitialDirectory = "C://Desktop";
            opnfd.Title = "Select images to be uploaded";
            opnfd.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
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
