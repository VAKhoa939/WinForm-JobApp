using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class CompanyDAO : AnyDAO<Company>
    {
        public Company GetCompany(string name)
        {
            return db.Companies.First(company => company.Name == name);
        }

        public void Update(Company company)
        {
            Company companyToUpdate = GetObject(company.Id);
            companyToUpdate.Logo = company.Logo;
            db.SaveChanges();
        }
    }
}
