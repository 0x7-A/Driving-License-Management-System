namespace Project_19_DVDL__2nd_
{
    partial class frmInternationalLicenseApplication
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
            label1 = new Label();
            gbFilter = new GroupBox();
            pbFibdLicenseID = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            ucDriverLicenseInfo1 = new ucDriverLicenseInfo();
            linklableShowLicenseHistory = new LinkLabel();
            ucInternationalApplicationInfo1 = new ucInternationalApplicationInfo();
            LinkLabelShowLicenseInfo = new LinkLabel();
            pictureBox2 = new PictureBox();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            btnIssue = new Button();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFibdLicenseID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(279, 41);
            label1.Name = "label1";
            label1.Size = new Size(403, 35);
            label1.TabIndex = 0;
            label1.Text = "International License Application";
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(pbFibdLicenseID);
            gbFilter.Controls.Add(textBox1);
            gbFilter.Controls.Add(label2);
            gbFilter.Location = new Point(95, 123);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(690, 97);
            gbFilter.TabIndex = 1;
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
            // ucDriverLicenseInfo1
            // 
            ucDriverLicenseInfo1.Location = new Point(24, 237);
            ucDriverLicenseInfo1.Name = "ucDriverLicenseInfo1";
            ucDriverLicenseInfo1.Size = new Size(948, 369);
            ucDriverLicenseInfo1.TabIndex = 2;
            // 
            // linklableShowLicenseHistory
            // 
            linklableShowLicenseHistory.AutoSize = true;
            linklableShowLicenseHistory.Enabled = false;
            linklableShowLicenseHistory.Location = new Point(36, 888);
            linklableShowLicenseHistory.Name = "linklableShowLicenseHistory";
            linklableShowLicenseHistory.Size = new Size(148, 20);
            linklableShowLicenseHistory.TabIndex = 3;
            linklableShowLicenseHistory.TabStop = true;
            linklableShowLicenseHistory.Text = "Show License History";
            linklableShowLicenseHistory.LinkClicked += linklableShowLicenseHistory_LinkClicked;
            // 
            // ucInternationalApplicationInfo1
            // 
            ucInternationalApplicationInfo1.Location = new Point(123, 597);
            ucInternationalApplicationInfo1.Name = "ucInternationalApplicationInfo1";
            ucInternationalApplicationInfo1.Size = new Size(728, 270);
            ucInternationalApplicationInfo1.TabIndex = 4;
            // 
            // LinkLabelShowLicenseInfo
            // 
            LinkLabelShowLicenseInfo.AutoSize = true;
            LinkLabelShowLicenseInfo.Enabled = false;
            LinkLabelShowLicenseInfo.Location = new Point(215, 888);
            LinkLabelShowLicenseInfo.Name = "LinkLabelShowLicenseInfo";
            LinkLabelShowLicenseInfo.Size = new Size(127, 20);
            LinkLabelShowLicenseInfo.TabIndex = 5;
            LinkLabelShowLicenseInfo.TabStop = true;
            LinkLabelShowLicenseInfo.Text = "Show License Info";
            LinkLabelShowLicenseInfo.LinkClicked += LinkLabelShowLicenseInfo_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Close_32;
            pictureBox2.Location = new Point(667, 888);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(658, 873);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 54);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.International_32;
            pictureBox1.Location = new Point(830, 888);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnIssue
            // 
            btnIssue.Enabled = false;
            btnIssue.Location = new Point(821, 873);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(138, 54);
            btnIssue.TabIndex = 17;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // frmInternationalLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 958);
            Controls.Add(pictureBox1);
            Controls.Add(btnIssue);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(LinkLabelShowLicenseInfo);
            Controls.Add(ucInternationalApplicationInfo1);
            Controls.Add(linklableShowLicenseHistory);
            Controls.Add(ucDriverLicenseInfo1);
            Controls.Add(gbFilter);
            Controls.Add(label1);
            Name = "frmInternationalLicenseApplication";
            Text = "International License Application";
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFibdLicenseID).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbFilter;
        private PictureBox pbFibdLicenseID;
        private TextBox textBox1;
        private Label label2;
        private ucDriverLicenseInfo ucDriverLicenseInfo1;
        private LinkLabel linklableShowLicenseHistory;
        private ucInternationalApplicationInfo ucInternationalApplicationInfo1;
        private LinkLabel LinkLabelShowLicenseInfo;
        private PictureBox pictureBox2;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Button btnIssue;
    }
}