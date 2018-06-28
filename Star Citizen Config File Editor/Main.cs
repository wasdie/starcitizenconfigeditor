using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Star_Citizen_Config_File_Editor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }



        #region Event Handlers
        /// <summary>
        /// Load event. Called when Main form is loaded for the first time. Controls will be blank or defaulted.
        /// </summary>
        /// <param name="sender">Main</param>
        /// <param name="e">Load event.</param>
        private void Main_Load(object sender, EventArgs e)
        {
            //initialize the registry info
            RegInfo.Initialize();

            //assuming everything went right, we want to update the labels accordingly
            lblRootDirectory.Text = RegInfo.LIVEInstallDirectory;
            lblPTUDirectory.Text = RegInfo.PUTInstallDirectory;
        }
        #endregion


    }
}
