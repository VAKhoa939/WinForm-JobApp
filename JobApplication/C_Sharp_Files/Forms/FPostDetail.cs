﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class FPostDetail : Form
    {
        private Post post;
        private JobSeeker user;
        private Company company;
        private JobSeekerDAO seekerDAO = new JobSeekerDAO();
        private int pictureIndex = 0;

        public FPostDetail(Post post, JobSeeker user)
        {
            InitializeComponent();
            this.post = post;
            this.user = user;
            company = post.Employer.Company;
            ucSeekHeader1.user = user;
        }

        private void FPostDetail_Load(object sender, EventArgs e)
        {
            DisplayPostDetails();
        }

        private void DisplayPostDetails()
        {
            lblPostName.Text = post.Name;
            lblCompanyName1.Text = company.Name;
            lblCompanyName2.Text = company.Name;
            picLogo.Image = ImageUtil.StringToImage(company.Logo);
            lblEmployerNum.Text = "Number of employers: " + company.Employers.Count.ToString();
            lblPostSalary.Text = $"Salary: {post.Salary.ToString("C")}";
            lblPostOther.Text = post.Others.Replace("\\n", Environment.NewLine);
            lblPostTime.Text = $"Posted on: {post.Timeposted.ToShortDateString()}";
            foreach (PostDescCatalog postDesc in post.JobDescs)
            {
                Label detail = new Label();
                detail.Text = postDesc.JobDesc;
                detail.Size = new Size(930, 50);
                detail.Font = new Font("Times New Roman", 14);
                flpJobDesc.Controls.Add(detail);
            }
            // Clear existing images
            imageListJobImage.Images.Clear();

            // Add images from selectedPost to imageListJobImage
            foreach (PostImageCatalog postImage in post.Images)
            {
                imageListJobImage.Images.Add(ImageUtil.StringToImage(postImage.Image));
            }

            // Start the timer to display images
            tmrChangeImage.Start();
        }

        private void tmrChangeImage_Tick(object sender, EventArgs e)
        {
            int totalImages = imageListJobImage.Images.Count;

            if (totalImages >= 3)
            {
                pbxCompanyAva.Image = imageListJobImage.Images[pictureIndex % totalImages];
                pbxCompanyAva2.Image = imageListJobImage.Images[(pictureIndex + 1) % totalImages];
                pbxCompanyAva3.Image = imageListJobImage.Images[(pictureIndex + 2) % totalImages];
                pictureIndex = (pictureIndex + 1) % totalImages;
            }
            else if (totalImages == 3)
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
            if(seekerDAO.ApplyingChecked(user, post))
            {
                MessageBox.Show("Already applied to this job before!");
                return;
            }

            Hide();
            FApplyForm fApplyForm = new FApplyForm(user, post);
            fApplyForm.Closed += (s, args) => Close();
            fApplyForm.Show();
        }
    }
}
