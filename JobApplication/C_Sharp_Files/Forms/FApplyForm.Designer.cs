namespace JobApplication
{
    partial class FApplyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoverLetter = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCurrentFileName = new System.Windows.Forms.Label();
            this.lblNewFileName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnSendCV = new System.Windows.Forms.Button();
            this.lblCoverQuestion = new System.Windows.Forms.Label();
            this.lblCoverLetter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtCoverLetter);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSendCV);
            this.panel1.Controls.Add(this.lblCoverQuestion);
            this.panel1.Controls.Add(this.lblCoverLetter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(313, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 773);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(35, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "APPLY FORM";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUserName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(38, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(894, 76);
            this.panel3.TabIndex = 17;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic);
            this.txtUserName.Location = new System.Drawing.Point(3, 40);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(889, 38);
            this.txtUserName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Name";
            // 
            // txtCoverLetter
            // 
            this.txtCoverLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCoverLetter.Location = new System.Drawing.Point(35, 408);
            this.txtCoverLetter.Multiline = true;
            this.txtCoverLetter.Name = "txtCoverLetter";
            this.txtCoverLetter.Size = new System.Drawing.Size(889, 230);
            this.txtCoverLetter.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCurrentFileName);
            this.panel2.Controls.Add(this.lblNewFileName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnChooseFile);
            this.panel2.Location = new System.Drawing.Point(38, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 135);
            this.panel2.TabIndex = 15;
            // 
            // lblCurrentFileName
            // 
            this.lblCurrentFileName.AutoSize = true;
            this.lblCurrentFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFileName.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCurrentFileName.Location = new System.Drawing.Point(7, 11);
            this.lblCurrentFileName.Name = "lblCurrentFileName";
            this.lblCurrentFileName.Size = new System.Drawing.Size(185, 29);
            this.lblCurrentFileName.TabIndex = 19;
            this.lblCurrentFileName.Text = "Upload New CV";
            // 
            // lblNewFileName
            // 
            this.lblNewFileName.AutoSize = true;
            this.lblNewFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblNewFileName.ForeColor = System.Drawing.Color.Gray;
            this.lblNewFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNewFileName.Location = new System.Drawing.Point(154, 60);
            this.lblNewFileName.Name = "lblNewFileName";
            this.lblNewFileName.Size = new System.Drawing.Size(25, 22);
            this.lblNewFileName.TabIndex = 18;
            this.lblNewFileName.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "We accept pdf only, up to 3MB";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnChooseFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChooseFile.Location = new System.Drawing.Point(12, 52);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(136, 41);
            this.btnChooseFile.TabIndex = 14;
            this.btnChooseFile.Text = "Choose File";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnSendCV
            // 
            this.btnSendCV.BackColor = System.Drawing.Color.Red;
            this.btnSendCV.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSendCV.ForeColor = System.Drawing.Color.White;
            this.btnSendCV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSendCV.Location = new System.Drawing.Point(38, 665);
            this.btnSendCV.Name = "btnSendCV";
            this.btnSendCV.Size = new System.Drawing.Size(889, 72);
            this.btnSendCV.TabIndex = 4;
            this.btnSendCV.Text = "Send my CV";
            this.btnSendCV.UseVisualStyleBackColor = false;
            this.btnSendCV.Click += new System.EventHandler(this.btnSendCV_Click);
            // 
            // lblCoverQuestion
            // 
            this.lblCoverQuestion.AutoSize = true;
            this.lblCoverQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblCoverQuestion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCoverQuestion.Location = new System.Drawing.Point(33, 376);
            this.lblCoverQuestion.Name = "lblCoverQuestion";
            this.lblCoverQuestion.Size = new System.Drawing.Size(777, 29);
            this.lblCoverQuestion.TabIndex = 3;
            this.lblCoverQuestion.Text = "What skills, work projects or achievement make you a strong candidate?";
            // 
            // lblCoverLetter
            // 
            this.lblCoverLetter.AutoSize = true;
            this.lblCoverLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCoverLetter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCoverLetter.Location = new System.Drawing.Point(30, 347);
            this.lblCoverLetter.Name = "lblCoverLetter";
            this.lblCoverLetter.Size = new System.Drawing.Size(275, 29);
            this.lblCoverLetter.TabIndex = 2;
            this.lblCoverLetter.Text = "Cover Letter (optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(30, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your CV";
            // 
            // FApplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JobApplication.Properties.Resources.Nitro_Wallpaper_5000x2813;
            this.ClientSize = new System.Drawing.Size(1602, 873);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FApplyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FApplyForm";
            this.Load += new System.EventHandler(this.FApplyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoverLetter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnSendCV;
        private System.Windows.Forms.Label lblCoverQuestion;
        private System.Windows.Forms.Label lblCoverLetter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentFileName;
        private System.Windows.Forms.Label lblNewFileName;
    }
}