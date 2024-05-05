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
    public partial class FCV : Form
    {
        private string path;
        public FCV()
        {
            InitializeComponent();
        }
        public FCV(string path)
        {
            this.path = path;
            InitializeComponent();
        }

        private void FCV_Load(object sender, EventArgs e)
        {
            pdfViewer1.LoadFromFile(path);
        }
    }
}
