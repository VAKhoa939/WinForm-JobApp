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
            this.ucSearchBar1 = new JobApplication.UCSearchBar();
            this.ucSeekHeader1 = new JobApplication.UCSeekHeader();
            this.SuspendLayout();
            // 
            // lblSoLuongKQ
            // 
            this.lblSoLuongKQ.AutoSize = true;
            this.lblSoLuongKQ.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongKQ.Location = new System.Drawing.Point(676, 196);
            this.lblSoLuongKQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongKQ.Name = "lblSoLuongKQ";
            this.lblSoLuongKQ.Size = new System.Drawing.Size(311, 46);
            this.lblSoLuongKQ.TabIndex = 2;
            this.lblSoLuongKQ.Text = "There are x results";
            // 
            // flpKetQua
            // 
            this.flpKetQua.AutoScroll = true;
            this.flpKetQua.Location = new System.Drawing.Point(100, 270);
            this.flpKetQua.Margin = new System.Windows.Forms.Padding(2);
            this.flpKetQua.Name = "flpKetQua";
            this.flpKetQua.Size = new System.Drawing.Size(1420, 550);
            this.flpKetQua.TabIndex = 3;
            // 
            // ucSearchBar1
            // 
            this.ucSearchBar1.Location = new System.Drawing.Point(0, 121);
            this.ucSearchBar1.Margin = new System.Windows.Forms.Padding(2);
            this.ucSearchBar1.Name = "ucSearchBar1";
            this.ucSearchBar1.Size = new System.Drawing.Size(1620, 49);
            this.ucSearchBar1.TabIndex = 4;
            // 
            // ucSeekHeader1
            // 
            this.ucSeekHeader1.BackColor = System.Drawing.Color.Coral;
            this.ucSeekHeader1.Location = new System.Drawing.Point(1, 0);
            this.ucSeekHeader1.Margin = new System.Windows.Forms.Padding(2);
            this.ucSeekHeader1.Name = "ucSeekHeader1";
            this.ucSeekHeader1.Size = new System.Drawing.Size(1620, 98);
            this.ucSeekHeader1.TabIndex = 0;
            // 
            // FAllPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.ucSearchBar1);
            this.Controls.Add(this.flpKetQua);
            this.Controls.Add(this.lblSoLuongKQ);
            this.Controls.Add(this.ucSeekHeader1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FAllPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FAllPost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSoLuongKQ;
        private System.Windows.Forms.FlowLayoutPanel flpKetQua;
        public UCSeekHeader ucSeekHeader1;
        private UCSearchBar ucSearchBar1;
    }
}