using Microsoft.VisualBasic.ApplicationServices;
using Project_19_DVDL__2nd_.Properties;
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
    public partial class frmManageUsers : Form
    {
        private DataTable _dt;

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _Refresh();

        }

        private void _Refresh()
        {
            _dt = clsUsers.GetAllUsers();

            dataGridView1.DataSource = _dt;
            dataGridView1.Columns[0].HeaderText = "User ID";
            dataGridView1.Columns[0].Width = 80;

            dataGridView1.Columns[1].HeaderText = "Person ID";
            dataGridView1.Columns[1].Width = 90;


            dataGridView1.Columns[2].HeaderText = "Created By";
            dataGridView1.Columns[2].Width = 200;

            dataGridView1.Columns[3].HeaderText = "Created Date";
            dataGridView1.Columns[3].Width = 160;

            dataGridView1.Columns[3].HeaderText = "Is Active";
            dataGridView1.Columns[3].Width = 80;

            lblrecord.Text = dataGridView1.RowCount.ToString();
            GetComboBoxCollection();
            GetComboBoxIsActive();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




            if (comboBox1.Text == "IsActive")
            {
                txtFiliter.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
                return;
            }
            else if(comboBox1.Text == "None")
            {
                txtFiliter.Visible = false;
                cbIsActive.Visible = false;
                return;

            }

            cbIsActive.Visible = false;
            txtFiliter.Visible = true;
            txtFiliter.Text = "";
            txtFiliter.Focus();
        }

        private void GetComboBoxCollection()
        {
            comboBox1.Items.Clear();


            comboBox1.Items.Add("None");

            foreach (DataColumn col in _dt.Columns)
            {
                comboBox1.Items.Add((string)col.ColumnName);
            }

            comboBox1.SelectedIndex = 0;
            txtFiliter.Visible = false;
        }


        private void GetComboBoxIsActive()
        {
            cbIsActive.Items.Clear();

            cbIsActive.Items.Add("All");
            cbIsActive.Items.Add("Yes");
            cbIsActive.Items.Add("No");
            cbIsActive.SelectedIndex = 0;

        }
        private void txtFiliter_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = comboBox1.Text;
            string FilterValue = txtFiliter.Text.Trim();

            if (string.IsNullOrEmpty(FilterValue))
            {
                _dt.DefaultView.RowFilter = "";
                return;
            }

            

            if (FilterColumn == "UserID" || FilterColumn == "PersonID")
            {
                _dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
            }
            else
            {
                _dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);
            }
        }

        private void txtFiliter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (comboBox1.Text == "PersonID" || comboBox1.Text == "UserID")
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {

                    e.Handled = true;
                }
            }



        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterValue = cbIsActive.Text;
            string RowFilter = "";
            if (cbIsActive.SelectedItem == "Yes")
            {
                RowFilter = "IsActive = 1";
            }
            else if (cbIsActive.SelectedItem == "No")
            {
                RowFilter = "IsActive = 0";
            }
            else
            {
                RowFilter = "";
            }
            _dt.DefaultView.RowFilter = RowFilter;

        }


        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            Form frm = new frmChangePassword(_GetPersonID(), _GetUserID());
            frm.ShowDialog();

        }

        private void cmManageUser_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dataGridView1.CurrentRow.Cells["UserID"].Value;
            if (MessageBox.Show($"Are you sure deleting User with {UserID} ID? ", "Deleting User", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsUsers.DeleteUser(UserID))
                {
                    MessageBox.Show("Successfully Deleted");
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }

            }
            else
            {
                MessageBox.Show("Deleting was cancled");
            }
        }

        private int _GetUserID()
        {
            return (int)dataGridView1.CurrentRow.Cells["UserID"].Value;
        }

        private int _GetPersonID()
        {
            return (int)dataGridView1.CurrentRow.Cells["PersonID"].Value;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
           
            Form frm = new frmAddEditUser(_GetPersonID(), _GetUserID());
            frm.ShowDialog();
            _Refresh();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditUser(-1, -1);
            frm.ShowDialog();
            _Refresh();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm = new frmUserInfo(_GetPersonID(), _GetUserID());
            frm.ShowDialog();
            _Refresh();
        }
    }
}
