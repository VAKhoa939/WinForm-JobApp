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
    public partial class FApplyForm : Form
    {
        JobSeeker user;

        public FApplyForm(JobSeeker user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FApplyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
