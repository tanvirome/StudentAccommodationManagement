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
    public partial class StudentHomePage : Form
    {
        public StudentHomePage()
        {
            InitializeComponent();
        }
        string userid = null;
        string status = null;

        public StudentHomePage(string id, string stat)
        {
            InitializeComponent();
            lblLogOut.Hide();
            lblProfile.Hide();

            userid = id;
            status = stat;

            if (status == "Verified")
            {
                lblVerificationCheck.Hide();
            }
            else if (status == "Unverified")
            {
                lblVerificationCheck.Show();
            }
        }

        private void btnFlat_Click(object sender, EventArgs e)
        {
            if (status == "Verified")
            {
                SearchFlat sf = new SearchFlat(userid, status);
                //SearchFlat sf = new SearchFlat(userid, status);
                sf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Please Verify Your Account.");
            }
        }

        private void btnMess_Click(object sender, EventArgs e)
        {
            if (status == "Verified")
            {
                SearchMess sm = new SearchMess(userid, status);
                //SearchMess sm = new SearchMess(userid, status);
                sm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Please Verify Your Account.");
            }
        }

        private void btnSublet_Click(object sender, EventArgs e)
        {
            if (status == "Verified")
            {
                SearchSublet ss = new SearchSublet(userid, status);
                //SearchSublet ads = new SearchSublet(userid, status);
                ss.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Please Verify Your Account.");
            }
        }
        private void btnUserProfile_MouseEnter(object sender, EventArgs e)
        {
            lblProfile.Show();
        }

        private void btnUserProfile_MouseLeave(object sender, EventArgs e)
        {
            lblProfile.Hide();
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
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            StudentProfile op = new StudentProfile(userid, status);
            op.Show();
            this.Hide();
        }

        private void StudentHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
