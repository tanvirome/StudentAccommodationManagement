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
    public partial class ShowSubletDetails : Form
    {
        public ShowSubletDetails()
        {
            InitializeComponent();
        }

        string userid = null;
        string status = null;
        string subletid = null;
        string smallPhoto1 = null;
        string smallPhoto2 = null;
        string smallPhoto3 = null;
        string smallPhoto4 = null;
        string smallPhoto5 = null;

        //private string[] ImagesPath;

        public ShowSubletDetails(String id, string stat, string sid)
        {
            InitializeComponent();
            userid = id;
            status = stat;
            subletid = sid;
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
                string query = "select * from SubletDetails where subletid = '" + subletid + "'";
                DataSet ds = dbc.GetInfo(query);
                string photospath = null;
                string rent1 = null;
                string rent2 = null;


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    txtTitle.Text = ds.Tables[0].Rows[i]["title"].ToString();
                    rent1 = ds.Tables[0].Rows[i]["rent"].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[i]["address"].ToString();
                    txtDetails.Text = ds.Tables[0].Rows[i]["details"].ToString();
                    txtOwnerName.Text = ds.Tables[0].Rows[i]["name"].ToString();
                    txtOwnerEmail.Text = ds.Tables[0].Rows[i]["email"].ToString();
                    txtOwnerPhone.Text = ds.Tables[0].Rows[i]["phone"].ToString();
                    txtCity.Text = ds.Tables[0].Rows[i]["city"].ToString();
                    txtArea.Text = ds.Tables[0].Rows[i]["area"].ToString();
                    txtDate.Text = ds.Tables[0].Rows[i]["date"].ToString();
                    txtFacility.Text = ds.Tables[0].Rows[i]["specialfacility"].ToString();
                    rent2 = ds.Tables[0].Rows[i]["renttype"].ToString();
                    photospath = ds.Tables[0].Rows[i]["photo"].ToString();
                }

                txtRent.Text = rent1 + " " + rent2;
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
            string appStartPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
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
            SearchSublet ss = new SearchSublet(userid, status);
            ss.Show();
            this.Hide();
        }

        private void ShowSubletDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
