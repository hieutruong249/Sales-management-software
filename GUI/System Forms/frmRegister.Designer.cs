namespace GUI
{
    partial class frmRegister
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbUsername = new DevExpress.XtraEditors.LabelControl();
            this.lbPassword = new DevExpress.XtraEditors.LabelControl();
            this.lbName = new DevExpress.XtraEditors.LabelControl();
            this.lbEmail = new DevExpress.XtraEditors.LabelControl();
            this.lbDob = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtDoB = new DevExpress.XtraEditors.TextEdit();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(63, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 25;
            // 
            // lbUsername
            // 
            this.lbUsername.Location = new System.Drawing.Point(52, 54);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(52, 13);
            this.lbUsername.TabIndex = 26;
            this.lbUsername.Text = "Username:";
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(52, 83);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(50, 13);
            this.lbPassword.TabIndex = 27;
            this.lbPassword.Text = "Password:";
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(52, 117);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(31, 13);
            this.lbName.TabIndex = 28;
            this.lbName.Text = "Name:";
            // 
            // lbEmail
            // 
            this.lbEmail.Location = new System.Drawing.Point(52, 149);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(28, 13);
            this.lbEmail.TabIndex = 29;
            this.lbEmail.Text = "Email:";
            // 
            // lbDob
            // 
            this.lbDob.Location = new System.Drawing.Point(52, 181);
            this.lbDob.Name = "lbDob";
            this.lbDob.Size = new System.Drawing.Size(25, 13);
            this.lbDob.TabIndex = 30;
            this.lbDob.Text = "DOB:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(122, 51);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(223, 20);
            this.txtUsername.TabIndex = 31;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(122, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(223, 20);
            this.txtPassword.TabIndex = 32;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 20);
            this.txtName.TabIndex = 33;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 20);
            this.txtEmail.TabIndex = 34;
            // 
            // txtDoB
            // 
            this.txtDoB.EditValue = "__/__/____";
            this.txtDoB.Location = new System.Drawing.Point(122, 178);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.Properties.DisplayFormat.FormatString = "d";
            this.txtDoB.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDoB.Properties.Mask.EditMask = "d";
            this.txtDoB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtDoB.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDoB.Size = new System.Drawing.Size(223, 20);
            this.txtDoB.TabIndex = 35;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(136, 229);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 36;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(242, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.6F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(178, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 21);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "Register";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 279);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtDoB);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbDob);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegister";
            this.Text = "Register form";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoB.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbUsername;
        private DevExpress.XtraEditors.LabelControl lbPassword;
        private DevExpress.XtraEditors.LabelControl lbName;
        private DevExpress.XtraEditors.LabelControl lbEmail;
        private DevExpress.XtraEditors.LabelControl lbDob;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtDoB;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}