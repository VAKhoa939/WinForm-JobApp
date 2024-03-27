using System.Windows.Forms;
using System;

namespace JobApplication
{
    public partial class FPostDetail : Form
    {
        public FPostDetail()
        {
            InitializeComponent();
        }

        int intImgNum = 0;

        private void tmrChangeImage_Tick(object sender, EventArgs e)
        {
            int totalImages = imageListJobImage.Images.Count;

            if (totalImages >= 3)
            {
                pbxCompanyAva.Image = imageListJobImage.Images[intImgNum];
                pbxCompanyAva2.Image = imageListJobImage.Images[(intImgNum + 1) % totalImages];
                pbxCompanyAva3.Image = imageListJobImage.Images[(intImgNum + 2) % totalImages];

                intImgNum = (intImgNum + 1) % totalImages;
            }
            else if (totalImages == 2)
            {
                pbxCompanyAva.Image = imageListJobImage.Images[intImgNum];
                pbxCompanyAva2.Image = imageListJobImage.Images[(intImgNum + 1) % totalImages];
                pbxCompanyAva3.Image = null;

                intImgNum = (intImgNum + 1) % totalImages;
            }
            else if (totalImages == 1)
            {
                pbxCompanyAva.Image = imageListJobImage.Images[intImgNum];
                pbxCompanyAva2.Image = null;
                pbxCompanyAva3.Image = null;

                intImgNum = 0; // Reset index as there's only one image
            }
            else
            {
                // No images in the list
                pbxCompanyAva.Image = null;
                pbxCompanyAva2.Image = null;
                pbxCompanyAva3.Image = null;
            }
        }
    }
}
