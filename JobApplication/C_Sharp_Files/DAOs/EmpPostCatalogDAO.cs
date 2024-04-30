using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class EmpPostCatalogDAO : AnyDAO
    {
        public string GetEmpName(int postId)
        {
            sqlStr = string.Format("SELECT * FROM EmpPostCatalog WHERE Postid = '{0}'", postId);
            DataTable dataTable = dBConn.Load(sqlStr);
            DataRow dataRow = dataTable.Rows[0];
            return dataRow[0].ToString();
        }

        public List<int> GetPostIds(string empName)
        {
            sqlStr = string.Format("SELECT * FROM EmpPostCatalog WHERE Empname = '{0}'", empName);
            DataTable dataTable = dBConn.Load(sqlStr);
            List<int> postIds = new List<int>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                postIds.Add(Convert.ToInt32(dataRow[1]));
            }
            return postIds;
        }

        public void Insert(string empName, int postId)
        {
            sqlStr = string.Format("INSERT INTO EmpPostCatalog (Empname, Postid) VALUES ('{0}', '{1}')", empName, postId);
            dBConn.Execute(sqlStr, "Insert");
        }

        public void DeleteEmpName(string empName)
        {
            sqlStr = string.Format("DELETE FROM EmpPostCatalog WHERE Empname = '{0}'", empName);
            dBConn.Execute(sqlStr, "Delete");
        }

        public void DeletePostId(int postId)
        {
            sqlStr = string.Format("DELETE FROM EmpPostCatalog WHERE Postid = '{0}'", postId);
            dBConn.Execute(sqlStr, "Delete");
        }
    }
}
