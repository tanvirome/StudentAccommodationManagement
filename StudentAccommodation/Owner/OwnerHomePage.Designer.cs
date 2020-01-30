namespace StudentAccommodation.Owner
{
    partial class OwnerHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerHomePage));
            this.lblVarificationCheck = new System.Windows.Forms.Label();
            this.lblShowAds = new System.Windows.Forms.Label();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnMess = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSublet = new System.Windows.Forms.Button();
            this.btnFlat = new System.Windows.Forms.Button();
            this.pnlHome.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVarificationCheck
            // 
            this.lblVarificationCheck.AutoSize = true;
            this.lblVarificationCheck.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarificationCheck.ForeColor = System.Drawing.Color.Red;
            this.lblVarificationCheck.Location = new System.Drawing.Point(281, 114);
            this.lblVarificationCheck.Name = "lblVarificationCheck";
            this.lblVarificationCheck.Size = new System.Drawing.Size(288, 16);
            this.lblVarificationCheck.TabIndex = 1;
            this.lblVarificationCheck.Text = "***Please give all details and wait 48 hours for verification***";
            // 
            // lblShowAds
            // 
            this.lblShowAds.AutoSize = true;
            this.lblShowAds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowAds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAds.Location = new System.Drawing.Point(320, 443);
            this.lblShowAds.Name = "lblShowAds";
            this.lblShowAds.Size = new System.Drawing.Size(200, 31);
            this.lblShowAds.TabIndex = 6;
            this.lblShowAds.Text = "Show Your Ads";
            this.lblShowAds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShowAds.Click += new System.EventHandler(this.lblShowAds_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.btnMess);
            this.pnlHome.Controls.Add(this.lblCategory);
            this.pnlHome.Controls.Add(this.panel1);
            this.pnlHome.Location = new System.Drawing.Point(1, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(833, 512);
            this.pnlHome.TabIndex = 9;
            // 
            // btnMess
            // 
            this.btnMess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMess.FlatAppearance.BorderSize = 0;
            this.btnMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMess.Image = ((System.Drawing.Image)(resources.GetObject("btnMess.Image")));
            this.btnMess.Location = new System.Drawing.Point(334, 250);
            this.btnMess.Name = "btnMess";
            this.btnMess.Size = new System.Drawing.Size(185, 160);
            this.btnMess.TabIndex = 7;
            this.btnMess.UseVisualStyleBackColor = true;
            this.btnMess.Click += new System.EventHandler(this.btnMess_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Image = ((System.Drawing.Image)(resources.GetObject("lblCategory.Image")));
            this.lblCategory.Location = new System.Drawing.Point(269, 150);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(304, 69);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.lblProfile);
            this.panel1.Controls.Add(this.lblLogOut);
            this.panel1.Controls.Add(this.btnUserProfile);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 100);
            this.panel1.TabIndex = 0;
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
            // btnUserProfile
            // 
            this.btnUserProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnUserProfile.FlatAppearance.BorderSize = 0;
            this.btnUserProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUserProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnUserProfile.Image")));
            this.btnUserProfile.Location = new System.Drawing.Point(718, 46);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(38, 38);
            this.btnUserProfile.TabIndex = 1;
            this.btnUserProfile.UseVisualStyleBackColor = false;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
            this.btnUserProfile.MouseEnter += new System.EventHandler(this.btnUserProfile_MouseEnter);
            this.btnUserProfile.MouseLeave += new System.EventHandler(this.btnUserProfile_MouseLeave);
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
            // btnSublet
            // 
            this.btnSublet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSublet.FlatAppearance.BorderSize = 0;
            this.btnSublet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSublet.Image = ((System.Drawing.Image)(resources.GetObject("btnSublet.Image")));
            this.btnSublet.Location = new System.Drawing.Point(582, 251);
            this.btnSublet.Name = "btnSublet";
            this.btnSublet.Size = new System.Drawing.Size(185, 160);
            this.btnSublet.TabIndex = 8;
            this.btnSublet.UseVisualStyleBackColor = true;
            this.btnSublet.Click += new System.EventHandler(this.btnSublet_Click);
            // 
            // btnFlat
            // 
            this.btnFlat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlat.FlatAppearance.BorderSize = 0;
            this.btnFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlat.Image = ((System.Drawing.Image)(resources.GetObject("btnFlat.Image")));
            this.btnFlat.Location = new System.Drawing.Point(70, 251);
            this.btnFlat.Name = "btnFlat";
            this.btnFlat.Size = new System.Drawing.Size(185, 160);
            this.btnFlat.TabIndex = 3;
            this.btnFlat.UseVisualStyleBackColor = true;
            this.btnFlat.Click += new System.EventHandler(this.btnFlat_Click);
            // 
            // OwnerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnSublet);
            this.Controls.Add(this.lblShowAds);
            this.Controls.Add(this.btnFlat);
            this.Controls.Add(this.lblVarificationCheck);
            this.Controls.Add(this.pnlHome);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "OwnerHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OwnerHomePage_FormClosing);
            this.pnlHome.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVarificationCheck;
        private System.Windows.Forms.Button btnFlat;
        private System.Windows.Forms.Label lblShowAds;
        private System.Windows.Forms.Button btnMess;
        private System.Windows.Forms.Button btnSublet;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblLogOut;
    }
}