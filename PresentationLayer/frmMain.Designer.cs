namespace Project_19_DVDL__2nd_
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
            menuStrip1 = new MenuStrip();
            appToolStripMenuItem = new ToolStripMenuItem();
            drivingLicensesServicesToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            replacementForLostOrDamageToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            releaseDetainedDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            retakeTestToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationsToolStripMenuItem = new ToolStripMenuItem();
            localDrivingLicenseApplicaionsToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            detainLicensesToolStripMenuItem = new ToolStripMenuItem();
            manaToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicensesToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationTypeToolStripMenuItem = new ToolStripMenuItem();
            mangeTestTypesToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            accountSittingToolStripMenuItem = new ToolStripMenuItem();
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { appToolStripMenuItem, peopleToolStripMenuItem, usersToolStripMenuItem, driversToolStripMenuItem, accountSittingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1807, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            appToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicensesServicesToolStripMenuItem, manageApplicationsToolStripMenuItem, detainLicensesToolStripMenuItem, manageApplicationTypeToolStripMenuItem, mangeTestTypesToolStripMenuItem });
            appToolStripMenuItem.Image = Properties.Resources.Applications;
            appToolStripMenuItem.Name = "appToolStripMenuItem";
            appToolStripMenuItem.Size = new Size(132, 36);
            appToolStripMenuItem.Text = "Application";
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem, renewDrivingLicenseToolStripMenuItem, toolStripMenuItem2, replacementForLostOrDamageToolStripMenuItem, toolStripMenuItem1, releaseDetainedDrivingLicenseToolStripMenuItem, retakeTestToolStripMenuItem });
            drivingLicensesServicesToolStripMenuItem.Image = Properties.Resources.LocalDriving_License;
            drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            drivingLicensesServicesToolStripMenuItem.Size = new Size(262, 26);
            drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, internationalLicenseToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.Image = Properties.Resources.New_Driving_License_32;
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(312, 26);
            newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Image = Properties.Resources.Local_32;
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(228, 26);
            localLicenseToolStripMenuItem.Text = "Local License";
            localLicenseToolStripMenuItem.Click += localLicenseToolStripMenuItem_Click;
            // 
            // internationalLicenseToolStripMenuItem
            // 
            internationalLicenseToolStripMenuItem.Image = Properties.Resources.International_32;
            internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            internationalLicenseToolStripMenuItem.Size = new Size(228, 26);
            internationalLicenseToolStripMenuItem.Text = "International License";
            internationalLicenseToolStripMenuItem.Click += internationalLicenseToolStripMenuItem_Click;
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            renewDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Renew_Driving_License_32;
            renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            renewDrivingLicenseToolStripMenuItem.Size = new Size(312, 26);
            renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            renewDrivingLicenseToolStripMenuItem.Click += renewDrivingLicenseToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(309, 6);
            // 
            // replacementForLostOrDamageToolStripMenuItem
            // 
            replacementForLostOrDamageToolStripMenuItem.Image = Properties.Resources.Damaged_Driving_License_32;
            replacementForLostOrDamageToolStripMenuItem.Name = "replacementForLostOrDamageToolStripMenuItem";
            replacementForLostOrDamageToolStripMenuItem.Size = new Size(312, 26);
            replacementForLostOrDamageToolStripMenuItem.Text = "Replacement for Lost or Damage";
            replacementForLostOrDamageToolStripMenuItem.Click += replacementForLostOrDamageToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(309, 6);
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            releaseDetainedDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Detained_Driving_License_32;
            releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            releaseDetainedDrivingLicenseToolStripMenuItem.Size = new Size(312, 26);
            releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            releaseDetainedDrivingLicenseToolStripMenuItem.Click += releaseDetainedDrivingLicenseToolStripMenuItem_Click;
            // 
            // retakeTestToolStripMenuItem
            // 
            retakeTestToolStripMenuItem.Image = Properties.Resources.Retake_Test_32;
            retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            retakeTestToolStripMenuItem.Size = new Size(312, 26);
            retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localDrivingLicenseApplicaionsToolStripMenuItem, internationalLicenseApplicationsToolStripMenuItem });
            manageApplicationsToolStripMenuItem.Image = Properties.Resources.Manage_Applications_32;
            manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            manageApplicationsToolStripMenuItem.Size = new Size(262, 26);
            manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicaionsToolStripMenuItem
            // 
            localDrivingLicenseApplicaionsToolStripMenuItem.Image = Properties.Resources.LocalDriving_License;
            localDrivingLicenseApplicaionsToolStripMenuItem.Name = "localDrivingLicenseApplicaionsToolStripMenuItem";
            localDrivingLicenseApplicaionsToolStripMenuItem.Size = new Size(315, 26);
            localDrivingLicenseApplicaionsToolStripMenuItem.Text = "Local Driving License Applicaions";
            localDrivingLicenseApplicaionsToolStripMenuItem.Click += localDrivingLicenseApplicaionsToolStripMenuItem_Click;
            // 
            // internationalLicenseApplicationsToolStripMenuItem
            // 
            internationalLicenseApplicationsToolStripMenuItem.Image = Properties.Resources.International_32;
            internationalLicenseApplicationsToolStripMenuItem.Name = "internationalLicenseApplicationsToolStripMenuItem";
            internationalLicenseApplicationsToolStripMenuItem.Size = new Size(315, 26);
            internationalLicenseApplicationsToolStripMenuItem.Text = "International License Applications";
            internationalLicenseApplicationsToolStripMenuItem.Click += internationalLicenseApplicationsToolStripMenuItem_Click;
            // 
            // detainLicensesToolStripMenuItem
            // 
            detainLicensesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manaToolStripMenuItem, detainLicenseToolStripMenuItem, releaseDetainedLicensesToolStripMenuItem });
            detainLicensesToolStripMenuItem.Image = Properties.Resources.Detain_32;
            detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            detainLicensesToolStripMenuItem.Size = new Size(262, 26);
            detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manaToolStripMenuItem
            // 
            manaToolStripMenuItem.Image = Properties.Resources.Detain_321;
            manaToolStripMenuItem.Name = "manaToolStripMenuItem";
            manaToolStripMenuItem.Size = new Size(270, 26);
            manaToolStripMenuItem.Text = "Manage Detained Licenses";
            manaToolStripMenuItem.Click += manaToolStripMenuItem_Click;
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.Image = Properties.Resources.Detain_32;
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(270, 26);
            detainLicenseToolStripMenuItem.Text = "Detain License";
            detainLicenseToolStripMenuItem.Click += detainLicenseToolStripMenuItem_Click;
            // 
            // releaseDetainedLicensesToolStripMenuItem
            // 
            releaseDetainedLicensesToolStripMenuItem.Image = Properties.Resources.Release_Detained_License_64;
            releaseDetainedLicensesToolStripMenuItem.Name = "releaseDetainedLicensesToolStripMenuItem";
            releaseDetainedLicensesToolStripMenuItem.Size = new Size(270, 26);
            releaseDetainedLicensesToolStripMenuItem.Text = "Release  Detained Licenses";
            releaseDetainedLicensesToolStripMenuItem.Click += releaseDetainedLicensesToolStripMenuItem_Click;
            // 
            // manageApplicationTypeToolStripMenuItem
            // 
            manageApplicationTypeToolStripMenuItem.Image = Properties.Resources.Application_Types_64;
            manageApplicationTypeToolStripMenuItem.Name = "manageApplicationTypeToolStripMenuItem";
            manageApplicationTypeToolStripMenuItem.Size = new Size(262, 26);
            manageApplicationTypeToolStripMenuItem.Text = "Manage Application Type";
            manageApplicationTypeToolStripMenuItem.Click += manageApplicationTypeToolStripMenuItem_Click;
            // 
            // mangeTestTypesToolStripMenuItem
            // 
            mangeTestTypesToolStripMenuItem.Image = Properties.Resources.Test_Type_64;
            mangeTestTypesToolStripMenuItem.Name = "mangeTestTypesToolStripMenuItem";
            mangeTestTypesToolStripMenuItem.Size = new Size(262, 26);
            mangeTestTypesToolStripMenuItem.Text = "Mange Test Types";
            mangeTestTypesToolStripMenuItem.Click += mangeTestTypesToolStripMenuItem_Click;
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Image = Properties.Resources.People_400;
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(100, 36);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Image = Properties.Resources.Drivers_64;
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(101, 36);
            usersToolStripMenuItem.Text = "Drivers";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.Image = Properties.Resources.Users_2_64;
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(90, 36);
            driversToolStripMenuItem.Text = "Users";
            driversToolStripMenuItem.Click += driversToolStripMenuItem_Click;
            // 
            // accountSittingToolStripMenuItem
            // 
            accountSittingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentUserInfoToolStripMenuItem, changePasswordToolStripMenuItem, signOutToolStripMenuItem });
            accountSittingToolStripMenuItem.Image = Properties.Resources.account_settings_64;
            accountSittingToolStripMenuItem.Name = "accountSittingToolStripMenuItem";
            accountSittingToolStripMenuItem.Size = new Size(166, 36);
            accountSittingToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            currentUserInfoToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Size = new Size(211, 26);
            currentUserInfoToolStripMenuItem.Text = "Current User Info";
            currentUserInfoToolStripMenuItem.Click += currentUserInfoToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = Properties.Resources.Password_32;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(211, 26);
            changePasswordToolStripMenuItem.Text = "Change  Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Image = Properties.Resources.sign_out_32__2;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(211, 26);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Logo_Final;
            pictureBox1.Location = new Point(0, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1807, 695);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1807, 735);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main ";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem appToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem accountSittingToolStripMenuItem;
        private ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private ToolStripMenuItem detainLicensesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationTypeToolStripMenuItem;
        private ToolStripMenuItem mangeTestTypesToolStripMenuItem;
        private ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem replacementForLostOrDamageToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem retakeTestToolStripMenuItem;
        private ToolStripMenuItem localLicenseToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private ToolStripMenuItem manaToolStripMenuItem;
        private ToolStripMenuItem detainLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLicensesToolStripMenuItem;
        private ToolStripMenuItem localDrivingLicenseApplicaionsToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseApplicationsToolStripMenuItem;
    }
}