using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class FMyPosts : Form
    {
        private Employer user;

        public FMyPosts(Employer user)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            ucEmpHeader1.user = user;
            this.user = user;
        }

        private void FMyPosts_Load(object sender, EventArgs e)
        {
            ICollection<Post> posts = user.Posts;

            foreach (Post post in posts)
            {
                UCEmpPost ucPost = new UCEmpPost(post, user);
                flpKetQua.Controls.Add(ucPost);
            }
            lblSoLuongKQ.Text = "There are " + posts.Count + " results";
        }
    }
}