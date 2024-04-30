namespace JobApplication
{
    partial class FAllPosts
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
            this.lblSoLuongKQ = new System.Windows.Forms.Label();
            this.flpKetQua = new System.Windows.Forms.FlowLayoutPanel();
            this.thanhTimKiem1 = new JobApplication.UCSearchBar();
            this.header1 = new JobApplication.UCSeekHeader();
            this.SuspendLayout();
            // 
            // lblSoLuongKQ
            // 
            this.lblSoLuongKQ.AutoSize = true;
            this.lblSoLuongKQ.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongKQ.Location = new System.Drawing.Point(750, 210);
            this.lblSoLuongKQ.Name = "lblSoLuongKQ";
            this.lblSoLuongKQ.Size = new System.Drawing.Size(394, 57);
            this.lblSoLuongKQ.TabIndex = 2;
            this.lblSoLuongKQ.Text = "There are x results";
            // 
            // flpKetQua
            // 
            this.flpKetQua.AutoScroll = true;
            this.flpKetQua.Location = new System.Drawing.Point(150, 300);
            this.flpKetQua.Name = "flpKetQua";
            this.flpKetQua.Size = new System.Drawing.Size(1620, 630);
            this.flpKetQua.TabIndex = 3;
            // 
            // thanhTimKiem1
            // 
            this.thanhTimKiem1.Location = new System.Drawing.Point(0, 140);
            this.thanhTimKiem1.Name = "thanhTimKiem1";
            this.thanhTimKiem1.Size = new System.Drawing.Size(1920, 60);
            this.thanhTimKiem1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.Location = new System.Drawing.Point(1, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1920, 120);
            this.header1.TabIndex = 0;
            // 
            // FAllPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.flpKetQua);
            this.Controls.Add(this.lblSoLuongKQ);
            this.Controls.Add(this.thanhTimKiem1);
            this.Controls.Add(this.header1);
            this.Name = "FTinTuyenDung";
            this.Load += new System.EventHandler(this.FAllPost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCSeekHeader header1;
        private UCSearchBar thanhTimKiem1;
        private System.Windows.Forms.Label lblSoLuongKQ;
        private System.Windows.Forms.FlowLayoutPanel flpKetQua;
    }
}