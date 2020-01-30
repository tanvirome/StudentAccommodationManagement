using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAccommodation.Owner
{
    public partial class OwnerProfile : Form
    {

        public OwnerProfile()
        {
            InitializeComponent();
        }

        string userid = null;
        string status = null;

        public OwnerProfile(string id, string stat)
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
            DBConnect dbc = new DBConnect();
            string query = "select * from OwnerDetails where userid = "+userid+" ;";
            DataSet ds = dbc.GetInfo(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                txtName.Text = ds.Tables[0].Rows[i]["name"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[i]["email"].ToString();
                txtUsername.Text = ds.Tables[0].Rows[i]["username"].ToString();
                txtPhone.Text = ds.Tables[0].Rows[i]["phonenumber"].ToString();
                txtNID.Text = ds.Tables[0].Rows[i]["nid"].ToString();
                txtStatus.Text = ds.Tables[0].Rows[i]["status"].ToString();
                txtAddress.Text = ds.Tables[0].Rows[i]["address"].ToString();
            }
        }

        private void btnPassChange_Click(object sender, EventArgs e)
        {
            PasswordChange pschng = new PasswordChange(userid, status);
            pschng.Show();
        }

        private void btnEditInformation_Click(object sender, EventArgs e)
        {
            OwnerEditInformation oedtinfo = new OwnerEditInformation(userid, status);
            oedtinfo.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OwnerHomePage ohp = new OwnerHomePage(userid, status);
            ohp.Show();
            this.Hide();

        }

        private void OwnerProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            OwnerProfile op = new OwnerProfile(userid, status);
            op.Show();
            this.Hide();
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            lblLogOut.Show();
        }

        private void btnUserProfile_MouseEnter(object sender, EventArgs e)
        {
            lblProfile.Show();
        }

        private void btnUserProfile_MouseLeave(object sender, EventArgs e)
        {
            lblProfile.Hide();
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            lblLogOut.Hide();
        }
    }
}
