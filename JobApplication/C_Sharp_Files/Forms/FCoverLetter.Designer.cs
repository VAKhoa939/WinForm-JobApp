namespace JobApplication
{
    partial class FCoverLetter
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
            this.lblCover = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCover
            // 
            this.lblCover.AllowDrop = true;
            this.lblCover.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCover.Location = new System.Drawing.Point(12, 9);
            this.lblCover.Name = "lblCover";
            this.lblCover.Size = new System.Drawing.Size(776, 432);
            this.lblCover.TabIndex = 1;
            this.lblCover.Text = "label1";
            // 
            // FCoverLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCover);
            this.Name = "FCoverLetter";
            this.Text = "FCoverLetter";
            this.Load += new System.EventHandler(this.FCoverLetter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCover;
    }
}