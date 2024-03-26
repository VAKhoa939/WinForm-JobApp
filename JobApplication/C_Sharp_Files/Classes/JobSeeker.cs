using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class JobSeeker : User
    {
        private string address;
        private DateTime birthDate;
        private string aboutMe;
        private List<ApplyForm> applyForms;

        public JobSeeker(string userName, string email, string password, string phoneNumber, string fullName, string address, DateTime birthDate, string aboutMe, List<ApplyForm> applyForms) : base(userName, email, password, phoneNumber, fullName)
        {
            this.address = address;
            this.birthDate = birthDate;
            this.aboutMe = aboutMe;
            this.applyForms = applyForms;
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string AboutMe
        {
            get { return aboutMe; }
            set { aboutMe = value; }
        }

        public List<ApplyForm> ApplyForms 
        { 
            get { return applyForms; } 
            set { applyForms = value; }
        }
    }
}
