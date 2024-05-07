using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public static class FileUtil
    {
        public static string FileToString(string path)
        {
            if (string.IsNullOrEmpty(path)) return string.Empty;
            BinaryReader binaryReader = new BinaryReader(File.OpenRead(path));

            byte[] bytes = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
            return Convert.ToBase64String(bytes);
        }

        public static string StringToFile(string fileContent, string fileName)
        {
            string newFilePath = "C:/sample/" + fileName;
            byte[] bytes = Convert.FromBase64String(fileContent);
            try
            {
                FileStream fileStream = new FileStream(newFilePath, FileMode.Create, FileAccess.Write);
                fileStream.Write(bytes, 0, bytes.Length);
            }
            catch (IOException)
            {
                return newFilePath;
            }
            return newFilePath;
        }

        public static string UploadFile()
        {
            OpenFileDialog opnfd = new OpenFileDialog
            {
                InitialDirectory = "C:/sample",
                Title = "Select file to be uploaded",
                Filter = "PDF Only(*.pdf)|*.pdf|All files|*.*"
            };
            while (true)
            {
                if (opnfd.ShowDialog() == DialogResult.OK)
                {
                    return opnfd.FileName;  // return file's path
                }
                MessageBox.Show("Please upload a file.");
            }
        }

        public static string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }
    }
}
