using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class PostImgCatalogDAO
    {
        private DBConnection dBConn = new DBConnection();
        private string sqlStr = "";

        public DataTable GetCatalog()
        {
            sqlStr = string.Format("SELECT * FROM PostImgCatalog");
            return dBConn.Load(sqlStr);
        }

        public List<Image> GetImages(int postId)
        {
            sqlStr = string.Format("SELECT * FROM PostImgCatalog WHERE Postid = '{0}'", postId);
            DataTable dataTable = dBConn.Load(sqlStr);
            List<Image> images = new List<Image>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                images.Add((Image)dataRow[1]);
            }
            return images;
        }

        public void Insert(int postId, Image image)
        {
            sqlStr = string.Format("INSERT INTO PostImgCatalog (Postid, Postimage) VALUES ('{0}', '{1}')", postId, image);
            dBConn.Execute(sqlStr, "Insert");
        }

        public void DeletePostId(int postId)
        {
            sqlStr = string.Format("DELETE FROM PostImgCatalog WHERE Postid = '{0}'", postId);
            dBConn.Execute(sqlStr, "Delete");
        }

        public void DeleteJobDesc(Image image)
        {
            sqlStr = string.Format("DELETE FROM PostImgCatalog WHERE Postimage = '{0}'", image);
            dBConn.Execute(sqlStr, "Delete");
        }
    }
}
