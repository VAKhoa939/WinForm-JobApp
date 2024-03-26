using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class UserDAO
    {
        protected DBConnection dBConn = new DBConnection();
        protected string sqlStr = "";
        protected string tableName = "";

        public UserDAO()
        {
            tableName = GetType().Name;
            tableName = tableName.Remove(tableName.Length - 3, 3);
        }

        public DataTable Load()
        {
            sqlStr = string.Format("SELECT * FROM '{0}'", tableName);
            return dBConn.Load(sqlStr);
        }

        public List<User> GetList()
        {
            JobSeekerDAO jobSeekerDAO = new JobSeekerDAO();
            EmployerDAO employerDAO = new EmployerDAO();

            List<User> users = new List<User>();
            List<JobSeeker> jobSeekers = jobSeekerDAO.GetList();
            List<Employer> employers = employerDAO.GetList();

            foreach (JobSeeker jobSeeker in jobSeekers) 
            {
                users.Add(jobSeeker);
            }
            foreach (Employer employer in employers)
            {
                users.Add(employer);
            }

            return users;
        }

        public User GetUser(DataRow dataRow)
        {
            User user = null;
            user.UserName = dataRow[0].ToString();
            user.Email = dataRow[1].ToString();
            user.Password = dataRow[2].ToString();
            user.PhoneNumber = dataRow[3].ToString();
            user.FullName = dataRow[4].ToString();
            return user;
        }
    }
}
