namespace StudentAccommodation.Admin
{
    partial class AdminMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainPage));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.btnAdminProfile = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.cmbHouse = new System.Windows.Forms.ComboBox();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLogo.Controls.Add(this.lblProfile);
            this.pnlLogo.Controls.Add(this.lblLogOut);
            this.pnlLogo.Controls.Add(this.btnAdminProfile);
            this.pnlLogo.Controls.Add(this.btnLogOut);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(833, 100);
            this.pnlLogo.TabIndex = 1;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(720, 30);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(36, 13);
            this.lblProfile.TabIndex = 9;
            this.lblProfile.Text = "Profile";
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Location = new System.Drawing.Point(770, 30);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(42, 13);
            this.lblLogOut.TabIndex = 8;
            this.lblLogOut.Text = "LogOut";
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminProfile.FlatAppearance.BorderSize = 0;
            this.btnAdminProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdminProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdminProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminProfile.Image")));
            this.btnAdminProfile.Location = new System.Drawing.Point(718, 46);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Size = new System.Drawing.Size(38, 38);
            this.btnAdminProfile.TabIndex = 1;
            this.btnAdminProfile.UseVisualStyleBackColor = false;
            this.btnAdminProfile.Click += new System.EventHandler(this.btnAdminProfile_Click);
            this.btnAdminProfile.MouseEnter += new System.EventHandler(this.btnAdminProfile_MouseEnter);
            this.btnAdminProfile.MouseLeave += new System.EventHandler(this.btnAdminProfile_MouseLeave);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(774, 46);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(38, 38);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogOut_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.SystemColors.Window;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(267, 155);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(290, 55);
            this.btnStudent.TabIndex = 54;
            this.btnStudent.Text = "Student Details";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.BackColor = System.Drawing.SystemColors.Window;
            this.btnOwner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOwner.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwner.Location = new System.Drawing.Point(267, 258);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(290, 55);
            this.btnOwner.TabIndex = 55;
            this.btnOwner.Text = "Owner Details";
            this.btnOwner.UseVisualStyleBackColor = false;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // cmbHouse
            // 
            this.cmbHouse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHouse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHouse.FormattingEnabled = true;
            this.cmbHouse.ItemHeight = 37;
            this.cmbHouse.Items.AddRange(new object[] {
            "     House Details",
            "     Flat Details",
            "     Mess Details",
            "     Sublet Details"});
            this.cmbHouse.Location = new System.Drawing.Point(267, 371);
            this.cmbHouse.Name = "cmbHouse";
            this.cmbHouse.Size = new System.Drawing.Size(290, 45);
            this.cmbHouse.TabIndex = 56;
            this.cmbHouse.SelectedIndexChanged += new System.EventHandler(this.cmbHouse_SelectedIndexChanged);
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.cmbHouse);
            this.Controls.Add(this.btnOwner);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.pnlLogo);
            this.MaximizeBox = false;
            this.Name = "AdminMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMainPage_FormClosing);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.ComboBox cmbHouse;
    }
}