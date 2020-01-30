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

namespace StudentAccommodation.Owner
{
    public partial class ShowYourAds : Form
    {
        public ShowYourAds()
        {
            InitializeComponent();
        }

        string userid = null;
        string status = null;
        string adID = null;
        int rowSelected;

        public ShowYourAds(String id, string stat)
        {
            InitializeComponent();
            cmbAd.SelectedIndex = 0;
            userid = id;
            status = stat;
            //AllData(id);
        }

        public ShowYourAds(String id, string stat, string hid)
        {
            InitializeComponent();
            cmbAd.SelectedIndex = 0;
            userid = id;
            status = stat;
            //DeletePhotosFolder(hid);
            //AllData(id);
        }

        public static void DeleteDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }

            //foreach (string directory in Directory.GetDirectories(path))
            //{
            //    DeleteDirectory(directory);
            //}

            //try
            //{
            //    Directory.Delete(path, true);
            //}
            //catch (UnauthorizedAccessException)
            //{
            //    Directory.Delete(path, true);
            //}
            //catch (IOException)
            //{
            //    Directory.Delete(path, true);
            //}
        }

        public void DeletePhotosFolder(string hid)
        {
            string appStartPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if (adID.StartsWith("1"))
            {
                string folderPath = appStartPath + "\\AdvertisePicture\\FlatAdsPicture\\" + hid.ToString();
                DeleteDirectory(folderPath);
            }
            else if (adID.StartsWith("5"))
            {
                string folderPath = appStartPath + "\\AdvertisePicture\\MessAdsPicture\\" + hid.ToString();
                DeleteDirectory(folderPath);
            }
            else if (adID.StartsWith("3"))
            {
                string folderPath = appStartPath + "\\AdvertisePicture\\SubletAdsPicture\\" + hid.ToString();
                DeleteDirectory(folderPath);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OwnerHomePage ohp = new OwnerHomePage(userid, status);
            ohp.Show();
            this.Hide();
        }

        private void dgvShowAds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
            try
            {
                DataGridViewRow row = dgvShowAds.Rows[rowSelected];
                adID = row.Cells[0].Value.ToString();
                //MessageBox.Show(adID);
                //AllData(userID);

                if (adID.StartsWith("1"))
                {
                    ShowFlatAds sfa = new ShowFlatAds(userid, status, adID);
                    sfa.Show();
                    this.Hide();
                }
                else if (adID.StartsWith("5"))
                {
                    ShowMessAds sma = new ShowMessAds(userid, status, adID);
                    sma.Show();
                    this.Hide();
                }
                else if (adID.StartsWith("3"))
                {
                    ShowSubletAds ssa = new ShowSubletAds(userid, status, adID);
                    ssa.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorted");
            }
        }

        private void ShowYourAds_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmbAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbAd.SelectedItem.ToString();
            if (selected == "       Flat Ads")
            {
                DBConnect dbc = new DBConnect();
                dgvShowAds.Columns[0].DataPropertyName = "flatid";
                //string query = "Select * from FlatDetails";
                string query = "Select * from FlatDetails where userid = '" + userid + "';";
                DataTable dt = dbc.GetTable(query);
                dgvShowAds.AutoGenerateColumns = false;
                dgvShowAds.DataSource = dt;
            }
            else if (selected == "      Mess Ads")
            {
                DBConnect dbc = new DBConnect();
                dgvShowAds.Columns[0].DataPropertyName = "messid";
                //string query = "Select * from MessDetails";
                string query = "Select * from MessDetails where userid = '" + userid + "';";
                DataTable dt = dbc.GetTable(query);
                dgvShowAds.AutoGenerateColumns = false;
                dgvShowAds.DataSource = dt;
            }
            else if (selected == "     Sublet Ads")
            {
                DBConnect dbc = new DBConnect();
                dgvShowAds.Columns[0].DataPropertyName = "subletid";
                //string query = "Select * from SubletDetails";
                string query = "Select * from SubletDetails where userid = '" + userid + "';";
                DataTable dt = dbc.GetTable(query);
                dgvShowAds.AutoGenerateColumns = false;
                dgvShowAds.DataSource = dt;
            }
        }
    }
}
