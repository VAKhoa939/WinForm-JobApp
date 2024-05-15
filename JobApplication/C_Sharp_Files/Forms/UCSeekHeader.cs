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
    public partial class UCSeekHeader : UserControl
    {
        public JobSeeker user;

        public UCSeekHeader()
        {
            InitializeComponent();
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
            FAllPosts fAllPosts = new FAllPosts(user);
            fAllPosts.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
            fAllPosts.Show();
        }

        private void myJobsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            FMyJobs fMyJobs = new FMyJobs(user);
            fMyJobs.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
            fMyJobs.Show();
        }
    }
}
