using JobApplication;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JobApplication
{
    public partial class FCreatePost : Form
    {
        private ImageList uploadedImages = new ImageList();
        private int currentPictureBoxIndex = 0;
        private PostDAO postDAO = new PostDAO();
        private Employer user;

        public FCreatePost()
        {
            InitializeComponent();
        }

        public FCreatePost(Employer user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnSelectImages_Click(object sender, EventArgs e)
        {
            Image uploadedImage = ImageUtil.UploadImage(); // Upload a single image
            if (uploadedImage != null)
            {
                // Resize the image to fit the PictureBox dimensions
                uploadedImage = ImageUtil.AutoFitPictureBox(GetCurrentPictureBox(), uploadedImage);

                if (currentPictureBoxIndex < 3) // Ensure we do not exceed the number of PictureBox controls
                {
                    // Clear previously uploaded images for the current PictureBox
                    uploadedImages.Images.Clear();
                    uploadedImages.Images.Add(uploadedImage); // Add the image to the ImageList

                    // Display the uploaded image in the current PictureBox
                    PictureBox currentPictureBox = GetCurrentPictureBox();
                    currentPictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Set the PictureBox size mode to Zoom
                    currentPictureBox.Image = uploadedImage; // Display the image in the current PictureBox

                    currentPictureBoxIndex++; // Move to the next PictureBox
                }
                else
                {
                    MessageBox.Show("You have reached the maximum number of images.");
                }
            }
            else
            {
                MessageBox.Show("Please upload an image.");
            }
        }

        private PictureBox GetCurrentPictureBox()
        {
            // Get the current PictureBox control based on the currentPictureBoxIndex
            switch (currentPictureBoxIndex)
            {
                case 0:
                default:
                    currentPictureBoxIndex = 0;
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
            uploadedImages.Images.Clear();
            currentPictureBoxIndex = 0;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            createNewPost();
            // Redirect to FMyPosts form
            FMyPosts myPostsForm = new FMyPosts(user);
            myPostsForm.Show();
            // Optionally, hide the current form
            this.Close();
        }

        private void createNewPost()
        {
            // Create new Post object
            int id = postDAO.GetList().Count;
            string other = string.Format($"{txtAddress.Text}\n{this.cbxWork.GetItemText(this.cbxWork.SelectedItem)}");
            Post tmp = new Post(id,txtPostName.Text, Convert.ToDecimal(txtSalary.Text), other);
            tmp.Images.Add(this.pbxJobImages1.Image);
            tmp.Images.Add(this.pbxJobImages2.Image);
            tmp.Images.Add(this.pbxJobImages3.Image);
            tmp.JobDescs.Add("- Skill Requirement: " + txtSkillReq.Text);
            tmp.JobDescs.Add("- In this job you need to work about: " + txtWorkHours.Text);
            tmp.JobDescs.Add("- For any further detail please contact by: " + txtContact.Text);
            postDAO.Insert(tmp, user);
            user.Posts.Add(tmp);
        }
    }
}
