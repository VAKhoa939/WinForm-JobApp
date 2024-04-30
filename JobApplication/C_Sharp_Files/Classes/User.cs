using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    public class User
    {
        protected string userName;
        protected string email;
        protected string password;
        protected string phoneNumber;
        protected string fullName;

        public User(string userName, string email, string password, string phoneNumber, string fullName)
        {
            this.userName = userName;
            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.fullName = fullName;
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
    }
}
