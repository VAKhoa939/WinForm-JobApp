using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class FAdmin : Form
    {
        private CompanyDAO companyDAO = new CompanyDAO();
        private ComEmpCatalogDAO comEmpDAO = new ComEmpCatalogDAO();
        private JobSeekerDAO jobSeekerDAO = new JobSeekerDAO();
        private SeekFormCatalogDAO seekFormDAO = new SeekFormCatalogDAO();
        private EmployerDAO employerDAO = new EmployerDAO();
        private EmpPostCatalogDAO empPostDAO = new EmpPostCatalogDAO();
        private PostDAO postDAO = new PostDAO();
        private PostDescCatalogDAO postDescDAO = new PostDescCatalogDAO();
        private PostImgCatalogDAO postImgDAO = new PostImgCatalogDAO();
        private PostTagCatalogDAO postTagDAO = new PostTagCatalogDAO();
        private PostFormCatalogDAO postFormDAO = new PostFormCatalogDAO();
        private ApplyFormDAO applyFormDAO = new ApplyFormDAO();

        public FAdmin()
        {
            InitializeComponent();
        }

        private void gvCom_Load()
        {
            gvCom.DataSource = companyDAO.Load();
        }

        private void gvComEmp_Load()
        {
            gvComEmp.DataSource = comEmpDAO.Load();
        }

        private void gvSeek_Load()
        {
            gvSeek.DataSource = jobSeekerDAO.Load();
        }

        private void gvSeekForm_Load()
        {
            gvSeekForm.DataSource = seekFormDAO.Load();
        }

        private void gvEmp_Load()
        {
            gvEmp.DataSource = employerDAO.Load();
        }

        private void gvEmpPost_Load()
        {
            gvEmpPost.DataSource = empPostDAO.Load();
        }

        private void gvPost_Load()
        {
            gvPost.DataSource = postDAO.Load();
        }

        private void gvPostForm_Load()
        {
            gvPostForm.DataSource = postFormDAO.Load();
        }

        private void gvPostDesc_Load()
        {
            gvPostDesc.DataSource = postDescDAO.Load();
        }

        private void gvPostTag_Load()
        {
            gvPostTag.DataSource = postTagDAO.Load();
        }

        private void gvPostImg_Load()
        {
            gvPostImg.DataSource = postImgDAO.Load();
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {
            gvCom_Load();
            gvComEmp_Load();
            gvSeek_Load();
            gvSeekForm_Load();
            gvEmp_Load();
            gvEmpPost_Load();
            gvPost_Load();
            gvPostForm_Load();
            gvPostDesc_Load();
            gvPostTag_Load();
            gvPostImg_Load();
        }



        /* Tab 1: Company & ComEmpCatalog */

        private void btnComChooseimage_Click(object sender, EventArgs e)
        {
            picComLogo.Image = new Bitmap(ImageUtil.UploadImage(), new Size(70, 70));
        }

        private void btnComInsert_Click(object sender, EventArgs e)
        {
            Company company = new Company(txtComName.Text, picComLogo.Image);
            companyDAO.Insert(company);
            gvCom_Load();
        }

        private void btnComDelete_Click(object sender, EventArgs e)
        {
            Company company = companyDAO.GetCompany(txtComName.Text);
            companyDAO.Delete(company);
            gvCom_Load();
            gvComEmp_Load();
            gvEmp_Load();
            gvEmpPost_Load();
            gvPost_Load();
            gvPostForm_Load();
            gvPostDesc_Load();
            gvPostTag_Load();
            gvPostImg_Load();
        }

        private void btnComUpdate_Click(object sender, EventArgs e)
        {
            Company company = new Company(txtComName.Text, picComLogo.Image);
            companyDAO.Update(company);
            gvCom_Load();
        }

        private void gvCom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = gvCom.Rows[e.RowIndex];
            txtComName.Text = dataRow.Cells[0].Value.ToString();
            picComLogo.Image = new Bitmap(ImageUtil.ByteToImage((byte[])dataRow.Cells[1].Value), new Size(70, 70));
        }

        private void btnComEmpDeleteEmpname_Click(object sender, EventArgs e)
        {
            comEmpDAO.DeleteEmpName(txtComEmpEmpname.Text);
            gvComEmp_Load();
            gvEmp_Load();
            gvEmpPost_Load();
            gvPost_Load();
            gvPostForm_Load();
            gvPostDesc_Load();
            gvPostTag_Load();
            gvPostImg_Load();
        }

        private void gvComEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = gvComEmp.Rows[e.RowIndex];
            txtComEmpComname.Text = dataRow.Cells[0].Value.ToString();
            txtComEmpEmpname.Text = dataRow.Cells[1].Value.ToString();
        }



        /* Tab 2: JobSeeker & SeekFormCatalog */

        private void btnSeekChooseimage_Click(object sender, EventArgs e)
        {
            picSeekPortraitimage.Image = new Bitmap(ImageUtil.UploadImage(), new Size(70, 70));
        }

        private void btnSeekInsert_Click(object sender, EventArgs e)
        {
            JobSeeker jobSeeker = new JobSeeker(txtSeekUsername.Text, txtSeekEmail.Text, txtSeekPassword.Text, txtSeekPhonenumber.Text, txtSeekFullname.Text, txtSeekAddress.Text, dtpSeekBirthdate.Value, picSeekPortraitimage.Image);
            jobSeekerDAO.Insert(jobSeeker);
            gvSeek_Load();
        }

        private void btnSeekDelete_Click(object sender, EventArgs e)
        {
            JobSeeker jobSeeker = jobSeekerDAO.GetJobSeeker(txtSeekUsername.Text);
            jobSeekerDAO.Delete(jobSeeker);
            gvSeek_Load();
            gvSeekForm_Load();
        }

        private void btnSeekUpdate_Click(object sender, EventArgs e)
        {
            JobSeeker jobSeeker = new JobSeeker(txtSeekUsername.Text, txtSeekEmail.Text, txtSeekPassword.Text, txtSeekPhonenumber.Text, txtSeekFullname.Text, txtSeekAddress.Text, dtpSeekBirthdate.Value, picSeekPortraitimage.Image);
            jobSeekerDAO.Update(jobSeeker);
            gvSeek_Load();
        }

        private void gvSeek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = gvSeek.Rows[e.RowIndex];
            txtSeekUsername.Text = dataRow.Cells[0].Value.ToString();
            txtSeekEmail.Text = dataRow.Cells[1].Value.ToString();
            txtSeekPassword.Text = dataRow.Cells[2].Value.ToString();
            txtSeekPhonenumber.Text = dataRow.Cells[3].Value.ToString();
            txtSeekFullname.Text = dataRow.Cells[4].Value.ToString();
            txtSeekAddress.Text = dataRow.Cells[5].Value.ToString();
            dtpSeekBirthdate.Value = (DateTime)dataRow.Cells[6].Value;
            picSeekPortraitimage.Image = new Bitmap(ImageUtil.ByteToImage((byte[])dataRow.Cells[7].Value), new Size(70, 70));
        }

        private void btnSeekFormDeleteFormid_Click(object sender, EventArgs e)
        {
            seekFormDAO.DeleteFormId(Convert.ToInt32(txtSeekFormFormid.Text));
            gvSeekForm_Load();
        }

        private void gvSeekForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = gvSeekForm.Rows[e.RowIndex];
            txtSeekFormSeekname.Text = dataRow.Cells[0].Value.ToString();
            txtSeekFormFormid.Text = dataRow.Cells[1].Value.ToString();
        }



        /* Tab 3: Employer & EmpPostCatalog */

        private void btnEmpInsert_Click(object sender, EventArgs e)
        {
            Employer employer = new Employer(txtEmpUsername.Text, txtEmpEmail.Text, txtEmpPassword.Text, txtEmpPhonenumber.Text, txtEmpFullname.Text);
            List<Company> companies = companyDAO.GetList();
            foreach (Company company in companies) 
            {
                if (company.Name.Equals(txtEmpComname.Text))
                {
                    employerDAO.Insert(employer, company);
                    gvEmp_Load();
                    gvComEmp_Load();
                    return;
                }
            }
            MessageBox.Show("This company name doesn't exist.");
        }

        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            Employer employer = employerDAO.GetEmployer(txtEmpUsername.Text);
            employerDAO.Delete(employer);
            gvEmp_Load();
            gvComEmp_Load();
            gvEmpPost_Load();
            gvPost_Load();
            gvPostForm_Load();
            gvPostDesc_Load();
            gvPostTag_Load();
            gvPostImg_Load();
        }

        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {
            Employer employer = new Employer(txtEmpUsername.Text, txtEmpEmail.Text, txtEmpPassword.Text, txtEmpPhonenumber.Text, txtEmpFullname.Text);
            employerDAO.Update(employer);
            gvEmp_Load();
        }

        private void gvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = gvEmp.Rows[e.RowIndex];
            txtEmpUsername.Text = dataRow.Cells[0].Value.ToString();
            txtEmpEmail.Text = dataRow.Cells[1].Value.ToString();
            txtEmpPassword.Text = dataRow.Cells[2].Value.ToString();
            txtEmpPhonenumber.Text = dataRow.Cells[3].Value.ToString();
            txtEmpFullname.Text = dataRow.Cells[4].Value.ToString();
            txtEmpComname.Text = comEmpDAO.GetComName(txtEmpUsername.Text);
        }

        private void btnEmpPostDeletePostid_Click(object sender, EventArgs e)
        {
            empPostDAO.DeletePostId(Convert.ToInt32(txtEmpPostPostid.Text));
            gvEmpPost_Load();
            gvPost_Load();
            gvPostForm_Load();
            gvPostDesc_Load();
            gvPostTag_Load();
            gvPostImg_Load();
        }

        private void gvEmpPost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = gvEmpPost.Rows[e.RowIndex];
            txtEmpPostEmpname.Text = dataRow.Cells[0].Value.ToString();
            txtEmpPostPostid.Text = dataRow.Cells[1].Value.ToString();
        }



        /* Tab 4: Post & PostFormCatalog */

        //private void btnPostInsert_Click(object sender, EventArgs e)
        //{
        //    Post post = new Post(Convert.ToInt32(txtPostId.Text), txtPostName.Text, Convert.ToDecimal(txtPostSalary.Text), txtPostOthers.Text);
        //    List<Employer> employers = employerDAO.GetList(); 
        //    foreach (Employer employer in employers)
        //    {
        //        if (employer.UserName.Equals(txtPostEmpname.Text))
        //        {
        //            postDAO.Insert(post, employer);
        //            gvPost_Load();
        //            gvEmpPost_Load();
        //            return;
        //        }
        //    }
        //    MessageBox.Show("This company name doesn't exist.");
        //}

        private void btnPostDelete_Click(object sender, EventArgs e)
        {
            Post post = postDAO.GetPost(Convert.ToInt32(txtPostId.Text));
            postDAO.Delete(post);
            gvPost_Load();
            gvEmpPost_Load();
            gvPostForm_Load();
            gvPostDesc_Load();
            gvPostTag_Load();
            gvPostImg_Load();
        }

        //private void btnPostUpdate_Click(object sender, EventArgs e)
        //{
        //    Post post = new Post(Convert.ToInt32(txtPostId.Text), txtPostName.Text, Convert.ToDecimal(txtPostSalary.Text), txtPostOthers.Text);
        //    postDAO.Update(post);
        //    gvPost_Load();
        //}

        private void gvPost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = gvPost.Rows[e.RowIndex];
            txtPostId.Text = dataRow.Cells[0].Value.ToString();
            txtPostName.Text = dataRow.Cells[1].Value.ToString();
            txtPostSalary.Text = dataRow.Cells[2].Value.ToString();
            txtPostOthers.Text = dataRow.Cells[3].Value.ToString();
            txtPostEmpname.Text = empPostDAO.GetEmpName(Convert.ToInt32(txtPostId.Text));
        }

        private void btnPostFormDeleteFormid_Click(object sender, EventArgs e)
        {
            postFormDAO.DeleteFormId(Convert.ToInt32(txtPostFormFormid.Text));
            gvPostForm_Load();
            gvPostDesc_Load();
            gvPostTag_Load();
            gvPostImg_Load();
        }

        private void gvPostForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = gvPostForm.Rows[e.RowIndex];
            txtPostFormPostid.Text = dataRow.Cells[0].Value.ToString();
            txtPostFormFormid.Text = dataRow.Cells[1].Value.ToString();
        }



        /* Tab 5: PostDescCatalog, PostTagCatalog and PostImgCatalog */

        private void btnPostDescInsert_Click(object sender, EventArgs e)
        {
            List<Post> posts = postDAO.GetList();
            foreach (Post post in posts) 
            {
                if (post.Id == Convert.ToInt32(txtPostDescPostid.Text)) 
                {
                    postDescDAO.Insert(post.Id, txtPostDescJobdesc.Text);
                    gvPostDesc_Load();
                    return;
                }
            }
            MessageBox.Show("This post id doesn't exist.");
        }

        private void btnPostDescDelete_Click(object sender, EventArgs e)
        {
            postDescDAO.DeleteJobDesc(txtPostDescJobdesc.Text);
            gvPostDesc_Load();
        }

        private void btnPostDescUpdate_Click(object sender, EventArgs e)
        {
            postDescDAO.Update(Convert.ToInt32(txtPostDescPostid.Text), txtPostDescJobdesc.Text);
            gvPostDesc_Load();
        }

        private void gvPostDesc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = gvPostDesc.Rows[e.RowIndex];
            txtPostDescPostid.Text = dataRow.Cells[0].Value.ToString();
            txtPostDescJobdesc.Text = dataRow.Cells[1].Value.ToString();
        }

        private void btnPostTagInsert_Click(object sender, EventArgs e)
        {
            List<Post> posts = postDAO.GetList();
            foreach (Post post in posts)
            {
                if (post.Id == Convert.ToInt32(txtPostTagPostid.Text))
                {
                    postTagDAO.Insert(post.Id, txtPostTagTag.Text);
                    gvPostTag_Load();
                    return;
                }
            }
            MessageBox.Show("This post id doesn't exist.");
        }

        private void btnPostTagDelete_Click(object sender, EventArgs e)
        {
            postTagDAO.DeleteTag(txtPostTagTag.Text);
            gvPostTag_Load();
        }

        private void btnPostTagUpdate_Click(object sender, EventArgs e)
        {
            postTagDAO.Update(Convert.ToInt32(txtPostTagPostid.Text), txtPostTagTag.Text);
            gvPostTag_Load();
        }

        private void gvPostTag_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = gvPostTag.Rows[e.RowIndex];
            txtPostTagPostid.Text = dataRow.Cells[0].Value.ToString();
            txtPostTagTag.Text = dataRow.Cells[1].Value.ToString();
        }

        private void btnPostImgChooseimage_Click(object sender, EventArgs e)
        {
            picPostImgImage.Image = new Bitmap(ImageUtil.UploadImage(), new Size(70, 70));
        }

        private void btnPostImgInsert_Click(object sender, EventArgs e)
        {
            List<Post> posts = postDAO.GetList();
            foreach (Post post in posts)
            {
                if (post.Id == Convert.ToInt32(txtPostImgPostid.Text))
                {
                    postImgDAO.Insert(post.Id, picPostImgImage.Image);
                    gvPostImg_Load();
                    return;
                }
            }
            MessageBox.Show("This post id doesn't exist.");
        }

        private void btnPostImgDelete_Click(object sender, EventArgs e)
        {
            postImgDAO.DeleteImage(picPostImgImage.Image);
            gvPostImg_Load();
        }

        private void btnPostImgUpdate_Click(object sender, EventArgs e)
        {
            postImgDAO.Update(Convert.ToInt32(txtPostImgPostid.Text), picPostImgImage.Image);
            gvPostImg_Load();
        }

        private void gvPostImg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = gvPostImg.Rows[e.RowIndex];
            txtPostImgPostid.Text = dataRow.Cells[0].Value.ToString();
            picPostImgImage.Image = ImageUtil.ByteToImage((byte[])dataRow.Cells[1].Value);
        }
    }
}
