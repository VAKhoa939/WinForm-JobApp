using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    public class Employer : User
    {
        private List<Post> posts;

        public Employer(string userName, string email, string password, string phoneNumber, string fullName) : base(userName, email, password, phoneNumber, fullName)
        {
            posts = new List<Post>();
        }

        public Employer(string userName, string email, string password, string phoneNumber, string fullName, List<Post> posts) : base (userName, email, password, phoneNumber, fullName)
        {
            this.posts = posts;
        }

        public List<Post> Posts 
        { 
            get { return posts; } 
            set { posts = value; }
        }
    }
}
