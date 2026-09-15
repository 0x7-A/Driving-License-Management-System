namespace Project_19_DVDL__2nd_
{
    partial class FrmManageDrivers
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            showPersonInfoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            issueInternationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            txtFiliter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1126, 224);
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(503, 211);
            lblTitle.Size = new Size(217, 38);
            lblTitle.Text = "Manage Drivers";
            // 
            // pbTitle
            // 
            pbTitle.Image = Properties.Resources.Driver_Main1;
            pbTitle.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonInfoToolStripMenuItem, toolStripMenuItem1, issueInternationalLicenseToolStripMenuItem, toolStripMenuItem2, showPersonLicenseHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(269, 94);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            showPersonInfoToolStripMenuItem.Image = Properties.Resources.PersonDetails_322;
            showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            showPersonInfoToolStripMenuItem.Size = new Size(268, 26);
            showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            showPersonInfoToolStripMenuItem.Click += showPersonInfoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(265, 6);
            // 
            // issueInternationalLicenseToolStripMenuItem
            // 
            issueInternationalLicenseToolStripMenuItem.Image = Properties.Resources.International_32;
            issueInternationalLicenseToolStripMenuItem.Name = "issueInternationalLicenseToolStripMenuItem";
            issueInternationalLicenseToolStripMenuItem.Size = new Size(268, 26);
            issueInternationalLicenseToolStripMenuItem.Text = "Issue International License";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(265, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(268, 26);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // txtFiliter
            // 
            txtFiliter.Location = new Point(325, 257);
            txtFiliter.Name = "txtFiliter";
            txtFiliter.Size = new Size(183, 27);
            txtFiliter.TabIndex = 20;
            // 
            // FrmManageDrivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 714);
            Controls.Add(txtFiliter);
            Name = "FrmManageDrivers";
            Text = "Manage Drivers";
            Load += FrmManageDrivers_Load;
            Controls.SetChildIndex(pbTitle, 0);
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(btnClose, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(comboBox1, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(lblrecord, 0);
            Controls.SetChildIndex(txtFiliter, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem issueInternationalLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private TextBox txtFiliter;
    }
}