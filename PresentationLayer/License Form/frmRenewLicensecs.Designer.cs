namespace Project_19_DVDL__2nd_
{
    partial class frmRenewLicensecs
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
            ucDriverLicenseInfo1 = new ucDriverLicenseInfo();
            gbFilter = new GroupBox();
            pbFibdLicenseID = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnRenew = new Button();
            pictureBox2 = new PictureBox();
            btnClose = new Button();
            linkLabelShowLicenseInfo = new LinkLabel();
            linklableShowLicenseHistory = new LinkLabel();
            ucNewAppicationaLicenseInfocs1 = new ucNewAppicationaLicenseInfocs();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFibdLicenseID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ucDriverLicenseInfo1
            // 
            ucDriverLicenseInfo1.Location = new Point(40, 182);
            ucDriverLicenseInfo1.Name = "ucDriverLicenseInfo1";
            ucDriverLicenseInfo1.Size = new Size(948, 369);
            ucDriverLicenseInfo1.TabIndex = 5;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(pbFibdLicenseID);
            gbFilter.Controls.Add(textBox1);
            gbFilter.Controls.Add(label2);
            gbFilter.Location = new Point(111, 68);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(690, 97);
            gbFilter.TabIndex = 4;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // pbFibdLicenseID
            // 
            pbFibdLicenseID.Image = Properties.Resources.License_View_32;
            pbFibdLicenseID.Location = new Point(585, 27);
            pbFibdLicenseID.Name = "pbFibdLicenseID";
            pbFibdLicenseID.Size = new Size(64, 52);
            pbFibdLicenseID.SizeMode = PictureBoxSizeMode.Zoom;
            pbFibdLicenseID.TabIndex = 2;
            pbFibdLicenseID.TabStop = false;
            pbFibdLicenseID.Click += pbFibdLicenseID_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 27);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(28, 43);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 0;
            label2.Text = "LicenseID: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(332, 18);
            label1.Name = "label1";
            label1.Size = new Size(329, 35);
            label1.TabIndex = 3;
            label1.Text = "Renew License Application";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.International_32;
            pictureBox1.Location = new Point(851, 955);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // btnRenew
            // 
            btnRenew.Enabled = false;
            btnRenew.Location = new Point(842, 940);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(138, 54);
            btnRenew.TabIndex = 23;
            btnRenew.Text = "Renew";
            btnRenew.UseVisualStyleBackColor = true;
            btnRenew.Click += btnRenew_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Close_32;
            pictureBox2.Location = new Point(688, 955);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(679, 940);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 54);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // linkLabelShowLicenseInfo
            // 
            linkLabelShowLicenseInfo.AutoSize = true;
            linkLabelShowLicenseInfo.Enabled = false;
            linkLabelShowLicenseInfo.Location = new Point(236, 955);
            linkLabelShowLicenseInfo.Name = "linkLabelShowLicenseInfo";
            linkLabelShowLicenseInfo.Size = new Size(127, 20);
            linkLabelShowLicenseInfo.TabIndex = 20;
            linkLabelShowLicenseInfo.TabStop = true;
            linkLabelShowLicenseInfo.Text = "Show License Info";
            linkLabelShowLicenseInfo.LinkClicked += LinkLabelShowLicenseInfo_LinkClicked;
            // 
            // linklableShowLicenseHistory
            // 
            linklableShowLicenseHistory.AutoSize = true;
            linklableShowLicenseHistory.Enabled = false;
            linklableShowLicenseHistory.Location = new Point(57, 955);
            linklableShowLicenseHistory.Name = "linklableShowLicenseHistory";
            linklableShowLicenseHistory.Size = new Size(148, 20);
            linklableShowLicenseHistory.TabIndex = 19;
            linklableShowLicenseHistory.TabStop = true;
            linklableShowLicenseHistory.Text = "Show License History";
            linklableShowLicenseHistory.LinkClicked += linklableShowLicenseHistory_LinkClicked;
            // 
            // ucNewAppicationaLicenseInfocs1
            // 
            ucNewAppicationaLicenseInfocs1.Location = new Point(65, 536);
            ucNewAppicationaLicenseInfocs1.Name = "ucNewAppicationaLicenseInfocs1";
            ucNewAppicationaLicenseInfocs1.Size = new Size(906, 384);
            ucNewAppicationaLicenseInfocs1.TabIndex = 25;
            // 
            // frmRenewLicensecs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 1014);
            Controls.Add(ucNewAppicationaLicenseInfocs1);
            Controls.Add(pictureBox1);
            Controls.Add(btnRenew);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(linkLabelShowLicenseInfo);
            Controls.Add(linklableShowLicenseHistory);
            Controls.Add(ucDriverLicenseInfo1);
            Controls.Add(gbFilter);
            Controls.Add(label1);
            Name = "frmRenewLicensecs";
            Text = "Renew Licensecs";
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFibdLicenseID).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ucDriverLicenseInfo ucDriverLicenseInfo1;
        private GroupBox gbFilter;
        private PictureBox pbFibdLicenseID;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnRenew;
        private PictureBox pictureBox2;
        private Button btnClose;
        private LinkLabel linkLabelShowLicenseInfo;
        private LinkLabel linklableShowLicenseHistory;
        private ucNewAppicationaLicenseInfocs ucNewAppicationaLicenseInfocs1;
    }
}