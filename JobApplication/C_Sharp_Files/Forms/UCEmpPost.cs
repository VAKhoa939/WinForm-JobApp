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
    public partial class UCEmpPost : UserControl
    {
        private Post post;
        private Company company;
        private Employer user;

        public UCEmpPost()
        {
            InitializeComponent();
        }

        public UCEmpPost(Post post, Company company, Employer user)
        {
            InitializeComponent();
            this.post = post;
            this.company = company;
            this.user = user;

            DateTime delta = new DateTime(DateTime.Now.Ticks - post.TimePosted.Ticks);
            lblThoiGianDang.Text = "Posted " + delta.Hour + " hours ago";
            lklblTenBaiDang.Text = post.Name;
            imgLogo.Image = company.Logo;
            lblTenCongTy.Text = company.Name;
            lblTienLuong.Text = post.Salary.ToString();
            lblKhac.Text = post.Others.Replace("\\n", System.Environment.NewLine);
            foreach (string tag in post.Tags)
            {
                Button btnTag = new Button();
                btnTag.Text = tag;
                btnTag.Size = new Size(100, 32);
                btnTag.Font = new Font("Times New Roman", 11);
                flpTags.Controls.Add(btnTag);
            }
        }

        private void lklblTenBaiDang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            //FFormManagement fFormManagement = new FFormManagement(post, company, user);
            FFormManagement fFormManagement = new FFormManagement(post);
            fFormManagement.ShowDialog();
        }
    }
}
