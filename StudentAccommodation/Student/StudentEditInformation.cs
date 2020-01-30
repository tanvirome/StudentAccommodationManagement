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
    public partial class StudentEditInformation : Form
    {
        public StudentEditInformation()
        {
            InitializeComponent();
        }
        DBConnect dbc = new DBConnect();
        string userid = null;
        string status = null;

        public StudentEditInformation(string id, string stat)
        {
            InitializeComponent();
            userid = id;
            status = stat;
            SetProfile();
        }

        public void SetProfile()
        {
            try
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
                    txtInstName.Text = ds.Tables[0].Rows[i]["institute"].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[i]["address"].ToString();
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("Error : " + er);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newstatus = "Unverified";
            try
            {
                String query = "Update StudentDetails set name = '" + txtName.Text + "', email = '" + txtEmail.Text + "', phonenumber = '" + txtPhone.Text + "', nid = '" + txtNID.Text + "', studentid = '"+ txtSID.Text + "', institute = '" + txtInstName.Text + "', address = '" + txtAddress.Text + "', status = '" + newstatus + "' where userid ='" + userid + "' ;";

                dbc.InsertIntoDatabase(query);

                status = newstatus;

                MessageBox.Show(this, "Update Successful");

                StudentProfile op = new StudentProfile(userid, status);
                op.Show();
                this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show(this, "Wrong Input");
                Console.WriteLine("Error : " + er);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StudentProfile op = new StudentProfile(userid, status);
            op.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentProfile op = new StudentProfile(userid, status);
            op.Show();
            this.Hide();
        }

        private void StudentEditInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
