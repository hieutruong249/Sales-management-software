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
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(103, 102);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // pBProcessBar
            // 
            this.pBProcessBar.Location = new System.Drawing.Point(35, 56);
            this.pBProcessBar.Name = "pBProcessBar";
            this.pBProcessBar.Size = new System.Drawing.Size(191, 23);
            this.pBProcessBar.TabIndex = 1;
            // 
            // lbPer
            // 
            this.lbPer.Location = new System.Drawing.Point(232, 66);
            this.lbPer.Name = "lbPer";
            this.lbPer.Size = new System.Drawing.Size(23, 13);
            this.lbPer.TabIndex = 2;
            this.lbPer.Text = " 0 %";
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 191);
            this.Controls.Add(this.lbPer);
            this.Controls.Add(this.pBProcessBar);
            this.Controls.Add(this.btnBackup);
            this.Name = "frmBackup";
            this.Text = "Backup form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private System.Windows.Forms.ProgressBar pBProcessBar;
        private DevExpress.XtraEditors.LabelControl lbPer;
    }
}