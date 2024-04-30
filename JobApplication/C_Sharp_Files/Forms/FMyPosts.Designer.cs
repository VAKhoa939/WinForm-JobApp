namespace JobApplication
{
    partial class FMyPosts
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
            this.flpKetQua = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSoLuongKQ = new System.Windows.Forms.Label();
            this.ucEmpHeader1 = new JobApplication.UCEmpHeader();
            this.thanhTimKiem1 = new JobApplication.UCSearchBar();
            this.SuspendLayout();
            // 
            // flpKetQua
            // 
            this.flpKetQua.AutoScroll = true;
            this.flpKetQua.Location = new System.Drawing.Point(141, 351);
            this.flpKetQua.Name = "flpKetQua";
            this.flpKetQua.Size = new System.Drawing.Size(1620, 551);
            this.flpKetQua.TabIndex = 7;
            // 
            // lblSoLuongKQ
            // 
            this.lblSoLuongKQ.AutoSize = true;
            this.lblSoLuongKQ.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongKQ.Location = new System.Drawing.Point(741, 261);
            this.lblSoLuongKQ.Name = "lblSoLuongKQ";
            this.lblSoLuongKQ.Size = new System.Drawing.Size(394, 57);
            this.lblSoLuongKQ.TabIndex = 6;
            this.lblSoLuongKQ.Text = "There are x results";
            // 
            // ucEmpHeader1
            // 
            this.ucEmpHeader1.BackColor = System.Drawing.Color.Coral;
            this.ucEmpHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucEmpHeader1.Location = new System.Drawing.Point(-8, 51);
            this.ucEmpHeader1.Name = "ucEmpHeader1";
            this.ucEmpHeader1.Size = new System.Drawing.Size(1920, 120);
            this.ucEmpHeader1.TabIndex = 8;
            // 
            // thanhTimKiem1
            // 
            this.thanhTimKiem1.Location = new System.Drawing.Point(-9, 191);
            this.thanhTimKiem1.Name = "thanhTimKiem1";
            this.thanhTimKiem1.Size = new System.Drawing.Size(1920, 60);
            this.thanhTimKiem1.TabIndex = 5;
            // 
            // FMyPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.ucEmpHeader1);
            this.Controls.Add(this.flpKetQua);
            this.Controls.Add(this.lblSoLuongKQ);
            this.Controls.Add(this.thanhTimKiem1);
            this.Name = "FMyPosts";
            this.Text = "FMyPosts";
            this.Load += new System.EventHandler(this.FMyPosts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpKetQua;
        private System.Windows.Forms.Label lblSoLuongKQ;
        private UCSearchBar thanhTimKiem1;
        private UCEmpHeader ucEmpHeader1;
    }
}