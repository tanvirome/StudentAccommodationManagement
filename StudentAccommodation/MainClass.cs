using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAccommodation
{
    static class MainClass
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
            //Application.Run(new Owner.OwnerHomePage());
            //Application.Run(new Owner.OwnerProfile());
            //Application.Run(new Owner.PasswordChange());
            //Application.Run(new Owner.OwnerEditInformation());
            //Application.Run(new Owner.AdsFlat());
            //Application.Run(new Owner.AdsMess());
            //Application.Run(new Owner.AdsSublet());
            //Application.Run(new Owner.ShowYourAds());
            //Application.Run(new Owner.ShowFlatAds());
            //Application.Run(new Owner.ShowMessAds());
            //Application.Run(new Owner.ShowSubletAds());
            //Application.Run(new Student.StudentHomePage());
            //Application.Run(new Student.StudentEditInformation());
            //Application.Run(new Student.StudentProfile());
            //Application.Run(new Student.SearchFlat());
            //Application.Run(new Student.ShowFlatDetails());
            //Application.Run(new Student.SearchMess());
            //Application.Run(new Student.ShowMessDetails());
            //Application.Run(new Student.SearchSublet());
            //Application.Run(new Student.ShowSubletDetails());
            //Application.Run(new Admin.AdminLogIn());
            //Application.Run(new Admin.AdminMainPage());
            //Application.Run(new Admin.StudentDetails());
            //Application.Run(new Admin.OwnerDetails());
            //Application.Run(new Admin.FlatDetails());
            //Application.Run(new Admin.MessDetails());
            //Application.Run(new Admin.SubletDetails());

        }
    }
}
