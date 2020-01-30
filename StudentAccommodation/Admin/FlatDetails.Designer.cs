namespace StudentAccommodation.Admin
{
    partial class FlatDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlatDetails));
            this.btnUnverified = new System.Windows.Forms.Button();
            this.btnVerified = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.dgvFlat = new System.Windows.Forms.DataGridView();
            this.FlatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtFlatID = new System.Windows.Forms.TextBox();
            this.lblFlatID = new System.Windows.Forms.Label();
            this.pcbxSmallPhoto5 = new System.Windows.Forms.PictureBox();
            this.pcbxSmallPhoto4 = new System.Windows.Forms.PictureBox();
            this.pcbxSmallPhoto3 = new System.Windows.Forms.PictureBox();
            this.pcbxSmallPhoto2 = new System.Windows.Forms.PictureBox();
            this.pcbxSmallPhoto1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbxLargePhoto = new System.Windows.Forms.PictureBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtFacility = new System.Windows.Forms.TextBox();
            this.txtRenttype = new System.Windows.Forms.TextBox();
            this.lblRenttype = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.lblSqft = new System.Windows.Forms.Label();
            this.txtCorridor = new System.Windows.Forms.TextBox();
            this.txtBathroom = new System.Windows.Forms.TextBox();
            this.txtBedroom = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.lblFacility = new System.Windows.Forms.Label();
            this.lblCorridor = new System.Windows.Forms.Label();
            this.lblBath = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFlatDetails = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisapprove = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSmallPhoto5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSmallPhoto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSmallPhoto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSmallPhoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSmallPhoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLargePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnverified
            // 
            this.btnUnverified.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnverified.Location = new System.Drawing.Point(702, 28);
            this.btnUnverified.Name = "btnUnverified";
            this.btnUnverified.Size = new System.Drawing.Size(105, 35);
            this.btnUnverified.TabIndex = 8;
            this.btnUnverified.Text = "Unverified";
            this.btnUnverified.UseVisualStyleBackColor = true;
            this.btnUnverified.Click += new System.EventHandler(this.btnUnverified_Click);
            // 
            // btnVerified
            // 
            this.btnVerified.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerified.Location = new System.Drawing.Point(566, 28);
            this.btnVerified.Name = "btnVerified";
            this.btnVerified.Size = new System.Drawing.Size(105, 35);
            this.btnVerified.TabIndex = 7;
            this.btnVerified.Text = "Verified";
            this.btnVerified.UseVisualStyleBackColor = true;
            this.btnVerified.Click += new System.EventHandler(this.btnVerified_Click);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(426, 28);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(105, 35);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // dgvFlat
            // 
            this.dgvFlat.AllowUserToAddRows = false;
            this.dgvFlat.AllowUserToDeleteRows = false;
            this.dgvFlat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlatID,
            this.Title,
            this.Area,
            this.Status});
            this.dgvFlat.Location = new System.Drawing.Point(381, 77);
            this.dgvFlat.Name = "dgvFlat";
            this.dgvFlat.ReadOnly = true;
            this.dgvFlat.Size = new System.Drawing.Size(444, 422);
            this.dgvFlat.TabIndex = 5;
            this.dgvFlat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlat_CellClick);
            // 
            // FlatID
            // 
            this.FlatID.DataPropertyName = "flatid";
            this.FlatID.HeaderText = "Flat ID";
            this.FlatID.Name = "FlatID";
            this.FlatID.ReadOnly = true;
            this.FlatID.Width = 90;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 140;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "area";
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 70;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.txtFlatID);
            this.panel1.Controls.Add(this.lblFlatID);
            this.panel1.Controls.Add(this.pcbxSmallPhoto5);
            this.panel1.Controls.Add(this.pcbxSmallPhoto4);
            this.panel1.Controls.Add(this.pcbxSmallPhoto3);
            this.panel1.Controls.Add(this.pcbxSmallPhoto2);
            this.panel1.Controls.Add(this.pcbxSmallPhoto1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pcbxLargePhoto);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.txtArea);
            this.panel1.Controls.Add(this.txtFacility);
            this.panel1.Controls.Add(this.txtRenttype);
            this.panel1.Controls.Add(this.lblRenttype);
            this.panel1.Controls.Add(this.lblArea);
            this.panel1.Controls.Add(this.txtDetails);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtRent);
            this.panel1.Controls.Add(this.lblSqft);
            this.panel1.Controls.Add(this.txtCorridor);
            this.panel1.Controls.Add(this.txtBathroom);
            this.panel1.Controls.Add(this.txtBedroom);
            this.panel1.Controls.Add(this.txtSize);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.lblDetails);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblRent);
            this.panel1.Controls.Add(this.lblFacility);
            this.panel1.Controls.Add(this.lblCorridor);
            this.panel1.Controls.Add(this.lblBath);
            this.panel1.Controls.Add(this.lblBed);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblFlatDetails);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnDisapprove);
            this.panel1.Controls.Add(this.btnApprove);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 510);
            this.panel1.TabIndex = 9;
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(245, 94);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(97, 20);
            this.txtStatus.TabIndex = 95;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(194, 98);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 16);
            this.lblStatus.TabIndex = 94;
            this.lblStatus.Text = "Status :";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFlatID
            // 
            this.txtFlatID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFlatID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlatID.Location = new System.Drawing.Point(61, 94);
            this.txtFlatID.Multiline = true;
            this.txtFlatID.Name = "txtFlatID";
            this.txtFlatID.Size = new System.Drawing.Size(109, 20);
            this.txtFlatID.TabIndex = 93;
            // 
            // lblFlatID
            // 
            this.lblFlatID.AutoSize = true;
            this.lblFlatID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlatID.Location = new System.Drawing.Point(14, 97);
            this.lblFlatID.Name = "lblFlatID";
            this.lblFlatID.Size = new System.Drawing.Size(47, 16);
            this.lblFlatID.TabIndex = 92;
            this.lblFlatID.Text = "FlatID :";
            this.lblFlatID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcbxSmallPhoto5
            // 
            this.pcbxSmallPhoto5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbxSmallPhoto5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbxSmallPhoto5.Location = new System.Drawing.Point(294, 701);
            this.pcbxSmallPhoto5.Name = "pcbxSmallPhoto5";
            this.pcbxSmallPhoto5.Size = new System.Drawing.Size(50, 50);
            this.pcbxSmallPhoto5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxSmallPhoto5.TabIndex = 91;
            this.pcbxSmallPhoto5.TabStop = false;
            this.pcbxSmallPhoto5.Click += new System.EventHandler(this.pcbxSmallPhoto5_Click);
            // 
            // pcbxSmallPhoto4
            // 
            this.pcbxSmallPhoto4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbxSmallPhoto4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbxSmallPhoto4.Location = new System.Drawing.Point(238, 701);
            this.pcbxSmallPhoto4.Name = "pcbxSmallPhoto4";
            this.pcbxSmallPhoto4.Size = new System.Drawing.Size(50, 50);
            this.pcbxSmallPhoto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxSmallPhoto4.TabIndex = 90;
            this.pcbxSmallPhoto4.TabStop = false;
            this.pcbxSmallPhoto4.Click += new System.EventHandler(this.pcbxSmallPhoto4_Click);
            // 
            // pcbxSmallPhoto3
            // 
            this.pcbxSmallPhoto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbxSmallPhoto3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbxSmallPhoto3.Location = new System.Drawing.Point(182, 701);
            this.pcbxSmallPhoto3.Name = "pcbxSmallPhoto3";
            this.pcbxSmallPhoto3.Size = new System.Drawing.Size(50, 50);
            this.pcbxSmallPhoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxSmallPhoto3.TabIndex = 89;
            this.pcbxSmallPhoto3.TabStop = false;
            this.pcbxSmallPhoto3.Click += new System.EventHandler(this.pcbxSmallPhoto3_Click);
            // 
            // pcbxSmallPhoto2
            // 
            this.pcbxSmallPhoto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbxSmallPhoto2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbxSmallPhoto2.Location = new System.Drawing.Point(126, 701);
            this.pcbxSmallPhoto2.Name = "pcbxSmallPhoto2";
            this.pcbxSmallPhoto2.Size = new System.Drawing.Size(50, 50);
            this.pcbxSmallPhoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxSmallPhoto2.TabIndex = 88;
            this.pcbxSmallPhoto2.TabStop = false;
            this.pcbxSmallPhoto2.Click += new System.EventHandler(this.pcbxSmallPhoto2_Click);
            // 
            // pcbxSmallPhoto1
            // 
            this.pcbxSmallPhoto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbxSmallPhoto1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbxSmallPhoto1.Location = new System.Drawing.Point(70, 701);
            this.pcbxSmallPhoto1.Name = "pcbxSmallPhoto1";
            this.pcbxSmallPhoto1.Size = new System.Drawing.Size(50, 50);
            this.pcbxSmallPhoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxSmallPhoto1.TabIndex = 87;
            this.pcbxSmallPhoto1.TabStop = false;
            this.pcbxSmallPhoto1.Click += new System.EventHandler(this.pcbxSmallPhoto1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Picture :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcbxLargePhoto
            // 
            this.pcbxLargePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbxLargePhoto.Location = new System.Drawing.Point(70, 496);
            this.pcbxLargePhoto.Name = "pcbxLargePhoto";
            this.pcbxLargePhoto.Size = new System.Drawing.Size(274, 190);
            this.pcbxLargePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxLargePhoto.TabIndex = 85;
            this.pcbxLargePhoto.TabStop = false;
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(250, 163);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(92, 20);
            this.txtDate.TabIndex = 84;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(219, 278);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(85, 20);
            this.txtCity.TabIndex = 83;
            // 
            // txtArea
            // 
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArea.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(56, 277);
            this.txtArea.Multiline = true;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(101, 20);
            this.txtArea.TabIndex = 82;
            // 
            // txtFacility
            // 
            this.txtFacility.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFacility.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacility.Location = new System.Drawing.Point(100, 239);
            this.txtFacility.Multiline = true;
            this.txtFacility.Name = "txtFacility";
            this.txtFacility.Size = new System.Drawing.Size(242, 20);
            this.txtFacility.TabIndex = 81;
            // 
            // txtRenttype
            // 
            this.txtRenttype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRenttype.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenttype.Location = new System.Drawing.Point(245, 129);
            this.txtRenttype.Multiline = true;
            this.txtRenttype.Name = "txtRenttype";
            this.txtRenttype.Size = new System.Drawing.Size(97, 20);
            this.txtRenttype.TabIndex = 80;
            // 
            // lblRenttype
            // 
            this.lblRenttype.AutoSize = true;
            this.lblRenttype.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenttype.Location = new System.Drawing.Point(176, 132);
            this.lblRenttype.Name = "lblRenttype";
            this.lblRenttype.Size = new System.Drawing.Size(68, 16);
            this.lblRenttype.TabIndex = 79;
            this.lblRenttype.Text = "Rent Type :";
            this.lblRenttype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(18, 280);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 16);
            this.lblArea.TabIndex = 78;
            this.lblArea.Text = "Area :";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDetails
            // 
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetails.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(70, 410);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(272, 66);
            this.txtDetails.TabIndex = 77;
            this.txtDetails.Text = "";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(70, 322);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(272, 65);
            this.txtAddress.TabIndex = 76;
            this.txtAddress.Text = "";
            // 
            // txtRent
            // 
            this.txtRent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRent.Location = new System.Drawing.Point(61, 129);
            this.txtRent.Multiline = true;
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(109, 20);
            this.txtRent.TabIndex = 75;
            // 
            // lblSqft
            // 
            this.lblSqft.AutoSize = true;
            this.lblSqft.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqft.Location = new System.Drawing.Point(141, 166);
            this.lblSqft.Name = "lblSqft";
            this.lblSqft.Size = new System.Drawing.Size(54, 15);
            this.lblSqft.TabIndex = 74;
            this.lblSqft.Text = "Square Ft.";
            this.lblSqft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCorridor
            // 
            this.txtCorridor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorridor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorridor.Location = new System.Drawing.Point(61, 201);
            this.txtCorridor.Multiline = true;
            this.txtCorridor.Name = "txtCorridor";
            this.txtCorridor.Size = new System.Drawing.Size(30, 20);
            this.txtCorridor.TabIndex = 73;
            // 
            // txtBathroom
            // 
            this.txtBathroom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBathroom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBathroom.Location = new System.Drawing.Point(165, 201);
            this.txtBathroom.Multiline = true;
            this.txtBathroom.Name = "txtBathroom";
            this.txtBathroom.Size = new System.Drawing.Size(30, 20);
            this.txtBathroom.TabIndex = 72;
            // 
            // txtBedroom
            // 
            this.txtBedroom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBedroom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedroom.Location = new System.Drawing.Point(274, 201);
            this.txtBedroom.Multiline = true;
            this.txtBedroom.Name = "txtBedroom";
            this.txtBedroom.Size = new System.Drawing.Size(30, 20);
            this.txtBedroom.TabIndex = 71;
            // 
            // txtSize
            // 
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSize.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(61, 163);
            this.txtSize.Multiline = true;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(76, 20);
            this.txtSize.TabIndex = 70;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(61, 62);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(281, 20);
            this.txtTitle.TabIndex = 69;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(3, 413);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(51, 16);
            this.lblDetails.TabIndex = 68;
            this.lblDetails.Text = "Details :";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(181, 281);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(36, 16);
            this.lblCity.TabIndex = 67;
            this.lblCity.Text = "City :";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(6, 322);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 66;
            this.lblAddress.Text = "Address :";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRent.Location = new System.Drawing.Point(15, 132);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(40, 16);
            this.lblRent.TabIndex = 65;
            this.lblRent.Text = "Rent :";
            this.lblRent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFacility
            // 
            this.lblFacility.AutoSize = true;
            this.lblFacility.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacility.Location = new System.Drawing.Point(6, 239);
            this.lblFacility.Name = "lblFacility";
            this.lblFacility.Size = new System.Drawing.Size(95, 16);
            this.lblFacility.TabIndex = 64;
            this.lblFacility.Text = "Special Facility :";
            this.lblFacility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorridor
            // 
            this.lblCorridor.AutoSize = true;
            this.lblCorridor.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorridor.Location = new System.Drawing.Point(3, 201);
            this.lblCorridor.Name = "lblCorridor";
            this.lblCorridor.Size = new System.Drawing.Size(59, 16);
            this.lblCorridor.TabIndex = 63;
            this.lblCorridor.Text = "Corridor :";
            this.lblCorridor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBath
            // 
            this.lblBath.AutoSize = true;
            this.lblBath.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBath.Location = new System.Drawing.Point(97, 201);
            this.lblBath.Name = "lblBath";
            this.lblBath.Size = new System.Drawing.Size(67, 16);
            this.lblBath.TabIndex = 62;
            this.lblBath.Text = "Bathroom :";
            this.lblBath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBed.Location = new System.Drawing.Point(213, 204);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(63, 16);
            this.lblBed.TabIndex = 61;
            this.lblBed.Text = "Bedroom :";
            this.lblBed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(18, 163);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(37, 16);
            this.lblSize.TabIndex = 60;
            this.lblSize.Text = "Size :";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(205, 166);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 16);
            this.lblDate.TabIndex = 59;
            this.lblDate.Text = "Date :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(18, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 16);
            this.lblTitle.TabIndex = 58;
            this.lblTitle.Text = "Title :";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFlatDetails
            // 
            this.lblFlatDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblFlatDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlatDetails.Location = new System.Drawing.Point(94, 13);
            this.lblFlatDetails.Name = "lblFlatDetails";
            this.lblFlatDetails.Size = new System.Drawing.Size(195, 34);
            this.lblFlatDetails.TabIndex = 5;
            this.lblFlatDetails.Text = "Flat Information";
            this.lblFlatDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(254, 775);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisapprove
            // 
            this.btnDisapprove.BackColor = System.Drawing.Color.Yellow;
            this.btnDisapprove.FlatAppearance.BorderSize = 0;
            this.btnDisapprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisapprove.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisapprove.Location = new System.Drawing.Point(146, 775);
            this.btnDisapprove.Name = "btnDisapprove";
            this.btnDisapprove.Size = new System.Drawing.Size(90, 35);
            this.btnDisapprove.TabIndex = 42;
            this.btnDisapprove.Text = "Disapprove";
            this.btnDisapprove.UseVisualStyleBackColor = false;
            this.btnDisapprove.Click += new System.EventHandler(this.btnDisapprove_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.LimeGreen;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(30, 775);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(90, 35);
            this.btnApprove.TabIndex = 41;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(13, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 36);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FlatDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUnverified);
            this.Controls.Add(this.btnVerified);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.dgvFlat);
            this.MaximizeBox = false;
            this.Name = "FlatDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlatDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlatDetails_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSmallPhoto5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSmallPhoto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSmallPhoto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSmallPhoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSmallPhoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLargePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnverified;
        private System.Windows.Forms.Button btnVerified;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.DataGridView dgvFlat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFlatDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisapprove;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtFacility;
        private System.Windows.Forms.TextBox txtRenttype;
        private System.Windows.Forms.Label lblRenttype;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.RichTextBox txtDetails;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label lblSqft;
        private System.Windows.Forms.TextBox txtCorridor;
        private System.Windows.Forms.TextBox txtBathroom;
        private System.Windows.Forms.TextBox txtBedroom;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label lblFacility;
        private System.Windows.Forms.Label lblCorridor;
        private System.Windows.Forms.Label lblBath;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbxLargePhoto;
        private System.Windows.Forms.PictureBox pcbxSmallPhoto5;
        private System.Windows.Forms.PictureBox pcbxSmallPhoto4;
        private System.Windows.Forms.PictureBox pcbxSmallPhoto3;
        private System.Windows.Forms.PictureBox pcbxSmallPhoto2;
        private System.Windows.Forms.PictureBox pcbxSmallPhoto1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtFlatID;
        private System.Windows.Forms.Label lblFlatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}