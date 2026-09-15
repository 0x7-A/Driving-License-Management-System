namespace Project_19_DVDL__2nd_
{
    partial class frmTakeTest
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
            txtNotes = new TextBox();
            pictureBox9 = new PictureBox();
            rbFail = new RadioButton();
            label6 = new Label();
            rbPass = new RadioButton();
            pictureBox8 = new PictureBox();
            label4 = new Label();
            ucTakeTest1 = new ucTakeTest();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(243, 639);
            txtNotes.MaxLength = 500;
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(358, 112);
            txtNotes.TabIndex = 41;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Notes_32;
            pictureBox9.Location = new Point(182, 640);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(29, 27);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 38;
            pictureBox9.TabStop = false;
            // 
            // rbFail
            // 
            rbFail.AutoSize = true;
            rbFail.Location = new Point(317, 592);
            rbFail.Name = "rbFail";
            rbFail.Size = new Size(52, 24);
            rbFail.TabIndex = 40;
            rbFail.TabStop = true;
            rbFail.Text = "Fail";
            rbFail.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(41, 641);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 35;
            label6.Text = "Notes: ";
            // 
            // rbPass
            // 
            rbPass.AutoSize = true;
            rbPass.Location = new Point(243, 592);
            rbPass.Name = "rbPass";
            rbPass.Size = new Size(57, 24);
            rbPass.TabIndex = 39;
            rbPass.TabStop = true;
            rbPass.Text = "Pass";
            rbPass.UseVisualStyleBackColor = true;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Number_32;
            pictureBox8.Location = new Point(182, 591);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(29, 27);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 36;
            pictureBox8.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(41, 592);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 37;
            label4.Text = "Result: ";
            // 
            // ucTakeTest1
            // 
            ucTakeTest1.Location = new Point(12, -1);
            ucTakeTest1.Name = "ucTakeTest1";
            ucTakeTest1.Size = new Size(646, 590);
            ucTakeTest1.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Close_32;
            pictureBox1.Location = new Point(478, 805);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(455, 791);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(155, 51);
            btnClose.TabIndex = 43;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Save_32;
            pictureBox2.Location = new Point(305, 805);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(282, 791);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 51);
            btnSave.TabIndex = 45;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmTakeTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 863);
            Controls.Add(pictureBox2);
            Controls.Add(btnSave);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(ucTakeTest1);
            Controls.Add(txtNotes);
            Controls.Add(pictureBox9);
            Controls.Add(rbFail);
            Controls.Add(label6);
            Controls.Add(rbPass);
            Controls.Add(pictureBox8);
            Controls.Add(label4);
            Name = "frmTakeTest";
            Text = "Take Test";
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNotes;
        private PictureBox pictureBox9;
        private RadioButton rbFail;
        private Label label6;
        private RadioButton rbPass;
        private PictureBox pictureBox8;
        private Label label4;
        private ucTakeTest ucTakeTest1;
        private PictureBox pictureBox1;
        private Button btnClose;
        private PictureBox pictureBox2;
        private Button btnSave;
    }
}