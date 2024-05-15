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
    public partial class UCSeekApplyForm : UserControl
    {
        private ApplyForm applyForm;
        private JobSeeker user;
        private Post post;
        private string cvPath;

        public UCSeekApplyForm()
        {
            InitializeComponent();
        }

        public UCSeekApplyForm(ApplyForm applyForm, JobSeeker user)
        {
            InitializeComponent();
            this.applyForm = applyForm;
            this.user = user;

            post = applyForm.Post;
            Company company = post.Employer.Company;
            lklblPostname.Text = post.Name;
            imgLogo.Image = ImageUtil.AutoFitPictureBox(imgLogo, ImageUtil.StringToImage(company.Logo));
            lblCompanyname.Text = company.Name;
            lblSalary.Text = post.Salary.ToString();
            DateTime delta = new DateTime(DateTime.Now.Ticks - applyForm.Timesent.Ticks);
            lblTimesent.Text = "Time sent: " + delta.Hour + " hours ago";
            cvPath = FileUtil.StringToFile(applyForm.CVcontent, applyForm.CVname);
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            FCoverLetter fCL = new FCoverLetter(applyForm.Coverletter);
            fCL.Show();
        }

        private void btnCover_Click(object sender, EventArgs e)
        {
            FCV fCV = new FCV(cvPath);
            fCV.Show();
        }

        private void lklblPostname_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            FPostDetail fPostDetail = new FPostDetail(post, user);
            fPostDetail.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
            fPostDetail.Show();
        }
    }
}
