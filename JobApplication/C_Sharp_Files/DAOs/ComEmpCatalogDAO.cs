using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class ComEmpCatalogDAO : AnyDAO
    {
        public string GetComName(string empName)
        {
            sqlStr = string.Format("SELECT * FROM ComEmpCatalog WHERE Empname = '{0}'", empName);
            DataTable dataTable = dBConn.Load(sqlStr);
            return dataTable.Rows[0][0].ToString();
        }

        public List<string> GetEmpNames(string comName)
        {
            sqlStr = string.Format("SELECT * FROM ComEmpCatalog WHERE Comname = '{0}'", comName);
            DataTable dataTable = dBConn.Load(sqlStr);
            List<string> empNames = new List<string>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                empNames.Add(dataRow[1].ToString());
            }
            return empNames;
        }

        public void Insert(string comName, string empName)
        {
            sqlStr = string.Format("INSERT INTO ComEmpCatalog (Comname, Empname) VALUES ('{0}', '{1}')", comName, empName);
            dBConn.Execute(sqlStr, "Insert");
        }

        public void DeleteComName(string comName)
        {
            sqlStr = string.Format("DELETE FROM ComEmpCatalog WHERE Comname = '{0}'", comName);
            dBConn.Execute(sqlStr, "Delete");
        }

        public void DeleteEmpName(string empName)
        {
            sqlStr = string.Format("DELETE FROM ComEmpCatalog WHERE Empname = '{0}'", empName);
            dBConn.Execute(sqlStr, "Delete");
        }
    }
}
