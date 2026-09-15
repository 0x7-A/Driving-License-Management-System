namespace Project_19_DVDL__2nd_
{
    partial class frmLicenseInfo
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
            label1 = new Label();
            ucLicenseInfo1 = new ucLicenseInfoHistory();
            pictureBox3 = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LicenseView_400;
            pictureBox1.Location = new Point(486, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(444, 151);
            label1.Name = "label1";
            label1.Size = new Size(214, 31);
            label1.TabIndex = 1;
            label1.Text = "Driver License Info";
            // 
            // ucLicenseInfo1
            // 
            ucLicenseInfo1.Location = new Point(12, 186);
            ucLicenseInfo1.Name = "ucLicenseInfo1";
            ucLicenseInfo1.Size = new Size(1051, 392);
            ucLicenseInfo1.TabIndex = 2;
            ucLicenseInfo1.Load += ucLicenseInfo1_Load;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Close_32;
            pictureBox3.Location = new Point(876, 593);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(864, 584);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(172, 42);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 667);
            Controls.Add(pictureBox3);
            Controls.Add(btnClose);
            Controls.Add(ucLicenseInfo1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmLicenseInfo";
            Text = "License Info";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ucLicenseInfoHistory ucLicenseInfo1;
        private PictureBox pictureBox3;
        private Button btnClose;
    }
}