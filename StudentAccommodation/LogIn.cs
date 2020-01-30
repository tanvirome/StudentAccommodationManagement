using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAccommodation
{
    public partial class LogIn : Form
    {
        public LogIn()
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
            string status = null;

            if (rbtnLogInOwner.Checked)
            {
                try
                {
                    string query = "select password, userid, status from OwnerDetails where username = '" + username + "'";
                    DataSet ds = dbc.GetInfo(query);

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dpass = ds.Tables[0].Rows[i]["password"].ToString();
                        userid = ds.Tables[0].Rows[i]["userid"].ToString();
                        status = ds.Tables[0].Rows[i]["status"].ToString();
                    }

                    if (dpass == password)
                    {
                        Owner.OwnerHomePage ohp = new Owner.OwnerHomePage(userid, status);
                        ohp.Show();
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
                    Console.WriteLine("Error : " + er);
                }
            }
            else if(rbtnLogInStudent.Checked)
            {
                try
                {
                    string query = "select password, userid, status from StudentDetails where username = '" + username + "'";
                    DataSet ds = dbc.GetInfo(query);

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dpass = ds.Tables[0].Rows[i]["password"].ToString();
                        userid = ds.Tables[0].Rows[i]["userid"].ToString();
                        status = ds.Tables[0].Rows[i]["status"].ToString();
                    }

                    if (dpass == password)
                    {
                        Student.StudentHomePage shp = new Student.StudentHomePage(userid, status);
                        shp.Show();
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
                    Console.WriteLine("Error : " + er);
                }
            }
            else
            {
                MessageBox.Show("Select Owner/Student");
            }

        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp sg = new SignUp();
            sg.Show();
            this.Hide();
        }

        private void chkLogInShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkLogInShowPass.Checked)
            {
                txtLogInPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtLogInPassword.UseSystemPasswordChar = false;
            }
        }

        private void rbtnLogInStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnLogIn_Click(sender, e);
            }
        }

        private void rbtnLogInOwner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogIn_Click(sender, e);
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
            Admin.AdminLogIn al = new Admin.AdminLogIn();
            al.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void termsPolicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string appStartPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            string policy = appStartPath + "\\Policy.txt";

            StreamReader sr = new StreamReader(policy);
            MessageBox.Show(sr.ReadToEnd());
            sr.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.O");
        }
    }
}
