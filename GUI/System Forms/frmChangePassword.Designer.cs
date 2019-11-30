namespace GUI
{
    partial class frmChangePassword
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
            this.lbOldPWord = new DevExpress.XtraEditors.LabelControl();
            this.txtOldPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPWord = new DevExpress.XtraEditors.TextEdit();
            this.lbNewPWord = new DevExpress.XtraEditors.LabelControl();
            this.txtEnterPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAgree = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnterPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOldPWord
            // 
            this.lbOldPWord.Location = new System.Drawing.Point(41, 70);
            this.lbOldPWord.Name = "lbOldPWord";
            this.lbOldPWord.Size = new System.Drawing.Size(69, 13);
            this.lbOldPWord.TabIndex = 0;
            this.lbOldPWord.Text = "Old Password:";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(137, 67);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Properties.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(196, 20);
            this.txtOldPassword.TabIndex = 1;
            // 
            // txtNewPWord
            // 
            this.txtNewPWord.Location = new System.Drawing.Point(137, 93);
            this.txtNewPWord.Name = "txtNewPWord";
            this.txtNewPWord.Properties.PasswordChar = '*';
            this.txtNewPWord.Properties.UseSystemPasswordChar = true;
            this.txtNewPWord.Size = new System.Drawing.Size(196, 20);
            this.txtNewPWord.TabIndex = 2;
            // 
            // lbNewPWord
            // 
            this.lbNewPWord.Location = new System.Drawing.Point(41, 96);
            this.lbNewPWord.Name = "lbNewPWord";
            this.lbNewPWord.Size = new System.Drawing.Size(74, 13);
            this.lbNewPWord.TabIndex = 2;
            this.lbNewPWord.Text = "New Password:";
            // 
            // txtEnterPassword
            // 
            this.txtEnterPassword.Location = new System.Drawing.Point(137, 119);
            this.txtEnterPassword.Name = "txtEnterPassword";
            this.txtEnterPassword.Properties.PasswordChar = '*';
            this.txtEnterPassword.Properties.UseSystemPasswordChar = true;
            this.txtEnterPassword.Size = new System.Drawing.Size(196, 20);
            this.txtEnterPassword.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 122);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Enter Password:";
            // 
            // btnAgree
            // 
            this.btnAgree.Location = new System.Drawing.Point(103, 160);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(75, 23);
            this.btnAgree.TabIndex = 4;
            this.btnAgree.Text = "Agree";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(229, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(103, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(188, 29);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Change Password";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 219);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.txtEnterPassword);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNewPWord);
            this.Controls.Add(this.lbNewPWord);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lbOldPWord);
            this.Name = "frmChangePassword";
            this.Text = "Change Password form";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnterPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbOldPWord;
        private DevExpress.XtraEditors.TextEdit txtOldPassword;
        private DevExpress.XtraEditors.TextEdit txtNewPWord;
        private DevExpress.XtraEditors.LabelControl lbNewPWord;
        private DevExpress.XtraEditors.TextEdit txtEnterPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAgree;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}