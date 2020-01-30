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
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
            
        }
    
        string userid = null;

        public AdminMainPage(string id)
        {
            InitializeComponent();
            cmbHouse.SelectedIndex = 0;
            lblLogOut.Hide();
            lblProfile.Hide();

            userid = id;
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            lblLogOut.Show();
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            lblLogOut.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AdminLogIn alg = new AdminLogIn();
            alg.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentDetails sd = new StudentDetails(userid);
            sd.Show();
            this.Hide();
        }
        private void btnOwner_Click(object sender, EventArgs e)
        {
            //OwnerDetails od = new OwnerDetails();
            OwnerDetails od = new OwnerDetails(userid);
            od.Show();
            this.Hide();
        }

        private void cmbHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbHouse.SelectedItem.ToString();
            if (selected == "     Flat Details")
            {
                FlatDetails fd = new FlatDetails(userid);
                //FlatDetails fd = new FlatDetails(userid);
                fd.Show();
                this.Hide();
            }
            else if (selected == "     Mess Details")
            {
                MessDetails md = new MessDetails(userid);
                //MessDetails md = new MessDetails(userid);
                md.Show();
                this.Hide();
            }
            else if (selected == "     Sublet Details")
            {
                SubletDetails sd = new SubletDetails(userid);
                //SubletDetails sd = new SubletDetails(userid);
                sd.Show();
                this.Hide();
            }
        }

        private void AdminMainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(userid);
            ap.Show();
            this.Hide();
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
