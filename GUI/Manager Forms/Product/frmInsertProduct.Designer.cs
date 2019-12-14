namespace GUI
{
    partial class frmInsertProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertProduct));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lkUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.lkCatergory = new DevExpress.XtraEditors.LookUpEdit();
            this.speCurr_Inventory = new DevExpress.XtraEditors.SpinEdit();
            this.speMin_Inventory = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrigin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPdName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPdID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lkSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.speRetail = new DevExpress.XtraEditors.SpinEdit();
            this.speWholesale = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.spePurchase = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lkWarehouse = new DevExpress.XtraEditors.LookUpEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet5 = new GUI.QLBH_v1DataSet5();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet8 = new GUI.QLBH_v1DataSet8();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet7 = new GUI.QLBH_v1DataSet7();
            this.catergoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet6 = new GUI.QLBH_v1DataSet6();
            this.warehouseTableAdapter = new GUI.QLBH_v1DataSet5TableAdapters.WarehouseTableAdapter();
            this.catergoriesTableAdapter = new GUI.QLBH_v1DataSet6TableAdapters.CatergoriesTableAdapter();
            this.unitTableAdapter = new GUI.QLBH_v1DataSet7TableAdapters.UnitTableAdapter();
            this.suppliersTableAdapter = new GUI.QLBH_v1DataSet8TableAdapters.SuppliersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCatergory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speCurr_Inventory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speMin_Inventory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrigin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPdName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPdID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speRetail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speWholesale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spePurchase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkWarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catergoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.lkUnit);
            this.groupControl1.Controls.Add(this.lkCatergory);
            this.groupControl1.Controls.Add(this.speCurr_Inventory);
            this.groupControl1.Controls.Add(this.speMin_Inventory);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtOrigin);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtPdName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtPdID);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 43);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(535, 292);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Information";
            // 
            // lkUnit
            // 
            this.lkUnit.Location = new System.Drawing.Point(114, 121);
            this.lkUnit.Name = "lkUnit";
            this.lkUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUnit.Properties.DataSource = this.unitBindingSource;
            this.lkUnit.Properties.DisplayMember = "Name";
            this.lkUnit.Properties.ValueMember = "ID";
            this.lkUnit.Size = new System.Drawing.Size(156, 20);
            this.lkUnit.TabIndex = 37;
            // 
            // lkCatergory
            // 
            this.lkCatergory.Location = new System.Drawing.Point(114, 39);
            this.lkCatergory.Name = "lkCatergory";
            this.lkCatergory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCatergory.Properties.DataSource = this.catergoriesBindingSource;
            this.lkCatergory.Properties.DisplayMember = "Name";
            this.lkCatergory.Properties.ValueMember = "ID";
            this.lkCatergory.Size = new System.Drawing.Size(403, 20);
            this.lkCatergory.TabIndex = 36;
            // 
            // speCurr_Inventory
            // 
            this.speCurr_Inventory.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speCurr_Inventory.Location = new System.Drawing.Point(114, 198);
            this.speCurr_Inventory.Name = "speCurr_Inventory";
            this.speCurr_Inventory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speCurr_Inventory.Properties.IsFloatValue = false;
            this.speCurr_Inventory.Properties.Mask.EditMask = "n0";
            this.speCurr_Inventory.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.speCurr_Inventory.Size = new System.Drawing.Size(156, 20);
            this.speCurr_Inventory.TabIndex = 13;
            // 
            // speMin_Inventory
            // 
            this.speMin_Inventory.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speMin_Inventory.Location = new System.Drawing.Point(114, 173);
            this.speMin_Inventory.Name = "speMin_Inventory";
            this.speMin_Inventory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speMin_Inventory.Properties.IsFloatValue = false;
            this.speMin_Inventory.Properties.Mask.EditMask = "n0";
            this.speMin_Inventory.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.speMin_Inventory.Size = new System.Drawing.Size(156, 20);
            this.speMin_Inventory.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(17, 205);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Current inventory:";
            this.labelControl7.ToolTip = "Current inventory";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 176);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(93, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Minimum inventory:";
            this.labelControl6.ToolTip = "Minimum inventory";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(114, 147);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(156, 20);
            this.txtOrigin.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 150);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Origin:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 124);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(23, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Unit:";
            // 
            // txtPdName
            // 
            this.txtPdName.Location = new System.Drawing.Point(114, 95);
            this.txtPdName.Name = "txtPdName";
            this.txtPdName.Size = new System.Drawing.Size(403, 20);
            this.txtPdName.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Product Name:";
            // 
            // txtPdID
            // 
            this.txtPdID.Location = new System.Drawing.Point(114, 69);
            this.txtPdID.Name = "txtPdID";
            this.txtPdID.Size = new System.Drawing.Size(403, 20);
            this.txtPdID.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Product ID:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Catergory:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lkSupplier);
            this.groupControl2.Controls.Add(this.speRetail);
            this.groupControl2.Controls.Add(this.speWholesale);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.spePurchase);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Location = new System.Drawing.Point(12, 341);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(535, 121);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Trade information";
            // 
            // lkSupplier
            // 
            this.lkSupplier.Location = new System.Drawing.Point(102, 36);
            this.lkSupplier.Name = "lkSupplier";
            this.lkSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkSupplier.Properties.DataSource = this.suppliersBindingSource;
            this.lkSupplier.Properties.DisplayMember = "SupplierName";
            this.lkSupplier.Properties.ValueMember = "SupplierID";
            this.lkSupplier.Size = new System.Drawing.Size(415, 20);
            this.lkSupplier.TabIndex = 22;
            // 
            // speRetail
            // 
            this.speRetail.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speRetail.Location = new System.Drawing.Point(102, 91);
            this.speRetail.Name = "speRetail";
            this.speRetail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speRetail.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.speRetail.Properties.IsFloatValue = false;
            this.speRetail.Properties.Mask.EditMask = "c3";
            this.speRetail.Properties.MaxValue = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.speRetail.Size = new System.Drawing.Size(156, 20);
            this.speRetail.TabIndex = 21;
            // 
            // speWholesale
            // 
            this.speWholesale.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speWholesale.Location = new System.Drawing.Point(361, 62);
            this.speWholesale.Name = "speWholesale";
            this.speWholesale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speWholesale.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.speWholesale.Properties.IsFloatValue = false;
            this.speWholesale.Properties.Mask.EditMask = "c3";
            this.speWholesale.Properties.MaxValue = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.speWholesale.Size = new System.Drawing.Size(156, 20);
            this.speWholesale.TabIndex = 20;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(276, 65);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(79, 13);
            this.labelControl11.TabIndex = 19;
            this.labelControl11.Text = "Wholesale price:";
            // 
            // spePurchase
            // 
            this.spePurchase.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spePurchase.Location = new System.Drawing.Point(102, 62);
            this.spePurchase.Name = "spePurchase";
            this.spePurchase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spePurchase.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spePurchase.Properties.IsFloatValue = false;
            this.spePurchase.Properties.Mask.EditMask = "c";
            this.spePurchase.Properties.MaxValue = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.spePurchase.Size = new System.Drawing.Size(156, 20);
            this.spePurchase.TabIndex = 17;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(17, 94);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(57, 13);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Retail price:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(17, 39);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Supplier:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(17, 65);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(74, 13);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "Purchase price:";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(336, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(454, 477);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(281, 15);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(96, 13);
            this.labelControl12.TabIndex = 15;
            this.labelControl12.Text = "Warehouse default:";
            // 
            // lkWarehouse
            // 
            this.lkWarehouse.Location = new System.Drawing.Point(383, 12);
            this.lkWarehouse.Name = "lkWarehouse";
            this.lkWarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkWarehouse.Properties.DataSource = this.warehouseBindingSource;
            this.lkWarehouse.Properties.DisplayMember = "Name";
            this.lkWarehouse.Properties.ValueMember = "ID";
            this.lkWarehouse.Size = new System.Drawing.Size(146, 20);
            this.lkWarehouse.TabIndex = 35;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(276, 122);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ErrorImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.ErrorImageOptions.Image")));
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(241, 165);
            this.pictureEdit1.TabIndex = 38;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "Warehouse";
            this.warehouseBindingSource.DataSource = this.qLBH_v1DataSet5;
            // 
            // qLBH_v1DataSet5
            // 
            this.qLBH_v1DataSet5.DataSetName = "QLBH_v1DataSet5";
            this.qLBH_v1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.qLBH_v1DataSet8;
            // 
            // qLBH_v1DataSet8
            // 
            this.qLBH_v1DataSet8.DataSetName = "QLBH_v1DataSet8";
            this.qLBH_v1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.DataSource = this.qLBH_v1DataSet7;
            // 
            // qLBH_v1DataSet7
            // 
            this.qLBH_v1DataSet7.DataSetName = "QLBH_v1DataSet7";
            this.qLBH_v1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catergoriesBindingSource
            // 
            this.catergoriesBindingSource.DataMember = "Catergories";
            this.catergoriesBindingSource.DataSource = this.qLBH_v1DataSet6;
            // 
            // qLBH_v1DataSet6
            // 
            this.qLBH_v1DataSet6.DataSetName = "QLBH_v1DataSet6";
            this.qLBH_v1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // catergoriesTableAdapter
            // 
            this.catergoriesTableAdapter.ClearBeforeFill = true;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // frmInsertProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 517);
            this.Controls.Add(this.lkWarehouse);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsertProduct";
            this.Text = "Insert Product form";
            this.Load += new System.EventHandler(this.frmInsertProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCatergory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speCurr_Inventory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speMin_Inventory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrigin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPdName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPdID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speRetail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speWholesale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spePurchase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkWarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catergoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SpinEdit speCurr_Inventory;
        private DevExpress.XtraEditors.SpinEdit speMin_Inventory;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtOrigin;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPdName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPdID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SpinEdit speRetail;
        private DevExpress.XtraEditors.SpinEdit speWholesale;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SpinEdit spePurchase;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LookUpEdit lkWarehouse;
        private QLBH_v1DataSet5 qLBH_v1DataSet5;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private QLBH_v1DataSet5TableAdapters.WarehouseTableAdapter warehouseTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lkCatergory;
        private QLBH_v1DataSet6 qLBH_v1DataSet6;
        private System.Windows.Forms.BindingSource catergoriesBindingSource;
        private QLBH_v1DataSet6TableAdapters.CatergoriesTableAdapter catergoriesTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lkUnit;
        private QLBH_v1DataSet7 qLBH_v1DataSet7;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private QLBH_v1DataSet7TableAdapters.UnitTableAdapter unitTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lkSupplier;
        private QLBH_v1DataSet8 qLBH_v1DataSet8;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private QLBH_v1DataSet8TableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}