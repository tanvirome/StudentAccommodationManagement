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
    public partial class ShowFlatAds : Form
    {
        public ShowFlatAds()
        {
            InitializeComponent();
        }

        string userid = null;
        string status = null;
        string flatid = null;

        string appStartPath = null;

        string smallPhoto1 = null;
        string smallPhoto2 = null;
        string smallPhoto3 = null;
        string smallPhoto4 = null;
        string smallPhoto5 = null;

        //private string[] ImagesPath;

        public ShowFlatAds(string id, string stat, string fid)
        {
            InitializeComponent();
            userid = id;
            status = stat;
            flatid = fid;
            dtpDate.MinDate = DateTime.Today;
            FillDetails();
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

        public void FillDetails()
        {
            try
            {
                DBConnect dbc = new DBConnect();
                string query = "select * from FlatDetails where flatid = " + flatid + " ;";
                DataSet ds = dbc.GetInfo(query);
                string date = null;
                //string month = null;
                //string year = null;
                string facility = null;
                string rtype = null;
                string photospath = null;

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    txtTitle.Text = ds.Tables[0].Rows[i]["title"].ToString();
                    txtSize.Text = ds.Tables[0].Rows[i]["size"].ToString();
                    txtRent.Text = ds.Tables[0].Rows[i]["rent"].ToString();
                    txtBedroom.Text = ds.Tables[0].Rows[i]["bedroom"].ToString();
                    txtBathroom.Text = ds.Tables[0].Rows[i]["bathroom"].ToString();
                    txtCorridor.Text = ds.Tables[0].Rows[i]["corridor"].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[i]["address"].ToString();
                    txtDetails.Text = ds.Tables[0].Rows[i]["details"].ToString();
                    txtOwnerName.Text = ds.Tables[0].Rows[i]["name"].ToString();
                    txtOwnerEmail.Text = ds.Tables[0].Rows[i]["email"].ToString();
                    txtOwnerPhone.Text = ds.Tables[0].Rows[i]["phone"].ToString();
                    combxCity.Text = ds.Tables[0].Rows[i]["city"].ToString();
                    combxArea.Text = ds.Tables[0].Rows[i]["area"].ToString();
                    photospath = ds.Tables[0].Rows[i]["photo"].ToString();
                    date = ds.Tables[0].Rows[i]["date"].ToString();
                    facility = ds.Tables[0].Rows[i]["specialfacility"].ToString();
                    rtype = ds.Tables[0].Rows[i]["renttype"].ToString();
                }
                ShowSpecialFacility(facility);
                if (rtype == "(Fixed)")
                {
                    rbtnFixed.Checked = true;
                    rbtnNegotiable.Checked = false;
                }
                else if (rtype == "(Negotiable)")
                {
                    rbtnNegotiable.Checked = true;
                    rbtnFixed.Checked = false;
                }
                ShowPhoto(photospath);
                dtpDate.Value=DateTime.ParseExact(date, "dd.MM.yyyy", null);
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
            if(smallPhoto1 != null)
            {
                pcbxLargePhoto.Image = new Bitmap(smallPhoto1);
                pcbxSmallPhoto1.Image = new Bitmap(smallPhoto1);
            }
            if(smallPhoto2 != null)
                pcbxSmallPhoto2.Image = new Bitmap(smallPhoto2);
            if (smallPhoto3 != null)
                pcbxSmallPhoto3.Image = new Bitmap(smallPhoto3);
            if (smallPhoto4 != null)
                pcbxSmallPhoto4.Image = new Bitmap(smallPhoto4);
            if (smallPhoto5 != null)
                pcbxSmallPhoto5.Image = new Bitmap(smallPhoto5);
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

        public void ShowSpecialFacility(string sp)
        {
            if (sp == "Lift, Generator, WiFi")
            {
                chkLift.Checked = true;
                chkWifi.Checked = true;
                chkGenerator.Checked = true;
            }
            else if (sp == "Lift, Generator")
            {
                chkLift.Checked = true;
                chkGenerator.Checked = true;
            }
            else if (sp == "Generator, WiFi")
            {
                chkWifi.Checked = true;
                chkGenerator.Checked = true;
            }
            else if (sp == "Lift, WiFi")
            {
                chkWifi.Checked = true;
                chkLift.Checked = true;
            }
            else if (sp == "Lift")
            {
                chkLift.Checked = true;
            }
            else if (sp == "Generator")
            {
                chkGenerator.Checked = true;
            }
            else if (sp == "WiFi")
            {
                chkWifi.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            //string month = combxMonth.GetItemText(combxMonth.SelectedItem);
            //string year = combxYear.GetItemText(combxYear.SelectedItem);
            //string date = month + ", " + year;
            string date= dtpDate.Text;
            string size = txtSize.Text;
            string bedroom = txtBedroom.Text;
            string bathroom = txtBathroom.Text;
            string corridor = txtCorridor.Text;
            string rent = txtRent.Text;
            string renttype = null;

            if (rbtnFixed.Checked)
            {
                renttype = "(Fixed)";
            }
            else if (rbtnNegotiable.Checked)
            {
                renttype = "(Negotiable)";
            }

            String specialFacility = null;

            if (chkLift.Checked == true && chkWifi.Checked == true && chkGenerator.Checked == true)
            {
                specialFacility = "Lift, Generator, WiFi";
            }
            else if (chkLift.Checked == true && chkGenerator.Checked == true)
            {
                specialFacility = "Lift, Generator";
            }
            else if (chkGenerator.Checked == true && chkWifi.Checked == true)
            {
                specialFacility = "Generator, WiFi";
            }
            else if (chkLift.Checked == true && chkWifi.Checked == true)
            {
                specialFacility = "Lift, WiFi";
            }
            else if (chkLift.Checked)
            {
                specialFacility = "Lift";
            }
            else if (chkGenerator.Checked)
            {
                specialFacility = "Generator";
            }
            else if (chkWifi.Checked)
            {
                specialFacility = "WiFi";
            }

            string address = txtAddress.Text;
            string city = combxCity.GetItemText(combxCity.SelectedItem);
            string area = combxArea.GetItemText(combxArea.SelectedItem);
            string details = txtDetails.Text;
            string ownerName = txtOwnerName.Text;
            string ownerEmail = txtOwnerEmail.Text;
            string ownerPhone = txtOwnerPhone.Text;
            string newstatus = "Unverified";

            try
            {
                DBConnect dbc = new DBConnect();

                String query = "Update FlatDetails set userid = " + userid + ", title = '" + title + "', date = '" + date + "', size = " + size + ", bedroom = "
                    + bedroom + ", bathroom = " + bathroom + ", corridor= " + corridor + ", rent= " + rent + ", renttype= '" + renttype + "', specialfacility= '"
                    + specialFacility + "', address = '" + address + "', city = '" + city + "', area = '" + area + "', details = '" + details + "', name = '"
                    + ownerName + "', email = '" + ownerEmail + "', phone = '" + ownerPhone + "', status = '" + newstatus + "' where flatid = " + flatid + " ;";
                
                dbc.InsertIntoDatabase(query);
                MessageBox.Show("Ads Updated! Wait For Verification");
                ShowYourAds sya = new ShowYourAds(userid, status);
                sya.Show();
                this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show("Enter All Data Correctly");
                Console.WriteLine("Error : " + er);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect dbc = new DBConnect();

                //string folderPath = appStartPath + "\\AdvertisePicture\\FlatAdsPicture\\" + flatid.ToString();

                //DeleteDirectory(folderPath);
                
                //if (Directory.Exists(folderPath))
                //{
                //    Directory.Delete(folderPath, true);
                //}

                String query = "Delete from FlatDetails where flatid = " + flatid + " ;";
                
                dbc.InsertIntoDatabase(query);

                MessageBox.Show("Ads Deleted!");
                ShowYourAds sya = new ShowYourAds(userid, status);
                sya.Show();
                this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show("Enter All Data Correctly");
                Console.WriteLine("Error : " + er);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowYourAds sya = new ShowYourAds(userid, status);
            sya.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowYourAds sya = new ShowYourAds(userid, status);
            sya.Show();
            this.Hide();
        }

        private void pcbxSmallPhoto1_Click(object sender, EventArgs e)
        {
            if(smallPhoto1 != null)
            {
                pcbxLargePhoto.Image = new Bitmap(smallPhoto1);
            }
        }

        private void pcbxSmallPhoto2_Click(object sender, EventArgs e)
        {
            if (smallPhoto2 != null)
            {
                pcbxLargePhoto.Image = new Bitmap(smallPhoto2);
            }
        }

        private void pcbxSmallPhoto3_Click(object sender, EventArgs e)
        {
            if (smallPhoto3 != null)
            {
                pcbxLargePhoto.Image = new Bitmap(smallPhoto3);
            }
        }

        private void pcbxSmallPhoto4_Click(object sender, EventArgs e)
        {
            if (smallPhoto4 != null)
            {
                pcbxLargePhoto.Image = new Bitmap(smallPhoto4);
            }
        }

        private void pcbxSmallPhoto5_Click(object sender, EventArgs e)
        {
            if (smallPhoto5 != null)
            {
                pcbxLargePhoto.Image = new Bitmap(smallPhoto5);
            }
        }

        private void ShowFlatAds_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
