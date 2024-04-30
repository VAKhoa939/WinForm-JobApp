using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class FAllPosts : Form
    {
        private PostDAO postDAO = new PostDAO();
        private CompanyDAO companyDAO = new CompanyDAO();
        private JobSeeker user;

        public FAllPosts(JobSeeker user)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.user = user;
            ucSeekHeader1.user = user;
        }

        private void FAllPost_Load(object sender, EventArgs e)
        {
            List<Post> posts = postDAO.GetList();
            //foreach (Post post in posts)
            //{
            //    UCSeekPost ucPost = new UCSeekPost(post, user);
            //    flpKetQua.Controls.Add(ucPost);
            //}
            foreach (Company company in companyDAO.GetList()) 
            {
                foreach (Employer employer in company.Employers)
                {
                    foreach (Post post in employer.Posts)
                    {
                        UCSeekPost ucPost = new UCSeekPost(post, user);
                        flpKetQua.Controls.Add(ucPost);
                    }
                }
            }
            lblSoLuongKQ.Text = "There are " + posts.Count + " results";
        }
    }
}
