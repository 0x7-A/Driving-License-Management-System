namespace Project_19_DVDL__2nd_
{
    partial class frmManageTestTypes
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
            dataGridView1 = new DataGridView();
            contextMenuStripUpdateTestType = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            button1 = new Button();
            label1 = new Label();
            lblTotalRecord = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStripUpdateTestType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            dataGridView1.ContextMenuStrip = contextMenuStripUpdateTestType;
            dataGridView1.Location = new Point(20, 206);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1195, 376);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStripUpdateTestType
            // 
            contextMenuStripUpdateTestType.ImageScalingSize = new Size(20, 20);
            contextMenuStripUpdateTestType.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStripUpdateTestType.Name = "contextMenuStripUpdateTestType";
            contextMenuStripUpdateTestType.Size = new Size(105, 28);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(104, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Test_Type_64;
            pictureBox1.Location = new Point(487, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(465, 154);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(214, 31);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Manage Test Types";
            // 
            // button1
            // 
            button1.Location = new Point(1090, 611);
            button1.Name = "button1";
            button1.Size = new Size(125, 34);
            button1.TabIndex = 3;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 609);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 4;
            label1.Text = "# Records";
            // 
            // lblTotalRecord
            // 
            lblTotalRecord.AutoSize = true;
            lblTotalRecord.Font = new Font("Nirmala Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRecord.Location = new Point(141, 614);
            lblTotalRecord.Name = "lblTotalRecord";
            lblTotalRecord.Size = new Size(22, 25);
            lblTotalRecord.TabIndex = 5;
            lblTotalRecord.Text = "0";
            // 
            // frmManageTestTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 662);
            Controls.Add(lblTotalRecord);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "frmManageTestTypes";
            Text = "Test Types";
            Load += frmTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStripUpdateTestType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button button1;
        private Label label1;
        private Label lblTotalRecord;
        private ContextMenuStrip contextMenuStripUpdateTestType;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}