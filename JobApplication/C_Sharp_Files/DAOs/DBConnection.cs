using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public DataTable Load(string sqlStr)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dataTable);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Xuat du lieu that bai\nCau sql: " + sqlStr + "\n" + exc);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        public void Execute(string sqlStr, string action)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Failed to " + action + ".\nSQL query: " + sqlStr + "\n" + exc);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Execute(string sqlStr, string action, byte[] image)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Failed to " + action + ".\nSQL query: " + sqlStr + "\n" + exc);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
