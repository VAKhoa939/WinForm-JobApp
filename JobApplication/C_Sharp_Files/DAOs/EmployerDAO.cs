using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class EmployerDAO : AnyDAO<Employer>
    {
        public Employer GetEmployer(string userName)
        {
            return query.First(employer => employer.Username == userName);
        }

        public void Update(Employer employer)
        {
            Employer employerToUpdate = GetObject(employer.Id);
            employerToUpdate.Password = employer.Password;
            employerToUpdate.Email = employer.Email;
            employerToUpdate.Phonenumber = employer.Phonenumber;
            employerToUpdate.Fullname = employer.Fullname;
            employerToUpdate.Portraitimage = employer.Portraitimage;
            db.SaveChanges();
        }
    }
}
