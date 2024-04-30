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
    public partial class UCEmpHeader : UserControl
    {
        public Employer user;

        public UCEmpHeader()
        {
            InitializeComponent();
        }

        private void createAPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            FCreatePost fCreatePost = new FCreatePost(user);
            fCreatePost.Show();
        }
    }
}
