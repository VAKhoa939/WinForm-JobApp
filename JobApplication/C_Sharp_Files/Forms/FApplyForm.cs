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
    public partial class FApplyForm : Form
    {
        private JobSeeker user;
        private Post post;
        private ApplyFormDAO applyFormDAO = new ApplyFormDAO();
        private string newFilePath;

        public FApplyForm(JobSeeker user, Post post)
        {
            InitializeComponent();
            this.user = user;
            this.post = post;
            ucSeekHeader1.user = user;
        }

        private void FApplyForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = user.Username;
        }

        private void btnSendCV_Click(object sender, EventArgs e)
        {
            if (newFilePath == string.Empty || txtUserName.Text == string.Empty) 
            {
                MessageBox.Show("Must fill in all the information!");
                return;
            }
            ApplyForm applyForm = new ApplyForm
            {
                CVname = FileUtil.GetFileName(newFilePath),
                CVcontent = FileUtil.FileToString(newFilePath),
                PostId = post.Id,
                JobSeekerId = user.Id,
                Timesent = DateTime.Now,
                Status = "Waiting",
                Coverletter = txtCoverLetter.Text,
                JobSeekerName = txtUserName.Text
            };
            applyFormDAO.Insert(applyForm);
            user.ApplyForms.Add(applyForm);
            MessageBox.Show("Sent CV successfully!");
            Hide();
            FAllPosts fAllPosts = new FAllPosts(user);
            fAllPosts.Closed += (s, args) => Close();
            fAllPosts.Show();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            newFilePath = FileUtil.UploadFile();
            lblNewFileName.Text = FileUtil.GetFileName(newFilePath);
        }

    }
}
