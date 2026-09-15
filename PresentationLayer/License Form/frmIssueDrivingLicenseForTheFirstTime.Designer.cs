namespace Project_19_DVDL__2nd_
{
    partial class frmIssueDrivingLicenseForTheFirstTime
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
            ucApplicationBasicInfo1 = new ucApplicationBasicInfo();
            ucdlApplicationInfo1 = new ucDLApplicationInfo();
            label67 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            pbDetainRelease = new PictureBox();
            btnIssue = new Button();
            pictureBox2 = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDetainRelease).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ucApplicationBasicInfo1
            // 
            ucApplicationBasicInfo1.Location = new Point(58, 201);
            ucApplicationBasicInfo1.Name = "ucApplicationBasicInfo1";
            ucApplicationBasicInfo1.Size = new Size(844, 300);
            ucApplicationBasicInfo1.TabIndex = 0;
            ucApplicationBasicInfo1.Load += ucApplicationBasicInfo1_Load;
            // 
            // ucdlApplicationInfo1
            // 
            ucdlApplicationInfo1.Location = new Point(-1, -1);
            ucdlApplicationInfo1.Name = "ucdlApplicationInfo1";
            ucdlApplicationInfo1.Size = new Size(954, 210);
            ucdlApplicationInfo1.TabIndex = 1;
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label67.Location = new Point(62, 533);
            label67.Name = "label67";
            label67.Size = new Size(59, 20);
            label67.TabIndex = 2;
            label67.Text = "Notes: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Notes_32;
            pictureBox1.Location = new Point(128, 534);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 507);
            textBox1.MaxLength = 500;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(684, 130);
            textBox1.TabIndex = 4;
            // 
            // pbDetainRelease
            // 
            pbDetainRelease.Image = Properties.Resources.IssueDrivingLicense_32;
            pbDetainRelease.Location = new Point(835, 673);
            pbDetainRelease.Name = "pbDetainRelease";
            pbDetainRelease.Size = new Size(31, 31);
            pbDetainRelease.SizeMode = PictureBoxSizeMode.Zoom;
            pbDetainRelease.TabIndex = 40;
            pbDetainRelease.TabStop = false;
            // 
            // btnIssue
            // 
            btnIssue.Location = new Point(821, 658);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(155, 54);
            btnIssue.TabIndex = 39;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Close_32;
            pictureBox2.Location = new Point(668, 673);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(659, 658);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 54);
            btnClose.TabIndex = 37;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmIssueDrivingLicenseForTheFirstTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 724);
            Controls.Add(pbDetainRelease);
            Controls.Add(btnIssue);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label67);
            Controls.Add(ucdlApplicationInfo1);
            Controls.Add(ucApplicationBasicInfo1);
            Name = "frmIssueDrivingLicenseForTheFirstTime";
            Text = "Issue Driving License For The First Time";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDetainRelease).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ucApplicationBasicInfo ucApplicationBasicInfo1;
        private ucDLApplicationInfo ucdlApplicationInfo1;
        private Label label67;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private PictureBox pbDetainRelease;
        private Button btnIssue;
        private PictureBox pictureBox2;
        private Button btnClose;
    }
}