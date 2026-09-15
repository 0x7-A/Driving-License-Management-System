using Microsoft.VisualBasic.ApplicationServices;
using Project19_businessLayer;
using Project19_BussnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_19_DVDL__2nd_
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword(int PersonID,int UserID)
        {
            InitializeComponent();
            ucPerson1.LoadPersonInfo(PersonID);
            ucUsers1.LoadUser(UserID);
        }


        private void _ValidateEmpty(object sender, CancelEventArgs e, string fieldName)
        {
            TextBox txt = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt, $"{fieldName} cannot be empty! To cancel, press 'Close'.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, "");
            }
        }
        private void txtCurrentPS_Validating(object sender, CancelEventArgs e)
        {
            _ValidateEmpty(sender, e, "Current Password");

        
            if (!ucUsers1.VerifyCurrentPassword(txtCurrentPS.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPS, "Current password is incorrect.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrentPS, "");
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtChangePS_Validating(object sender, CancelEventArgs e)
        {
            _ValidateEmpty(sender, e, "New Password");
        }

        private void txtConfirmPS_Validating(object sender, CancelEventArgs e)
        {
            _ValidateEmpty(sender, e, "Confirm Password");

            if (!e.Cancel)
            {
                if (txtConfirmPS.Text != txtNewPS.Text)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtConfirmPS, "Confrim password  is diffierent from New Password");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtConfirmPS, "");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if(clsUsers.Update(ucUsers1.User.UserID,ucUsers1.User.PersonID,ucUsers1.User.userName,txtConfirmPS.Text,ucUsers1.User.isActive))
            {
                MessageBox.Show("Password updated successfully ","Data updated Successfully",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
