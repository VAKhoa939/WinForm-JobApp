using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class JobSeekerDAO : AnyDAO
    {
        private ApplyFormDAO applyFormDAO = new ApplyFormDAO();
        private SeekFormCatalogDAO seekFormDAO = new SeekFormCatalogDAO();

        public List<JobSeeker> GetList()
        {
            List<JobSeeker> jobSeekers = new List<JobSeeker>();
            DataTable dataTable = Load();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                string userName = dataRow[0].ToString();
                string email = dataRow[1].ToString();
                string password = dataRow[2].ToString();
                string phoneNumber = dataRow[3].ToString();
                string fullName = dataRow[4].ToString();
                string address = dataRow[5].ToString();
                DateTime birthDate = (DateTime)dataRow[6];
                Image portraitImage = ImageUtil.ByteToImage((byte[])dataRow[7]);
                JobSeeker jobSeeker = new JobSeeker(userName, email, password, phoneNumber, fullName, address, birthDate, portraitImage);
                foreach (int formId in seekFormDAO.GetFormIds(jobSeeker.UserName))
                {
                    jobSeeker.ApplyForms.Add(applyFormDAO.GetApplyFormSeekId(formId));
                }
                jobSeekers.Add(jobSeeker);
            }
            return jobSeekers;
        }

        public JobSeeker GetJobSeeker(string userName)
        {
            sqlStr = string.Format("SELECT * FROM JobSeeker WHERE Username = '{0}'", userName);
            DataTable dataTable = dBConn.Load(sqlStr);

            DataRow dataRow = dataTable.Rows[0];
            string email = dataRow[1].ToString();
            string password = dataRow[2].ToString();
            string phoneNumber = dataRow[3].ToString();
            string fullName = dataRow[4].ToString();
            string address = dataRow[5].ToString();
            DateTime birthDate = (DateTime)dataRow[6];
            Image portraitImage = ImageUtil.ByteToImage((byte[])dataRow[7]);
            JobSeeker jobSeeker = new JobSeeker(userName, email, password, phoneNumber, fullName, address, birthDate, portraitImage);
            foreach (int formId in seekFormDAO.GetFormIds(jobSeeker.UserName))
            {
                jobSeeker.ApplyForms.Add(applyFormDAO.GetApplyFormSeekId(formId));
            }
            return jobSeeker;
        }

        public void Insert(JobSeeker jobSeeker)
        {
            sqlStr = string.Format("INSERT INTO JobSeeker (Username, Email, Password, Phonenumber, Fullname, Address, Birthdate, Portraitimage) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', @image)", jobSeeker.UserName, jobSeeker.Email, jobSeeker.Password, jobSeeker.PhoneNumber, jobSeeker.FullName, jobSeeker.Address, jobSeeker.BirthDate.ToString("yyyy-MM-dd"));
            dBConn.Execute(sqlStr, "Insert", ImageUtil.ImageToByte(jobSeeker.PortraitImage));

            foreach (FApplyForm applyForm in jobSeeker.ApplyForms)
            {
                seekFormDAO.Insert(jobSeeker.UserName, applyForm.SeekFormId);
            }
        }

        public void Delete(JobSeeker jobSeeker)
        {
            sqlStr = string.Format("DELETE FROM JobSeeker WHERE Username = '{0}'", jobSeeker.UserName);
            dBConn.Execute(sqlStr, "Delete");

            foreach (FApplyForm applyForm in jobSeeker.ApplyForms)
            {
                applyFormDAO.Delete(applyForm);
            }
        }

        public void Update(JobSeeker jobSeeker)
        {
            sqlStr = string.Format("UPDATE JobSeeker SET Email = '{0}', Password = '{1}', Phonenumber = '{2}', Fullname = '{3}', Address = '{4}', Birthdate = '{5}', @image WHERE Username = '{6}'", jobSeeker.Email, jobSeeker.Password, jobSeeker.PhoneNumber, jobSeeker.FullName, jobSeeker.Address, jobSeeker.BirthDate.ToString("yyyy-MM-dd"), jobSeeker.UserName);
            dBConn.Execute(sqlStr, "Update", ImageUtil.ImageToByte(jobSeeker.PortraitImage));

            seekFormDAO.DeleteSeekName(jobSeeker.UserName);
            foreach (FApplyForm applyForm in jobSeeker.ApplyForms)
            {
                seekFormDAO.Insert(jobSeeker.UserName, applyForm.SeekFormId);
            }
        }
    }
}
