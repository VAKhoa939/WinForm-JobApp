using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class PostTagCatalogDAO : AnyDAO
    {
        public List<string> GetTags(int postId)
        {
            sqlStr = string.Format("SELECT * FROM PostTagCatalog WHERE Postid = '{0}'", postId);
            DataTable dataTable = dBConn.Load(sqlStr);
            List<string> tags = new List<string>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                tags.Add(dataRow[1].ToString());
            }
            return tags;
        }

        public void Insert(int postId, string tag)
        {
            sqlStr = string.Format("INSERT INTO PostTagCatalog (Postid, Tag) VALUES ('{0}', '{1}')", postId, tag);
            dBConn.Execute(sqlStr, "Insert");
        }

        public void DeletePostId(int postId)
        {
            sqlStr = string.Format("DELETE FROM PostTagCatalog WHERE Postid = '{0}'", postId);
            dBConn.Execute(sqlStr, "Delete");
        }

        public void DeleteTag(string tag)
        {
            sqlStr = string.Format("DELETE FROM PostTagCatalog WHERE Tag = '{0}'", tag);
            dBConn.Execute(sqlStr, "Delete");
        }

        public void Update(int postId, string tag)
        {
            sqlStr = string.Format("UPDATE PostTagCatalog SET Tag = '{0}' WHERE Postid = '{1}')", postId, tag);
            dBConn.Execute(sqlStr, "Update");
        }
    }
}
