namespace Project_19_DVDL__2nd_
{
    partial class frmManagement
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
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            btnAdd = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            cmsBaseManagement = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            lblTitle = new Label();
            pbTitle = new PictureBox();
            label1 = new Label();
            lblrecord = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cmsBaseManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Close_32;
            pictureBox1.Location = new Point(1087, 624);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 32);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(124, 256);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 28);
            comboBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 255);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 13;
            label2.Text = "Filiter By:";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.Add_Person_40;
            btnAdd.Location = new Point(1160, 224);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(63, 51);
            btnAdd.TabIndex = 12;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1076, 608);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 63);
            btnClose.TabIndex = 11;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = cmsBaseManagement;
            dataGridView1.Location = new Point(36, 290);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1221, 283);
            dataGridView1.TabIndex = 10;
            // 
            // cmsBaseManagement
            // 
            cmsBaseManagement.ImageScalingSize = new Size(20, 20);
            cmsBaseManagement.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cmsBaseManagement.Name = "contextMenuStrip1";
            cmsBaseManagement.Size = new Size(189, 172);
            cmsBaseManagement.Opening += cmsBaseManagement_Opening;
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_321;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(188, 26);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(185, 6);
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.Add_Person_401;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(188, 26);
            addNewPersonToolStripMenuItem.Text = "Add new Person";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(188, 26);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(188, 26);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(185, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.send_email_32;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(188, 26);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = Properties.Resources.call_32;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(188, 26);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(664, 200);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(71, 38);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Title";
            // 
            // pbTitle
            // 
            pbTitle.Location = new Point(589, 50);
            pbTitle.Name = "pbTitle";
            pbTitle.Size = new Size(202, 134);
            pbTitle.TabIndex = 8;
            pbTitle.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 624);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 16;
            label1.Text = "#Records ";
            // 
            // lblrecord
            // 
            lblrecord.AutoSize = true;
            lblrecord.Location = new Point(148, 624);
            lblrecord.Name = "lblrecord";
            lblrecord.Size = new Size(17, 20);
            lblrecord.TabIndex = 17;
            lblrecord.Text = "0";
            lblrecord.Click += lblrecord_Click;
            // 
            // frmManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 718);
            Controls.Add(lblrecord);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Controls.Add(pbTitle);
            Name = "frmManagement";
            Text = "frmManagePeople";
            Load += frmManagement_Load;
            Click += btnClose_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cmsBaseManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBox1;
        public ComboBox comboBox1;
        public Label label2;
        public Button btnAdd;
        public Button btnClose;
        public DataGridView dataGridView1;
        public Label lblTitle;
        public PictureBox pbTitle;
        public Label label1;
        public Label lblrecord;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        public ContextMenuStrip cmsBaseManagement;
        public ToolStripMenuItem showDetailsToolStripMenuItem;
        public ToolStripMenuItem addNewPersonToolStripMenuItem;
        public ToolStripMenuItem editToolStripMenuItem;
        public ToolStripMenuItem deleteToolStripMenuItem;
        public ToolStripMenuItem sendEmailToolStripMenuItem;
        public ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}