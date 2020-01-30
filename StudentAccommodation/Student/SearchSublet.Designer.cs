namespace StudentAccommodation.Student
{
    partial class SearchSublet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSublet));
            this.dgvSublet = new System.Windows.Forms.DataGridView();
            this.Sub_letID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.txtMaxRent = new System.Windows.Forms.TextBox();
            this.txtMinRent = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSublet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSublet
            // 
            this.dgvSublet.AllowUserToAddRows = false;
            this.dgvSublet.AllowUserToDeleteRows = false;
            this.dgvSublet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSublet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSublet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSublet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sub_letID,
            this.Title,
            this.Rent,
            this.Area,
            this.Date});
            this.dgvSublet.Location = new System.Drawing.Point(12, 208);
            this.dgvSublet.Name = "dgvSublet";
            this.dgvSublet.ReadOnly = true;
            this.dgvSublet.Size = new System.Drawing.Size(810, 292);
            this.dgvSublet.TabIndex = 20;
            this.dgvSublet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSublet_CellClick);
            // 
            // Sub_letID
            // 
            this.Sub_letID.DataPropertyName = "subletid";
            this.Sub_letID.HeaderText = "Sublet ID";
            this.Sub_letID.Name = "Sub_letID";
            this.Sub_letID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Rent
            // 
            this.Rent.DataPropertyName = "rent";
            this.Rent.HeaderText = "Rent";
            this.Rent.Name = "Rent";
            this.Rent.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "area";
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Items.AddRange(new object[] {
            "Select Area",
            "Adabor",
            "Aftabnagar",
            "Agargaon",
            "Ahmed Nagar",
            "Ahmedbagh",
            "Alambagh",
            "Alamganj",
            "Alinagar",
            "Alu Bazar",
            "Amin Bagh",
            "Angur Jora",
            "Arambagh",
            "Asad Gate",
            "Ashiyan City",
            "Ashkona",
            "Ashrafabad",
            "Atipara",
            "Azimpur",
            "Babu Bazar",
            "Badda",
            "Baddanagar",
            "Bagbari",
            "Bahadurpur",
            "Baily Square",
            "Bakshi",
            "Banagram",
            "Banani",
            "Banani DOHS",
            "Banasree",
            "Bangla Bazar",
            "Bangla Motor",
            "Bangladesh Bank Colony",
            "Bangsal",
            "Banianagar",
            "Bank Colony",
            "Bara Katra",
            "Bara Maghbazar",
            "Barentek",
            "Baridhara",
            "Baridhara DOHS",
            "Bashabo",
            "Begum Bazar",
            "Begumganj",
            "Bibir Bazar",
            "Bijoynagar",
            "Boro Moghbazar",
            "Box Nagar",
            "Brahman Chiron",
            "Byshteki",
            "Chalk Bazar",
            "Chamilibagh",
            "Chankharpool",
            "Chhaya Bithi Housing",
            "Chhota Katra",
            "Chowdhury Para Malibagh",
            "Commissoner Bari",
            "Companiganj",
            "Court House Street",
            "D.I.T.Area",
            "Dakshin Khan",
            "Dakshin Mugda Para",
            "Dalpur",
            "Darus Salam",
            "Dawanpara",
            "Dayaganj",
            "Dhaka College Area",
            "Dhaka Medical College",
            "Dhalka Nagar",
            "Dhanmondi",
            "Dholairpar",
            "Dilkusha",
            "East Baragram",
            "Eskaton",
            "Faidabad",
            "Fakira Pool",
            "Farashganj",
            "Faridabad ",
            "Gabtoli ",
            "Ganaktuli ",
            "Gendaria ",
            "Goalghat ",
            "Goalnagar ",
            "Golartek ",
            "Goran ",
            "Gulbagh ",
            "Gulistan ",
            "Gulshan -1  ",
            "Gulshan-2 ",
            "Gupibagh Haji ",
            "Para Hasan Nagar ",
            "Hatirpool Bazar ",
            "Hatkhola Hazaribagh ",
            "Hazi Bari ",
            "Hazrat Nagar ",
            "Ibrahinpur ",
            "Islambagh ",
            "Islamnagar ",
            "Islampur ",
            "Jafrabad ",
            "Jaolahati ",
            "Jatrabari ",
            "Jeleypara ",
            "Jhigatola ",
            "Jurain ",
            "Kadamtala ",
            "Kafrul ",
            "Kakrail ",
            "Kalabagan ",
            "Kamalapur ",
            "Kaptan Bazar ",
            "Karatitola ",
            "Karimullah Bagh ",
            "Kather Pool ",
            "Kawranbazar ",
            "Kazipara ",
            "Khamer Bari",
            "Khilgaon ",
            "Khilkhat ",
            "Kumartuly ",
            "Kuril ",
            "Kusumbag ",
            "Lakshmi Bazar ",
            "Lalbagh ",
            "Lalmatia ",
            "Madartek ",
            "Madhu Bazar ",
            "Malibagh ",
            "Manikdey ",
            "Matikata ",
            "Mazibari ",
            "Meradia ",
            "Merul Badda ",
            "Middle Badda ",
            "Mir Hazirbagh ",
            "Mirpur Ceramic ",
            "Mirpur Colony ",
            "Mirpur Section-1 ",
            "Mirpur Section-10  ",
            "Mirpur Section-11 ",
            "Mirpur Section-12  ",
            "Mirpur Section-14 ",
            "Mirpur Section-2 ",
            "Mirpur Section-6  ",
            "Mirpur Section-7  ",
            "Mohakhali ",
            "Mohammadpur ",
            "Mokim Katra ",
            "Mominbagh ",
            "Moneshwar ",
            "Monipur ",
            "Monipuripara ",
            "Moshundi ",
            "Motijheil ",
            "Moulvi Bazar ",
            "Munshihati ",
            "Muradpur-1 ",
            "Muradpur-2 ",
            "Murgitola ",
            "Nabin Bag Bank Colony ",
            "Nadda Para ",
            "Namapara ",
            "Narinda ",
            "Nawab Katara ",
            "Nawabbari ",
            "Naya Bazar ",
            "Naya Paltan ",
            "Nazira Bazar ",
            "Newmarket ",
            "Neyatola ",
            "Niketan ",
            "Nikunjo ",
            "Nilkhet ",
            "Nilkhet ",
            "Babupura ",
            "North Badda ",
            "Nowagaon ",
            "Nowapara ",
            "Nurerchala ",
            "Paikpara ",
            "Parbata ",
            "Parer Bagh ",
            "Paribagh ",
            "Patuatuly ",
            "Pilkhana ",
            "Pollabi ",
            "Postagola ",
            "Purana Paltan ",
            "Puratan Mogultoli Purba ",
            "Purba ",
            "Razabazar ",
            "Rajarbagh ",
            "Ramna ",
            "Rampura ",
            "Rasulpur ",
            "Rayer Bazar ",
            "Rishi Para ",
            "Islamabed ",
            "Rokanpur ",
            "Royer Bazar ",
            "Staff Roysaheb Bazar ",
            "Rupnagar ",
            "Sabujbagh ",
            "Saidabad ",
            "Sawrapara ",
            "Science Laboratory ",
            "Segun Bagicha ",
            "Senpara ",
            "Shahidbagh ",
            "Shahidnagar ",
            "Shahjadpur ",
            "Shahjahanpur ",
            "Shakari Nagar ",
            "Shakertek ",
            "Shakhari Bazar  ",
            "Shamibagh ",
            "Shantibagh ",
            "Shantinagar ",
            "Shikaritola ",
            "Siddeswary ",
            "Siddique Bazar ",
            "Sonatengar ",
            "South Badda ",
            "Sowarighat ",
            "Sultanganj",
            "Takerhat",
            "Tallabagh ",
            "Taltola ",
            "Tegturipara ",
            "Tejkunipara ",
            "Tennery ",
            "Thatary Bazar ",
            "Topkhana ",
            "Uttar Khan ",
            "Uttar Mousondi ",
            "Uttara ABM City ",
            "Uttara Model Town ",
            "Vasantek ",
            "Wari"});
            this.cmbArea.Location = new System.Drawing.Point(163, 78);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(121, 24);
            this.cmbArea.TabIndex = 1;
            this.cmbArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbArea_KeyPress);
            // 
            // txtMaxRent
            // 
            this.txtMaxRent.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxRent.Location = new System.Drawing.Point(673, 73);
            this.txtMaxRent.Name = "txtMaxRent";
            this.txtMaxRent.Size = new System.Drawing.Size(100, 26);
            this.txtMaxRent.TabIndex = 3;
            this.txtMaxRent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxRent_KeyPress);
            // 
            // txtMinRent
            // 
            this.txtMinRent.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinRent.Location = new System.Drawing.Point(539, 73);
            this.txtMinRent.Name = "txtMinRent";
            this.txtMinRent.Size = new System.Drawing.Size(100, 26);
            this.txtMinRent.TabIndex = 2;
            this.txtMinRent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinRent_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lime;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(362, 153);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSearch_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(645, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Rent Range:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Area:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(21, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 36);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search Sublet";
            // 
            // SearchSublet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.dgvSublet);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.txtMaxRent);
            this.Controls.Add(this.txtMinRent);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SearchSublet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchSublet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchSublet_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSublet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSublet;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.TextBox txtMaxRent;
        private System.Windows.Forms.TextBox txtMinRent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_letID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}