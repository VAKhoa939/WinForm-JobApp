using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class EmployerDAO : UserDAO
    {
        private PostDAO postDAO = new PostDAO();
        private ComEmpCatalogDAO comEmpDAO = new ComEmpCatalogDAO();
        private EmpPostCatalogDAO empPostDAO = new EmpPostCatalogDAO();

        public new List<Employer> GetList()
        {
            List<Employer> employers = new List<Employer>();
            DataTable dataTable = Load();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Employer employer = (Employer)GetUser(dataRow);
                foreach (int postId in empPostDAO.GetPostIds(employer.UserName))
                {
                    employer.Posts.Add(postDAO.GetPost(postId));
                }
                employers.Add(employer);
            }
            return employers;
        }

        public Employer GetEmployer(string userName)
        {
            sqlStr = string.Format("SELECT * FROM Employer WHERE Username = '{0}'", userName);
            DataTable dataTable = dBConn.Load(sqlStr);

            DataRow dataRow = dataTable.Rows[0];
            Employer employer = (Employer)GetUser(dataRow);
            foreach (int postId in empPostDAO.GetPostIds(employer.UserName))
            {
                employer.Posts.Add(postDAO.GetPost(postId));
            }
            return employer;
        }

        public void Insert(Employer employer, Company company)
        {
            sqlStr = string.Format("INSERT INTO Employer (Username, Email, Password, Phonenumber, Fullname) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", employer.UserName, employer.Email, employer.Password, employer.PhoneNumber, employer.FullName);
            dBConn.Execute(sqlStr, "Insert");

            foreach (Post post in employer.Posts)
            {
                empPostDAO.Insert(employer.UserName, post.Id);
            }
            comEmpDAO.Insert(company.Name, employer.UserName);
        }

        public void Delete(Employer employer)
        {
            sqlStr = string.Format("DELETE FROM Employer WHERE Username = '{0}'", employer.UserName);
            dBConn.Execute(sqlStr, "Delete");

            empPostDAO.DeleteEmpName(employer.UserName);
            foreach (Post post in employer.Posts)
            {
                postDAO.Delete(post);
            }
            comEmpDAO.DeleteEmpName(employer.UserName);
        }

        public void Update(Employer employer)
        {
            sqlStr = string.Format("UPDATE Employer SET Email = '{0}', Password = '{1}', Phonenumber = '{2}', Fullname = '{3}' WHERE Username = '{4}'", employer.Email, employer.Password, employer.PhoneNumber, employer.FullName, employer.UserName);
            dBConn.Execute(sqlStr, "Update");

            empPostDAO.DeleteEmpName(employer.UserName);
            foreach (Post post in employer.Posts)
            {
                empPostDAO.Insert(employer.UserName, post.Id);
            }
        }
    }
}
