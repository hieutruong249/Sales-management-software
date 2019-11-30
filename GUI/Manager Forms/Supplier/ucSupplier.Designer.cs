namespace GUI
{
    partial class ucSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSupplier));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcSuppliers = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefesh = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcSuppliers;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // gcSuppliers
            // 
            this.gcSuppliers.Location = new System.Drawing.Point(0, 52);
            this.gcSuppliers.MainView = this.gridView1;
            this.gcSuppliers.Name = "gcSuppliers";
            this.gcSuppliers.Size = new System.Drawing.Size(862, 217);
            this.gcSuppliers.TabIndex = 11;
            this.gcSuppliers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom;
            this.groupControl1.Controls.Add(this.btnInsert);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(259, 44);
            this.groupControl1.TabIndex = 22;
            // 
            // btnInsert
            // 
            this.btnInsert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.ImageOptions.Image")));
            this.btnInsert.Location = new System.Drawing.Point(5, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnInsert.Size = new System.Drawing.Size(75, 34);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(175, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDelete.Size = new System.Drawing.Size(79, 31);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(90, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnUpdate.Size = new System.Drawing.Size(79, 31);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AutoSize = true;
            this.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Bottom;
            this.groupControl2.Controls.Add(this.btnImport);
            this.groupControl2.Controls.Add(this.btnRefesh);
            this.groupControl2.Controls.Add(this.btnExport);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl2.Location = new System.Drawing.Point(268, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(264, 44);
            this.groupControl2.TabIndex = 23;
            // 
            // btnImport
            // 
            this.btnImport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.ImageOptions.Image")));
            this.btnImport.Location = new System.Drawing.Point(175, 5);
            this.btnImport.Name = "btnImport";
            this.btnImport.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnImport.Size = new System.Drawing.Size(79, 32);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "Import";
            // 
            // btnRefesh
            // 
            this.btnRefesh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefesh.ImageOptions.Image")));
            this.btnRefesh.Location = new System.Drawing.Point(9, 7);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnRefesh.Size = new System.Drawing.Size(75, 30);
            this.btnRefesh.TabIndex = 5;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnExport
            // 
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(90, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnExport.Size = new System.Drawing.Size(79, 30);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.Appearance.Options.UseBorderColor = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(538, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClose.Size = new System.Drawing.Size(79, 32);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gcSuppliers);
            this.Name = "ucSupplier";
            this.Size = new System.Drawing.Size(862, 270);
            this.Load += new System.EventHandler(this.ucSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcSuppliers;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnRefesh;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}
