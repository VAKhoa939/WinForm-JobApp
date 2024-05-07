using JobApplication;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JobApplication
{
    public partial class FCreatePost : Form
    {
        private List<Image> uploadedImages = new List<Image>();
        private int pictureIndex = 0;
        private PostDAO postDAO = new PostDAO();
        private EmployerDAO employerDAO = new EmployerDAO();
        private Employer user;

        public FCreatePost()
        {
            InitializeComponent();
        }

        public FCreatePost(Employer user)
        {
            InitializeComponent();
            this.user = user;
            ucEmpHeader1.user = user;
        }

        private void btnSelectImages_Click(object sender, EventArgs e)
        {
            Image uploadedImage = ImageUtil.UploadImage(); // Upload a single image
            // Resize the image to fit the PictureBox dimensions
            uploadedImage = ImageUtil.AutoFitPictureBox(GetCurrentPictureBox(), uploadedImage);
            uploadedImages.Add(uploadedImage); // Add the image to the ImageList
            tmrChangeImage.Start();
        }

        private void tmrChangeImage_Tick(object sender, EventArgs e)
        {
            int totalImages = uploadedImages.Count;

            if (totalImages > 3)
            {
                pbxJobImages1.Image = uploadedImages[pictureIndex % totalImages];
                pbxJobImages2.Image = uploadedImages[(pictureIndex + 1) % totalImages];
                pbxJobImages3.Image = uploadedImages[(pictureIndex + 2) % totalImages];
                pictureIndex = (pictureIndex + 1) % totalImages;
            }
            else if (totalImages == 3)
            {
                pbxJobImages1.Image = uploadedImages[0];
                pbxJobImages2.Image = uploadedImages[1];
                pbxJobImages3.Image = uploadedImages[2];
            }
            else if (totalImages == 2)
            {
                pbxJobImages1.Image = uploadedImages[0];
                pbxJobImages2.Image = uploadedImages[1];
                pbxJobImages3.Image = null;
            }
            else if (totalImages == 1)
            {
                pbxJobImages1.Image = uploadedImages[0];
                pbxJobImages2.Image = null;
                pbxJobImages3.Image = null;
            }
            else
            {
                pbxJobImages1.Image = null;
                pbxJobImages2.Image = null;
                pbxJobImages3.Image = null;
            }
        }

        private PictureBox GetCurrentPictureBox()
        {
            // Get the current PictureBox control based on the currentPictureBoxIndex
            switch (pictureIndex)
            {
                case 0:
                default:
                    pictureIndex = 0;
                    return pbxJobImages1;
                case 1:
                    return pbxJobImages2;
                case 2:
                    return pbxJobImages3;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pbxJobImages1.Image = null;
            pbxJobImages2.Image = null;
            pbxJobImages3.Image = null;
            txtPostName.Text = "";
            txtSalary.Text = "";
            txtAddress.Text = "";
            cbxWork.SelectedIndex = -1;
            txtSkillReq.Text = "";
            txtWorkHours.Text = "";
            txtContact.Text = "";
            uploadedImages.Clear();
            pictureIndex = 0;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            createNewPost();
            MessageBox.Show("Created a post successfully.");
            Hide();
            FMyPosts myPostsForm = new FMyPosts(user);
            myPostsForm.Closed += (s, args) => Close();
            myPostsForm.Show();
        }

        private void createNewPost()
        {
            string others = string.Format($"{txtAddress.Text}\n{this.cbxWork.GetItemText(this.cbxWork.SelectedItem)}");
            // Create new Post object
            Post post = new Post
            {
                Name = txtPostName.Text, 
                Salary = Convert.ToDecimal(txtSalary.Text), 
                Others = others,
                Status = "active",
                Timeposted = DateTime.Now,
            };
            post.EmployerId = user.Id;

            foreach (Image img in uploadedImages)
            {
                PostImageCatalog postImage = new PostImageCatalog
                {
                    Image = ImageUtil.ImageToString(img)
                };
                post.Images.Add(postImage);
            }

            PostDescCatalog postDesc1 = new PostDescCatalog
            {
                JobDesc = "- Skill Requirement: " + txtSkillReq.Text
            };
            post.JobDescs.Add(postDesc1);
            PostDescCatalog postDesc2 = new PostDescCatalog
            {
                JobDesc = "- In this job you need to work about: " + txtWorkHours.Text + " hours"
            };
            post.JobDescs.Add(postDesc2);
            PostDescCatalog postDesc3 = new PostDescCatalog
            {
                JobDesc = "- For any further detail please contact by: " + txtContact.Text
            };
            post.JobDescs.Add(postDesc3);

            string[] tags = txtSkilltags.Text.Split(',');
            foreach (string tag in tags)
            {
                PostTagCatalog postTagCatalog = new PostTagCatalog
                {
                    Tag = tag
                };
                post.SkillTags.Add(postTagCatalog);
            }
            postDAO.Insert(post);
            user.Posts.Add(post);
        }
    }
}
