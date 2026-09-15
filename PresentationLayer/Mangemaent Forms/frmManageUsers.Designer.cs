namespace Project_19_DVDL__2nd_
{
    partial class frmManageUsers
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
            txtFiliter = new TextBox();
            cbIsActive = new ComboBox();
            cmManageUser = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            lblrecord = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            btnAdd = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            lblTitle = new Label();
            pbTitle = new PictureBox();
            cmManageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
            SuspendLayout();
            // 
            // txtFiliter
            // 
            txtFiliter.Location = new Point(332, 257);
            txtFiliter.Name = "txtFiliter";
            txtFiliter.Size = new Size(183, 27);
            txtFiliter.TabIndex = 18;
            txtFiliter.TextChanged += txtFiliter_TextChanged;
            txtFiliter.KeyPress += txtFiliter_KeyPress;
            // 
            // cbIsActive
            // 
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Location = new Point(332, 257);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(117, 28);
            cbIsActive.TabIndex = 19;
            cbIsActive.Visible = false;
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // cmManageUser
            // 
            cmManageUser.ImageScalingSize = new Size(20, 20);
            cmManageUser.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, addNewUserToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, changePasswordToolStripMenuItem, toolStripMenuItem2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cmManageUser.Name = "contextMenuStrip1";
            cmManageUser.Size = new Size(198, 198);
            cmManageUser.Opening += cmManageUser_Opening;
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(197, 26);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(194, 6);
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Image = Properties.Resources.Add_New_User_72;
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(197, 26);
            addNewUserToolStripMenuItem.Text = "Add New User";
            addNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(197, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(197, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = Properties.Resources.Password_32;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(197, 26);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(194, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.send_email_32;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(197, 26);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = Properties.Resources.call_32;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(197, 26);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // lblrecord
            // 
            lblrecord.AutoSize = true;
            lblrecord.Location = new Point(163, 624);
            lblrecord.Name = "lblrecord";
            lblrecord.Size = new Size(17, 20);
            lblrecord.TabIndex = 29;
            lblrecord.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 624);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 28;
            label1.Text = "#Records ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Close_32;
            pictureBox1.Location = new Point(822, 612);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 32);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(139, 256);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 28);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 255);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 25;
            label2.Text = "Filiter By:";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.Add_Person_40;
            btnAdd.Location = new Point(900, 224);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(63, 51);
            btnAdd.TabIndex = 24;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += addNewUserToolStripMenuItem_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(811, 596);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(152, 62);
            btnClose.TabIndex = 23;
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
            dataGridView1.ContextMenuStrip = cmManageUser;
            dataGridView1.Location = new Point(64, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(913, 283);
            dataGridView1.TabIndex = 22;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(459, 166);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(198, 38);
            lblTitle.TabIndex = 21;
            lblTitle.Text = "Manage Users";
            // 
            // pbTitle
            // 
            pbTitle.Image = Properties.Resources.Users_2_4001;
            pbTitle.Location = new Point(455, 12);
            pbTitle.Name = "pbTitle";
            pbTitle.Size = new Size(202, 134);
            pbTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pbTitle.TabIndex = 20;
            pbTitle.TabStop = false;
            // 
            // frmManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 670);
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
            Controls.Add(cbIsActive);
            Controls.Add(txtFiliter);
            Name = "frmManageUsers";
            Text = "Manage Users";
            Load += frmManageUsers_Load;
            Click += addNewUserToolStripMenuItem_Click;
            cmManageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFiliter;
        private ComboBox cbIsActive;
        private ContextMenuStrip cmManageUser;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem addNewUserToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        public Label lblrecord;
        public Label label1;
        public PictureBox pictureBox1;
        public ComboBox comboBox1;
        public Label label2;
        public Button btnAdd;
        public Button btnClose;
        public DataGridView dataGridView1;
        public Label lblTitle;
        public PictureBox pbTitle;
    }
}