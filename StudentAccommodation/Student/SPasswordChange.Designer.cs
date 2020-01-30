namespace StudentAccommodation.Student
{
    partial class SPasswordChange
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNewConfirmPassNotMatch = new System.Windows.Forms.Label();
            this.lblOldPassNotMatch = new System.Windows.Forms.Label();
            this.lblEnterOldPass = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNewConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblNewConfirmPassNotMatch);
            this.panel1.Controls.Add(this.lblOldPassNotMatch);
            this.panel1.Controls.Add(this.lblEnterOldPass);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtNewConfirmPassword);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Controls.Add(this.txtOldPassword);
            this.panel1.Controls.Add(this.lblConfirmNewPass);
            this.panel1.Controls.Add(this.lblNewPass);
            this.panel1.Controls.Add(this.lblOldPass);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 275);
            this.panel1.TabIndex = 1;
            // 
            // lblNewConfirmPassNotMatch
            // 
            this.lblNewConfirmPassNotMatch.AutoSize = true;
            this.lblNewConfirmPassNotMatch.ForeColor = System.Drawing.Color.Red;
            this.lblNewConfirmPassNotMatch.Location = new System.Drawing.Point(183, 174);
            this.lblNewConfirmPassNotMatch.Name = "lblNewConfirmPassNotMatch";
            this.lblNewConfirmPassNotMatch.Size = new System.Drawing.Size(107, 13);
            this.lblNewConfirmPassNotMatch.TabIndex = 11;
            this.lblNewConfirmPassNotMatch.Text = "*Password not match";
            // 
            // lblOldPassNotMatch
            // 
            this.lblOldPassNotMatch.AutoSize = true;
            this.lblOldPassNotMatch.ForeColor = System.Drawing.Color.Red;
            this.lblOldPassNotMatch.Location = new System.Drawing.Point(183, 73);
            this.lblOldPassNotMatch.Name = "lblOldPassNotMatch";
            this.lblOldPassNotMatch.Size = new System.Drawing.Size(107, 13);
            this.lblOldPassNotMatch.TabIndex = 9;
            this.lblOldPassNotMatch.Text = "*Password not match";
            // 
            // lblEnterOldPass
            // 
            this.lblEnterOldPass.AutoSize = true;
            this.lblEnterOldPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnterOldPass.ForeColor = System.Drawing.Color.Red;
            this.lblEnterOldPass.Location = new System.Drawing.Point(183, 73);
            this.lblEnterOldPass.Name = "lblEnterOldPass";
            this.lblEnterOldPass.Size = new System.Drawing.Size(140, 13);
            this.lblEnterOldPass.TabIndex = 8;
            this.lblEnterOldPass.Text = "*Please enter OLD passwod";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(315, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 37);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(86, 203);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 37);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNewConfirmPassword
            // 
            this.txtNewConfirmPassword.Location = new System.Drawing.Point(186, 146);
            this.txtNewConfirmPassword.Multiline = true;
            this.txtNewConfirmPassword.Name = "txtNewConfirmPassword";
            this.txtNewConfirmPassword.PasswordChar = '*';
            this.txtNewConfirmPassword.Size = new System.Drawing.Size(283, 25);
            this.txtNewConfirmPassword.TabIndex = 5;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(186, 96);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(283, 25);
            this.txtNewPassword.TabIndex = 4;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(186, 42);
            this.txtOldPassword.Multiline = true;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(283, 25);
            this.txtOldPassword.TabIndex = 3;
            // 
            // lblConfirmNewPass
            // 
            this.lblConfirmNewPass.AutoSize = true;
            this.lblConfirmNewPass.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPass.Location = new System.Drawing.Point(28, 148);
            this.lblConfirmNewPass.Name = "lblConfirmNewPass";
            this.lblConfirmNewPass.Size = new System.Drawing.Size(155, 20);
            this.lblConfirmNewPass.TabIndex = 2;
            this.lblConfirmNewPass.Text = "Confirm New Password :";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(80, 98);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(103, 20);
            this.lblNewPass.TabIndex = 1;
            this.lblNewPass.Text = "New Password :";
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPass.Location = new System.Drawing.Point(80, 44);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(100, 20);
            this.lblOldPass.TabIndex = 0;
            this.lblOldPass.Text = "Old Password :";
            // 
            // SPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 276);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "SPasswordChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordChange";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SPasswordChange_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNewConfirmPassNotMatch;
        private System.Windows.Forms.Label lblOldPassNotMatch;
        private System.Windows.Forms.Label lblEnterOldPass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNewConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblConfirmNewPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblOldPass;
    }
}