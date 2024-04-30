using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class AnyDAO
    {
        protected DBConnection dBConn = new DBConnection();
        protected string sqlStr = "";
        protected string tableName = "";

        public AnyDAO()
        {
            tableName = GetType().Name;
            tableName = tableName.Remove(tableName.Length - 3, 3);
        }

        public DataTable Load()
        {
            sqlStr = string.Format("SELECT * FROM {0}", tableName);
            return dBConn.Load(sqlStr);
        }
    }
}
