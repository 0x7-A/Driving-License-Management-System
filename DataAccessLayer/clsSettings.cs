using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DataAccessLayer
{
    static class clsSettings
    {

        public static  string FileName = "Login.txt";
        public static  string SourceName = "DVDL_Application";
        public static char Seprator = '#';

    

        
    

        public static string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
        public static string subKey = @"SOFTWARE\DVLD";

        /// </summary>
        /// Username property to read from rigester
        /// </summary>
        public static string ValueName1 = "Username";

        /// </summary>
        /// Password property to read from rigester
        /// </summary>
        public static string ValueName2 = "Password";


        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DVLD_ConnectionString"].ConnectionString;
    }

}