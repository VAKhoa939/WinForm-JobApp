﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class FFormManagement : Form
    {
        private Post post;
        private Employer user;
        private int waiting = 1;

        public FFormManagement(Post post, Employer user)
        {
            InitializeComponent();
            this.post = post;
            this.user = user;
            ucEmpHeader1.user = user;
        }

        private void FFormManagement_Load(object sender, EventArgs e)
        {
            DisplayPostDetails();
        }

        private void DisplayPostDetails()
        {
            lblPostName.Text = post.Name;
            lblPostSalary.Text = $"Salary: {post.Salary.ToString("C")}";
            lblPostOther.Text = post.Others.Replace("\\n", Environment.NewLine);
            lblPostTime.Text = $"Posted on: {post.Timeposted.ToShortDateString()}";
            lblCompanyname.Text = user.Company.Name;
            foreach(PostDescCatalog postDesc in post.JobDescs)
            {
                Label detail = new Label();
                detail.Text = postDesc.JobDesc;
                detail.Size = new Size(930, 50);
                flpJobDesc.Controls.Add(detail);
            }
            // Clear existing images
            imageListJobImage.Images.Clear();

            // Add images from selectedPost to imageListJobImage
            foreach (PostImageCatalog postImage in post.Images)
            {
                imageListJobImage.Images.Add(ImageUtil.StringToImage(postImage.Image));
            }
            flpCV.Controls.Clear();
            foreach (ApplyForm cv in post.ApplyForms)
            {
                if (cv.Status == "Waiting")
                {
                    UCApplyForm applyForm = new UCApplyForm(cv);
                    flpCV.Controls.Add(applyForm);
                    waiting++;
                }
            }
            lblCVCount.Text = "There are " + waiting + " apply forms waiting"; 
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

        private void flpCV_ControlRemoved(object sender, ControlEventArgs e)
        {
            waiting--;
            lblCVCount.Text = "There are " + waiting + " apply forms waiting";
        }
    }
}
