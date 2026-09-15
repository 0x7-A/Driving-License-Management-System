namespace Project_19_DVDL__2nd_
{
    partial class frmReplacmentForDemagedLostLicense
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
            ucApplicationInfoForDamagedLostLicense1 = new ucApplicationInfoForDamagedLostLicense();
            gbReplacementFor = new GroupBox();
            rbLostLicense = new RadioButton();
            rbDamagedLicense = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnClose = new Button();
            linkLabelShowLicenseInfo = new LinkLabel();
            linklableShowLicenseHistory = new LinkLabel();
            btnIssueReplacement = new Button();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFibdLicenseID).BeginInit();
            gbReplacementFor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ucDriverLicenseInfo1
            // 
            ucDriverLicenseInfo1.Location = new Point(26, 186);
            ucDriverLicenseInfo1.Name = "ucDriverLicenseInfo1";
            ucDriverLicenseInfo1.Size = new Size(948, 369);
            ucDriverLicenseInfo1.TabIndex = 8;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(pbFibdLicenseID);
            gbFilter.Controls.Add(textBox1);
            gbFilter.Controls.Add(label2);
            gbFilter.Location = new Point(26, 83);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(658, 97);
            gbFilter.TabIndex = 7;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // pbFibdLicenseID
            // 
            pbFibdLicenseID.Image = Properties.Resources.License_View_32;
            pbFibdLicenseID.Location = new Point(574, 26);
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
            label1.Location = new Point(288, 26);
            label1.Name = "label1";
            label1.Size = new Size(421, 35);
            label1.TabIndex = 6;
            label1.Text = "Replacement for Damaged License";
            // 
            // ucApplicationInfoForDamagedLostLicense1
            // 
            ucApplicationInfoForDamagedLostLicense1.Location = new Point(114, 541);
            ucApplicationInfoForDamagedLostLicense1.Name = "ucApplicationInfoForDamagedLostLicense1";
            ucApplicationInfoForDamagedLostLicense1.Size = new Size(776, 201);
            ucApplicationInfoForDamagedLostLicense1.TabIndex = 9;
            // 
            // gbReplacementFor
            // 
            gbReplacementFor.Controls.Add(rbLostLicense);
            gbReplacementFor.Controls.Add(rbDamagedLicense);
            gbReplacementFor.Enabled = false;
            gbReplacementFor.Location = new Point(724, 90);
            gbReplacementFor.Name = "gbReplacementFor";
            gbReplacementFor.Size = new Size(220, 90);
            gbReplacementFor.TabIndex = 10;
            gbReplacementFor.TabStop = false;
            gbReplacementFor.Text = "Replacement For";
            // 
            // rbLostLicense
            // 
            rbLostLicense.AutoSize = true;
            rbLostLicense.Location = new Point(13, 60);
            rbLostLicense.Name = "rbLostLicense";
            rbLostLicense.Size = new Size(109, 24);
            rbLostLicense.TabIndex = 1;
            rbLostLicense.TabStop = true;
            rbLostLicense.Text = "Lost License";
            rbLostLicense.UseVisualStyleBackColor = true;
            rbLostLicense.CheckedChanged += rbDamagedLicense_CheckedChanged;
            // 
            // rbDamagedLicense
            // 
            rbDamagedLicense.AutoSize = true;
            rbDamagedLicense.Location = new Point(13, 31);
            rbDamagedLicense.Name = "rbDamagedLicense";
            rbDamagedLicense.Size = new Size(148, 24);
            rbDamagedLicense.TabIndex = 0;
            rbDamagedLicense.TabStop = true;
            rbDamagedLicense.Text = "Damaged License";
            rbDamagedLicense.UseVisualStyleBackColor = true;
            rbDamagedLicense.CheckedChanged += rbDamagedLicense_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.International_32;
            pictureBox1.Location = new Point(769, 767);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Close_32;
            pictureBox2.Location = new Point(584, 767);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(575, 752);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 54);
            btnClose.TabIndex = 27;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // linkLabelShowLicenseInfo
            // 
            linkLabelShowLicenseInfo.AutoSize = true;
            linkLabelShowLicenseInfo.Enabled = false;
            linkLabelShowLicenseInfo.Location = new Point(233, 778);
            linkLabelShowLicenseInfo.Name = "linkLabelShowLicenseInfo";
            linkLabelShowLicenseInfo.Size = new Size(127, 20);
            linkLabelShowLicenseInfo.TabIndex = 26;
            linkLabelShowLicenseInfo.TabStop = true;
            linkLabelShowLicenseInfo.Text = "Show License Info";
            linkLabelShowLicenseInfo.LinkClicked += linkLabelShowLicenseInfo_LinkClicked;
            // 
            // linklableShowLicenseHistory
            // 
            linklableShowLicenseHistory.AutoSize = true;
            linklableShowLicenseHistory.Enabled = false;
            linklableShowLicenseHistory.Location = new Point(54, 778);
            linklableShowLicenseHistory.Name = "linklableShowLicenseHistory";
            linklableShowLicenseHistory.Size = new Size(148, 20);
            linklableShowLicenseHistory.TabIndex = 25;
            linklableShowLicenseHistory.TabStop = true;
            linklableShowLicenseHistory.Text = "Show License History";
            linklableShowLicenseHistory.LinkClicked += linklableShowLicenseHistory_LinkClicked;
            // 
            // btnIssueReplacement
            // 
            btnIssueReplacement.Enabled = false;
            btnIssueReplacement.Location = new Point(760, 752);
            btnIssueReplacement.Name = "btnIssueReplacement";
            btnIssueReplacement.Size = new Size(223, 54);
            btnIssueReplacement.TabIndex = 29;
            btnIssueReplacement.Text = "Issue Replacement";
            btnIssueReplacement.UseVisualStyleBackColor = true;
            btnIssueReplacement.Click += btnRenew_Click;
            // 
            // frmReplacmentForDemagedLostLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 821);
            Controls.Add(pictureBox1);
            Controls.Add(btnIssueReplacement);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(linkLabelShowLicenseInfo);
            Controls.Add(linklableShowLicenseHistory);
            Controls.Add(gbReplacementFor);
            Controls.Add(ucApplicationInfoForDamagedLostLicense1);
            Controls.Add(ucDriverLicenseInfo1);
            Controls.Add(gbFilter);
            Controls.Add(label1);
            Name = "frmReplacmentForDemagedLostLicense";
            Text = "Replacment For Demaged Lost License";
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFibdLicenseID).EndInit();
            gbReplacementFor.ResumeLayout(false);
            gbReplacementFor.PerformLayout();
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
        private ucApplicationInfoForDamagedLostLicense ucApplicationInfoForDamagedLostLicense1;
        private GroupBox gbReplacementFor;
        private RadioButton rbLostLicense;
        private RadioButton rbDamagedLicense;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnClose;
        private LinkLabel linkLabelShowLicenseInfo;
        private LinkLabel linklableShowLicenseHistory;
        private Button btnIssueReplacement;
    }
}