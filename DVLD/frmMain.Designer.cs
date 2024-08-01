namespace DVLD
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMainMenue = new System.Windows.Forms.MenuStrip();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLocalDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageInternationaDrivingLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.DetainLicensesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageDetainedLicensestoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msMainMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMainMenue
            // 
            this.msMainMenue.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.msMainMenue, "msMainMenue");
            this.msMainMenue.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMainMenue.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMainMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicesToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.msMainMenue.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.msMainMenue.Name = "msMainMenue";
            // 
            // lblLoggedInUser
            // 
            resources.ApplyResources(this.lblLoggedInUser, "lblLoggedInUser");
            this.lblLoggedInUser.BackColor = System.Drawing.SystemColors.Control;
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicensesToolStripMenuItem,
            this.toolStripSeparator6,
            this.tsMManageApplications,
            this.toolStripSeparator5,
            this.DetainLicensesToolStripMenuItem1,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.servicesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Applications_64;
            resources.ApplyResources(this.servicesToolStripMenuItem, "servicesToolStripMenuItem");
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            // 
            // drivingLicensesToolStripMenuItem
            // 
            this.drivingLicensesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.drivingLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNewDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.toolStripSeparator1,
            this.ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem,
            this.toolStripSeparator2,
            this.releaseDetainedDrivingLicenseToolStripMenuItem,
            this.retakeTestToolStripMenuItem1});
            this.drivingLicensesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Driver_License_32;
            resources.ApplyResources(this.drivingLicensesToolStripMenuItem, "drivingLicensesToolStripMenuItem");
            this.drivingLicensesToolStripMenuItem.Name = "drivingLicensesToolStripMenuItem";
            // 
            // oNewDrivingLicenseToolStripMenuItem
            // 
            this.oNewDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.oNewDrivingLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.New_Driving_License_32;
            resources.ApplyResources(this.oNewDrivingLicenseToolStripMenuItem, "oNewDrivingLicenseToolStripMenuItem");
            this.oNewDrivingLicenseToolStripMenuItem.Name = "oNewDrivingLicenseToolStripMenuItem";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Local_32;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            resources.ApplyResources(this.localLicenseToolStripMenuItem, "localLicenseToolStripMenuItem");
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.internationalLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.International_32;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            resources.ApplyResources(this.internationalLicenseToolStripMenuItem, "internationalLicenseToolStripMenuItem");
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            resources.ApplyResources(this.renewDrivingLicenseToolStripMenuItem, "renewDrivingLicenseToolStripMenuItem");
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem
            // 
            this.ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Damaged_Driving_License_32;
            resources.ApplyResources(this.ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem, "ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem");
            this.ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem.Name = "ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem";
            this.ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detained_Driving_License_32;
            resources.ApplyResources(this.releaseDetainedDrivingLicenseToolStripMenuItem, "releaseDetainedDrivingLicenseToolStripMenuItem");
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedDrivingLicenseToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem1
            // 
            this.retakeTestToolStripMenuItem1.Image = global::DVLD.Properties.Resources.Retake_Test_32;
            resources.ApplyResources(this.retakeTestToolStripMenuItem1, "retakeTestToolStripMenuItem1");
            this.retakeTestToolStripMenuItem1.Name = "retakeTestToolStripMenuItem1";
            this.retakeTestToolStripMenuItem1.Click += new System.EventHandler(this.retakeTestToolStripMenuItem1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // tsMManageApplications
            // 
            this.tsMManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLocalDrivingLicenseApplicationsToolStripMenuItem,
            this.ManageInternationaDrivingLicenseToolStripMenuItem1});
            this.tsMManageApplications.Image = global::DVLD.Properties.Resources.Manage_Applications_64;
            resources.ApplyResources(this.tsMManageApplications, "tsMManageApplications");
            this.tsMManageApplications.Name = "tsMManageApplications";
            // 
            // manageLocalDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.manageLocalDrivingLicenseApplicationsToolStripMenuItem.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            resources.ApplyResources(this.manageLocalDrivingLicenseApplicationsToolStripMenuItem, "manageLocalDrivingLicenseApplicationsToolStripMenuItem");
            this.manageLocalDrivingLicenseApplicationsToolStripMenuItem.Name = "manageLocalDrivingLicenseApplicationsToolStripMenuItem";
            this.manageLocalDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.manageLocalDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // ManageInternationaDrivingLicenseToolStripMenuItem1
            // 
            this.ManageInternationaDrivingLicenseToolStripMenuItem1.Image = global::DVLD.Properties.Resources.International_32;
            resources.ApplyResources(this.ManageInternationaDrivingLicenseToolStripMenuItem1, "ManageInternationaDrivingLicenseToolStripMenuItem1");
            this.ManageInternationaDrivingLicenseToolStripMenuItem1.Name = "ManageInternationaDrivingLicenseToolStripMenuItem1";
            this.ManageInternationaDrivingLicenseToolStripMenuItem1.Click += new System.EventHandler(this.ManageInternationaDrivingLicenseToolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // DetainLicensesToolStripMenuItem1
            // 
            this.DetainLicensesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageDetainedLicensestoolStripMenuItem1,
            this.detainLicenseToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.DetainLicensesToolStripMenuItem1.Image = global::DVLD.Properties.Resources.Detain_64;
            resources.ApplyResources(this.DetainLicensesToolStripMenuItem1, "DetainLicensesToolStripMenuItem1");
            this.DetainLicensesToolStripMenuItem1.Name = "DetainLicensesToolStripMenuItem1";
            // 
            // ManageDetainedLicensestoolStripMenuItem1
            // 
            this.ManageDetainedLicensestoolStripMenuItem1.Image = global::DVLD.Properties.Resources.Detain_32;
            resources.ApplyResources(this.ManageDetainedLicensestoolStripMenuItem1, "ManageDetainedLicensestoolStripMenuItem1");
            this.ManageDetainedLicensestoolStripMenuItem1.Name = "ManageDetainedLicensestoolStripMenuItem1";
            this.ManageDetainedLicensestoolStripMenuItem1.Click += new System.EventHandler(this.ManageDetainedLicensestoolStripMenuItem1_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detain_32;
            resources.ApplyResources(this.detainLicenseToolStripMenuItem, "detainLicenseToolStripMenuItem");
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            resources.ApplyResources(this.releaseDetainedLicenseToolStripMenuItem, "releaseDetainedLicenseToolStripMenuItem");
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Application_Types_64;
            resources.ApplyResources(this.manageApplicationTypesToolStripMenuItem, "manageApplicationTypesToolStripMenuItem");
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_Type_64;
            resources.ApplyResources(this.manageTestTypesToolStripMenuItem, "manageTestTypesToolStripMenuItem");
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            resources.ApplyResources(this.peopleToolStripMenuItem, "peopleToolStripMenuItem");
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = global::DVLD.Properties.Resources.Drivers_64;
            resources.ApplyResources(this.driversToolStripMenuItem, "driversToolStripMenuItem");
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Users_2_64;
            resources.ApplyResources(this.employeesToolStripMenuItem, "employeesToolStripMenuItem");
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator4,
            this.signOutToolStripMenuItem});
            this.closeToolStripMenuItem.Image = global::DVLD.Properties.Resources.account_settings_64;
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            resources.ApplyResources(this.currentUserInfoToolStripMenuItem, "currentUserInfoToolStripMenuItem");
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::DVLD.Properties.Resources.Password_32;
            resources.ApplyResources(this.changePasswordToolStripMenuItem, "changePasswordToolStripMenuItem");
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = global::DVLD.Properties.Resources.sign_out_32__2;
            resources.ApplyResources(this.signOutToolStripMenuItem, "signOutToolStripMenuItem");
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::DVLD.Properties.Resources.DVLD_Logo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.msMainMenue);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainMenue;
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMainMenue.ResumeLayout(false);
            this.msMainMenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenue;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMManageApplications;
        private System.Windows.Forms.ToolStripMenuItem manageLocalDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ManageInternationaDrivingLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DetainLicensesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageDetainedLicensestoolStripMenuItem1;
    }
}

