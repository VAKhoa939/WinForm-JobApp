namespace JobApplication
{
    partial class FHomePage
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
            this.header1 = new JobApplication.UCSeekHeader();
            this.thanhTimKiem1 = new JobApplication.UCSearchBar();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1920, 120);
            this.header1.TabIndex = 0;
            // 
            // thanhTimKiem1
            // 
            this.thanhTimKiem1.Location = new System.Drawing.Point(0, 140);
            this.thanhTimKiem1.Name = "thanhTimKiem1";
            this.thanhTimKiem1.Size = new System.Drawing.Size(1920, 60);
            this.thanhTimKiem1.TabIndex = 1;
            // 
            // FHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.thanhTimKiem1);
            this.Controls.Add(this.header1);
            this.Name = "FHomePage";
            this.Text = "TrangChu";
            this.ResumeLayout(false);

        }

        #endregion

        private UCSeekHeader header1;
        private UCSearchBar thanhTimKiem1;
    }
}