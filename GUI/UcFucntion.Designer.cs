namespace GUI
{
    partial class UcFucntion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(26, 13);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 19);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(117, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 19);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(212, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 19);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(312, 13);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(79, 19);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(409, 13);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(79, 19);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            // 
            // UcFucntion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Name = "UcFucntion";
            this.Size = new System.Drawing.Size(515, 78);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnExport;
    }
}
