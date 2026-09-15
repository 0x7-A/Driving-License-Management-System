namespace Project_19_DVDL__2nd_
{
    partial class frmManageInternationalLicense
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
            pictureBox2 = new PictureBox();
            lblrecord = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showPersonDetailToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            showLicenseDetailToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            showPersonLicenseHistoryToolStripMenuItem1 = new ToolStripMenuItem();
            lblTitle = new Label();
            pbTitle = new PictureBox();
            txtFiliter = new TextBox();
            pbAddNewInternationalLicense = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddNewInternationalLicense).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.International_32;
            pictureBox2.Location = new Point(631, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
            // 
            // lblrecord
            // 
            lblrecord.AutoSize = true;
            lblrecord.Location = new Point(123, 588);
            lblrecord.Name = "lblrecord";
            lblrecord.Size = new Size(17, 20);
            lblrecord.TabIndex = 52;
            lblrecord.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 588);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 51;
            label1.Text = "#Records ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Close_32;
            pictureBox1.Location = new Point(1062, 588);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 32);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(99, 220);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 28);
            comboBox1.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 219);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 48;
            label2.Text = "Filiter By:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1051, 572);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 63);
            btnClose.TabIndex = 47;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(11, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1197, 283);
            dataGridView1.TabIndex = 46;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonDetailToolStripMenuItem, toolStripMenuItem1, showLicenseDetailToolStripMenuItem, toolStripMenuItem2, showPersonLicenseHistoryToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(265, 94);
            // 
            // showPersonDetailToolStripMenuItem
            // 
            showPersonDetailToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showPersonDetailToolStripMenuItem.Name = "showPersonDetailToolStripMenuItem";
            showPersonDetailToolStripMenuItem.Size = new Size(264, 26);
            showPersonDetailToolStripMenuItem.Text = "Show Person Detail";
            showPersonDetailToolStripMenuItem.Click += showPersonDetailToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(261, 6);
            // 
            // showLicenseDetailToolStripMenuItem
            // 
            showLicenseDetailToolStripMenuItem.Image = Properties.Resources.License_View_32;
            showLicenseDetailToolStripMenuItem.Name = "showLicenseDetailToolStripMenuItem";
            showLicenseDetailToolStripMenuItem.Size = new Size(264, 26);
            showLicenseDetailToolStripMenuItem.Text = "Show License Detail";
            showLicenseDetailToolStripMenuItem.Click += showLicenseDetailToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(261, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem1
            // 
            showPersonLicenseHistoryToolStripMenuItem1.Image = Properties.Resources.PersonLicenseHistory_32;
            showPersonLicenseHistoryToolStripMenuItem1.Name = "showPersonLicenseHistoryToolStripMenuItem1";
            showPersonLicenseHistoryToolStripMenuItem1.Size = new Size(264, 26);
            showPersonLicenseHistoryToolStripMenuItem1.Text = "Show PersonLicense History";
            showPersonLicenseHistoryToolStripMenuItem1.Click += showPersonLicenseHistoryToolStripMenuItem1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(360, 165);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(432, 38);
            lblTitle.TabIndex = 45;
            lblTitle.Text = "International License Application";
            // 
            // pbTitle
            // 
            pbTitle.Image = Properties.Resources.Manage_Applications_64;
            pbTitle.Location = new Point(478, 12);
            pbTitle.Name = "pbTitle";
            pbTitle.Size = new Size(202, 134);
            pbTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pbTitle.TabIndex = 44;
            pbTitle.TabStop = false;
            // 
            // txtFiliter
            // 
            txtFiliter.Location = new Point(292, 221);
            txtFiliter.Name = "txtFiliter";
            txtFiliter.Size = new Size(183, 27);
            txtFiliter.TabIndex = 43;
            // 
            // pbAddNewInternationalLicense
            // 
            pbAddNewInternationalLicense.Image = Properties.Resources.New_Application_64;
            pbAddNewInternationalLicense.Location = new Point(1116, 187);
            pbAddNewInternationalLicense.Name = "pbAddNewInternationalLicense";
            pbAddNewInternationalLicense.Size = new Size(64, 52);
            pbAddNewInternationalLicense.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddNewInternationalLicense.TabIndex = 54;
            pbAddNewInternationalLicense.TabStop = false;
            // 
            // frmManageInternationalLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 642);
            Controls.Add(pbAddNewInternationalLicense);
            Controls.Add(pictureBox2);
            Controls.Add(lblrecord);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Controls.Add(pbTitle);
            Controls.Add(txtFiliter);
            Name = "frmManageInternationalLicense";
            Text = "Manage International License";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddNewInternationalLicense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBox2;
        public Label lblrecord;
        public Label label1;
        public PictureBox pictureBox1;
        public ComboBox comboBox1;
        public Label label2;
        public Button btnClose;
        public DataGridView dataGridView1;
        public Label lblTitle;
        public PictureBox pbTitle;
        private TextBox txtFiliter;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showPersonDetailToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem showLicenseDetailToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem1;
        public PictureBox pbAddNewInternationalLicense;
    }
}