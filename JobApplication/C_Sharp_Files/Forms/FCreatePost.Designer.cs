namespace JobApplication
{
    partial class FCreatePost
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.cbxWork = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectImages = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxJobImages1 = new System.Windows.Forms.PictureBox();
            this.txtPostName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWorkHours = new System.Windows.Forms.TextBox();
            this.txtSkillReq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSkilltags = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pbxJobImages3 = new System.Windows.Forms.PictureBox();
            this.pbxJobImages2 = new System.Windows.Forms.PictureBox();
            this.displayImageList = new System.Windows.Forms.ImageList(this.components);
            this.tmrChangeImage = new System.Windows.Forms.Timer(this.components);
            this.ucEmpHeader1 = new JobApplication.UCEmpHeader();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJobImages1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJobImages3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJobImages2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Cyan;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(871, 636);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 67);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Cyan;
            this.btnUpload.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(485, 636);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(150, 67);
            this.btnUpload.TabIndex = 18;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // cbxWork
            // 
            this.cbxWork.FormattingEnabled = true;
            this.cbxWork.Items.AddRange(new object[] {
            "Office",
            "Home",
            "Hybrid"});
            this.cbxWork.Location = new System.Drawing.Point(243, 228);
            this.cbxWork.Margin = new System.Windows.Forms.Padding(2);
            this.cbxWork.Name = "cbxWork";
            this.cbxWork.Size = new System.Drawing.Size(1054, 29);
            this.cbxWork.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 228);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Work at:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(243, 180);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(1054, 29);
            this.txtAddress.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create A New Post";
            // 
            // btnSelectImages
            // 
            this.btnSelectImages.BackColor = System.Drawing.Color.Cyan;
            this.btnSelectImages.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImages.Location = new System.Drawing.Point(1306, 471);
            this.btnSelectImages.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectImages.Name = "btnSelectImages";
            this.btnSelectImages.Size = new System.Drawing.Size(99, 41);
            this.btnSelectImages.TabIndex = 13;
            this.btnSelectImages.Text = "Add";
            this.btnSelectImages.UseVisualStyleBackColor = false;
            this.btnSelectImages.Click += new System.EventHandler(this.btnSelectImages_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Post\'s name:";
            // 
            // pbxJobImages1
            // 
            this.pbxJobImages1.Location = new System.Drawing.Point(243, 471);
            this.pbxJobImages1.Margin = new System.Windows.Forms.Padding(2);
            this.pbxJobImages1.Name = "pbxJobImages1";
            this.pbxJobImages1.Size = new System.Drawing.Size(344, 136);
            this.pbxJobImages1.TabIndex = 12;
            this.pbxJobImages1.TabStop = false;
            // 
            // txtPostName
            // 
            this.txtPostName.Location = new System.Drawing.Point(243, 82);
            this.txtPostName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostName.Name = "txtPostName";
            this.txtPostName.Size = new System.Drawing.Size(1054, 29);
            this.txtPostName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 471);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Add job\'s image:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salary:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(243, 374);
            this.txtContact.Margin = new System.Windows.Forms.Padding(2);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(1054, 29);
            this.txtContact.TabIndex = 10;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(243, 130);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(1054, 29);
            this.txtSalary.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contact by:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Skills requirement:";
            // 
            // txtWorkHours
            // 
            this.txtWorkHours.Location = new System.Drawing.Point(243, 325);
            this.txtWorkHours.Margin = new System.Windows.Forms.Padding(2);
            this.txtWorkHours.Name = "txtWorkHours";
            this.txtWorkHours.Size = new System.Drawing.Size(1054, 29);
            this.txtWorkHours.TabIndex = 8;
            // 
            // txtSkillReq
            // 
            this.txtSkillReq.Location = new System.Drawing.Point(243, 276);
            this.txtSkillReq.Margin = new System.Windows.Forms.Padding(2);
            this.txtSkillReq.Name = "txtSkillReq";
            this.txtSkillReq.Size = new System.Drawing.Size(1054, 29);
            this.txtSkillReq.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 325);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Working hours:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSkilltags);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pbxJobImages3);
            this.panel1.Controls.Add(this.pbxJobImages2);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.cbxWork);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSelectImages);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pbxJobImages1);
            this.panel1.Controls.Add(this.txtPostName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtWorkHours);
            this.panel1.Controls.Add(this.txtSkillReq);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(78, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1425, 730);
            this.panel1.TabIndex = 16;
            // 
            // txtSkilltags
            // 
            this.txtSkilltags.Location = new System.Drawing.Point(243, 422);
            this.txtSkilltags.Margin = new System.Windows.Forms.Padding(2);
            this.txtSkilltags.Name = "txtSkilltags";
            this.txtSkilltags.Size = new System.Drawing.Size(1054, 29);
            this.txtSkilltags.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 422);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Skill tags:";
            // 
            // pbxJobImages3
            // 
            this.pbxJobImages3.Location = new System.Drawing.Point(953, 471);
            this.pbxJobImages3.Margin = new System.Windows.Forms.Padding(2);
            this.pbxJobImages3.Name = "pbxJobImages3";
            this.pbxJobImages3.Size = new System.Drawing.Size(344, 136);
            this.pbxJobImages3.TabIndex = 21;
            this.pbxJobImages3.TabStop = false;
            // 
            // pbxJobImages2
            // 
            this.pbxJobImages2.Location = new System.Drawing.Point(598, 471);
            this.pbxJobImages2.Margin = new System.Windows.Forms.Padding(2);
            this.pbxJobImages2.Name = "pbxJobImages2";
            this.pbxJobImages2.Size = new System.Drawing.Size(344, 136);
            this.pbxJobImages2.TabIndex = 20;
            this.pbxJobImages2.TabStop = false;
            // 
            // displayImageList
            // 
            this.displayImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.displayImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.displayImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tmrChangeImage
            // 
            this.tmrChangeImage.Enabled = true;
            this.tmrChangeImage.Interval = 1000;
            this.tmrChangeImage.Tick += new System.EventHandler(this.tmrChangeImage_Tick);
            // 
            // ucEmpHeader1
            // 
            this.ucEmpHeader1.BackColor = System.Drawing.Color.Coral;
            this.ucEmpHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucEmpHeader1.Location = new System.Drawing.Point(0, 0);
            this.ucEmpHeader1.Margin = new System.Windows.Forms.Padding(2);
            this.ucEmpHeader1.Name = "ucEmpHeader1";
            this.ucEmpHeader1.Size = new System.Drawing.Size(1620, 98);
            this.ucEmpHeader1.TabIndex = 17;
            // 
            // FCreatePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::JobApplication.Properties.Resources.Nitro_Wallpaper_5000x2813;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.ucEmpHeader1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FCreatePost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCreatePost";
            ((System.ComponentModel.ISupportInitialize)(this.pbxJobImages1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJobImages3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJobImages2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ComboBox cbxWork;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectImages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxJobImages1;
        private System.Windows.Forms.TextBox txtPostName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWorkHours;
        private System.Windows.Forms.TextBox txtSkillReq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList displayImageList;
        private System.Windows.Forms.PictureBox pbxJobImages3;
        private System.Windows.Forms.PictureBox pbxJobImages2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSkilltags;
        public UCEmpHeader ucEmpHeader1;
        private System.Windows.Forms.Timer tmrChangeImage;
    }
}