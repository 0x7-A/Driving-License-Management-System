namespace Project_19_DVDL__2nd_
{
    partial class frmAddEditPerson
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
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // btnSave
            // 
            btnSave.Click += btnSave_Click;
            // 
            // txtAddress
            // 
            txtAddress.Validating += txtEmpty_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Validating += txtEmpty_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Validating += txtEmail_Validating;
            // 
            // rbFemale
            // 
            rbFemale.CheckedChanged += rb_CheckedChanged;
            // 
            // rbMale
            // 
            rbMale.CheckedChanged += rb_CheckedChanged;
            // 
            // dtDateOfBirth
            // 
            dtDateOfBirth.MaxDate = new DateTime(2026, 2, 10, 0, 0, 0, 0);
            dtDateOfBirth.Value = new DateTime(2026, 2, 10, 0, 0, 0, 0);
            // 
            // txtNationalNumber
            // 
            txtNationalNumber.TextChanged += txtNationalNumber_TextChanged;
            txtNationalNumber.Validating += txtNationalNumber_Validating;
            // 
            // txtLastName
            // 
            txtLastName.Validating += txtEmpty_Validating;
            // 
            // txtSecondName
            // 
            txtSecondName.Validating += txtEmpty_Validating;
            // 
            // txtFirstName
            // 
            txtFirstName.Validating += txtEmpty_Validating;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(376, 66);
            lblTitle.Click += label1_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmAddEditPerson
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1027, 642);
            Name = "frmAddEditPerson";
            Text = "frmAddDelete";
            Load += frmAddDelete_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider;
    }
}