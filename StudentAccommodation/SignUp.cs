using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAccommodation
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            lblEmailTaken.Hide();
            lblUserNameTaken.Hide();
            lblRbtnSignInSelector.Hide();
            lblCheckPrivacyBox.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DBConnect dbc = new DBConnect();
            //SqlDataReader dr;/*= new SqlDataReader();*/
            DataSet ds = new DataSet();
            //DataTable dt;

            string name = txtSignUpName.Text;
            string email = txtSignUpEmail.Text;
            string username = txtSignUpUserName.Text;
            string phonenumber = txtSignUpPhoneNumber.Text;
            string password = txtSignUpPassword.Text;

            ArrayList info = new ArrayList();

            info.Add(name);
            info.Add(email);
            info.Add(username);
            info.Add(phonenumber);
            info.Add(password);

            if (chkPrivacy.Checked)
            {
                lblCheckPrivacyBox.Hide();
                if (rbtnSignUpOwner.Checked)
                {
                    lblRbtnSignInSelector.Hide();

                    try
                    {
                        string mail = null;
                        string user = null;
                        string equery = "select email from OwnerDetails where email = '" + email + "' ";
                        string uquery = "select username from OwnerDetails where username = '" + username + "'";

                        ds = dbc.CheckEmail(equery);

                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            mail = ds.Tables[0].Rows[i]["email"].ToString();
                        }

                        ds = dbc.CheckUsername(uquery);

                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            user = ds.Tables[0].Rows[i]["username"].ToString();
                        }

                        if (email != mail)
                        {
                            lblEmailTaken.Hide();
                        }
                        if (username != user)
                        {
                            lblUserNameTaken.Hide();
                        }
                        if (email != mail && username != user)
                        {
                            dbc.OwnerSignIn(info);
                            lblEmailTaken.Hide();
                            lblUserNameTaken.Hide();
                            MessageBox.Show(this, "SignUp Successful.");
                            LogIn lg = new LogIn();
                            lg.Show();
                            this.Hide();
                        }
                        else if (email == mail && username == user)
                        {
                            lblEmailTaken.Show();
                            lblUserNameTaken.Show();
                        }
                        else if (email == mail)
                        {
                            lblEmailTaken.Show();
                        }
                        else if (username == user)
                        {
                            lblUserNameTaken.Show();
                        }
                    }
                    catch (Exception er)
                    {
                        Console.WriteLine("Error : " + er);
                        MessageBox.Show(this, "Please Enter Data Correctly.");
                    }
                }
                else if (rbtnSignUpStudent.Checked)
                {
                    lblRbtnSignInSelector.Hide();

                    try
                    {
                        string mail = null;
                        string user = null;
                        string equery = "select email from StudentDetails where email = '" + email + "' ";
                        string uquery = "select username from StudentDetails where username = '" + username + "'";

                        ds = dbc.CheckEmail(equery);

                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            mail = ds.Tables[0].Rows[i]["email"].ToString();
                        }

                        ds = dbc.CheckUsername(uquery);

                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            user = ds.Tables[0].Rows[i]["username"].ToString();
                        }

                        if (email != mail)
                        {
                            lblEmailTaken.Hide();
                        }
                        if (username != user)
                        {
                            lblUserNameTaken.Hide();
                        }
                        if (email != mail && username != user)
                        {
                            dbc.StudentSignIn(info);
                            lblEmailTaken.Hide();
                            lblUserNameTaken.Hide();
                            MessageBox.Show(this, "SignUp Successful.");
                            LogIn lg = new LogIn();
                            lg.Show();
                            this.Hide();
                        }
                        else if (email == mail && username == user)
                        {
                            lblEmailTaken.Show();
                            lblUserNameTaken.Show();
                        }
                        else if (email == mail)
                        {
                            lblEmailTaken.Show();
                        }
                        else if (username == user)
                        {
                            lblUserNameTaken.Show();
                        }
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(this, "Please Enter Data Correctly.");
                        Console.WriteLine("Error : " + er);
                    }
                }
                else if (!rbtnSignUpOwner.Checked && !rbtnSignUpStudent.Checked)
                {
                    lblRbtnSignInSelector.Show();
                }
            }
            else if (!chkPrivacy.Checked)
            {
                lblCheckPrivacyBox.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
