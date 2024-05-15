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
    public partial class FMyJobs : Form
    {
        private JobSeeker user;

        public FMyJobs()
        {
            InitializeComponent();
        }

        public FMyJobs(JobSeeker user)
        {
            InitializeComponent();
            this.user = user;
            ucSeekHeader1.user = user;
        }

        private void FMyJobs_Load(object sender, EventArgs e)
        {
            lblFormnum.Text = "You have applied " + user.ApplyForms.Count + " jobs";
            foreach (ApplyForm applyForm in user.ApplyForms)
            {
                UCSeekApplyForm ucSeekApplyForm = new UCSeekApplyForm(applyForm, user);
                if (applyForm.Status == "Waiting")
                {
                    flpWaiting.Controls.Add(ucSeekApplyForm);
                }
                else if (applyForm.Status == "Accepted")
                {
                    flpAccepted.Controls.Add(ucSeekApplyForm);
                }
                else
                {
                    flpDenied.Controls.Add(ucSeekApplyForm);
                }
            }
        }
    }
}
