namespace GUI
{
    partial class frmPermission
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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.permDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finsertUserDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fdeleteUserDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fupdateUserDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finsertProductDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fdeleteProductDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fupdateProductDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finsertCategoryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fdeleteCategoryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fupdateCategoryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finsertSupplierDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fdeleteSupplierDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fupdateSupplierDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finsertStaffDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fdeleteStaffDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fupdateStaffDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fcashingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.freportDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permissionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet = new GUI.QLBH_v1DataSet();
            this.permissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissionTableAdapter = new GUI.QLBH_v1DataSetTableAdapters.PermissionTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(854, 124);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Information Role";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(491, 36);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(310, 20);
            this.textEdit3.TabIndex = 5;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(64, 73);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(251, 20);
            this.textEdit2.TabIndex = 4;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(64, 40);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(251, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(415, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Description";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dataGridView1);
            this.groupControl2.Location = new System.Drawing.Point(12, 132);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(854, 281);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Permission";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.permDataGridViewTextBoxColumn,
            this.finsertUserDataGridViewCheckBoxColumn,
            this.fdeleteUserDataGridViewCheckBoxColumn,
            this.fupdateUserDataGridViewCheckBoxColumn,
            this.finsertProductDataGridViewCheckBoxColumn,
            this.fdeleteProductDataGridViewCheckBoxColumn,
            this.fupdateProductDataGridViewCheckBoxColumn,
            this.finsertCategoryDataGridViewCheckBoxColumn,
            this.fdeleteCategoryDataGridViewCheckBoxColumn,
            this.fupdateCategoryDataGridViewCheckBoxColumn,
            this.finsertSupplierDataGridViewCheckBoxColumn,
            this.fdeleteSupplierDataGridViewCheckBoxColumn,
            this.fupdateSupplierDataGridViewCheckBoxColumn,
            this.finsertStaffDataGridViewCheckBoxColumn,
            this.fdeleteStaffDataGridViewCheckBoxColumn,
            this.fupdateStaffDataGridViewCheckBoxColumn,
            this.fcashingDataGridViewCheckBoxColumn,
            this.freportDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.permissionBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(5, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // permDataGridViewTextBoxColumn
            // 
            this.permDataGridViewTextBoxColumn.DataPropertyName = "Perm";
            this.permDataGridViewTextBoxColumn.HeaderText = "Perm";
            this.permDataGridViewTextBoxColumn.Name = "permDataGridViewTextBoxColumn";
            // 
            // finsertUserDataGridViewCheckBoxColumn
            // 
            this.finsertUserDataGridViewCheckBoxColumn.DataPropertyName = "f_insertUser";
            this.finsertUserDataGridViewCheckBoxColumn.HeaderText = "f_insertUser";
            this.finsertUserDataGridViewCheckBoxColumn.Name = "finsertUserDataGridViewCheckBoxColumn";
            // 
            // fdeleteUserDataGridViewCheckBoxColumn
            // 
            this.fdeleteUserDataGridViewCheckBoxColumn.DataPropertyName = "f_deleteUser";
            this.fdeleteUserDataGridViewCheckBoxColumn.HeaderText = "f_deleteUser";
            this.fdeleteUserDataGridViewCheckBoxColumn.Name = "fdeleteUserDataGridViewCheckBoxColumn";
            // 
            // fupdateUserDataGridViewCheckBoxColumn
            // 
            this.fupdateUserDataGridViewCheckBoxColumn.DataPropertyName = "f_updateUser";
            this.fupdateUserDataGridViewCheckBoxColumn.HeaderText = "f_updateUser";
            this.fupdateUserDataGridViewCheckBoxColumn.Name = "fupdateUserDataGridViewCheckBoxColumn";
            // 
            // finsertProductDataGridViewCheckBoxColumn
            // 
            this.finsertProductDataGridViewCheckBoxColumn.DataPropertyName = "f_insertProduct";
            this.finsertProductDataGridViewCheckBoxColumn.HeaderText = "f_insertProduct";
            this.finsertProductDataGridViewCheckBoxColumn.Name = "finsertProductDataGridViewCheckBoxColumn";
            // 
            // fdeleteProductDataGridViewCheckBoxColumn
            // 
            this.fdeleteProductDataGridViewCheckBoxColumn.DataPropertyName = "f_deleteProduct";
            this.fdeleteProductDataGridViewCheckBoxColumn.HeaderText = "f_deleteProduct";
            this.fdeleteProductDataGridViewCheckBoxColumn.Name = "fdeleteProductDataGridViewCheckBoxColumn";
            // 
            // fupdateProductDataGridViewCheckBoxColumn
            // 
            this.fupdateProductDataGridViewCheckBoxColumn.DataPropertyName = "f_updateProduct";
            this.fupdateProductDataGridViewCheckBoxColumn.HeaderText = "f_updateProduct";
            this.fupdateProductDataGridViewCheckBoxColumn.Name = "fupdateProductDataGridViewCheckBoxColumn";
            // 
            // finsertCategoryDataGridViewCheckBoxColumn
            // 
            this.finsertCategoryDataGridViewCheckBoxColumn.DataPropertyName = "f_insertCategory";
            this.finsertCategoryDataGridViewCheckBoxColumn.HeaderText = "f_insertCategory";
            this.finsertCategoryDataGridViewCheckBoxColumn.Name = "finsertCategoryDataGridViewCheckBoxColumn";
            // 
            // fdeleteCategoryDataGridViewCheckBoxColumn
            // 
            this.fdeleteCategoryDataGridViewCheckBoxColumn.DataPropertyName = "f_deleteCategory";
            this.fdeleteCategoryDataGridViewCheckBoxColumn.HeaderText = "f_deleteCategory";
            this.fdeleteCategoryDataGridViewCheckBoxColumn.Name = "fdeleteCategoryDataGridViewCheckBoxColumn";
            // 
            // fupdateCategoryDataGridViewCheckBoxColumn
            // 
            this.fupdateCategoryDataGridViewCheckBoxColumn.DataPropertyName = "f_updateCategory";
            this.fupdateCategoryDataGridViewCheckBoxColumn.HeaderText = "f_updateCategory";
            this.fupdateCategoryDataGridViewCheckBoxColumn.Name = "fupdateCategoryDataGridViewCheckBoxColumn";
            // 
            // finsertSupplierDataGridViewCheckBoxColumn
            // 
            this.finsertSupplierDataGridViewCheckBoxColumn.DataPropertyName = "f_insertSupplier";
            this.finsertSupplierDataGridViewCheckBoxColumn.HeaderText = "f_insertSupplier";
            this.finsertSupplierDataGridViewCheckBoxColumn.Name = "finsertSupplierDataGridViewCheckBoxColumn";
            // 
            // fdeleteSupplierDataGridViewCheckBoxColumn
            // 
            this.fdeleteSupplierDataGridViewCheckBoxColumn.DataPropertyName = "f_deleteSupplier";
            this.fdeleteSupplierDataGridViewCheckBoxColumn.HeaderText = "f_deleteSupplier";
            this.fdeleteSupplierDataGridViewCheckBoxColumn.Name = "fdeleteSupplierDataGridViewCheckBoxColumn";
            // 
            // fupdateSupplierDataGridViewCheckBoxColumn
            // 
            this.fupdateSupplierDataGridViewCheckBoxColumn.DataPropertyName = "f_updateSupplier";
            this.fupdateSupplierDataGridViewCheckBoxColumn.HeaderText = "f_updateSupplier";
            this.fupdateSupplierDataGridViewCheckBoxColumn.Name = "fupdateSupplierDataGridViewCheckBoxColumn";
            // 
            // finsertStaffDataGridViewCheckBoxColumn
            // 
            this.finsertStaffDataGridViewCheckBoxColumn.DataPropertyName = "f_insertStaff";
            this.finsertStaffDataGridViewCheckBoxColumn.HeaderText = "f_insertStaff";
            this.finsertStaffDataGridViewCheckBoxColumn.Name = "finsertStaffDataGridViewCheckBoxColumn";
            // 
            // fdeleteStaffDataGridViewCheckBoxColumn
            // 
            this.fdeleteStaffDataGridViewCheckBoxColumn.DataPropertyName = "f_deleteStaff";
            this.fdeleteStaffDataGridViewCheckBoxColumn.HeaderText = "f_deleteStaff";
            this.fdeleteStaffDataGridViewCheckBoxColumn.Name = "fdeleteStaffDataGridViewCheckBoxColumn";
            // 
            // fupdateStaffDataGridViewCheckBoxColumn
            // 
            this.fupdateStaffDataGridViewCheckBoxColumn.DataPropertyName = "f_updateStaff";
            this.fupdateStaffDataGridViewCheckBoxColumn.HeaderText = "f_updateStaff";
            this.fupdateStaffDataGridViewCheckBoxColumn.Name = "fupdateStaffDataGridViewCheckBoxColumn";
            // 
            // fcashingDataGridViewCheckBoxColumn
            // 
            this.fcashingDataGridViewCheckBoxColumn.DataPropertyName = "f_cashing";
            this.fcashingDataGridViewCheckBoxColumn.HeaderText = "f_cashing";
            this.fcashingDataGridViewCheckBoxColumn.Name = "fcashingDataGridViewCheckBoxColumn";
            // 
            // freportDataGridViewCheckBoxColumn
            // 
            this.freportDataGridViewCheckBoxColumn.DataPropertyName = "f_report";
            this.freportDataGridViewCheckBoxColumn.HeaderText = "f_report";
            this.freportDataGridViewCheckBoxColumn.Name = "freportDataGridViewCheckBoxColumn";
            // 
            // permissionBindingSource1
            // 
            this.permissionBindingSource1.DataMember = "Permission";
            this.permissionBindingSource1.DataSource = this.qLBH_v1DataSet;
            // 
            // qLBH_v1DataSet
            // 
            this.qLBH_v1DataSet.DataSetName = "QLBH_v1DataSet";
            this.qLBH_v1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // permissionBindingSource
            // 
            this.permissionBindingSource.DataMember = "Permission";
            this.permissionBindingSource.DataSource = this.qLBH_v1DataSet;
            // 
            // permissionTableAdapter
            // 
            this.permissionTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(609, 433);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Save";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(722, 433);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Close";
            // 
            // frmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 468);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmPermission";
            this.Text = "Permission form";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private QLBH_v1DataSet qLBH_v1DataSet;
        private System.Windows.Forms.BindingSource permissionBindingSource;
        private QLBH_v1DataSetTableAdapters.PermissionTableAdapter permissionTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn permDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finsertUserDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fdeleteUserDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fupdateUserDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finsertProductDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fdeleteProductDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fupdateProductDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finsertCategoryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fdeleteCategoryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fupdateCategoryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finsertSupplierDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fdeleteSupplierDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fupdateSupplierDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finsertStaffDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fdeleteStaffDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fupdateStaffDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fcashingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn freportDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource permissionBindingSource1;
    }
}