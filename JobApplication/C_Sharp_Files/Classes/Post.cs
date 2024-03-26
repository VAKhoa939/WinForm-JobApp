using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class Post
    {
        private int id;
        private string name;
        private decimal salary;
        private string others;
        private DateTime timePosted;
        private List<string> jobDesc;
        private List<Image> images;
        private List<ApplyForm> applyForms;

        public Post(int id, string name, decimal salary, string others, DateTime timePosted, List<string> jobDesc, List<Image> images, List<ApplyForm> applyForms)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.others = others;
            this.timePosted = timePosted;
            this.jobDesc = jobDesc;
            this.images = images;
            this.applyForms = applyForms;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        { 
            get { return name; } 
            set { name = value; } 
        }

        public decimal Salary
        { 
            get { return salary; } 
            set {  salary = value; } 
        }

        public string Others
        { 
            get { return others; } 
            set {  others = value; } 
        }

        public DateTime TimePosted
        { 
            get { return timePosted; } 
            set { timePosted = value; } 
        }

        public List<string> JobDescs 
        { 
            get { return jobDesc; } 
            set { jobDesc = value; } 
        }

        public List<Image> Images
        { 
            get { return images; } 
            set { images = value; }
        }

        public List<ApplyForm> ApplyForms 
        { 
            get { return applyForms; } 
            set { applyForms = value; }
        }
    }
}
