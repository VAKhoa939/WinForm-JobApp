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
    public partial class FCoverLetter : Form
    {
        private string coverLetter;
        public FCoverLetter()
        {
            InitializeComponent();
        }
        public FCoverLetter(string coverLetter)
        {
            InitializeComponent();
            this.coverLetter = coverLetter;
        }

        private void FCoverLetter_Load(object sender, EventArgs e)
        {
            lblCover.Text = coverLetter;
        }
    }
}
