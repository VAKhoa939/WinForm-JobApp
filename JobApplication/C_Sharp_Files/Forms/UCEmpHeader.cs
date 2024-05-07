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
    public partial class UCEmpHeader : UserControl
    {
        public Employer user;

        public UCEmpHeader()
        {
            InitializeComponent();
        }

        private void createAPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            FCreatePost fCreatePost = new FCreatePost(user);
            fCreatePost.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
            fCreatePost.Show();
        }

        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            FLogin fLogin = new FLogin();
            fLogin.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
            fLogin.Show();
        }

        private void allJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            FMyPosts fMyPosts = new FMyPosts(user);
            fMyPosts.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
            fMyPosts.Show();
        }
    }
}
