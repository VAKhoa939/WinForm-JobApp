using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class PostFormCatalogDAO : AnyDAO
    {
        public int GetPostId(int formId)
        {
            sqlStr = string.Format("SELECT * FROM PostFormCatalog WHERE Formid = '{0}'", formId);
            DataTable dataTable = dBConn.Load(sqlStr);
            DataRow dataRow = dataTable.Rows[0];
            return Convert.ToInt32(dataRow[0]);
        }

        public List<int> GetFormIds(int postId)
        {
            sqlStr = string.Format("SELECT * FROM PostFormCatalog WHERE Postid = '{0}'", postId);
            DataTable dataTable = dBConn.Load(sqlStr);
            List<int> formIds = new List<int>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                formIds.Add(Convert.ToInt32(dataRow[1]));
            }
            return formIds;
        }

        public void Insert(int postId, int formId)
        {
            sqlStr = string.Format("INSERT INTO PostFormCatalog (Postid, Formid) VALUES ('{0}', '{1}')", postId, formId);
            dBConn.Execute(sqlStr, "Insert");
        }

        public void DeletePostId(int postId)
        {
            sqlStr = string.Format("DELETE FROM PostFormCatalog WHERE Postid = '{0}'", postId);
            dBConn.Execute(sqlStr, "Delete");
        }

        public void DeleteFormId(int formId)
        {
            sqlStr = string.Format("DELETE FROM PostFormCatalog WHERE Formid = '{0}'", formId);
            dBConn.Execute(sqlStr, "Delete");
        }
    }
}
