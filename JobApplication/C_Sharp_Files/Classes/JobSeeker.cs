using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    public class JobSeeker : User
    {
        private string address;
        private DateTime birthDate;
        private Image portraitImage;
        private List<FApplyForm> applyForms;
        public JobSeeker(string userName, string email, string password, string phoneNumber, string fullName): base(userName, email, password, phoneNumber, fullName)
        {
            address = " ";
            this.birthDate = DateTime.Now;
            portraitImage = global::JobApplication.Properties.Resources.user;
            applyForms = new List<FApplyForm>();
        }
        public JobSeeker(string userName, string email, string password, string phoneNumber, string fullName, string address, DateTime birthDate, Image portraitImage) : base(userName, email, password, phoneNumber, fullName)
        {
            this.address = address;
            this.birthDate = birthDate;
            this.portraitImage = portraitImage;
            applyForms = new List<FApplyForm>();
        }

        public JobSeeker(string userName, string email, string password, string phoneNumber, string fullName, string address, DateTime birthDate, Image portraitImage, List<FApplyForm> applyForms) : base(userName, email, password, phoneNumber, fullName)
        {
            this.address = address;
            this.birthDate = birthDate;
            this.portraitImage = portraitImage;
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

        public Image PortraitImage
        {
            get { return portraitImage; }
            set { portraitImage = value; }
        }

        public List<FApplyForm> ApplyForms 
        { 
            get { return applyForms; } 
            set { applyForms = value; }
        }
    }
}
