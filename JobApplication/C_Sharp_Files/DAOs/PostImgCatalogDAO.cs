using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class PostImgCatalogDAO : AnyDAO
    {
        public List<Image> GetImages(int postId)
        {
            sqlStr = string.Format("SELECT * FROM PostImgCatalog WHERE Postid = '{0}'", postId);
            DataTable dataTable = dBConn.Load(sqlStr);
            List<Image> images = new List<Image>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                images.Add(ImageUtil.ByteToImage((byte[])dataRow[1]));
            }
            return images;
        }


        public void Insert(int postId, Image image)
        {
            if (ImageUtil.ImageToByte(image) == null) return;
            sqlStr = string.Format("INSERT INTO PostImgCatalog (Postid, Postimage) VALUES ('{0}', @image)", postId);
            dBConn.Execute(sqlStr, "Insert", ImageUtil.ImageToByte(image));
        }

        public void DeletePostId(int postId)
        {
            sqlStr = string.Format("DELETE FROM PostImgCatalog WHERE Postid = '{0}'", postId);
            dBConn.Execute(sqlStr, "Delete");
        }

        public void DeleteImage(Image image)
        {
            sqlStr = string.Format("DELETE FROM PostImgCatalog WHERE Postimage = @image");
            dBConn.Execute(sqlStr, "Delete", ImageUtil.ImageToByte(image));
        }

        public void Update(int postId, Image image)
        {
            sqlStr = string.Format("UPDATE PostImgCatalog SET Postimage = @image WHERE Postid = '{0}'", postId);
            dBConn.Execute(sqlStr, "Update", ImageUtil.ImageToByte(image));
        }
    }
}
