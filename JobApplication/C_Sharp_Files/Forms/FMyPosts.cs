using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class FMyPosts : Form
    {
        private CompanyDAO companyDAO = new CompanyDAO();
        private ComEmpCatalogDAO comEmpDAO = new ComEmpCatalogDAO();
        private Employer user;


        public FMyPosts()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        public FMyPosts(Employer user)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            ucEmpHeader1.user = user;
            this.user = user;
        }

        private void FMyPosts_Load(object sender, EventArgs e)
        {
            int noPosts = 0;

            Company company = companyDAO.GetCompany(comEmpDAO.GetComName(user.UserName));
            foreach (Post post in user.Posts)
            {
                noPosts++;
                UCEmpPost ucPost = new UCEmpPost(post, company, user);
                flpKetQua.Controls.Add(ucPost);
            }
            lblSoLuongKQ.Text = "There are " + noPosts + " results";
        }
    }
}