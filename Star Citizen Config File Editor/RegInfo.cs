using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Star_Citizen_Config_File_Editor
{
    /// <summary>
    /// Contains all functions related to reading/writing from registery.
    /// </summary>
    public static class RegInfo
    {
        /// <summary>
        /// Default RegistryKey used for the software.
        /// </summary>
        private const string SubKey = @"\SOFTWARE\StarCitizenRegEditor";

        /// <summary>
        /// Directory of the Star Citizen install.
        /// INSTALL FOLDER\Cloud Imperium Games\StarCitizen\LIVE\
        /// </summary>
        public static string LIVEInstallDirectory = "";

        public static string PUTInstallDirectory = "";

        public static string ProfilesDirectory = "";

        public static void Initialize()
        {
            RegistryKey getKey = Registry.CurrentUser.OpenSubKey(SubKey);

            if (getKey != null)
            {
            }
            else
            {
                //warn the user that an install directory has not been found
                var result = MessageBox.Show("Star Citizen Install Directory Not Found \nPlease locate the Star Citizen Root Directory \nExample: C:", "Install Directory Not Found"  , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.OK)
                {

                }
            }
        }

        private static void GetInstallDirectory()
        {

        }

    }
}
