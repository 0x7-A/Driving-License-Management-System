using Project19_businessLayer;

namespace Project_19_DVDL__2nd_
{
    public partial class frmMain : Form
    {

        frmLogin _frmLogin;


        public frmMain(frmLogin frm)
        {
            InitializeComponent();

            _frmLogin = frm;
        }



        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmManageDrivers();

            frm.ShowDialog();
        }



        private void mangeTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void manageApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageAppTypes();
            frm.ShowDialog();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPeopleManagement();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsers();
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword(clsSystem.CurrentUser.PersonID, clsSystem.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserInfo(clsSystem.CurrentUser.PersonID, clsSystem.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsSystem.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }



        private void localDrivingLicenseApplicaionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewLDLApplication();
            frm.ShowDialog();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicense frm = new frmManageInternationalLicense();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseApplication frm = new frmInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLicensecs frm = new frmRenewLicensecs();
            frm.ShowDialog();
        }

        private void replacementForLostOrDamageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplacmentForDemagedLostLicense frm = new frmReplacmentForDemagedLostLicense();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatainAndRelease frm = new frmDatainAndRelease(clsDetainLicense.enMode.Detain);
            frm.ShowDialog();
        }

        private void releaseDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatainAndRelease frm = new frmDatainAndRelease(clsDetainLicense.enMode.Release);
            frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatainAndRelease frm = new frmDatainAndRelease(clsDetainLicense.enMode.Release);
            frm.ShowDialog();
        }

        private void manaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicense frm = new frmManageDetainedLicense();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
          //  Project19_BussnessLayer.clsSecurityUtility.MigrateAllPasswordsToHash();
        }
    }
}
