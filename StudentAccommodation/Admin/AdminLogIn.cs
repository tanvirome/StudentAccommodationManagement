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
    public partial class AdminLogIn : Form
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DBConnect dbc = new DBConnect();

            string username = txtLogInUserName.Text;
            string password = txtLogInPassword.Text;
            string dpass = "";
            string userid = null;

             try
             {
                string query = "select password, userid from AdminDetails where username = '" + username + "'";
                DataSet ds = dbc.GetInfo(query);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dpass = ds.Tables[0].Rows[i]["password"].ToString();
                    userid = ds.Tables[0].Rows[i]["userid"].ToString();
                }

                if (dpass == password)
                {
                    //AdminMainPage amp = new AdminMainPage();
                    AdminMainPage amp = new AdminMainPage(userid);
                    amp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(this, "Username or Password Incorrect. Try again");
                    txtLogInPassword.Text = "";
                }
             }
             catch (Exception er)
             {
                //Console.WriteLine("Error : " + er);
                MessageBox.Show("Error:"+er);
             }
        }

        private void chkLogInShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLogInShowPass.Checked)
            {
                txtLogInPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtLogInPassword.UseSystemPasswordChar = false;
            }
        }


        private void txtLogInUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogIn_Click(sender, e);
            }
        }

        private void txtLogInPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogIn_Click(sender, e);
            }
        }

        private void btnLogIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogIn_Click(sender, e);
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            l.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
