namespace Project_19_DVDL__2nd_
{
    partial class frmTest
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
            components = new System.ComponentModel.Container();
            pbTitle = new PictureBox();
            lblTitle = new Label();
            ucdlApplicationInfo1 = new ucDLApplicationInfo();
            ucApplicationBasicInfo1 = new ucApplicationBasicInfo();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            lblTotalRecords = new Label();
            pictureBox2 = new PictureBox();
            btnClose = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pbTitle
            // 
            pbTitle.Location = new Point(480, 12);
            pbTitle.Name = "pbTitle";
            pbTitle.Size = new Size(131, 99);
            pbTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pbTitle.TabIndex = 0;
            pbTitle.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 17F);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(506, 132);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(78, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Titlle";
            // 
            // ucdlApplicationInfo1
            // 
            ucdlApplicationInfo1.Location = new Point(95, 175);
            ucdlApplicationInfo1.Name = "ucdlApplicationInfo1";
            ucdlApplicationInfo1.Size = new Size(944, 217);
            ucdlApplicationInfo1.TabIndex = 2;
            // 
            // ucApplicationBasicInfo1
            // 
            ucApplicationBasicInfo1.Location = new Point(144, 398);
            ucApplicationBasicInfo1.Name = "ucApplicationBasicInfo1";
            ucApplicationBasicInfo1.Size = new Size(847, 287);
            ucApplicationBasicInfo1.TabIndex = 3;
            ucApplicationBasicInfo1.Load += ucApplicationBasicInfo1_Load;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(107, 705);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(944, 217);
            dataGridView1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, toolStripMenuItem1, takeTestToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(142, 62);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(141, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(138, 6);
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Image = Properties.Resources.Test_32;
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(141, 26);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 975);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 5;
            label2.Text = "# Records";
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRecords.Location = new Point(146, 975);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(24, 28);
            lblTotalRecords.TabIndex = 6;
            lblTotalRecords.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Close_32;
            pictureBox2.Location = new Point(960, 972);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(951, 957);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 54);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = Properties.Resources.AddAppointment_32;
            pictureBox3.Location = new Point(1007, 631);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 1037);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(lblTotalRecords);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(ucApplicationBasicInfo1);
            Controls.Add(ucdlApplicationInfo1);
            Controls.Add(lblTitle);
            Controls.Add(pbTitle);
            Name = "frmTest";
            Text = "Test";
            Load += frmTest_Load;
            ((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbTitle;
        private Label lblTitle;
        private ucDLApplicationInfo ucdlApplicationInfo1;
        private ucApplicationBasicInfo ucApplicationBasicInfo1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label lblTotalRecords;
        private PictureBox pictureBox2;
        private Button btnClose;
        private PictureBox pictureBox3;
        private ToolStripSeparator toolStripMenuItem1;
        public ToolStripMenuItem editToolStripMenuItem;
        public ToolStripMenuItem takeTestToolStripMenuItem;
        public ContextMenuStrip contextMenuStrip1;
    }
}