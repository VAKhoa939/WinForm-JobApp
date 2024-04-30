using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class CompanyDAO : AnyDAO
    {
        private EmployerDAO employerDAO = new EmployerDAO();
        private ComEmpCatalogDAO comEmpDAO = new ComEmpCatalogDAO();

        public List<Company> GetList()
        {
            List<Company> companies = new List<Company>();
            DataTable dataTable = Load();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                string name = dataRow[0].ToString();
                Image logo = ImageUtil.ByteToImage((byte[])dataRow[1]);
                Company company = new Company(name, logo);
                foreach (string empName in comEmpDAO.GetEmpNames(company.Name))
                {
                    company.Employers.Add(employerDAO.GetEmployer(empName));
                }
                companies.Add(company);
            }
            return companies;
        }

        public Company GetCompany(string name)
        {
            sqlStr = string.Format("SELECT * FROM Company WHERE Name = '{0}'", name);
            DataTable dataTable = dBConn.Load(sqlStr);

            DataRow dataRow = dataTable.Rows[0];
            Image logo = ImageUtil.ByteToImage((byte[])dataRow[1]);
            Company company = new Company(name, logo);
            foreach (string empName in comEmpDAO.GetEmpNames(company.Name))
            {
                company.Employers.Add(employerDAO.GetEmployer(empName));
            }
            return company;
        }

        public void Insert(Company company)
        {
            sqlStr = string.Format("INSERT INTO Company (Name, Logo) VALUES ('{0}', @image)", company.Name);
            dBConn.Execute(sqlStr, "Insert", ImageUtil.ImageToByte(company.Logo));

            foreach (Employer employer in company.Employers)
            {
                comEmpDAO.Insert(company.Name, employer.UserName);
            }
        }

        public void Delete(Company company)
        {
            sqlStr = string.Format("DELETE FROM Company WHERE Name = '{0}'", company.Name);
            dBConn.Execute(sqlStr, "Delete");

            foreach (Employer employer in company.Employers)
            {
                employerDAO.Delete(employer);
            }
        }

        public void Update(Company company)
        {
            sqlStr = string.Format("UPDATE Company SET Logo = @image WHERE Name = '{0}'", company.Name);
            dBConn.Execute(sqlStr, "Update", ImageUtil.ImageToByte(company.Logo));

            comEmpDAO.DeleteComName(company.Name);
            foreach (Employer employer in company.Employers)
            {
                comEmpDAO.Insert(company.Name, employer.UserName);
            }
        }
    }
}
