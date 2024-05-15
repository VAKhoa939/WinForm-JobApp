using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JobApplication
{
    public partial class UCSeekPost : UserControl
    {
        private Post post;
        private JobSeeker user;

        public UCSeekPost(Post post, JobSeeker user)
        {
            InitializeComponent();
            this.post = post;
            this.user = user;
            Company company = post.Employer.Company;

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
                btnTag.Size = new Size(80, 32);
                btnTag.Font = new Font("Times New Roman", 11);
                flpTags.Controls.Add(btnTag);
            }
        }

        public void lklblTenBaiDang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            FPostDetail fPostDetail = new FPostDetail(post, user);
            fPostDetail.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
            fPostDetail.Show();
        }
    }
}