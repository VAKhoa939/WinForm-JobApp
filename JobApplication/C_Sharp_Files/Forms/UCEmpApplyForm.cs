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
    public partial class UCEmpApplyForm : UserControl
    {
        private ApplyFormDAO applyFormDAO = new ApplyFormDAO();
        private ApplyForm applyCV;
        private string cvPath;
        public UCEmpApplyForm() 
        {
            InitializeComponent();
        }
        public UCEmpApplyForm(ApplyForm applyCV)
        {
            InitializeComponent();
            this.applyCV = applyCV;
            lblName.Text = applyCV.JobSeekerName;
            lblPhone.Text = applyCV.JobSeeker.Phonenumber;
            lblDOB.Text = applyCV.JobSeeker.Birthdate.ToString("d");
            picPortrait.Image = ImageUtil.AutoFitPictureBox(picPortrait, ImageUtil.StringToImage(applyCV.JobSeeker.Portraitimage));
            cvPath = FileUtil.StringToFile(applyCV.CVcontent, applyCV.CVname);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            applyCV.Status = "Accepted";
            applyFormDAO.Update(applyCV);
            this.Parent?.Controls?.Remove(this);
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            applyCV.Status = "Denied";
            applyFormDAO.Update(applyCV);
            this.Parent?.Controls?.Remove(this);
        }

        private void btnCover_Click(object sender, EventArgs e)
        {
            FCoverLetter fCL= new FCoverLetter(applyCV.Coverletter);
            fCL.Show();
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            FCV fCV = new FCV(cvPath);
            fCV.Show();
        }
    }
}
