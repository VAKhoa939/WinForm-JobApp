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
    public partial class FTinTuyenDung : Form
    {
        public FTinTuyenDung()
        {
            InitializeComponent();
        }

        private void TinTuyenDung_Load(object sender, EventArgs e)
        {
            lblSoLuongKQ.Text = "There are 9 results";

            Image logo = Image.FromFile("D:\\21110CLA2 - 5\\Năm 3 - HK2\\Window Programming\\Winform_code\\GitPull\\WinForm-JobApp\\JobApplication\\Image\\Cat.jpg");
            logo = new Bitmap(logo, new Size(70, 70));
            Font font = new Font("Times New Roman", 11);

            for (int i = 0; i < 9; i++)
            {
                UCBaiDang ucBaiDang = new UCBaiDang();
                ucBaiDang.lblThoiGianDang.Text = "Posted 18 hours ago";
                ucBaiDang.lklblTenBaiDang.Text = "Software Engineer II (C#, .NET, JavaScript)";
                ucBaiDang.imgLogo.Image = logo;
                ucBaiDang.lblTenCongTy.Text = "Motorola Solutions";
                ucBaiDang.lblTienLuong.Text = "700 - 1,071 USD";
                ucBaiDang.lblKhac.Text = "At office\nHo Chi Minh";
                Button tag1 = new Button();
                tag1.Text = "C#";
                tag1.Size = new Size(100, 32);
                tag1.Font = font;
                Button tag2 = new Button();
                tag2.Text = "JavaScript";
                tag2.Size = new Size(100, 32);
                tag2.Font = font;
                Button tag3 = new Button();
                tag3.Text = ".NET";
                tag3.Size = new Size(100, 32);
                tag3.Font = font;
                ucBaiDang.flpTags.Controls.Add(tag1);
                ucBaiDang.flpTags.Controls.Add(tag2);
                ucBaiDang.flpTags.Controls.Add(tag3);
                flpKetQua.Controls.Add(ucBaiDang);
            }
        }
    }
}
