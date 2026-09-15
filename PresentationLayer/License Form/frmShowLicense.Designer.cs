namespace Project_19_DVDL__2nd_
{
    partial class frmShowLicense
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
            ucLicenseInfo1 = new ucLicenseInfoHistory();
            pictureBox2 = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ucLicenseInfo1
            // 
            ucLicenseInfo1.Location = new Point(0, -5);
            ucLicenseInfo1.Name = "ucLicenseInfo1";
            ucLicenseInfo1.Size = new Size(1069, 408);
            ucLicenseInfo1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Close_32;
            pictureBox2.Location = new Point(904, 425);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(895, 410);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 54);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 488);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(ucLicenseInfo1);
            Name = "frmShowLicense";
            Text = "Show License";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ucLicenseInfoHistory ucLicenseInfo1;
        private PictureBox pictureBox2;
        private Button btnClose;
    }
}