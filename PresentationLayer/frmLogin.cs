using Project19_businessLayer;
using Microsoft.Win32;
using System.Net;

namespace Project_19_DVDL__2nd_
{
    public partial class frmLogin : Form
    {

        clsUsers _CurrnetUser = null;

        Form frm;
        public frmLogin()
        {
            InitializeComponent();
    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnLogin_Click_3(object sender, EventArgs e)
        {
            _CurrnetUser = clsUsers.Login(txtUsename.Text.Trim(), txtPassword.Text.Trim() );

            if (_CurrnetUser == null)
            {
                txtUsename.Focus();
                MessageBox.Show("Username or password is wrong, try again", "Wrong Credentials",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            else if(!_CurrnetUser.isActive)
            {
                txtUsename.Focus();
                
                MessageBox.Show("Your account is not active, please contact your Admin");
                return;
            }


            string UserName = "";
            string Password = "";

            if (chRemember.Checked)
            {
                clsSystem.WriteRigestry(txtUsename.Text, txtPassword.Text);
            }
            else
            {
                clsSystem.ClearRigesrty();
            }

            clsSystem.CurrentUser = _CurrnetUser;
                frm = new frmMain(this);
                this.Hide();
                frm.ShowDialog();
             
            
        }

        private void ReadLoginFile()
        {
            string username = "";
            string password = "";




            if (clsSystem.ReadRigestry(ref username,ref password))
            {
              txtUsename.Text = username;
              txtPassword.Text = password;
              chRemember.Checked = true;
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            ReadLoginFile();
        }
    }
}
