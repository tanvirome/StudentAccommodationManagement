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
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        DBConnect dbc = new DBConnect();
        string userid = null;

        public AdminProfile(string id)
        {
            InitializeComponent();
            userid = id;
            lblLogOut.Hide();
            lblProfile.Hide();

            ShowProfile();
        }

        public void ShowProfile()
        {
            string query = "select * from AdminDetails where userid = '" + userid + "'";
            DataSet ds = dbc.GetInfo(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                txtName.Text = ds.Tables[0].Rows[i]["name"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[i]["email"].ToString();
                txtUsername.Text = ds.Tables[0].Rows[i]["username"].ToString();
                txtPhone.Text = ds.Tables[0].Rows[i]["phonenumber"].ToString();
                txtNID.Text = ds.Tables[0].Rows[i]["nid"].ToString();
                txtAddress.Text = ds.Tables[0].Rows[i]["address"].ToString();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMainPage amp = new AdminMainPage(userid);
            amp.Show();
            this.Hide();
        }

        private void AdminProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AdminLogIn alg = new AdminLogIn();
            alg.Show();
            this.Hide();
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(userid);
            ap.Show();
            this.Hide();
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            lblLogOut.Show();
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            lblLogOut.Hide();
        }

        private void btnAdminProfile_MouseEnter(object sender, EventArgs e)
        {
            lblProfile.Show();
        }

        private void btnAdminProfile_MouseLeave(object sender, EventArgs e)
        {
            lblProfile.Hide();
        }
    }
}
