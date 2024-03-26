using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class ApplyFormDAO
    {
        private DBConnection dBConn = new DBConnection();
        private string sqlStr = "";
        private SeekFormCatalogDAO seekFormDAO = new SeekFormCatalogDAO();
        private PostFormCatalogDAO postFormDAO = new PostFormCatalogDAO();

        public DataTable Load()
        {
            sqlStr = string.Format("SELECT * FROM ApplyForm");
            return dBConn.Load(sqlStr);
        }

        public List<ApplyForm> GetList()
        {
            List<ApplyForm> applyForms = new List<ApplyForm>();
            DataTable dataTable = Load();
            foreach (DataRow dataRow in dataTable.Rows) 
            {
                ApplyForm applyForm = null;
                applyForm.SeekFormId = Convert.ToInt32(dataRow[0]);
                applyForm.PostFormId = Convert.ToInt32(dataRow[1]);
                applyForm.Id = applyForm.SeekFormId.ToString() + applyForm.PostFormId.ToString();
                applyForm.Cv = (byte[])dataRow[2];
                applyForm.CoverLetter = dataRow[3].ToString();
                applyForm.Status = dataRow[4].ToString();
                applyForm.TimeSent = (DateTime)dataRow[5];
                applyForms.Add(applyForm);
            }
            return applyForms;
        }

        public ApplyForm GetApplyFormSeekId(int seekFormId)
        {
            sqlStr = string.Format("SELECT * FROM ApplyForm WHERE SeekFormId = '{0}'", seekFormId);
            DataTable dataTable = dBConn.Load(sqlStr);

            DataRow dataRow = dataTable.Rows[0];
            ApplyForm applyForm = null;
            applyForm.SeekFormId = seekFormId;
            applyForm.PostFormId = Convert.ToInt32(dataRow[1]);
            applyForm.Id = applyForm.SeekFormId.ToString() + applyForm.PostFormId.ToString();
            applyForm.Cv = (byte[])dataRow[2];
            applyForm.CoverLetter = dataRow[3].ToString();
            applyForm.Status = dataRow[4].ToString();
            applyForm.TimeSent = (DateTime)dataRow[5];
            return applyForm;
        }

        public ApplyForm GetApplyFormPostId(int postFormId)
        {
            sqlStr = string.Format("SELECT * FROM ApplyForm WHERE PostFormId = '{0}'", postFormId);
            DataTable dataTable = dBConn.Load(sqlStr);

            DataRow dataRow = dataTable.Rows[0];
            ApplyForm applyForm = null;
            applyForm.SeekFormId = Convert.ToInt32(dataRow[0]);
            applyForm.PostFormId = postFormId;
            applyForm.Id = applyForm.SeekFormId.ToString() + applyForm.PostFormId.ToString();
            applyForm.Cv = (byte[])dataRow[2];
            applyForm.CoverLetter = dataRow[3].ToString();
            applyForm.Status = dataRow[4].ToString();
            applyForm.TimeSent = (DateTime)dataRow[5];
            return applyForm;
        }

        public void Insert(ApplyForm applyForm, JobSeeker jobSeeker, Post post)
        {
            sqlStr = string.Format("INSERT INTO ApplyForm (Seekformid, Postformid, Cv, Coverletter, Status, Timesent) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", applyForm.SeekFormId, applyForm.PostFormId, applyForm.Cv, applyForm.CoverLetter, applyForm.Status, applyForm.TimeSent.ToString("yyyy-MM-dd HH:mm:ss"));
            dBConn.Execute(sqlStr, "Insert");

            seekFormDAO.Insert(jobSeeker.UserName, applyForm.SeekFormId);
            postFormDAO.Insert(post.Id, applyForm.PostFormId);
        }

        public void Delete(ApplyForm applyForm)
        {
            sqlStr = string.Format("DELETE FROM ApplyForm WHERE Seekformid = '{0}' OR Postformid = '{1}'", applyForm.SeekFormId, applyForm.PostFormId);
            dBConn.Execute(sqlStr, "Delete");

            seekFormDAO.DeleteFormId(applyForm.SeekFormId);
            postFormDAO.DeleteFormId(applyForm.PostFormId);
        }

        public void Update(ApplyForm applyForm)
        {
            sqlStr = string.Format("UPDATE ApplyForm SET Cv = '{0}', Coverletter = '{1}', Status = '{2}', Timesent = '{3}' WHERE Seekformid = '{4}' OR Postformid = '{5}'", applyForm.Cv, applyForm.CoverLetter, applyForm.Status, applyForm.TimeSent.ToString("yyyy-MM-dd HH:mm:ss"), applyForm.SeekFormId, applyForm.PostFormId);
            dBConn.Execute(sqlStr, "Update");
        }
    }
}
