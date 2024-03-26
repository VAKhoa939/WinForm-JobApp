using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class PostDescCatalogDAO
    {
        private DBConnection dBConn = new DBConnection();
        private string sqlStr = "";

        public DataTable GetCatalog()
        {
            sqlStr = string.Format("SELECT * FROM PostDescCatalog");
            return dBConn.Load(sqlStr);
        }

        public List<string> GetJobDescs(int postId)
        {
            sqlStr = string.Format("SELECT * FROM PostDescCatalog WHERE Postid = '{0}'", postId);
            DataTable dataTable = dBConn.Load(sqlStr);
            List<string> jobDescs = new List<string>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                jobDescs.Add(dataRow[1].ToString());
            }
            return jobDescs;
        }

        public void Insert(int postId, string jobDesc)
        {
            sqlStr = string.Format("INSERT INTO PostDescCatalog (Postid, Jobdesc) VALUES ('{0}', '{1}')", postId, jobDesc);
            dBConn.Execute(sqlStr, "Insert");
        }

        public void DeletePostId(int postId)
        {
            sqlStr = string.Format("DELETE FROM PostDescCatalog WHERE Postid = '{0}'", postId);
            dBConn.Execute(sqlStr, "Delete");
        }

        public void DeleteJobDesc(string jobDesc)
        {
            sqlStr = string.Format("DELETE FROM PostDescCatalog WHERE Jobdesc = '{0}'", jobDesc);
            dBConn.Execute(sqlStr, "Delete");
        }
    }
}
