using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class FFormManagement : Form
    {
        private Post selectedPost;

        public FFormManagement(Post post)
        {
            InitializeComponent();
            this.selectedPost = post;
        }

        public FFormManagement(Post post, Company company, JobSeeker user)
        {
            InitializeComponent();
            this.selectedPost = post;
        }

        private void FFormManagement_Load(object sender, EventArgs e)
        {
            DisplayPostDetails();
        }

        private void DisplayPostDetails()
        {
            lblPostName.Text = selectedPost.Name;
            lblPostSalary.Text = $"Salary: {selectedPost.Salary.ToString("C")}";
            lblPostOther.Text = selectedPost.Others.Replace("\\n", Environment.NewLine);
            lblPostTime.Text = $"Posted on: {selectedPost.TimePosted.ToShortDateString()}";
            foreach(string desc in selectedPost.JobDescs)
            {
                Label detail = new Label();
                detail.Text = desc;
                detail.Size = new Size(930, 50);
                flpJobDesc.Controls.Add(detail);
            }
            // Clear existing images
            imageListJobImage.Images.Clear();

            // Add images from selectedPost to imageListJobImage
            foreach (Image img in selectedPost.Images)
            {
                imageListJobImage.Images.Add(img);
            }

            // Start the timer to display images
            tmrChangeImage.Start();
        }

        private void tmrChangeImage_Tick(object sender, EventArgs e)
        {
            int totalImages = imageListJobImage.Images.Count;

            if (totalImages >= 3)
            {
                pbxCompanyAva.Image = imageListJobImage.Images[0];
                pbxCompanyAva2.Image = imageListJobImage.Images[1];
                pbxCompanyAva3.Image = imageListJobImage.Images[2];
            }
            else if (totalImages == 2)
            {
                pbxCompanyAva.Image = imageListJobImage.Images[0];
                pbxCompanyAva2.Image = imageListJobImage.Images[1];
                pbxCompanyAva3.Image = null;
            }
            else if (totalImages == 1)
            {
                pbxCompanyAva.Image = imageListJobImage.Images[0];
                pbxCompanyAva2.Image = null;
                pbxCompanyAva3.Image = null;
            }
            else
            {
                pbxCompanyAva.Image = null;
                pbxCompanyAva2.Image = null;
                pbxCompanyAva3.Image = null;
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            // Handle the apply button click event
            this.Hide();
        }
    }
}
