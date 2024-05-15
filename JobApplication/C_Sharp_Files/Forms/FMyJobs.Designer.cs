namespace JobApplication
{
    partial class FMyJobs
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
            this.ucSeekHeader1 = new JobApplication.UCSeekHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flpAccepted = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flpDenied = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpWaiting = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFormnum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucSeekHeader1
            // 
            this.ucSeekHeader1.BackColor = System.Drawing.Color.Coral;
            this.ucSeekHeader1.Location = new System.Drawing.Point(0, 0);
            this.ucSeekHeader1.Margin = new System.Windows.Forms.Padding(2);
            this.ucSeekHeader1.Name = "ucSeekHeader1";
            this.ucSeekHeader1.Size = new System.Drawing.Size(1620, 98);
            this.ucSeekHeader1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblFormnum);
            this.panel1.Location = new System.Drawing.Point(100, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 639);
            this.panel1.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.flpAccepted);
            this.panel4.Location = new System.Drawing.Point(500, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 510);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Accepted";
            // 
            // flpAccepted
            // 
            this.flpAccepted.AutoScroll = true;
            this.flpAccepted.Location = new System.Drawing.Point(2, 94);
            this.flpAccepted.Margin = new System.Windows.Forms.Padding(2);
            this.flpAccepted.Name = "flpAccepted";
            this.flpAccepted.Size = new System.Drawing.Size(414, 414);
            this.flpAccepted.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.flpDenied);
            this.panel3.Location = new System.Drawing.Point(966, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 510);
            this.panel3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Denied";
            // 
            // flpDenied
            // 
            this.flpDenied.AutoScroll = true;
            this.flpDenied.Location = new System.Drawing.Point(2, 94);
            this.flpDenied.Margin = new System.Windows.Forms.Padding(2);
            this.flpDenied.Name = "flpDenied";
            this.flpDenied.Size = new System.Drawing.Size(414, 414);
            this.flpDenied.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.flpWaiting);
            this.panel2.Location = new System.Drawing.Point(30, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 510);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Waiting";
            // 
            // flpWaiting
            // 
            this.flpWaiting.AutoScroll = true;
            this.flpWaiting.Location = new System.Drawing.Point(2, 94);
            this.flpWaiting.Margin = new System.Windows.Forms.Padding(2);
            this.flpWaiting.Name = "flpWaiting";
            this.flpWaiting.Size = new System.Drawing.Size(414, 414);
            this.flpWaiting.TabIndex = 7;
            // 
            // lblFormnum
            // 
            this.lblFormnum.AutoSize = true;
            this.lblFormnum.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormnum.Location = new System.Drawing.Point(506, 22);
            this.lblFormnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormnum.Name = "lblFormnum";
            this.lblFormnum.Size = new System.Drawing.Size(410, 46);
            this.lblFormnum.TabIndex = 6;
            this.lblFormnum.Text = "You have applied X jobs";
            // 
            // FMyJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JobApplication.Properties.Resources.Nitro_Wallpaper_5000x2813;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucSeekHeader1);
            this.Name = "FMyJobs";
            this.Text = "FMyJobs";
            this.Load += new System.EventHandler(this.FMyJobs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UCSeekHeader ucSeekHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFormnum;
        private System.Windows.Forms.FlowLayoutPanel flpWaiting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flpAccepted;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpDenied;
        private System.Windows.Forms.Label label3;
    }
}