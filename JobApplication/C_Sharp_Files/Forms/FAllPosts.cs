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
        private CompanyDAO companyDAO = new CompanyDAO();
        private JobSeeker user;

        public FAllPosts()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        public FAllPosts(JobSeeker user)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.user = user;
        }

        private void FAllPost_Load(object sender, EventArgs e)
        {
            int noPosts = 0;

            List<Company> companies = companyDAO.GetList();
            foreach (Company company in companies)
            {
                foreach (Employer employer in company.Employers)
                {
                    foreach (Post post in employer.Posts)
                    {
                        noPosts++;
                        UCSeekPost ucPost = new UCSeekPost(post, company, user);
                        flpKetQua.Controls.Add(ucPost);
                    }
                }
            }
            lblSoLuongKQ.Text = "There are " + noPosts + " results";
        }
    }
}
