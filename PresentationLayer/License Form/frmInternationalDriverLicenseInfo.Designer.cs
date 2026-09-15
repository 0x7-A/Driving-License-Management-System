namespace Project_19_DVDL__2nd_
{
    partial class frmInternationalDriverLicenseInfo
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            btnClose = new Button();
            ucInternationalLicenseInfo1 = new ucInternationalLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LicenseView_400;
            pictureBox1.Location = new Point(404, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.International_32;
            pictureBox2.Location = new Point(404, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(257, 138);
            label1.Name = "label1";
            label1.Size = new Size(441, 38);
            label1.TabIndex = 2;
            label1.Text = "Driver International License Info";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Close_32;
            pictureBox3.Location = new Point(751, 637);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 32);
            pictureBox3.TabIndex = 52;
            pictureBox3.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(740, 621);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 63);
            btnClose.TabIndex = 51;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ucInternationalLicenseInfo1
            // 
            ucInternationalLicenseInfo1.Location = new Point(30, 204);
            ucInternationalLicenseInfo1.Name = "ucInternationalLicenseInfo1";
            ucInternationalLicenseInfo1.Size = new Size(924, 397);
            ucInternationalLicenseInfo1.TabIndex = 53;
            // 
            // frmInternationalDriverLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 720);
            Controls.Add(ucInternationalLicenseInfo1);
            Controls.Add(pictureBox3);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmInternationalDriverLicenseInfo";
            Text = "International Driver License Info";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        public PictureBox pictureBox3;
        public Button btnClose;
        private ucInternationalLicenseInfo ucInternationalLicenseInfo1;
    }
}