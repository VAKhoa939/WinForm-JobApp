using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class SeekFormCatalogDAO : AnyDAO
    {
        public string GetSeekName(int formId)
        {
            sqlStr = string.Format("SELECT * FROM SeekFormCatalog WHERE Formid = '{0}'", formId);
            DataTable dataTable = dBConn.Load(sqlStr);
            DataRow dataRow = dataTable.Rows[0];
            return dataRow[0].ToString();
        }

        public List<int> GetFormIds(string seekName)
        {
            sqlStr = string.Format("SELECT * FROM SeekFormCatalog WHERE Seekname = '{0}'", seekName);
            DataTable dataTable = dBConn.Load(sqlStr);
            List<int> formIds = new List<int>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                formIds.Add(Convert.ToInt32(dataRow[1]));
            }
            return formIds;
        }

        public void Insert(string seekName, int formId)
        {
            sqlStr = string.Format("INSERT INTO SeekFormCatalog (Seekname, Formid) VALUES ('{0}', '{1}')", seekName, formId);
            dBConn.Execute(sqlStr, "Insert");
        }

        public void DeleteSeekName(string seekName)
        {
            sqlStr = string.Format("DELETE FROM SeekFormCatalog WHERE Seekname = '{0}'", seekName);
            dBConn.Execute(sqlStr, "Delete");
        }

        public void DeleteFormId(int formId)
        {
            sqlStr = string.Format("DELETE FROM SeekFormCatalog WHERE Formid = '{0}'", formId);
            dBConn.Execute(sqlStr, "Delete");
        }
    }
}
