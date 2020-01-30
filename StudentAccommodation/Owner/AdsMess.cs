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

namespace StudentAccommodation.Owner
{
    public partial class AdsMess : Form
    {
        public AdsMess()
        {
            InitializeComponent();
        }

        //static int fid = 100001;
        string userid = null;
        string status = null;
        private string[] files;
        string dpath = null;

        public AdsMess(String id, string stat)
        {
            InitializeComponent();
            userid = id;
            status = stat;
            dtpDate.MinDate = DateTime.Today;
            dtpDate.Value = DateTime.Today;
            combxArea.SelectedIndex = 0;
            combxCity.SelectedIndex = 0;
        }

        public void SavePicture()
        {
            string appStartPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            string mid = null;
            try
            {
                DBConnect dbc = new DBConnect();
                string query = "SELECT IDENT_CURRENT('MessDetails') ;";
                DataSet ds = dbc.GetInfo(query);
                mid = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
            }
            int id = Convert.ToInt32(mid) + 1;
            mid = id.ToString();
            string savePath = "\\AdvertisePicture\\MessAdsPicture\\" + mid.ToString() + "\\";
            string createPath = appStartPath + savePath;

            if (!Directory.Exists(createPath))
            {
                Directory.CreateDirectory(createPath);
            }

            for (int i = 0; i < files.Length; i++)
            {
                File.Copy(files[i], Path.Combine((appStartPath + savePath), Path.GetFileName(files[i])), true);

                if (dpath == null)
                {
                    dpath = savePath + Path.GetFileName(files[i]);
                }
                else
                {
                    dpath = dpath + "@" + (savePath + Path.GetFileName(files[i]));
                }
            }
        }

        private void btnSubmitAds_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            //string month = combxMonth.GetItemText(combxMonth.SelectedItem);
            //string year = combxYear.GetItemText(combxYear.SelectedItem);
            //string date = month + ", " + year;
            string date = dtpDate.Text;
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

            string seat = txtSeat.Text;
            string address = txtAddress.Text;
            string city = combxCity.GetItemText(combxCity.SelectedItem);
            string area = combxArea.GetItemText(combxArea.SelectedItem);
            string details = txtDetails.Text;

            string ownerName = txtOwnerName.Text;
            string ownerEmail = txtOwnerEmail.Text;
            string ownerPhone = txtOwnerPhone.Text;

            SavePicture();

            try
            {
                DBConnect dbc = new DBConnect();

                string query = "insert into MessDetails(userid, title, date, rent, renttype, seat, address, city, area, details, name, email, phone, photo) values("
                        + userid + ",'" + title + "','" + date + "',"+ rent + ",'" + renttype + "'," + seat + ",'" + address + "','" + city + "','" + area + "','"
                        + details + "','" + ownerName + "','" + ownerEmail + "','" + ownerPhone + "','" + dpath + "' " + ");";

                dbc.InsertIntoDatabase(query);
                MessageBox.Show("Ads Posted! Wait For Verification");
                OwnerHomePage ohp = new OwnerHomePage(userid, status);
                ohp.Show();
                this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show("Enter All Data Correctly");
                Console.WriteLine("Error : " + er);
            }
        }

        private void btnChoosePhotos_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            string txtpaths = null;
            open.Multiselect = true;
            open.Filter = "JPG(*.jpg)|*.jpg; |JPEG(*.jpeg)|*.jpeg; |PNG(*.png)|*.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                files = open.FileNames;
                if (files.Length > 5)
                {
                    MessageBox.Show(this, "Please Select Max 5 Pictures");
                }
                else
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        if (txtpaths == null)
                        {
                            txtpaths = Path.GetFileName(files[i]);
                        }
                        else
                        {
                            txtpaths = txtpaths + "\n" + Path.GetFileName(files[i]);
                        }
                    }
                }
                txtPhoto.Text = txtpaths;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OwnerHomePage ohp = new OwnerHomePage(userid, status);
            ohp.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OwnerHomePage ohp = new OwnerHomePage(userid, status);
            ohp.Show();
            this.Hide();
        }

        private void AdsMess_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
