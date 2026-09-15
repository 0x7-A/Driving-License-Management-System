namespace Project_19_DVDL__2nd_
{
    partial class frmManageAppTypes
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
            lblTotalRecord = new Label();
            label1 = new Label();
            button1 = new Button();
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            contextMenuStripEdit = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStripEdit.SuspendLayout();
            SuspendLayout();
            // 
            // lblTotalRecord
            // 
            lblTotalRecord.AutoSize = true;
            lblTotalRecord.Font = new Font("Nirmala Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRecord.Location = new Point(130, 556);
            lblTotalRecord.Name = "lblTotalRecord";
            lblTotalRecord.Size = new Size(22, 25);
            lblTotalRecord.TabIndex = 11;
            lblTotalRecord.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 550);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 10;
            label1.Text = "# Records";
            // 
            // button1
            // 
            button1.Location = new Point(898, 547);
            button1.Name = "button1";
            button1.Size = new Size(123, 45);
            button1.TabIndex = 9;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(358, 136);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(297, 31);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Manage Application Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Application_Types_64;
            pictureBox1.Location = new Point(425, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlDark;
            dataGridView1.Location = new Point(23, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(998, 331);
            dataGridView1.TabIndex = 6;
            // 
            // contextMenuStripEdit
            // 
            contextMenuStripEdit.ImageScalingSize = new Size(20, 20);
            contextMenuStripEdit.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStripEdit.Name = "contextMenuStripEdit";
            contextMenuStripEdit.Size = new Size(105, 28);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(104, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // frmManageAppTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 618);
            ContextMenuStrip = contextMenuStripEdit;
            Controls.Add(lblTotalRecord);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "frmManageAppTypes";
            Text = "Manage Application Types";
            Load += frmManageAppTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStripEdit.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalRecord;
        private Label label1;
        private Button button1;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStripEdit;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}