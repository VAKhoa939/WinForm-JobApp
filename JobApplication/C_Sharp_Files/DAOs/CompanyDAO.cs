using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class CompanyDAO
    {
        private DBConnection dBConn = new DBConnection();
        private string sqlStr = "";
        private EmployerDAO employerDAO = new EmployerDAO();
        private ComEmpCatalogDAO comEmpDAO = new ComEmpCatalogDAO();

        public DataTable Load()
        {
            sqlStr = string.Format("SELECT * FROM Company");
            return dBConn.Load(sqlStr);
        }

        public List<Company> GetList()
        {
            List<Company> companies = new List<Company>();
            DataTable dataTable = Load();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Company company = null;
                company.Name = dataRow[0].ToString();
                company.Logo = (Image)dataRow[1];
                foreach (string empName in comEmpDAO.GetEmpNames(company.Name))
                {
                    company.Employers.Add(employerDAO.GetEmployer(empName));
                }
                companies.Add(company);
            }
            return companies;
        }

        public Company GetCompany(string companyName)
        {
            sqlStr = string.Format("SELECT * FROM Company WHERE Name = '{0}'", companyName);
            DataTable dataTable = dBConn.Load(sqlStr);

            DataRow dataRow = dataTable.Rows[0];
            Company company = null;
            company.Name = companyName;
            company.Logo = (Image)dataRow[1];
            foreach (string empName in comEmpDAO.GetEmpNames(company.Name))
            {
                company.Employers.Add(employerDAO.GetEmployer(empName));
            }
            return company;
        }

        public void Insert(Company company)
        {
            sqlStr = string.Format("INSERT INTO Company (Name, Logo) VALUES ('{0}', '{1}')", company.Name, company.Logo);
            dBConn.Execute(sqlStr, "Insert");

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
            sqlStr = string.Format("UPDATE Company SET Logo = '{0}' WHERE Name = '{1}'", company.Logo, company.Name);
            dBConn.Execute(sqlStr, "Update");

            comEmpDAO.DeleteComName(company.Name);
            foreach (Employer employer in company.Employers)
            {
                comEmpDAO.Insert(company.Name, employer.UserName);
            }
        }
    }
}
