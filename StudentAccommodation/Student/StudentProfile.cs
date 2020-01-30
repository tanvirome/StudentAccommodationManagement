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
    public partial class StudentProfile : Form
    {
        DBConnect dbc = new DBConnect();
        public StudentProfile()
        {
            InitializeComponent();
        }
        string userid = null;
        string status = null;

        public StudentProfile(string id, string stat)
        {
            InitializeComponent();
            userid = id;
            status = stat;
            lblLogOut.Hide();
            lblProfile.Hide();
            ShowProfile();
        }

        public void ShowProfile()
        {
            string query = "select * from StudentDetails where userid = '" + userid + "'";
            DataSet ds = dbc.GetInfo(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                txtName.Text = ds.Tables[0].Rows[i]["name"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[i]["email"].ToString();
                txtUsername.Text = ds.Tables[0].Rows[i]["username"].ToString();
                txtPhone.Text = ds.Tables[0].Rows[i]["phonenumber"].ToString();
                txtNID.Text = ds.Tables[0].Rows[i]["nid"].ToString();
                txtSID.Text = ds.Tables[0].Rows[i]["studentid"].ToString();
                txtInstName.Text= ds.Tables[0].Rows[i]["institute"].ToString();
                txtStatus.Text = ds.Tables[0].Rows[i]["status"].ToString();
                txtAddress.Text = ds.Tables[0].Rows[i]["address"].ToString();
            }
        }

        private void btnPassChange_Click(object sender, EventArgs e)
        {
            SPasswordChange pschng = new SPasswordChange(userid, status);
            pschng.Show();
        }

        private void btnEditInformation_Click(object sender, EventArgs e)
        {
            StudentEditInformation sei = new StudentEditInformation(userid, status);
            sei.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentHomePage shp = new StudentHomePage(userid, status);
            shp.Show();
            this.Hide();
        }

        private void StudentProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile(userid, status);
            sp.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
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

        private void btnUserProfile_MouseEnter(object sender, EventArgs e)
        {
            lblProfile.Show();
        }

        private void btnUserProfile_MouseLeave(object sender, EventArgs e)
        {
            lblProfile.Hide();
        }
    }
}
