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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FApplyForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCoverLetter = new System.Windows.Forms.Label();
            this.lblCoverQuestion = new System.Windows.Forms.Label();
            this.btnSendCV = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComChooseFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdUploadCV = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnSendCV);
            this.panel1.Controls.Add(this.lblCoverQuestion);
            this.panel1.Controls.Add(this.lblCoverLetter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblCoverLetter
            // 
            resources.ApplyResources(this.lblCoverLetter, "lblCoverLetter");
            this.lblCoverLetter.Name = "lblCoverLetter";
            // 
            // lblCoverQuestion
            // 
            resources.ApplyResources(this.lblCoverQuestion, "lblCoverQuestion");
            this.lblCoverQuestion.Name = "lblCoverQuestion";
            // 
            // btnSendCV
            // 
            this.btnSendCV.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnSendCV, "btnSendCV");
            this.btnSendCV.ForeColor = System.Drawing.Color.White;
            this.btnSendCV.Name = "btnSendCV";
            this.btnSendCV.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnComChooseFile
            // 
            resources.ApplyResources(this.btnComChooseFile, "btnComChooseFile");
            this.btnComChooseFile.Name = "btnComChooseFile";
            this.btnComChooseFile.UseVisualStyleBackColor = true;
            this.btnComChooseFile.Click += new System.EventHandler(this.btnComChooseFile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rdUploadCV);
            this.panel2.Controls.Add(this.btnComChooseFile);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // rdUploadCV
            // 
            resources.ApplyResources(this.rdUploadCV, "rdUploadCV");
            this.rdUploadCV.Name = "rdUploadCV";
            this.rdUploadCV.TabStop = true;
            this.rdUploadCV.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Name = "label3";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // FApplyForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::JobApplication.Properties.Resources.Nitro_Wallpaper_5000x2813;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FApplyForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ApplyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCoverQuestion;
        private System.Windows.Forms.Label lblCoverLetter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendCV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdUploadCV;
        private System.Windows.Forms.Button btnComChooseFile;
        private System.Windows.Forms.TextBox textBox2;
    }
}