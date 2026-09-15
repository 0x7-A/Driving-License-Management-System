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
    public partial class frmManageTestTypes : Form
    {
        clsTestTypes _CurrnetType;

        Form frm;
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void _RefreshData()
        {

            dataGridView1.DataSource = clsTestTypes.GetAllTestTypes();
            lblTotalRecord.Text = dataGridView1.RowCount.ToString();

            dataGridView1.Columns[0].HeaderText = "Test Type ID";
            dataGridView1.Columns[0].Width = 80;

          

            dataGridView1.Columns[3].HeaderText = "Fee";
            dataGridView1.Columns[3].Width = 110;

            dataGridView1.Columns[1].HeaderText = "Test Title";
            dataGridView1.Columns[1].Width = 160;

            dataGridView1.Columns[2].HeaderText = "Description";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TargetedID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            _CurrnetType = clsTestTypes.FindTestType(TargetedID);
            if (_CurrnetType != null)
            {
                frm = new frmEditTestype(_CurrnetType);
                frm.ShowDialog();
                _RefreshData();
            }
            else
            {
                MessageBox.Show("Something Went Wrong, try later");
            }

        }
    }
}
