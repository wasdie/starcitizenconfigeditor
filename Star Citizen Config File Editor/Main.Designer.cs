namespace Star_Citizen_Config_File_Editor
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.lblRootDirectoryHead = new System.Windows.Forms.Label();
            this.lblRootDirectory = new System.Windows.Forms.Label();
            this.lblPTUDirectoryHead = new System.Windows.Forms.Label();
            this.lblPTUDirectory = new System.Windows.Forms.Label();
            this.directoriesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // directoriesGroupBox
            // 
            this.directoriesGroupBox.Controls.Add(this.lblPTUDirectory);
            this.directoriesGroupBox.Controls.Add(this.lblPTUDirectoryHead);
            this.directoriesGroupBox.Controls.Add(this.lblRootDirectory);
            this.directoriesGroupBox.Controls.Add(this.lblRootDirectoryHead);
            this.directoriesGroupBox.Location = new System.Drawing.Point(12, 474);
            this.directoriesGroupBox.Name = "directoriesGroupBox";
            this.directoriesGroupBox.Size = new System.Drawing.Size(478, 76);
            this.directoriesGroupBox.TabIndex = 0;
            this.directoriesGroupBox.TabStop = false;
            this.directoriesGroupBox.Text = "Directories";
            // 
            // lblRootDirectoryHead
            // 
            this.lblRootDirectoryHead.AutoSize = true;
            this.lblRootDirectoryHead.Location = new System.Drawing.Point(6, 28);
            this.lblRootDirectoryHead.Name = "lblRootDirectoryHead";
            this.lblRootDirectoryHead.Size = new System.Drawing.Size(134, 13);
            this.lblRootDirectoryHead.TabIndex = 0;
            this.lblRootDirectoryHead.Text = "Star Citizen Root Directory:";
            // 
            // lblRootDirectory
            // 
            this.lblRootDirectory.AutoSize = true;
            this.lblRootDirectory.Location = new System.Drawing.Point(146, 28);
            this.lblRootDirectory.Name = "lblRootDirectory";
            this.lblRootDirectory.Size = new System.Drawing.Size(134, 13);
            this.lblRootDirectory.TabIndex = 1;
            this.lblRootDirectory.Text = "Star Citizen Root Directory:";
            // 
            // lblPTUDirectoryHead
            // 
            this.lblPTUDirectoryHead.AutoSize = true;
            this.lblPTUDirectoryHead.Location = new System.Drawing.Point(6, 54);
            this.lblPTUDirectoryHead.Name = "lblPTUDirectoryHead";
            this.lblPTUDirectoryHead.Size = new System.Drawing.Size(134, 13);
            this.lblPTUDirectoryHead.TabIndex = 2;
            this.lblPTUDirectoryHead.Text = "Star Citizen Root Directory:";
            // 
            // lblPTUDirectory
            // 
            this.lblPTUDirectory.AutoSize = true;
            this.lblPTUDirectory.Location = new System.Drawing.Point(146, 54);
            this.lblPTUDirectory.Name = "lblPTUDirectory";
            this.lblPTUDirectory.Size = new System.Drawing.Size(134, 13);
            this.lblPTUDirectory.TabIndex = 3;
            this.lblPTUDirectory.Text = "Star Citizen Root Directory:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 562);
            this.Controls.Add(this.directoriesGroupBox);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Star Citizen Config Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.directoriesGroupBox.ResumeLayout(false);
            this.directoriesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox directoriesGroupBox;
        private System.Windows.Forms.Label lblRootDirectory;
        private System.Windows.Forms.Label lblRootDirectoryHead;
        private System.Windows.Forms.Label lblPTUDirectory;
        private System.Windows.Forms.Label lblPTUDirectoryHead;
    }
}

