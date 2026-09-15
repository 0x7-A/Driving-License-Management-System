
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
    public partial class FrmManageDrivers : frmManagement
    {
        DataTable dt;

        public FrmManageDrivers()
        {
            InitializeComponent();
            dataGridView1.ContextMenuStrip = contextMenuStrip1;

        }

        private void FrmManageDrivers_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            dt = clsDrivers.GetAllDrivers();
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "Driver ID";
            dataGridView1.Columns[0].Width = 80;

            dataGridView1.Columns[1].HeaderText = "Person ID";
            dataGridView1.Columns[1].Width = 90;


            dataGridView1.Columns[2].HeaderText = "Created By Usee ID";
            dataGridView1.Columns[2].Width = 250;

            dataGridView1.Columns[3].HeaderText = "Created Date";
            dataGridView1.Columns[3].Width = 160;
            lblrecord.Text = dataGridView1.RowCount.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails( (int)dataGridView1.CurrentRow.Cells["PersonID"].Value);
            frm.ShowDialog();
            RefreshData();
        }
    }
}
