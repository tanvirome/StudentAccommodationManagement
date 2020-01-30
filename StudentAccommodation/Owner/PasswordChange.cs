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
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        string userid = null;
        string status = null;

        public PasswordChange(string id, string stat)
        {
            InitializeComponent();
            userid = id;
            status = stat;
            lblOldPassNotMatch.Hide();
            lblNewConfirmPassNotMatch.Hide();
            lblEnterOldPass.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string password = txtOldPassword.Text;
            string newPass = txtNewPassword.Text;
            string confirmPass = txtNewConfirmPassword.Text;
            string dpass = null;
            try
            {
                DBConnect dbc = new DBConnect();
                string query = "select password from OwnerDetails where userid = " + userid + " ;";
                DataSet ds = dbc.GetInfo(query);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dpass = ds.Tables[0].Rows[i]["password"].ToString();
                }

                if (password == "")
                {
                    lblEnterOldPass.Show();
                }
                else
                {
                    lblEnterOldPass.Hide();
                    if (dpass == password)
                    {
                        lblOldPassNotMatch.Hide();

                        if (newPass == confirmPass)
                        {
                            lblNewConfirmPassNotMatch.Hide();
                            String updtquery = "Update OwnerDetails set password = '" + txtNewPassword.Text + "' where userid = " + userid + " ;";

                            dbc.InsertIntoDatabase(updtquery);
                            MessageBox.Show(this, "Password Changed Successful");
                            this.Hide();
                        }
                        else
                        {
                            lblNewConfirmPassNotMatch.Show();
                        }
                    }
                    else if(dpass != password)
                    {
                        //MessageBox.Show(this, "Old Password Incorrect. Try again");
                        lblOldPassNotMatch.Show();
                        lblNewConfirmPassNotMatch.Hide();
                    }
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("Error : " + er);
            }
        }

        private void PasswordChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
