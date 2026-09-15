using Project19_businessLayer;
using System.Data;


namespace Project_19_DVDL__2nd_
{
    public partial class frmPeopleManagement : frmManagement
    {

        private DataTable _dtPeople;
        public frmPeopleManagement()
        {
            InitializeComponent();
         
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void frmPeopleManagement_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

       
        protected override void RefreshData() // Changed to override and fixed spelling
        {
            _dtPeople = clsPerson.GetAllPeople();
            dataGridView1.DataSource = _dtPeople;
            _ComboBoxItems();
            lblrecord.Text = dataGridView1.Rows.Count.ToString();


            dataGridView1.Columns[0].HeaderText = "Person ID";
            dataGridView1.Columns[1].HeaderText = "National Number";
            dataGridView1.Columns[2].HeaderText = "First Name";
            dataGridView1.Columns[3].HeaderText = "Second Name";
            dataGridView1.Columns[4].HeaderText = "Third Name";
            dataGridView1.Columns[5].HeaderText = "Last Name";
            dataGridView1.Columns[7].HeaderText = "Date Of Birth";




            if (comboBox1.SelectedIndex == 0)
                textBox1.Visible = false;
            else
                textBox1.Visible = true;
        }

        private void _ComboBoxItems()
        {
            comboBox1.Items.Clear();

            comboBox1.Items.Add("None");

            foreach (DataGridViewColumn C in dataGridView1.Columns)
            {
                comboBox1.Items.Add(C.HeaderText);
            }
            comboBox1.Items.Remove("DateOfBirth");

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "None")
            {
                textBox1.Visible = false;
            }
            else
            {
                textBox1.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblrecord.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

            string selectedColumn = comboBox1.Text;
            string filterValue = textBox1.Text.Trim();


            if (selectedColumn == "PersonID")
            {
                
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", selectedColumn, filterValue);
            }
            else
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", selectedColumn, filterValue);
            }

            lblrecord.Text = dataGridView1.Rows.Count.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int targetedID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete  the eprson with " + targetedID + " ?"
                , "Deleting", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsPerson.DeleteByID(targetedID))
                {
                    MessageBox.Show("Person with " + targetedID + " deleted.");
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Error!");
                }

            }




        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPerson(-1);
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewPersonToolStripMenuItem_Click(sender, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPerson((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshData();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.Text == "PersonID")
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {

                    e.Handled = true;
                }
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPersonDetails((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshData();
        }
    }
}
