namespace GUI.System_Forms
{
    partial class frmUpdatePermission
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
            this.cbAccess = new System.Windows.Forms.CheckBox();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.cbInsert = new System.Windows.Forms.CheckBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbExport = new System.Windows.Forms.CheckBox();
            this.cbImport = new System.Windows.Forms.CheckBox();
            this.cbPrint = new System.Windows.Forms.CheckBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cbAccess
            // 
            this.cbAccess.AutoSize = true;
            this.cbAccess.Location = new System.Drawing.Point(8, 21);
            this.cbAccess.Name = "cbAccess";
            this.cbAccess.Size = new System.Drawing.Size(59, 17);
            this.cbAccess.TabIndex = 1;
            this.cbAccess.Text = "Access";
            this.cbAccess.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Location = new System.Drawing.Point(134, 21);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(61, 17);
            this.cbUpdate.TabIndex = 2;
            this.cbUpdate.Text = "Update";
            this.cbUpdate.UseVisualStyleBackColor = true;
            // 
            // cbInsert
            // 
            this.cbInsert.AutoSize = true;
            this.cbInsert.Location = new System.Drawing.Point(73, 21);
            this.cbInsert.Name = "cbInsert";
            this.cbInsert.Size = new System.Drawing.Size(55, 17);
            this.cbInsert.TabIndex = 3;
            this.cbInsert.Text = "Insert";
            this.cbInsert.UseVisualStyleBackColor = true;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(201, 21);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(57, 17);
            this.cbDelete.TabIndex = 4;
            this.cbDelete.Text = "Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbExport
            // 
            this.cbExport.AutoSize = true;
            this.cbExport.Location = new System.Drawing.Point(264, 21);
            this.cbExport.Name = "cbExport";
            this.cbExport.Size = new System.Drawing.Size(58, 17);
            this.cbExport.TabIndex = 5;
            this.cbExport.Text = "Export";
            this.cbExport.UseVisualStyleBackColor = true;
            // 
            // cbImport
            // 
            this.cbImport.AutoSize = true;
            this.cbImport.Location = new System.Drawing.Point(328, 21);
            this.cbImport.Name = "cbImport";
            this.cbImport.Size = new System.Drawing.Size(58, 17);
            this.cbImport.TabIndex = 6;
            this.cbImport.Text = "Import";
            this.cbImport.UseVisualStyleBackColor = true;
            // 
            // cbPrint
            // 
            this.cbPrint.AutoSize = true;
            this.cbPrint.Location = new System.Drawing.Point(392, 21);
            this.cbPrint.Name = "cbPrint";
            this.cbPrint.Size = new System.Drawing.Size(48, 17);
            this.cbPrint.TabIndex = 7;
            this.cbPrint.Text = "Print";
            this.cbPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(284, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(365, 54);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUpdatePermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 93);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbPrint);
            this.Controls.Add(this.cbImport);
            this.Controls.Add(this.cbExport);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.cbInsert);
            this.Controls.Add(this.cbUpdate);
            this.Controls.Add(this.cbAccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdatePermission";
            this.Text = "Edit permission";
            this.Load += new System.EventHandler(this.frmUpdatePermission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAccess;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.CheckBox cbInsert;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbExport;
        private System.Windows.Forms.CheckBox cbImport;
        private System.Windows.Forms.CheckBox cbPrint;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}