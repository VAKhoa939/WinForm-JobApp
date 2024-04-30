using System.Drawing;

namespace JobApplication
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.tbLogin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.rdoEmployerLogin = new System.Windows.Forms.RadioButton();
            this.rdoJobSeekerLogin = new System.Windows.Forms.RadioButton();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.txtUserNameLogin = new System.Windows.Forms.TextBox();
            this.lblUserNameLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.txtPhoneNumberJS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmailJS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstNameJS = new System.Windows.Forms.TextBox();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.txtPasswordRepeatJS = new System.Windows.Forms.TextBox();
            this.txtPasswordJS = new System.Windows.Forms.TextBox();
            this.txtLastNameJS = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnJSRegister = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserNameJobSeeker = new System.Windows.Forms.Label();
            this.txtUserNameJS = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCompanyNameEmp = new System.Windows.Forms.Label();
            this.txtCompanyNameEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepeatPasswordEmp = new System.Windows.Forms.TextBox();
            this.txtPhoneNumberEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordEmp = new System.Windows.Forms.TextBox();
            this.txtLastNameEmp = new System.Windows.Forms.TextBox();
            this.txtUserNameEmp = new System.Windows.Forms.TextBox();
            this.txtEmailEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEmployerRegister = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFirstNameEmp = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picComLogo = new System.Windows.Forms.PictureBox();
            this.btnComChooseimage = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCompRegister = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCompanyNameComp = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbLogin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.AllowDrop = true;
            this.tbLogin.Controls.Add(this.tabPage1);
            this.tbLogin.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tbLogin, "tbLogin");
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.SelectedIndex = 0;
            this.tbLogin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage1.Controls.Add(this.pnlLogin);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.rdoEmployerLogin);
            this.pnlLogin.Controls.Add(this.rdoJobSeekerLogin);
            this.pnlLogin.Controls.Add(this.txtPasswordLogin);
            this.pnlLogin.Controls.Add(this.txtUserNameLogin);
            this.pnlLogin.Controls.Add(this.lblUserNameLogin);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblPasswordLogin);
            this.pnlLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.pnlLogin, "pnlLogin");
            this.pnlLogin.Name = "pnlLogin";
            // 
            // rdoEmployerLogin
            // 
            resources.ApplyResources(this.rdoEmployerLogin, "rdoEmployerLogin");
            this.rdoEmployerLogin.Name = "rdoEmployerLogin";
            this.rdoEmployerLogin.UseVisualStyleBackColor = true;
            // 
            // rdoJobSeekerLogin
            // 
            resources.ApplyResources(this.rdoJobSeekerLogin, "rdoJobSeekerLogin");
            this.rdoJobSeekerLogin.Checked = true;
            this.rdoJobSeekerLogin.Name = "rdoJobSeekerLogin";
            this.rdoJobSeekerLogin.TabStop = true;
            this.rdoJobSeekerLogin.UseVisualStyleBackColor = true;
            // 
            // txtPasswordLogin
            // 
            resources.ApplyResources(this.txtPasswordLogin, "txtPasswordLogin");
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.UseSystemPasswordChar = true;
            // 
            // txtUserNameLogin
            // 
            resources.ApplyResources(this.txtUserNameLogin, "txtUserNameLogin");
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            // 
            // lblUserNameLogin
            // 
            resources.ApplyResources(this.lblUserNameLogin, "lblUserNameLogin");
            this.lblUserNameLogin.Name = "lblUserNameLogin";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSalmon;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPasswordLogin
            // 
            resources.ApplyResources(this.lblPasswordLogin, "lblPasswordLogin");
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage3.Controls.Add(this.pnlRegister);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.txtPhoneNumberJS);
            this.pnlRegister.Controls.Add(this.label10);
            this.pnlRegister.Controls.Add(this.txtEmailJS);
            this.pnlRegister.Controls.Add(this.label11);
            this.pnlRegister.Controls.Add(this.label3);
            this.pnlRegister.Controls.Add(this.label5);
            this.pnlRegister.Controls.Add(this.txtFirstNameJS);
            this.pnlRegister.Controls.Add(this.lblRepeatPassword);
            this.pnlRegister.Controls.Add(this.txtPasswordRepeatJS);
            this.pnlRegister.Controls.Add(this.txtPasswordJS);
            this.pnlRegister.Controls.Add(this.txtLastNameJS);
            this.pnlRegister.Controls.Add(this.lblEmail);
            this.pnlRegister.Controls.Add(this.btnJSRegister);
            this.pnlRegister.Controls.Add(this.lblPassword);
            this.pnlRegister.Controls.Add(this.lblUserNameJobSeeker);
            this.pnlRegister.Controls.Add(this.txtUserNameJS);
            this.pnlRegister.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pnlRegister, "pnlRegister");
            this.pnlRegister.Name = "pnlRegister";
            // 
            // txtPhoneNumberJS
            // 
            resources.ApplyResources(this.txtPhoneNumberJS, "txtPhoneNumberJS");
            this.txtPhoneNumberJS.Name = "txtPhoneNumberJS";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtEmailJS
            // 
            resources.ApplyResources(this.txtEmailJS, "txtEmailJS");
            this.txtEmailJS.Name = "txtEmailJS";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtFirstNameJS
            // 
            resources.ApplyResources(this.txtFirstNameJS, "txtFirstNameJS");
            this.txtFirstNameJS.Name = "txtFirstNameJS";
            // 
            // lblRepeatPassword
            // 
            resources.ApplyResources(this.lblRepeatPassword, "lblRepeatPassword");
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            // 
            // txtPasswordRepeatJS
            // 
            resources.ApplyResources(this.txtPasswordRepeatJS, "txtPasswordRepeatJS");
            this.txtPasswordRepeatJS.Name = "txtPasswordRepeatJS";
            this.txtPasswordRepeatJS.UseSystemPasswordChar = true;
            // 
            // txtPasswordJS
            // 
            resources.ApplyResources(this.txtPasswordJS, "txtPasswordJS");
            this.txtPasswordJS.Name = "txtPasswordJS";
            this.txtPasswordJS.UseSystemPasswordChar = true;
            // 
            // txtLastNameJS
            // 
            resources.ApplyResources(this.txtLastNameJS, "txtLastNameJS");
            this.txtLastNameJS.Name = "txtLastNameJS";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // btnJSRegister
            // 
            this.btnJSRegister.BackColor = System.Drawing.Color.LightSalmon;
            resources.ApplyResources(this.btnJSRegister, "btnJSRegister");
            this.btnJSRegister.Name = "btnJSRegister";
            this.btnJSRegister.UseVisualStyleBackColor = false;
            this.btnJSRegister.Click += new System.EventHandler(this.btnJSRegister_Click);
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // lblUserNameJobSeeker
            // 
            resources.ApplyResources(this.lblUserNameJobSeeker, "lblUserNameJobSeeker");
            this.lblUserNameJobSeeker.Name = "lblUserNameJobSeeker";
            // 
            // txtUserNameJS
            // 
            resources.ApplyResources(this.txtUserNameJS, "txtUserNameJS");
            this.txtUserNameJS.Name = "txtUserNameJS";
            // 
            // tabPage4
            // 
            this.tabPage4.AllowDrop = true;
            this.tabPage4.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage4.Controls.Add(this.panel1);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCompanyNameEmp);
            this.panel1.Controls.Add(this.txtCompanyNameEmp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRepeatPasswordEmp);
            this.panel1.Controls.Add(this.txtPhoneNumberEmp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPasswordEmp);
            this.panel1.Controls.Add(this.txtLastNameEmp);
            this.panel1.Controls.Add(this.txtUserNameEmp);
            this.panel1.Controls.Add(this.txtEmailEmp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnEmployerRegister);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtFirstNameEmp);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblCompanyNameEmp
            // 
            resources.ApplyResources(this.lblCompanyNameEmp, "lblCompanyNameEmp");
            this.lblCompanyNameEmp.Name = "lblCompanyNameEmp";
            // 
            // txtCompanyNameEmp
            // 
            resources.ApplyResources(this.txtCompanyNameEmp, "txtCompanyNameEmp");
            this.txtCompanyNameEmp.Name = "txtCompanyNameEmp";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtRepeatPasswordEmp
            // 
            resources.ApplyResources(this.txtRepeatPasswordEmp, "txtRepeatPasswordEmp");
            this.txtRepeatPasswordEmp.Name = "txtRepeatPasswordEmp";
            this.txtRepeatPasswordEmp.UseSystemPasswordChar = true;
            // 
            // txtPhoneNumberEmp
            // 
            resources.ApplyResources(this.txtPhoneNumberEmp, "txtPhoneNumberEmp");
            this.txtPhoneNumberEmp.Name = "txtPhoneNumberEmp";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtPasswordEmp
            // 
            resources.ApplyResources(this.txtPasswordEmp, "txtPasswordEmp");
            this.txtPasswordEmp.Name = "txtPasswordEmp";
            this.txtPasswordEmp.UseSystemPasswordChar = true;
            // 
            // txtLastNameEmp
            // 
            resources.ApplyResources(this.txtLastNameEmp, "txtLastNameEmp");
            this.txtLastNameEmp.Name = "txtLastNameEmp";
            // 
            // txtUserNameEmp
            // 
            resources.ApplyResources(this.txtUserNameEmp, "txtUserNameEmp");
            this.txtUserNameEmp.Name = "txtUserNameEmp";
            // 
            // txtEmailEmp
            // 
            resources.ApplyResources(this.txtEmailEmp, "txtEmailEmp");
            this.txtEmailEmp.Name = "txtEmailEmp";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // btnEmployerRegister
            // 
            this.btnEmployerRegister.BackColor = System.Drawing.Color.LightSalmon;
            resources.ApplyResources(this.btnEmployerRegister, "btnEmployerRegister");
            this.btnEmployerRegister.Name = "btnEmployerRegister";
            this.btnEmployerRegister.UseVisualStyleBackColor = false;
            this.btnEmployerRegister.Click += new System.EventHandler(this.btnEmployerRegister_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtFirstNameEmp
            // 
            resources.ApplyResources(this.txtFirstNameEmp, "txtFirstNameEmp");
            this.txtFirstNameEmp.Name = "txtFirstNameEmp";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage5.Controls.Add(this.panel2);
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picComLogo);
            this.panel2.Controls.Add(this.btnComChooseimage);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnCompRegister);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtCompanyNameComp);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // picComLogo
            // 
            resources.ApplyResources(this.picComLogo, "picComLogo");
            this.picComLogo.Name = "picComLogo";
            this.picComLogo.TabStop = false;
            // 
            // btnComChooseimage
            // 
            resources.ApplyResources(this.btnComChooseimage, "btnComChooseimage");
            this.btnComChooseimage.Name = "btnComChooseimage";
            this.btnComChooseimage.UseVisualStyleBackColor = true;
            this.btnComChooseimage.Click += new System.EventHandler(this.btnComChooseimage_Click);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // btnCompRegister
            // 
            this.btnCompRegister.BackColor = System.Drawing.Color.LightSalmon;
            resources.ApplyResources(this.btnCompRegister, "btnCompRegister");
            this.btnCompRegister.ForeColor = System.Drawing.Color.Black;
            this.btnCompRegister.Name = "btnCompRegister";
            this.btnCompRegister.UseVisualStyleBackColor = false;
            this.btnCompRegister.Click += new System.EventHandler(this.btnCompRegister_Click);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // txtCompanyNameComp
            // 
            resources.ApplyResources(this.txtCompanyNameComp, "txtCompanyNameComp");
            this.txtCompanyNameComp.Name = "txtCompanyNameComp";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbLogin);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // FLogin
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Name = "FLogin";
            this.tbLogin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbLogin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.TextBox txtUserNameLogin;
        private System.Windows.Forms.Label lblUserNameLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.TextBox txtPasswordJS;
        private System.Windows.Forms.TextBox txtLastNameJS;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnJSRegister;
        private System.Windows.Forms.Label lblUserNameJobSeeker;
        private System.Windows.Forms.TextBox txtUserNameJS;
        private System.Windows.Forms.RadioButton rdoEmployerLogin;
        private System.Windows.Forms.RadioButton rdoJobSeekerLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.TextBox txtPasswordRepeatJS;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCompanyNameEmp;
        private System.Windows.Forms.TextBox txtCompanyNameEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRepeatPasswordEmp;
        private System.Windows.Forms.TextBox txtPhoneNumberEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordEmp;
        private System.Windows.Forms.TextBox txtLastNameEmp;
        private System.Windows.Forms.TextBox txtUserNameEmp;
        private System.Windows.Forms.TextBox txtEmailEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEmployerRegister;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFirstNameEmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCompRegister;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCompanyNameComp;
        private System.Windows.Forms.PictureBox picComLogo;
        private System.Windows.Forms.Button btnComChooseimage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstNameJS;
        private System.Windows.Forms.TextBox txtPhoneNumberJS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmailJS;
        private System.Windows.Forms.Label label11;
    }
}

