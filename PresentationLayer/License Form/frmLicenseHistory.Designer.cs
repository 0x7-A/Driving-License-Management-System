namespace Project_19_DVDL__2nd_
{
    partial class frmLicenseHistory
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
            pbTitle = new PictureBox();
            ucDriverLicense1 = new ucDriverLicense();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            ucPerson1 = new ucPerson();
            ((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(458, 23);
            label1.Name = "label1";
            label1.Size = new Size(231, 41);
            label1.TabIndex = 0;
            label1.Text = "License History";
            // 
            // pbTitle
            // 
            pbTitle.Image = Properties.Resources.PersonLicenseHistory_512;
            pbTitle.Location = new Point(26, 163);
            pbTitle.Name = "pbTitle";
            pbTitle.Size = new Size(197, 150);
            pbTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pbTitle.TabIndex = 1;
            pbTitle.TabStop = false;
            // 
            // ucDriverLicense1
            // 
            ucDriverLicense1.Location = new Point(21, 423);
            ucDriverLicense1.Name = "ucDriverLicense1";
            ucDriverLicense1.Size = new Size(1089, 510);
            ucDriverLicense1.TabIndex = 2;
            ucDriverLicense1.Load += ucDriverLicense1_Load;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Close_32;
            pictureBox1.Location = new Point(949, 989);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 32);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(938, 973);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 63);
            btnClose.TabIndex = 16;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ucPerson1
            // 
            ucPerson1.Location = new Point(229, 87);
            ucPerson1.Name = "ucPerson1";
            ucPerson1.Size = new Size(881, 330);
            ucPerson1.TabIndex = 18;
            // 
            // frmLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 1051);
            Controls.Add(ucPerson1);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(ucDriverLicense1);
            Controls.Add(pbTitle);
            Controls.Add(label1);
            Name = "frmLicenseHistory";
            Text = "License History";
            Load += frmLicenseHistory_Load;
            ((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbTitle;
        private ucDriverLicense ucDriverLicense1;
        public PictureBox pictureBox1;
        public Button btnClose;
        private ucPerson ucPerson1;
    }
}