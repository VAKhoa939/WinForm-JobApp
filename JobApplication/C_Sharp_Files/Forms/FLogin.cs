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
    public partial class FLogin : Form
    {
        private CompanyDAO companyDAO = new CompanyDAO();
        private EmployerDAO employerDAO = new EmployerDAO();
        private JobSeekerDAO jobSeekerDAO = new JobSeekerDAO();
        private List<Company> listCompany;
        private List<Employer> listEmployer;
        private List<JobSeeker> listJobSeeker;

        public FLogin()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            listCompany = companyDAO.GetList();
            listEmployer = employerDAO.GetList();
            listJobSeeker = jobSeekerDAO.GetList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rdoJobSeekerLogin.Checked)
            {
                foreach(JobSeeker js in listJobSeeker)
                {
                    if (js.Username == txtUserNameLogin.Text
                        && js.Password == txtPasswordLogin.Text)
                    {
                        Hide();
                        FAllPosts fAllPosts = new FAllPosts(js);
                        fAllPosts.Closed += (s, args) => Close();
                        fAllPosts.Show();
                        return;
                    }
                }
                MessageBox.Show("User Name or Password is not correct, please try again!");
                txtUserNameLogin.Text = string.Empty;
                txtPasswordLogin.Text = string.Empty;
            }
            else if (rdoEmployerLogin.Checked)
            {
                foreach (Employer emp in listEmployer)
                {
                    if (emp.Username == txtUserNameLogin.Text
                        && emp.Password == txtPasswordLogin.Text)
                    {
                        Hide();
                        FMyPosts fMyPosts = new FMyPosts(emp);
                        fMyPosts.Show();
                        return;
                    }
                }
                MessageBox.Show("User Name or Password is not correct, please try again!");
                txtUserNameLogin.Text = string.Empty;
                txtPasswordLogin.Text = string.Empty;
            }
        }

        private void btnComChooseimage_Click(object sender, EventArgs e)
        {
            picComLogo.Image = ImageUtil.AutoFitPictureBox(picComLogo, ImageUtil.UploadImage());
        }

        private void btnCompRegister_Click(object sender, EventArgs e)
        {
            Company company = new Company
            {
                Name = txtCompanyNameComp.Text,
                Logo = ImageUtil.ImageToString(picComLogo.Image),
            };

            foreach (var comp in listCompany)
            {
                if (txtCompanyNameComp.Text == comp.Name)
                {
                    MessageBox.Show("Company already registered");
                    return;
                }
            }
            companyDAO.Insert(company);
            listCompany.Add(company);
            MessageBox.Show("Add new Company successfully");
        }

        private void btnJSRegister_Click(object sender, EventArgs e)
        {
            JobSeeker jobSeeker = new JobSeeker
            {
                Username = txtUserNameJS.Text,
                Email = txtEmailJS.Text,
                Password = txtPasswordJS.Text,
                Phonenumber = txtPhoneNumberJS.Text,
                Fullname = txtFirstNameJS.Text + txtLastNameJS,
                Portraitimage = ImageUtil.ImageToString(Properties.Resources.user),
                Address = string.Empty,
                Birthdate = (DateTime)dtpDOB.Value,
            };
            
            foreach(var seeker in listJobSeeker)
            {
                if(txtUserNameJS.Text == seeker.Username)
                {
                    MessageBox.Show("User Name already registered");
                    return;
                }
            }
            jobSeekerDAO.Insert(jobSeeker);
            listJobSeeker.Add(jobSeeker);
            MessageBox.Show("Add new Job Seeker successfully");
        }

        private void btnEmployerRegister_Click(object sender, EventArgs e)
        {
            Employer employer = new Employer
            {
                Username = txtUserNameEmp.Text,
                Email = txtEmailEmp.Text,
                Password = txtPasswordEmp.Text,
                Phonenumber = txtPhoneNumberEmp.Text,
                Fullname = txtFirstNameJS.Text + txtLastNameJS,
                Portraitimage = ImageUtil.ImageToString(Properties.Resources.user),
            };
            bool companyNameExist = false;
            foreach (var company in listCompany)
            {
                if (txtCompanyNameComp.Text == company.Name)
                {
                    employer.Company = company;
                    companyNameExist = true;
                    break;
                }
            }
            if (!companyNameExist)
            {
                MessageBox.Show("Company Name not registered!");
                return;
            }
            foreach (var emp in listEmployer)
            {
                if (txtUserNameEmp.Text == emp.Username)
                {
                    MessageBox.Show("User Name already registered");
                    return;
                }
            }
            employerDAO.Insert(employer);
            listEmployer.Add(employer);
            MessageBox.Show("Add new Employer successfully");
        }
    }
}
