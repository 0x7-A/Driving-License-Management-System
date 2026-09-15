namespace Project_19_DVDL__2nd_
{
    partial class frmSceduleTest
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
            ucScheduledTest1 = new ucScheduledTest();
            SuspendLayout();
            // 
            // ucScheduledTest1
            // 
            ucScheduledTest1.AutoSize = true;
            ucScheduledTest1.Location = new Point(164, 12);
            ucScheduledTest1.Name = "ucScheduledTest1";
            ucScheduledTest1.Size = new Size(695, 904);
            ucScheduledTest1.TabIndex = 0;
            // 
            // frmSceduleTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 910);
            Controls.Add(ucScheduledTest1);
            Name = "frmSceduleTest";
            Text = "Scedule Test";
            Load += frmSceduleTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ucScheduledTest ucScheduledTest1;
    }
}