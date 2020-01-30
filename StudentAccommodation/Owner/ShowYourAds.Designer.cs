namespace StudentAccommodation.Owner
{
    partial class ShowYourAds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowYourAds));
            this.pnlShowAds = new System.Windows.Forms.Panel();
            this.dgvShowAds = new System.Windows.Forms.DataGridView();
            this.AdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAd = new System.Windows.Forms.ComboBox();
            this.lblAdvertise = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlShowAds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAds)).BeginInit();
            this.pnlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShowAds
            // 
            this.pnlShowAds.Controls.Add(this.dgvShowAds);
            this.pnlShowAds.Controls.Add(this.pnlPanel);
            this.pnlShowAds.Location = new System.Drawing.Point(0, 0);
            this.pnlShowAds.Name = "pnlShowAds";
            this.pnlShowAds.Size = new System.Drawing.Size(834, 511);
            this.pnlShowAds.TabIndex = 0;
            // 
            // dgvShowAds
            // 
            this.dgvShowAds.AllowUserToAddRows = false;
            this.dgvShowAds.AllowUserToDeleteRows = false;
            this.dgvShowAds.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvShowAds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvShowAds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdID,
            this.txtTitle,
            this.txtStatus,
            this.txtRent,
            this.txtArea,
            this.txtDate});
            this.dgvShowAds.Location = new System.Drawing.Point(3, 106);
            this.dgvShowAds.Name = "dgvShowAds";
            this.dgvShowAds.ReadOnly = true;
            this.dgvShowAds.Size = new System.Drawing.Size(828, 402);
            this.dgvShowAds.TabIndex = 1;
            this.dgvShowAds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowAds_CellClick);
            // 
            // AdID
            // 
            this.AdID.DataPropertyName = "flatid, messid, subletid";
            this.AdID.HeaderText = "Ad ID";
            this.AdID.Name = "AdID";
            this.AdID.ReadOnly = true;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtTitle.DataPropertyName = "title";
            this.txtTitle.HeaderText = "Title";
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            // 
            // txtStatus
            // 
            this.txtStatus.DataPropertyName = "status";
            this.txtStatus.HeaderText = "Status";
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            // 
            // txtRent
            // 
            this.txtRent.DataPropertyName = "rent";
            this.txtRent.HeaderText = "Rent";
            this.txtRent.Name = "txtRent";
            this.txtRent.ReadOnly = true;
            // 
            // txtArea
            // 
            this.txtArea.DataPropertyName = "area";
            this.txtArea.HeaderText = "Area";
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            // 
            // txtDate
            // 
            this.txtDate.DataPropertyName = "date";
            this.txtDate.HeaderText = "Date";
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            // 
            // pnlPanel
            // 
            this.pnlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPanel.BackgroundImage")));
            this.pnlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlPanel.Controls.Add(this.label1);
            this.pnlPanel.Controls.Add(this.cmbAd);
            this.pnlPanel.Controls.Add(this.lblAdvertise);
            this.pnlPanel.Controls.Add(this.btnBack);
            this.pnlPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(834, 100);
            this.pnlPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad Category : ";
            // 
            // cmbAd
            // 
            this.cmbAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAd.FormattingEnabled = true;
            this.cmbAd.Items.AddRange(new object[] {
            "---Select One---",
            "       Flat Ads",
            "      Mess Ads",
            "     Sublet Ads"});
            this.cmbAd.Location = new System.Drawing.Point(194, 72);
            this.cmbAd.Name = "cmbAd";
            this.cmbAd.Size = new System.Drawing.Size(117, 24);
            this.cmbAd.TabIndex = 2;
            this.cmbAd.SelectedIndexChanged += new System.EventHandler(this.cmbAd_SelectedIndexChanged);
            // 
            // lblAdvertise
            // 
            this.lblAdvertise.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvertise.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertise.ForeColor = System.Drawing.Color.Black;
            this.lblAdvertise.Location = new System.Drawing.Point(306, 26);
            this.lblAdvertise.Name = "lblAdvertise";
            this.lblAdvertise.Size = new System.Drawing.Size(233, 31);
            this.lblAdvertise.TabIndex = 1;
            this.lblAdvertise.Text = "Your Advertise...";
            this.lblAdvertise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(25, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 36);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ShowYourAds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.pnlShowAds);
            this.Name = "ShowYourAds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowYourAds";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowYourAds_FormClosing);
            this.pnlShowAds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAds)).EndInit();
            this.pnlPanel.ResumeLayout(false);
            this.pnlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShowAds;
        private System.Windows.Forms.Panel pnlPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAdvertise;
        private System.Windows.Forms.DataGridView dgvShowAds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDate;
    }
}