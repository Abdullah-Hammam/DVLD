using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Buisness;
using Microsoft.Win32;


namespace DVLD.Classes
{
    internal static  class clsGlobal
    {
        public static clsUser CurrentUser;


        public static bool RememberUserNameAndPasswordInRegistry(string username, string password)
        {
            string PathRegistry = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

            string ValueName = "UserInfo";
            string ValueData = username + "#//#" + password;

            try
            {
                Registry.SetValue(PathRegistry, ValueName, ValueData);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

        }

        public static bool GetInfoUserByRegistry(ref string username, ref string password)
        {
            string PathRegistry = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string ValueName = "UserInfo";

            try
            {
                string line = Registry.GetValue(PathRegistry, ValueName, null) as string;

                if (line == null || line == "")
                {
                    username = "";
                    password = "";
                    return false;
                }
                else
                {
                    string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                    username = result[0];
                    password = result[1];
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

        }


    }
}
