namespace JobApplication
{
    partial class FFormManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFormManagement));
            this.flpJobDesc = new System.Windows.Forms.FlowLayoutPanel();
            this.imageListJobImage2 = new System.Windows.Forms.ImageList(this.components);
            this.tmrChangeImage = new System.Windows.Forms.Timer(this.components);
            this.imageListJobImage = new System.Windows.Forms.ImageList(this.components);
            this.lblPostTime = new System.Windows.Forms.Label();
            this.lblPostOther = new System.Windows.Forms.Label();
            this.pbxCompanyAva3 = new System.Windows.Forms.PictureBox();
            this.pbxCompanyAva2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxCompanyAva = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPostName = new System.Windows.Forms.Label();
            this.lblPostSalary = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ucEmpHeader1 = new JobApplication.UCEmpHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucApplyForm1 = new JobApplication.UCApplyForm();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCompanyAva3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCompanyAva2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCompanyAva)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpJobDesc
            // 
            this.flpJobDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpJobDesc.Location = new System.Drawing.Point(45, 602);
            this.flpJobDesc.Name = "flpJobDesc";
            this.flpJobDesc.Size = new System.Drawing.Size(930, 282);
            this.flpJobDesc.TabIndex = 18;
            // 
            // imageListJobImage2
            // 
            this.imageListJobImage2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListJobImage2.ImageStream")));
            this.imageListJobImage2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListJobImage2.Images.SetKeyName(0, "jun-seong-park-for-artstation.jpg");
            this.imageListJobImage2.Images.SetKeyName(1, "Biboo.png");
            this.imageListJobImage2.Images.SetKeyName(2, "F0BvAFzaYAISCCm.jpg");
            // 
            // tmrChangeImage
            // 
            this.tmrChangeImage.Enabled = true;
            this.tmrChangeImage.Interval = 1000;
            this.tmrChangeImage.Tick += new System.EventHandler(this.tmrChangeImage_Tick);
            // 
            // imageListJobImage
            // 
            this.imageListJobImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListJobImage.ImageStream")));
            this.imageListJobImage.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListJobImage.Images.SetKeyName(0, "𝐒𝐔𝐋𝐄𝐓𝐓𝐀 𝐌𝐄𝐑𝐂𝐔𝐑𝐘.jpg");
            this.imageListJobImage.Images.SetKeyName(1, "Suletta.Mercury.600.3950579.jpg");
            this.imageListJobImage.Images.SetKeyName(2, "Starrail1.png");
            // 
            // lblPostTime
            // 
            this.lblPostTime.AutoSize = true;
            this.lblPostTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostTime.Location = new System.Drawing.Point(4, 189);
            this.lblPostTime.Name = "lblPostTime";
            this.lblPostTime.Size = new System.Drawing.Size(159, 22);
            this.lblPostTime.TabIndex = 5;
            this.lblPostTime.Text = "Posted 8 hours ago";
            // 
            // lblPostOther
            // 
            this.lblPostOther.AutoSize = true;
            this.lblPostOther.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostOther.Location = new System.Drawing.Point(4, 124);
            this.lblPostOther.Name = "lblPostOther";
            this.lblPostOther.Size = new System.Drawing.Size(760, 44);
            this.lblPostOther.TabIndex = 3;
            this.lblPostOther.Text = "3rd Floor, Dong Nhan Building, 90 Nguyen Dinh Chieu, Da Kao Ward, District 1, Ho " +
    "Chi Minh\r\nHybrid\r\n";
            // 
            // pbxCompanyAva3
            // 
            this.pbxCompanyAva3.Location = new System.Drawing.Point(620, 3);
            this.pbxCompanyAva3.Name = "pbxCompanyAva3";
            this.pbxCompanyAva3.Size = new System.Drawing.Size(300, 100);
            this.pbxCompanyAva3.TabIndex = 2;
            this.pbxCompanyAva3.TabStop = false;
            // 
            // pbxCompanyAva2
            // 
            this.pbxCompanyAva2.Location = new System.Drawing.Point(314, 3);
            this.pbxCompanyAva2.Name = "pbxCompanyAva2";
            this.pbxCompanyAva2.Size = new System.Drawing.Size(300, 100);
            this.pbxCompanyAva2.TabIndex = 1;
            this.pbxCompanyAva2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPostTime);
            this.panel3.Controls.Add(this.lblPostOther);
            this.panel3.Controls.Add(this.pbxCompanyAva3);
            this.panel3.Controls.Add(this.pbxCompanyAva2);
            this.panel3.Controls.Add(this.pbxCompanyAva);
            this.panel3.Location = new System.Drawing.Point(45, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(927, 222);
            this.panel3.TabIndex = 14;
            // 
            // pbxCompanyAva
            // 
            this.pbxCompanyAva.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxCompanyAva.InitialImage")));
            this.pbxCompanyAva.Location = new System.Drawing.Point(8, 3);
            this.pbxCompanyAva.Name = "pbxCompanyAva";
            this.pbxCompanyAva.Size = new System.Drawing.Size(300, 100);
            this.pbxCompanyAva.TabIndex = 0;
            this.pbxCompanyAva.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPostName);
            this.panel1.Controls.Add(this.lblPostSalary);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(45, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 172);
            this.panel1.TabIndex = 13;
            // 
            // lblPostName
            // 
            this.lblPostName.AutoSize = true;
            this.lblPostName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostName.Location = new System.Drawing.Point(3, 0);
            this.lblPostName.Name = "lblPostName";
            this.lblPostName.Size = new System.Drawing.Size(494, 26);
            this.lblPostName.TabIndex = 1;
            this.lblPostName.Text = "Senior Golang Developer (Backend, AWS, MySQL)";
            // 
            // lblPostSalary
            // 
            this.lblPostSalary.AutoSize = true;
            this.lblPostSalary.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostSalary.Location = new System.Drawing.Point(3, 74);
            this.lblPostSalary.Name = "lblPostSalary";
            this.lblPostSalary.Size = new System.Drawing.Size(125, 25);
            this.lblPostSalary.TabIndex = 3;
            this.lblPostSalary.Text = "$ Negotiable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ANDPAD VietNam Co., Ltd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1197, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "List of appliers for the job:";
            // 
            // ucEmpHeader1
            // 
            this.ucEmpHeader1.BackColor = System.Drawing.Color.Coral;
            this.ucEmpHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucEmpHeader1.Location = new System.Drawing.Point(0, 0);
            this.ucEmpHeader1.Name = "ucEmpHeader1";
            this.ucEmpHeader1.Size = new System.Drawing.Size(1920, 120);
            this.ucEmpHeader1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucApplyForm1);
            this.panel2.Location = new System.Drawing.Point(1203, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 635);
            this.panel2.TabIndex = 27;
            // 
            // ucApplyForm1
            // 
            this.ucApplyForm1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucApplyForm1.Location = new System.Drawing.Point(3, 3);
            this.ucApplyForm1.Name = "ucApplyForm1";
            this.ucApplyForm1.Size = new System.Drawing.Size(522, 401);
            this.ucApplyForm1.TabIndex = 0;
            // 
            // FFormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucEmpHeader1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flpJobDesc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FFormManagement";
            this.Text = "FPostDetailE";
            this.Load += new System.EventHandler(this.FFormManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCompanyAva3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCompanyAva2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCompanyAva)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpJobDesc;
        private System.Windows.Forms.ImageList imageListJobImage2;
        private System.Windows.Forms.Timer tmrChangeImage;
        private System.Windows.Forms.ImageList imageListJobImage;
        private System.Windows.Forms.Label lblPostTime;
        private System.Windows.Forms.Label lblPostOther;
        private System.Windows.Forms.PictureBox pbxCompanyAva3;
        private System.Windows.Forms.PictureBox pbxCompanyAva2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbxCompanyAva;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPostName;
        private System.Windows.Forms.Label lblPostSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private UCEmpHeader ucEmpHeader1;
        private System.Windows.Forms.Panel panel2;
        private UCApplyForm ucApplyForm1;
    }
}