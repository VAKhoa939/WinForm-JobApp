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
        private Employer user;

        public UCEmpPost(Post post, Employer user)
        {
            InitializeComponent();
            this.post = post;
            this.user = user;
            Company company = user.Company;

            DateTime delta = new DateTime(DateTime.Now.Ticks - post.Timeposted.Ticks);
            lblThoiGianDang.Text = "Posted " + delta.Hour + " hours ago";
            lklblTenBaiDang.Text = post.Name;
            imgLogo.Image = ImageUtil.AutoFitPictureBox(imgLogo, ImageUtil.StringToImage(company.Logo));
            lblTenCongTy.Text = company.Name;
            lblTienLuong.Text = post.Salary.ToString();
            lblKhac.Text = post.Others.Replace("\\n", System.Environment.NewLine);
            foreach (PostTagCatalog postTag in post.SkillTags)
            {
                Button btnTag = new Button();
                btnTag.Text = postTag.Tag;
                btnTag.Size = new Size(100, 32);
                btnTag.Font = new Font("Times New Roman", 11);
                flpTags.Controls.Add(btnTag);
            }
        }

        private void lklblTenBaiDang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            FFormManagement fFormManagement = new FFormManagement(post, user);
            fFormManagement.ShowDialog();
        }
    }
}
