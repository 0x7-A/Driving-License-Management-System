using Project19_businessLayer;
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
    public partial class frmPerson : Form
    {
        public frmPerson()
        {
            InitializeComponent();
        }

        private void usPerson1_Load(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void frmShow_Load(object sender, EventArgs e)
        {

        }

        protected void UpdateDateTime()
        {
            dtDateOfBirth.MaxDate = DateTime.Now.AddYears(-18); 
            dtDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtDateOfBirth.Value = dtDateOfBirth.MaxDate;
        }



        protected void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNationalNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNationalNumber_Validating(object sender, CancelEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
