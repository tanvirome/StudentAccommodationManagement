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
    public partial class OwnerHomePage : Form
    {
        public OwnerHomePage()
        {
            InitializeComponent();
        }

        string userid = null;
        string status = null;

        public OwnerHomePage(string id, string stat)
        {
            InitializeComponent();
            lblLogOut.Hide();
            lblProfile.Hide();

            userid = id;
            status = stat;

            if(status == "Verified")
            {
                lblVarificationCheck.Hide();
            }
            else if (status == "Unverified")
            {
                lblVarificationCheck.Show();
            }
        }

        private void btnFlat_Click(object sender, EventArgs e)
        {
            if(status == "Verified")
            {
                AdsFlat adf = new AdsFlat(userid, status);
                adf.Show();
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
                AdsMess adm = new AdsMess(userid, status);
                adm.Show();
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
                AdsSublet ads = new AdsSublet(userid, status);
                ads.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Please Verify Your Account.");
            }
        }

        private void lblShowAds_Click(object sender, EventArgs e)
        {
            if (status == "Verified")
            {
                ShowYourAds sad = new ShowYourAds(userid, status);
                sad.Show();
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
            OwnerProfile op = new OwnerProfile(userid, status);
            op.Show();
            this.Hide();
        }

        private void OwnerHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
