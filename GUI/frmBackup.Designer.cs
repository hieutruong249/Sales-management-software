namespace GUI
{
    partial class frmBackup
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
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            this.pBProcessBar = new System.Windows.Forms.ProgressBar();
            this.lbPer = new DevExpress.XtraEditors.LabelControl();
            this.lbStatus = new DevExpress.XtraEditors.LabelControl();
            this.lbLocation = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(141, 147);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // pBProcessBar
            // 
            this.pBProcessBar.Location = new System.Drawing.Point(12, 38);
            this.pBProcessBar.Name = "pBProcessBar";
            this.pBProcessBar.Size = new System.Drawing.Size(336, 23);
            this.pBProcessBar.TabIndex = 1;
            // 
            // lbPer
            // 
            this.lbPer.Location = new System.Drawing.Point(165, 67);
            this.lbPer.Name = "lbPer";
            this.lbPer.Size = new System.Drawing.Size(23, 13);
            this.lbPer.TabIndex = 2;
            this.lbPer.Text = " 0 %";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbStatus.Location = new System.Drawing.Point(12, 98);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(35, 13);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Status:";
            // 
            // lbLocation
            // 
            this.lbLocation.Location = new System.Drawing.Point(12, 117);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(44, 13);
            this.lbLocation.TabIndex = 4;
            this.lbLocation.Text = "Location:";
            this.lbLocation.Visible = false;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 193);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbPer);
            this.Controls.Add(this.pBProcessBar);
            this.Controls.Add(this.btnBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackup";
            this.Text = "Backup form";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private System.Windows.Forms.ProgressBar pBProcessBar;
        private DevExpress.XtraEditors.LabelControl lbPer;
        private DevExpress.XtraEditors.LabelControl lbStatus;
        private DevExpress.XtraEditors.LabelControl lbLocation;
    }
}