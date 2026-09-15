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
    public partial class usUsers : UserControl
    {
       public clsUsers User;


        public usUsers()
        {
            InitializeComponent();

        }
        public usUsers(int UserID)
        {
            InitializeComponent();
            LoadUser(UserID);
        }
       

        private void usUsers_Load(object sender, EventArgs e)
        {

        }


        public bool VerifyCurrentPassword(string plaintextPassword)
        {
            if (User == null || string.IsNullOrEmpty(User.userName))
                return false;

            // الدالة هنا ستتولى التشفير والمطابقة عبر الـ Login تلقائياً
            return (clsUsers.Login(User.userName, plaintextPassword) != null);
        }



        public void LoadUser(int UserID)
        {

            User = clsUsers.FindByID(UserID);

            if (User == null)
            {
                MessageBox.Show("Something went wrong");
                return;
            }


            lblUserID.Text = UserID.ToString();
            lblUsername.Text = User.userName;
            if(User.isActive)
            {
                lblIsActive.Text = "Yes";
            }
            else
            {
                lblIsActive.Text = "No";
            }
        }
    }
}
