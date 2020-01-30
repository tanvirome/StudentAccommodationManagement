using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAccommodation.Admin
{
    public partial class OwnerDetails : Form
    {
        public OwnerDetails()
        {
            InitializeComponent();
        }
        string aid;
        public OwnerDetails(string id)
        {
            InitializeComponent();
            aid = id;
            btnAll_Click(btnAll, EventArgs.Empty);
        }

        string userID = null;
        int rowSelected;


        private void btnAll_Click(object sender, EventArgs e)
        {
            ClearData();
            DBConnect dbc = new DBConnect();
            string query = "Select * from OwnerDetails ;";
            DataTable dt = dbc.GetTable(query);
            dgvOwner.AutoGenerateColumns = false;
            dgvOwner.DataSource = dt;
        }

        private void dgvOwner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
            try
            {
                ClearData();
                DataGridViewRow row = dgvOwner.Rows[rowSelected];
                userID = row.Cells[0].Value.ToString();
                SetData(userID);
            }
            catch (Exception)
            {
                MessageBox.Show("Sorted");
            }

            //MessageBox.Show("User ID:"+userID);
        }

        private void SetData(string userID)
        {
            DBConnect dbc = new DBConnect();
            string query = "select * from OwnerDetails where userid = " + userID + " ;";
            DataSet ds = dbc.GetInfo(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                txtName.Text = ds.Tables[0].Rows[i]["name"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[i]["email"].ToString();
                txtUsername.Text = ds.Tables[0].Rows[i]["username"].ToString();
                txtPhone.Text = ds.Tables[0].Rows[i]["phonenumber"].ToString();
                txtNID.Text = ds.Tables[0].Rows[i]["nid"].ToString();
                txtUserId.Text = ds.Tables[0].Rows[i]["userid"].ToString();
                txtStatus.Text = ds.Tables[0].Rows[i]["status"].ToString();
                txtAddress.Text = ds.Tables[0].Rows[i]["address"].ToString();
            }
        }

        private void ClearData()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPhone.Text = "";
            txtNID.Text = "";
            txtUserId.Text = "";
            txtStatus.Text = "";
            txtAddress.Text = "";
        }

        public static void DeleteDirectory(string path)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                DeleteDirectory(directory);
            }

            try
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
        }

        public void DeletePhotos(String id)
        {
            DBConnect dbc = new DBConnect();
            ArrayList fid = new ArrayList();
            ArrayList mid = new ArrayList();
            ArrayList sid = new ArrayList();
            //try
            //{
                string appStartPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                string query1 = "select flatid from FlatDetails where userid = " + id + " ;";
                string query2 = "select messid from MessDetails where userid = " + id + " ;";
                string query3 = "select subletid from SubletDetails where userid = " + id + " ;";

                DataSet ds = dbc.GetInfo(query1);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    fid.Add(ds.Tables[0].Rows[i]["flatid"].ToString());
                }
                ds = dbc.GetInfo(query2);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    mid.Add(ds.Tables[0].Rows[i]["messid"].ToString());
                }

                ds = dbc.GetInfo(query3);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    sid.Add(ds.Tables[0].Rows[i]["subletid"].ToString());
                }

                for (int i = 0; i < fid.Count; i++)
                {
                    string folderPath = appStartPath + "\\AdvertisePicture\\FlatAdsPicture\\" + fid[i].ToString();
                    DeleteDirectory(folderPath);
                }

                for (int i = 0; i < mid.Count; i++)
                {
                    string folderPath = appStartPath + "\\AdvertisePicture\\MessAdsPicture\\" + mid[i].ToString();
                    DeleteDirectory(folderPath);
                }

                for (int i = 0; i < sid.Count; i++)
                {
                    string folderPath = appStartPath + "\\AdvertisePicture\\SubletAdsPicture\\" + sid[i].ToString();
                    DeleteDirectory(folderPath);
                }
            //}
            //catch (Exception er)
            //{
            //    Console.WriteLine("Error : " + er);
            //}
        }

        public void DeleteFlatDetails(string id)
        {
            DBConnect dbc = new DBConnect();
            String fquery = "Delete from FlatDetails where userid = " + id + " ;";
            dbc.InsertIntoDatabase(fquery);
        }

        public void DeleteMessDetails(string id)
        {
            DBConnect dbc = new DBConnect();
            String mquery = "Delete from MessDetails where userid = " + id + " ;";
            dbc.InsertIntoDatabase(mquery);
        }

        public void DeleteSubletDetails(string id)
        {
            DBConnect dbc = new DBConnect();
            String squery = "Delete from SubletDetails where userid = " + id + " ;";
            dbc.InsertIntoDatabase(squery);
        }

        private void btnVerified_Click(object sender, EventArgs e)
        {
            ClearData();
            DBConnect dbc = new DBConnect();
            string stat = "Verified";
            string query = "Select * from OwnerDetails where status = '" + stat + "' ;";
            DataTable dt = dbc.GetTable(query);
            dgvOwner.AutoGenerateColumns = false;
            dgvOwner.DataSource = dt;
        }

        private void btnUnverified_Click(object sender, EventArgs e)
        {
            ClearData();
            DBConnect dbc = new DBConnect();
            string stat = "Unverified";
            string query = "Select * from OwnerDetails where status = '" + stat + "' ;";
            DataTable dt = dbc.GetTable(query);
            dgvOwner.AutoGenerateColumns = false;
            dgvOwner.DataSource = dt;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            DBConnect dbc = new DBConnect();
            if ("".Equals(txtUserId.Text))
            {
                MessageBox.Show(this, "Data is not selected.");
            }
            else
            {
                String id = txtUserId.Text;
                String stat = "Verified";
                String query = "Update OwnerDetails set status = '" + stat + "' where userid = " + id + " ;";
                dbc.InsertIntoDatabase(query);
                btnVerified_Click(btnVerified, e);
                SetData(id);
            }
        }

        private void btnDisapprove_Click(object sender, EventArgs e)
        {
            DBConnect dbc = new DBConnect();
            if ("".Equals(txtUserId.Text))
            {
                MessageBox.Show(this, "Data is not selected.");
            }
            else
            {
                String id = txtUserId.Text;
                String stat = "Unverified";
                String query = "Update OwnerDetails set status = '" + stat + "' where userid = " + id + " ;";
                dbc.InsertIntoDatabase(query);
                btnUnverified_Click(btnUnverified, e);
                SetData(id);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBConnect dbc = new DBConnect();
            if ("".Equals(txtUserId.Text))
            {
                MessageBox.Show(this, "Data is not selected.");
            }
            else
            {
                String id = txtUserId.Text;

                //DeletePhotos(id);
                DeleteFlatDetails(id);
                DeleteMessDetails(id);
                DeleteSubletDetails(id);

                String query = "Delete from OwnerDetails where userid = " + id + " ;";
                dbc.InsertIntoDatabase(query);

                btnAll_Click(btnUnverified, e);
                ClearData();
                MessageBox.Show("Data Deleted");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMainPage amp = new AdminMainPage(aid);
            amp.Show();
            this.Hide();
        }

        private void OwnerDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
