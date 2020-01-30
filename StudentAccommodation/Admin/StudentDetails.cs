using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAccommodation.Admin
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }
        string aid;
        public StudentDetails(string id)
        {
            InitializeComponent();
            aid = id;
            btnAll_Click(btnAll, EventArgs.Empty);
        }

        string userID = null;
        int rowSelected;


        private void btnAll_Click(object sender, EventArgs e)
        {
            ClearData();
            DBConnect dbc = new DBConnect();
            string query = "Select * from StudentDetails";
            DataTable dt = dbc.GetTable(query);
            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.DataSource = dt;
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
            try
            {
                ClearData();
                DataGridViewRow row = dgvStudent.Rows[rowSelected];
                userID = row.Cells[0].Value.ToString();
                SetData(userID);
            }
            catch (Exception)
            {
                MessageBox.Show("Sorted");
            }
        }

        private void SetData(string userID)
        {
            DBConnect dbc = new DBConnect();
            string query = "select * from StudentDetails where userid = '" + userID + "'";
            DataSet ds = dbc.GetInfo(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                txtName.Text = ds.Tables[0].Rows[i]["name"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[i]["email"].ToString();
                txtUsername.Text = ds.Tables[0].Rows[i]["username"].ToString();
                txtPhone.Text = ds.Tables[0].Rows[i]["phonenumber"].ToString();
                txtNID.Text = ds.Tables[0].Rows[i]["nid"].ToString();
                txtUserId.Text = ds.Tables[0].Rows[i]["userid"].ToString();
                txtSID.Text = ds.Tables[0].Rows[i]["studentid"].ToString();
                txtInstName.Text = ds.Tables[0].Rows[i]["institute"].ToString();
                txtStatus.Text = ds.Tables[0].Rows[i]["status"].ToString();
                txtAddress.Text = ds.Tables[0].Rows[i]["address"].ToString();
            }
        }

        private void ClearData()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPhone.Text = "";
            txtNID.Text = "";
            txtUserId.Text = "";
            txtSID.Text = "";
            txtInstName.Text = "";
            txtStatus.Text = "";
            txtAddress.Text = "";
        }


        private void btnVerified_Click(object sender, EventArgs e)
        {
            ClearData();
            DBConnect dbc = new DBConnect();
            string stat = "Verified";
            string query = "Select * from StudentDetails where status = '" + stat + "';";
            DataTable dt = dbc.GetTable(query);
            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.DataSource = dt;
        }

        private void btnUnverified_Click(object sender, EventArgs e)
        {
            ClearData();
            DBConnect dbc = new DBConnect();
            string stat = "Unverified";
            string query = "Select * from StudentDetails where status = '" + stat + "';";
            DataTable dt = dbc.GetTable(query);
            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.DataSource = dt;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            DBConnect dbc = new DBConnect();
            if ("".Equals(txtUserId.Text))
            {
                MessageBox.Show(this, "Data is not selected.");
            }
            else
            {
                String id = txtUserId.Text;
                String stat = "Verified";
                String query = "Update StudentDetails set status = '" + stat + "' where userid = '" + id + "'";
                dbc.InsertIntoDatabase(query);
                btnVerified_Click(btnVerified, e);
                SetData(id);
            }
        }

        private void btnDisapprove_Click(object sender, EventArgs e)
        {
            DBConnect dbc = new DBConnect();
            if ("".Equals(txtUserId.Text))
            {
                MessageBox.Show(this, "Data is not selected.");
            }
            else
            {
                String id = txtUserId.Text;
                String stat = "Unverified";
                String query = "Update StudentDetails set status = '" + stat + "' where userid = '" + id + "'";
                dbc.InsertIntoDatabase(query);
                btnUnverified_Click(btnUnverified, e);
                SetData(id);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBConnect dbc = new DBConnect();
            if ("".Equals(txtUserId.Text))
            {
                MessageBox.Show(this, "Data is not selected.");
            }
            else
            {
                String id = txtUserId.Text;
                String query = "Delete from studentdetails where userid = '" + id + "'";
                dbc.InsertIntoDatabase(query);
                btnAll_Click(btnAll, e);
                ClearData();
                MessageBox.Show("Data Deleted");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMainPage amp = new AdminMainPage(aid);
            amp.Show();
            this.Hide();
        }

        private void StudentDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
