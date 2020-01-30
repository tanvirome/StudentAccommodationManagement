using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAccommodation.Student
{
    public partial class SearchMess : Form
    {
        public SearchMess()
        {
            InitializeComponent();
        }

        string userid = null;
        string status = null;
        string messID = null;
        int rowSelected;

        public SearchMess(string id, string stat)
        {
            InitializeComponent();
            userid = id;
            status = stat;
            cmbArea.SelectedIndex = 0;
            ShowAllData();
        }
        private void ShowAllData()
        {
            string stat = "Verified";
            DBConnect dbc = new DBConnect();
            string query = "Select * from MessDetails where status = '" + stat + "';";
            DataTable dt = dbc.GetTable(query);
            dgvMess.AutoGenerateColumns = false;
            dgvMess.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string rentmin = txtMinRent.Text;
            string rentmax = txtMaxRent.Text;
            string stat = "Verified";
            string rarea = cmbArea.SelectedItem.ToString();
            if (!"".Equals(rentmin) && !"".Equals(rentmax) && !"Select Area".Equals(rarea))
            {
                DBConnect dbc = new DBConnect();
                string query = "Select * from MessDetails where area='" + rarea + "' and rent between '" + rentmin + "' and '" + rentmax + "' and status = '" + stat + "';";
                DataTable dt = dbc.GetTable(query);
                dgvMess.AutoGenerateColumns = false;
                dgvMess.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Please give rent range and select area");
            }

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentHomePage shp = new StudentHomePage(userid, status);
            shp.Show();
            this.Hide();
        }

        private void dgvMess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
            try
            {
                DataGridViewRow row = dgvMess.Rows[rowSelected];
                messID = row.Cells[0].Value.ToString();
                ShowMessDetails sfd = new ShowMessDetails(userid, status, messID);
                sfd.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Sorted");
            }
        }

        private void SearchMess_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmbArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void txtMinRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void txtMaxRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
    }
}
