using System;
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
    public partial class MessDetails : Form
    {
        public MessDetails()
        {
            InitializeComponent();
        }

        string aid;
        string messID = null;
        int rowSelected;

        string appStartPath = null;

        string smallPhoto1 = null;
        string smallPhoto2 = null;
        string smallPhoto3 = null;
        string smallPhoto4 = null;
        string smallPhoto5 = null;

        public MessDetails(string id)
        {
            InitializeComponent();
            aid = id;
            btnAll_Click(btnAll, EventArgs.Empty);
        }
        
        private void ClearData()
        {
            txtTitle.Text = "";
            txtStatus.Text = "";
            txtSeat.Text = "";
            txtRenttype.Text = "";
            txtRent.Text = "";
            txtMessID.Text = "";
            txtDetails.Text = "";
            txtDate.Text = "";
            txtCity.Text = "";
            txtArea.Text = "";
            txtAddress.Text = "";
            pcbxLargePhoto.Image = null;
            pcbxSmallPhoto1.Image = null;
            pcbxSmallPhoto2.Image = null;
            pcbxSmallPhoto3.Image = null;
            pcbxSmallPhoto4.Image = null;
            pcbxSmallPhoto5.Image = null;
        }

        private void SetData(string mID)
        {
            try
            {
                DBConnect dbc = new DBConnect();
                string query = "select * from MessDetails where messid = '" + messID + "'";
                DataSet ds = dbc.GetInfo(query);
                string photospath = null;

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    txtTitle.Text = ds.Tables[0].Rows[i]["title"].ToString();
                    txtMessID.Text = ds.Tables[0].Rows[i]["messid"].ToString();
                    txtStatus.Text = ds.Tables[0].Rows[i]["status"].ToString();
                    txtSeat.Text = ds.Tables[0].Rows[i]["seat"].ToString();
                    txtRent.Text = ds.Tables[0].Rows[i]["rent"].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[i]["address"].ToString();
                    txtDetails.Text = ds.Tables[0].Rows[i]["details"].ToString();
                    txtCity.Text = ds.Tables[0].Rows[i]["city"].ToString();
                    txtArea.Text = ds.Tables[0].Rows[i]["area"].ToString();
                    txtDate.Text = ds.Tables[0].Rows[i]["date"].ToString();
                    txtRenttype.Text = ds.Tables[0].Rows[i]["renttype"].ToString();
                    photospath = ds.Tables[0].Rows[i]["photo"].ToString();
                }
                ShowPhoto(photospath);
            }
            catch (Exception er)
            {
                Console.WriteLine("Error : " + er);
            }
        }

        public void ShowPhoto(string p)
        {
            string[] pathList = p.Split('@');
            appStartPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            for (int i = 0; i < pathList.Length; i++)
            {
                //ImagesPath[i] = appStartPath + pathList[i];
                if (i == 0)
                    smallPhoto1 = appStartPath + pathList[i];
                else if (i == 1)
                    smallPhoto2 = appStartPath + pathList[i];
                else if (i == 2)
                    smallPhoto3 = appStartPath + pathList[i];
                else if (i == 3)
                    smallPhoto4 = appStartPath + pathList[i];
                else if (i == 4)
                    smallPhoto5 = appStartPath + pathList[i];
            }
            if (smallPhoto1 != null)
            {
                pcbxLargePhoto.Image = new Bitmap(smallPhoto1);
                pcbxSmallPhoto1.Image = new Bitmap(smallPhoto1);
            }
            if (smallPhoto2 != null)
                pcbxSmallPhoto2.Image = new Bitmap(smallPhoto2);
            if (smallPhoto3 != null)
                pcbxSmallPhoto3.Image = new Bitmap(smallPhoto3);
            if (smallPhoto4 != null)
                pcbxSmallPhoto4.Image = new Bitmap(smallPhoto4);
            if (smallPhoto5 != null)
                pcbxSmallPhoto5.Image = new Bitmap(smallPhoto5);
            CursorBorderChange();
        }

        public void CursorBorderChange()
        {

            if (pcbxSmallPhoto1.Image == null)
            {
                pcbxSmallPhoto1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                pcbxSmallPhoto1.Cursor = System.Windows.Forms.Cursors.Default;
            }
            if (pcbxSmallPhoto2.Image == null)
            {
                pcbxSmallPhoto2.BorderStyle = System.Windows.Forms.BorderStyle.None;
                pcbxSmallPhoto2.Cursor = System.Windows.Forms.Cursors.Default;
            }
            if (pcbxSmallPhoto3.Image == null)
            {
                pcbxSmallPhoto3.BorderStyle = System.Windows.Forms.BorderStyle.None;
                pcbxSmallPhoto3.Cursor = System.Windows.Forms.Cursors.Default;
            }
            if (pcbxSmallPhoto4.Image == null)
            {
                pcbxSmallPhoto4.BorderStyle = System.Windows.Forms.BorderStyle.None;
                pcbxSmallPhoto4.Cursor = System.Windows.Forms.Cursors.Default;
            }
            if (pcbxSmallPhoto5.Image == null)
            {
                pcbxSmallPhoto5.BorderStyle = System.Windows.Forms.BorderStyle.None;
                pcbxSmallPhoto5.Cursor = System.Windows.Forms.Cursors.Default;
            }
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
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ClearData();
            DBConnect dbc = new DBConnect();
            string query = "Select * from MessDetails";
            DataTable dt = dbc.GetTable(query);
            dgvMess.AutoGenerateColumns = false;
            dgvMess.DataSource = dt;
        }

        private void dgvMess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
            try
            {
                ClearData();
                DataGridViewRow row = dgvMess.Rows[rowSelected];
                messID = row.Cells[0].Value.ToString();
                SetData(messID);
            }
            catch (Exception)
            {
                MessageBox.Show("Sorted");
            }
        }
        
        private void MessDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnVerified_Click(object sender, EventArgs e)
        {
            ClearData();
            DBConnect dbc = new DBConnect();
            string stat = "Verified";
            string query = "Select * from MessDetails where status = '" + stat + "' ;";
            DataTable dt = dbc.GetTable(query);
            dgvMess.AutoGenerateColumns = false;
            dgvMess.DataSource = dt;
        }

        private void btnUnverified_Click(object sender, EventArgs e)
        {
            ClearData();
            DBConnect dbc = new DBConnect();
            string stat = "Unverified";
            string query = "Select * from MessDetails where status = '" + stat + "' ;";
            DataTable dt = dbc.GetTable(query);
            dgvMess.AutoGenerateColumns = false;
            dgvMess.DataSource = dt;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            DBConnect dbc = new DBConnect();
            if ("".Equals(txtMessID.Text))
            {
                MessageBox.Show(this, "Data is not selected.");
            }
            else
            {
                String id = txtMessID.Text;
                String stat = "Verified";
                String query = "Update MessDetails set status = '" + stat + "' where messid = '" + id + "'";
                dbc.InsertIntoDatabase(query);
                btnVerified_Click(btnVerified, e);
                SetData(id);
            }
        }

        private void btnDisapprove_Click(object sender, EventArgs e)
        {
            DBConnect dbc = new DBConnect();
            if ("".Equals(txtMessID.Text))
            {
                MessageBox.Show(this, "Data is not selected.");
            }
            else
            {
                String id = txtMessID.Text;
                String stat = "Unverified";
                String query = "Update MessDetails set status = '" + stat + "' where messid = '" + id + "'";
                dbc.InsertIntoDatabase(query);
                btnUnverified_Click(btnUnverified, e);
                SetData(id);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBConnect dbc = new DBConnect();
            if ("".Equals(txtMessID.Text))
            {
                MessageBox.Show(this, "Data is not selected.");
            }
            else
            {
                String id = txtMessID.Text;
                //string folderPath = appStartPath + "\\AdvertisePicture\\MessAdsPicture\\" + id.ToString();
                //DeleteDirectory(folderPath);
                String query = "Delete from MessDetails where messid = '" + id + "' ;";
                dbc.InsertIntoDatabase(query);
                btnAll_Click(btnAll, e);
                ClearData();
                MessageBox.Show("Data Deleted");
            }
        }

        private void pcbxSmallPhoto1_Click(object sender, EventArgs e)
        {
            if (smallPhoto1 != null)
                pcbxLargePhoto.Image = new Bitmap(smallPhoto1);
        }

        private void pcbxSmallPhoto2_Click(object sender, EventArgs e)
        {
            if (smallPhoto2 != null)
                pcbxLargePhoto.Image = new Bitmap(smallPhoto2);
        }

        private void pcbxSmallPhoto3_Click(object sender, EventArgs e)
        {
            if (smallPhoto3 != null)
                pcbxLargePhoto.Image = new Bitmap(smallPhoto3);
        }

        private void pcbxSmallPhoto4_Click(object sender, EventArgs e)
        {
            if (smallPhoto4 != null)
                pcbxLargePhoto.Image = new Bitmap(smallPhoto4);
        }

        private void pcbxSmallPhoto5_Click(object sender, EventArgs e)
        {
            if (smallPhoto5 != null)
                pcbxLargePhoto.Image = new Bitmap(smallPhoto5);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMainPage amp = new AdminMainPage(aid);
            amp.Show();
            this.Hide();
        }
    }
}
