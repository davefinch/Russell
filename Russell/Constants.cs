using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;

namespace Russell
{
    public static class Constants
    {
        public static string ConnectionString { get; private set; }
        public static string UserFullName { get; private set; }
        public static int UserId { get; private set; }
        public static string StartupFolder { get; private set; }
        public static string AppName { get; private set; }
        public static string AppVersion { get; private set; }
        public enum RetrievalStatus
        {
            Single,
            Multiple
        };

        static Constants()
        {
            StartupFolder = ConfigurationManager.AppSettings["StartupFolder"];

            //ConnectionString = ConfigurationManager.ConnectionStrings["JO"].ConnectionString;
            ConnectionString = ConfigurationManager.ConnectionStrings["Joe"].ConnectionString;

            UserFullName = UserPrincipal.Current.DisplayName;

            // Should get this from the DB but only one user for now
            if (UserFullName == "Russell Jones")
            {
                UserId = 1;
                UserFullName = "Joe Finch";
            }
            else
            {
                UserId = 2;
            }

            AppName = ConfigurationManager.AppSettings["AplicationName"];
            AppVersion = ConfigurationManager.AppSettings["ApplicationVersion"];

            


        }

    }
}
