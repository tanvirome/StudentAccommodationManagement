namespace StudentAccommodation
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termsPolicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnLogInStudent = new System.Windows.Forms.RadioButton();
            this.rbtnLogInOwner = new System.Windows.Forms.RadioButton();
            this.txtLogInUserName = new System.Windows.Forms.TextBox();
            this.txtLogInPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.chkLogInShowPass = new System.Windows.Forms.CheckBox();
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.label02 = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.LinkLabel();
            this.label01 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termsPolicyToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // termsPolicyToolStripMenuItem
            // 
            this.termsPolicyToolStripMenuItem.Name = "termsPolicyToolStripMenuItem";
            this.termsPolicyToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.termsPolicyToolStripMenuItem.Text = "Terms and Conditions";
            this.termsPolicyToolStripMenuItem.Click += new System.EventHandler(this.termsPolicyToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(257, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In To Your Account";
            // 
            // rbtnLogInStudent
            // 
            this.rbtnLogInStudent.AutoSize = true;
            this.rbtnLogInStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLogInStudent.Location = new System.Drawing.Point(263, 203);
            this.rbtnLogInStudent.Name = "rbtnLogInStudent";
            this.rbtnLogInStudent.Size = new System.Drawing.Size(71, 20);
            this.rbtnLogInStudent.TabIndex = 1;
            this.rbtnLogInStudent.TabStop = true;
            this.rbtnLogInStudent.Text = "Student";
            this.rbtnLogInStudent.UseVisualStyleBackColor = true;
            this.rbtnLogInStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtnLogInStudent_KeyPress);
            // 
            // rbtnLogInOwner
            // 
            this.rbtnLogInOwner.AutoSize = true;
            this.rbtnLogInOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLogInOwner.Location = new System.Drawing.Point(355, 203);
            this.rbtnLogInOwner.Name = "rbtnLogInOwner";
            this.rbtnLogInOwner.Size = new System.Drawing.Size(107, 20);
            this.rbtnLogInOwner.TabIndex = 2;
            this.rbtnLogInOwner.TabStop = true;
            this.rbtnLogInOwner.Text = "House Owner";
            this.rbtnLogInOwner.UseVisualStyleBackColor = true;
            this.rbtnLogInOwner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtnLogInOwner_KeyPress);
            // 
            // txtLogInUserName
            // 
            this.txtLogInUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogInUserName.ForeColor = System.Drawing.Color.Black;
            this.txtLogInUserName.Location = new System.Drawing.Point(258, 238);
            this.txtLogInUserName.Name = "txtLogInUserName";
            this.txtLogInUserName.Size = new System.Drawing.Size(340, 30);
            this.txtLogInUserName.TabIndex = 3;
            this.txtLogInUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogInUserName_KeyPress);
            // 
            // txtLogInPassword
            // 
            this.txtLogInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogInPassword.ForeColor = System.Drawing.Color.Black;
            this.txtLogInPassword.Location = new System.Drawing.Point(260, 290);
            this.txtLogInPassword.Multiline = true;
            this.txtLogInPassword.Name = "txtLogInPassword";
            this.txtLogInPassword.PasswordChar = '*';
            this.txtLogInPassword.Size = new System.Drawing.Size(338, 30);
            this.txtLogInPassword.TabIndex = 4;
            this.txtLogInPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogInPassword_KeyPress);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogIn.Location = new System.Drawing.Point(329, 374);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(158, 41);
            this.btnLogIn.TabIndex = 6;
            this.btnLogIn.Text = "LogIn";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            this.btnLogIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLogIn_KeyPress);
            // 
            // chkLogInShowPass
            // 
            this.chkLogInShowPass.AutoSize = true;
            this.chkLogInShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLogInShowPass.Location = new System.Drawing.Point(260, 339);
            this.chkLogInShowPass.Name = "chkLogInShowPass";
            this.chkLogInShowPass.Size = new System.Drawing.Size(114, 19);
            this.chkLogInShowPass.TabIndex = 5;
            this.chkLogInShowPass.Text = "Show Password";
            this.chkLogInShowPass.UseVisualStyleBackColor = true;
            this.chkLogInShowPass.CheckedChanged += new System.EventHandler(this.chkLogInShowPass_CheckedChanged);
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.BackColor = System.Drawing.Color.MintCream;
            this.pnlLogIn.Controls.Add(this.label02);
            this.pnlLogIn.Controls.Add(this.lblSignUp);
            this.pnlLogIn.Controls.Add(this.label01);
            this.pnlLogIn.Controls.Add(this.lblPassword);
            this.pnlLogIn.Controls.Add(this.lblUsername);
            this.pnlLogIn.Controls.Add(this.rbtnLogInOwner);
            this.pnlLogIn.Controls.Add(this.label1);
            this.pnlLogIn.Controls.Add(this.txtLogInUserName);
            this.pnlLogIn.Controls.Add(this.btnLogIn);
            this.pnlLogIn.Controls.Add(this.rbtnLogInStudent);
            this.pnlLogIn.Controls.Add(this.chkLogInShowPass);
            this.pnlLogIn.Controls.Add(this.txtLogInPassword);
            this.pnlLogIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlLogIn.Location = new System.Drawing.Point(0, 25);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(834, 487);
            this.pnlLogIn.TabIndex = 44;
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label02.Location = new System.Drawing.Point(454, 437);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(53, 20);
            this.label02.TabIndex = 11;
            this.label02.Text = "here...";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(395, 437);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(62, 20);
            this.lblSignUp.TabIndex = 10;
            this.lblSignUp.TabStop = true;
            this.lblSignUp.Text = "SignUp";
            this.lblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSignUp_LinkClicked);
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label01.Location = new System.Drawing.Point(304, 437);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(94, 20);
            this.label01.TabIndex = 9;
            this.label01.Text = "New User!!! ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(165, 296);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(84, 16);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(162, 244);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 16);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username :";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLogo.Location = new System.Drawing.Point(0, 25);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(834, 100);
            this.pnlLogo.TabIndex = 1;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlLogIn);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termsPolicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnLogInStudent;
        private System.Windows.Forms.RadioButton rbtnLogInOwner;
        private System.Windows.Forms.TextBox txtLogInUserName;
        private System.Windows.Forms.TextBox txtLogInPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.CheckBox chkLogInShowPass;
        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.LinkLabel lblSignUp;
        private System.Windows.Forms.Label label01;
    }
}

