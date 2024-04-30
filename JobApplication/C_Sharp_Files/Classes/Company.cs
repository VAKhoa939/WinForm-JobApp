using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    public class Company
    {
        private string name;
        private Image logo;
        private List<Employer> employers;

        public Company(string name, Image logo)
        {
            Name = name;
            Logo = logo;
            employers = new List<Employer>();
        }

        public Company(string name, Image logo, List<Employer> employers)
        {
            this.name = name;
            this.logo = logo;
            this.employers = employers;
        }

        public string Name 
        { 
            get { return name; } 
            set { name = value; }
        }

        public Image Logo
        {
            get { return logo; }
            set { logo = value; }
        }

        public List<Employer> Employers
        {
            get { return employers; }
            set { employers = value; }
        }
    }
}
