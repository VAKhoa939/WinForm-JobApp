﻿namespace JobApplication
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
            this.ucEmpHeader1 = new JobApplication.UCEmpHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucSearchBar1 = new JobApplication.UCSearchBar();
            this.lblSoLuongKQ = new System.Windows.Forms.Label();
            this.flpKetQua = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucEmpHeader1
            // 
            this.ucEmpHeader1.BackColor = System.Drawing.Color.Coral;
            this.ucEmpHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucEmpHeader1.Location = new System.Drawing.Point(0, 0);
            this.ucEmpHeader1.Margin = new System.Windows.Forms.Padding(2);
            this.ucEmpHeader1.Name = "ucEmpHeader1";
            this.ucEmpHeader1.Size = new System.Drawing.Size(1620, 98);
            this.ucEmpHeader1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucSearchBar1);
            this.panel1.Controls.Add(this.lblSoLuongKQ);
            this.panel1.Controls.Add(this.flpKetQua);
            this.panel1.Location = new System.Drawing.Point(238, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 692);
            this.panel1.TabIndex = 13;
            // 
            // ucSearchBar1
            // 
            this.ucSearchBar1.Location = new System.Drawing.Point(116, 2);
            this.ucSearchBar1.Margin = new System.Windows.Forms.Padding(2);
            this.ucSearchBar1.Name = "ucSearchBar1";
            this.ucSearchBar1.Size = new System.Drawing.Size(925, 42);
            this.ucSearchBar1.TabIndex = 13;
            // 
            // lblSoLuongKQ
            // 
            this.lblSoLuongKQ.AutoSize = true;
            this.lblSoLuongKQ.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongKQ.Location = new System.Drawing.Point(423, 59);
            this.lblSoLuongKQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongKQ.Name = "lblSoLuongKQ";
            this.lblSoLuongKQ.Size = new System.Drawing.Size(311, 46);
            this.lblSoLuongKQ.TabIndex = 6;
            this.lblSoLuongKQ.Text = "There are x results";
            // 
            // flpKetQua
            // 
            this.flpKetQua.AutoScroll = true;
            this.flpKetQua.Location = new System.Drawing.Point(14, 125);
            this.flpKetQua.Margin = new System.Windows.Forms.Padding(2);
            this.flpKetQua.Name = "flpKetQua";
            this.flpKetQua.Size = new System.Drawing.Size(1120, 550);
            this.flpKetQua.TabIndex = 7;
            // 
            // FMyPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::JobApplication.Properties.Resources.Nitro_Wallpaper_5000x2813;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucEmpHeader1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FMyPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMyPosts";
            this.Load += new System.EventHandler(this.FMyPosts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public UCEmpHeader ucEmpHeader1;
        private System.Windows.Forms.Panel panel1;
        private UCSearchBar ucSearchBar1;
        private System.Windows.Forms.Label lblSoLuongKQ;
        private System.Windows.Forms.FlowLayoutPanel flpKetQua;
    }
}