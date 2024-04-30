using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    public class Post
    {
        private int id;
        private string name;
        private decimal salary;
        private string others;
        private DateTime timePosted;
        private List<string> jobDesc;
        private List<Image> images;
        private List<string> tags;
        private List<FApplyForm> applyForms;

        public Post(int id,string name, decimal salary, string others)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.others = others;
            timePosted = DateTime.Now;
            jobDesc = new List<string>();
            images = new List<Image>();
            tags = new List<string>();
            applyForms = new List<FApplyForm>();
        }

        public Post(int id, string name, decimal salary, string others, DateTime timePosted)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.others = others;
            this.timePosted = timePosted;
            jobDesc = new List<string>();
            images = new List<Image>();
            tags = new List<string>();
            applyForms = new List<FApplyForm>();
        }

        public Post(int id, string name, decimal salary, string others, DateTime timePosted, List<string> jobDesc, List<Image> images, List<string> tags, List<FApplyForm> applyForms)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.others = others;
            this.timePosted = timePosted;
            this.jobDesc = jobDesc;
            this.images = images;
            this.tags = tags;
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

        public List<string> Tags
        {
            get { return tags; }
            set { tags = value; }
        }

        public List<FApplyForm> ApplyForms 
        { 
            get { return applyForms; } 
            set { applyForms = value; }
        }
    }
}
