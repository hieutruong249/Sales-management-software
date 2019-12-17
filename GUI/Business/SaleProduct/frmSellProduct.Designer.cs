namespace GUI.Business.SaleProduct
{
    partial class frmSellProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellProduct));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarWarehouse = new DevExpress.XtraNavBar.NavBarItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefesh = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteR = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateR = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertR = new DevExpress.XtraEditors.SimpleButton();
            this.lkWarehouse = new DevExpress.XtraEditors.LookUpEdit();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet5 = new GUI.QLBH_v1DataSet5();
            this.lkStaffID = new DevExpress.XtraEditors.LookUpEdit();
            this.staffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet3 = new GUI.QLBH_v1DataSet3();
            this.txtBill = new DevExpress.XtraEditors.TextEdit();
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lkCustomerID = new DevExpress.XtraEditors.LookUpEdit();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet10 = new GUI.QLBH_v1DataSet10();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtNumVat = new DevExpress.XtraEditors.TextEdit();
            this.txtExdate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkCustomerName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.gcItems = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.customerTableAdapter = new GUI.QLBH_v1DataSet10TableAdapters.CustomerTableAdapter();
            this.warehouseTableAdapter = new GUI.QLBH_v1DataSet5TableAdapters.WarehouseTableAdapter();
            this.staffsTableAdapter = new GUI.QLBH_v1DataSet3TableAdapters.StaffsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkWarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStaffID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBill.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumVat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            this.layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("e0122796-7e94-4522-9a0c-f46162f96336");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(190, 200);
            this.dockPanel1.Size = new System.Drawing.Size(190, 592);
            this.dockPanel1.Text = "Business";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 24);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(183, 565);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarProduct,
            this.navBarCustomer,
            this.navBarWarehouse});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 183;
            this.navBarControl1.Size = new System.Drawing.Size(183, 565);
            this.navBarControl1.TabIndex = 29;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("DevExpress Style");
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Sell product";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Bill";
            this.navBarItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.ImageOptions.LargeImage")));
            this.navBarItem1.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.ImageOptions.SmallImage")));
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "List";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "\r\nAccording to document";
            this.navBarItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.LargeImage")));
            this.navBarItem2.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.SmallImage")));
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "According to the goods";
            this.navBarItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.LargeImage")));
            this.navBarItem3.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.SmallImage")));
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Category";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarProduct),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarWarehouse)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarProduct
            // 
            this.navBarProduct.Caption = "Product";
            this.navBarProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarProduct.ImageOptions.LargeImage")));
            this.navBarProduct.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarProduct.ImageOptions.SmallImage")));
            this.navBarProduct.Name = "navBarProduct";
            this.navBarProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarProduct_LinkClicked);
            // 
            // navBarCustomer
            // 
            this.navBarCustomer.Caption = "Customer";
            this.navBarCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarCustomer.ImageOptions.LargeImage")));
            this.navBarCustomer.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarCustomer.ImageOptions.SmallImage")));
            this.navBarCustomer.Name = "navBarCustomer";
            this.navBarCustomer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarCustomer_LinkClicked);
            // 
            // navBarWarehouse
            // 
            this.navBarWarehouse.Caption = "Warehouse";
            this.navBarWarehouse.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarWarehouse.ImageOptions.LargeImage")));
            this.navBarWarehouse.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarWarehouse.ImageOptions.SmallImage")));
            this.navBarWarehouse.Name = "navBarWarehouse";
            this.navBarWarehouse.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarWarehouse_LinkClicked);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl3);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(190, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1064, 58);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnCreate);
            this.groupControl3.Controls.Add(this.btnSave);
            this.groupControl3.Controls.Add(this.btnRefesh);
            this.groupControl3.Controls.Add(this.btnPrint);
            this.groupControl3.Controls.Add(this.btnClose);
            this.groupControl3.Location = new System.Drawing.Point(12, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(1040, 34);
            this.groupControl3.TabIndex = 36;
            this.groupControl3.Text = "groupControl3";
            // 
            // btnCreate
            // 
            this.btnCreate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.ImageOptions.Image")));
            this.btnCreate.Location = new System.Drawing.Point(5, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 33;
            this.btnCreate.Text = "Create";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(86, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefesh.ImageOptions.Image")));
            this.btnRefesh.Location = new System.Drawing.Point(167, 5);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnRefesh.Size = new System.Drawing.Size(75, 23);
            this.btnRefesh.TabIndex = 35;
            this.btnRefesh.Text = "Refesh";
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(248, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "Print";
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(329, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1064, 58);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl3;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1044, 38);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.groupControl2);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl2.Location = new System.Drawing.Point(190, 58);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(1064, 269);
            this.layoutControl2.TabIndex = 4;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDeleteR);
            this.groupControl2.Controls.Add(this.btnUpdateR);
            this.groupControl2.Controls.Add(this.btnInsertR);
            this.groupControl2.Controls.Add(this.lkWarehouse);
            this.groupControl2.Controls.Add(this.lkStaffID);
            this.groupControl2.Controls.Add(this.txtBill);
            this.groupControl2.Controls.Add(this.txtDate);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.lkCustomerID);
            this.groupControl2.Controls.Add(this.txtPhone);
            this.groupControl2.Controls.Add(this.txtNumVat);
            this.groupControl2.Controls.Add(this.txtExdate);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtAddress);
            this.groupControl2.Controls.Add(this.txtNote);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.lkCustomerName);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1040, 245);
            this.groupControl2.TabIndex = 39;
            this.groupControl2.Text = "Information";
            // 
            // btnDeleteR
            // 
            this.btnDeleteR.AutoSize = true;
            this.btnDeleteR.Enabled = false;
            this.btnDeleteR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteR.ImageOptions.Image")));
            this.btnDeleteR.Location = new System.Drawing.Point(181, 218);
            this.btnDeleteR.Name = "btnDeleteR";
            this.btnDeleteR.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDeleteR.Size = new System.Drawing.Size(83, 22);
            this.btnDeleteR.TabIndex = 27;
            this.btnDeleteR.Text = "Delete Row";
            this.btnDeleteR.Click += new System.EventHandler(this.btnDeleteR_Click);
            // 
            // btnUpdateR
            // 
            this.btnUpdateR.AutoSize = true;
            this.btnUpdateR.Enabled = false;
            this.btnUpdateR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateR.ImageOptions.Image")));
            this.btnUpdateR.Location = new System.Drawing.Point(90, 218);
            this.btnUpdateR.Name = "btnUpdateR";
            this.btnUpdateR.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnUpdateR.Size = new System.Drawing.Size(87, 22);
            this.btnUpdateR.TabIndex = 26;
            this.btnUpdateR.Text = "Update Row";
            // 
            // btnInsertR
            // 
            this.btnInsertR.AutoSize = true;
            this.btnInsertR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertR.ImageOptions.Image")));
            this.btnInsertR.Location = new System.Drawing.Point(5, 218);
            this.btnInsertR.Name = "btnInsertR";
            this.btnInsertR.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnInsertR.Size = new System.Drawing.Size(81, 22);
            this.btnInsertR.TabIndex = 25;
            this.btnInsertR.Text = "Insert Row";
            this.btnInsertR.Click += new System.EventHandler(this.btnInsertR_Click);
            // 
            // lkWarehouse
            // 
            this.lkWarehouse.Location = new System.Drawing.Point(778, 95);
            this.lkWarehouse.Name = "lkWarehouse";
            this.lkWarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkWarehouse.Properties.DataSource = this.warehouseBindingSource;
            this.lkWarehouse.Properties.DisplayMember = "Name";
            this.lkWarehouse.Properties.ValueMember = "ID";
            this.lkWarehouse.Size = new System.Drawing.Size(224, 20);
            this.lkWarehouse.TabIndex = 24;
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
            // lkStaffID
            // 
            this.lkStaffID.Location = new System.Drawing.Point(778, 118);
            this.lkStaffID.Name = "lkStaffID";
            this.lkStaffID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkStaffID.Properties.DataSource = this.staffsBindingSource;
            this.lkStaffID.Properties.DisplayMember = "ID";
            this.lkStaffID.Properties.ValueMember = "ID";
            this.lkStaffID.Size = new System.Drawing.Size(224, 20);
            this.lkStaffID.TabIndex = 23;
            // 
            // staffsBindingSource
            // 
            this.staffsBindingSource.DataMember = "Staffs";
            this.staffsBindingSource.DataSource = this.qLBH_v1DataSet3;
            // 
            // qLBH_v1DataSet3
            // 
            this.qLBH_v1DataSet3.DataSetName = "QLBH_v1DataSet3";
            this.qLBH_v1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBill
            // 
            this.txtBill.Enabled = false;
            this.txtBill.Location = new System.Drawing.Point(778, 38);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(224, 20);
            this.txtBill.TabIndex = 21;
            // 
            // txtDate
            // 
            this.txtDate.EditValue = null;
            this.txtDate.Location = new System.Drawing.Point(778, 66);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Size = new System.Drawing.Size(224, 20);
            this.txtDate.TabIndex = 20;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(696, 95);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 13);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "WareHouse:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(696, 69);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(27, 13);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Date:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(696, 45);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(16, 13);
            this.labelControl10.TabIndex = 17;
            this.labelControl10.Text = "Bill:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(696, 121);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(42, 13);
            this.labelControl11.TabIndex = 16;
            this.labelControl11.Text = "Staff ID:";
            // 
            // lkCustomerID
            // 
            this.lkCustomerID.Location = new System.Drawing.Point(461, 42);
            this.lkCustomerID.Name = "lkCustomerID";
            this.lkCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCustomerID.Properties.DataSource = this.customerBindingSource;
            this.lkCustomerID.Properties.DisplayMember = "CustomerID";
            this.lkCustomerID.Properties.ValueMember = "CustomerID";
            this.lkCustomerID.Size = new System.Drawing.Size(224, 20);
            this.lkCustomerID.TabIndex = 15;
            this.lkCustomerID.TextChanged += new System.EventHandler(this.lkCustomerID_TextChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.qLBH_v1DataSet10;
            // 
            // qLBH_v1DataSet10
            // 
            this.qLBH_v1DataSet10.DataSetName = "QLBH_v1DataSet10";
            this.qLBH_v1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(461, 69);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Mask.EditMask = "99999";
            this.txtPhone.Size = new System.Drawing.Size(224, 20);
            this.txtPhone.TabIndex = 14;
            // 
            // txtNumVat
            // 
            this.txtNumVat.Location = new System.Drawing.Point(461, 95);
            this.txtNumVat.Name = "txtNumVat";
            this.txtNumVat.Size = new System.Drawing.Size(224, 20);
            this.txtNumVat.TabIndex = 13;
            // 
            // txtExdate
            // 
            this.txtExdate.EditValue = null;
            this.txtExdate.Location = new System.Drawing.Point(461, 118);
            this.txtExdate.Name = "txtExdate";
            this.txtExdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtExdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtExdate.Size = new System.Drawing.Size(224, 20);
            this.txtExdate.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(379, 98);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Num VAT";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(379, 118);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Experi Date";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(379, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Phone:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(379, 49);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Customer ID:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(316, 41);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(21, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 165);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Note:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(114, 76);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(224, 80);
            this.txtAddress.TabIndex = 5;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(114, 162);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(224, 20);
            this.txtNote.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Address:";
            // 
            // lkCustomerName
            // 
            this.lkCustomerName.Location = new System.Drawing.Point(114, 43);
            this.lkCustomerName.Name = "lkCustomerName";
            this.lkCustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCustomerName.Properties.DataSource = this.customerBindingSource;
            this.lkCustomerName.Properties.DisplayMember = "CustomerName";
            this.lkCustomerName.Properties.ValueMember = "CustomerID";
            this.lkCustomerName.Size = new System.Drawing.Size(196, 20);
            this.lkCustomerName.TabIndex = 1;
            this.lkCustomerName.TextChanged += new System.EventHandler(this.lkCustomerName_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Customer Name:";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1064, 269);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1044, 249);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControl3
            // 
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutControl3.Location = new System.Drawing.Point(190, 534);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup2;
            this.layoutControl3.Size = new System.Drawing.Size(1064, 58);
            this.layoutControl3.TabIndex = 5;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1064, 58);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControl4
            // 
            this.layoutControl4.Controls.Add(this.gcItems);
            this.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl4.Location = new System.Drawing.Point(190, 327);
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.Root = this.layoutControlGroup3;
            this.layoutControl4.Size = new System.Drawing.Size(1064, 207);
            this.layoutControl4.TabIndex = 6;
            this.layoutControl4.Text = "layoutControl4";
            // 
            // gcItems
            // 
            this.gcItems.Location = new System.Drawing.Point(12, 12);
            this.gcItems.MainView = this.gridView1;
            this.gcItems.Name = "gcItems";
            this.gcItems.Size = new System.Drawing.Size(1040, 183);
            this.gcItems.TabIndex = 4;
            this.gcItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcItems.Click += new System.EventHandler(this.gcItems_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView1.GridControl = this.gcItems;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.ShowFooterItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Product ID";
            this.gridColumn1.FieldName = "ProductID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Product Name";
            this.gridColumn2.FieldName = "ProductName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Unit";
            this.gridColumn3.FieldName = "Unit";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Exchange rate";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "ExRate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Amount";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "Count";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Count", "{0:0.##}")});
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Price";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "Price";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Total";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "Total";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:0.##}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Discount";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "Discount";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Discount", "{0:0.##}")});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1064, 207);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcItems;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1044, 187);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // staffsTableAdapter
            // 
            this.staffsTableAdapter.ClearBeforeFill = true;
            // 
            // frmSellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 592);
            this.Controls.Add(this.layoutControl4);
            this.Controls.Add(this.layoutControl3);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmSellProduct";
            this.Text = "Sell Product form";
            this.Load += new System.EventHandler(this.frmSellProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkWarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStaffID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBill.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumVat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            this.layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnRefesh;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnDeleteR;
        private DevExpress.XtraEditors.SimpleButton btnUpdateR;
        private DevExpress.XtraEditors.SimpleButton btnInsertR;
        private DevExpress.XtraEditors.LookUpEdit lkWarehouse;
        private DevExpress.XtraEditors.LookUpEdit lkStaffID;
        private DevExpress.XtraEditors.TextEdit txtBill;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LookUpEdit lkCustomerID;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtNumVat;
        private DevExpress.XtraEditors.DateEdit txtExdate;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtAddress;
        private DevExpress.XtraEditors.TextEdit txtNote;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lkCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private DevExpress.XtraGrid.GridControl gcItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarProduct;
        private DevExpress.XtraNavBar.NavBarItem navBarCustomer;
        private DevExpress.XtraNavBar.NavBarItem navBarWarehouse;
        private QLBH_v1DataSet10 qLBH_v1DataSet10;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private QLBH_v1DataSet10TableAdapters.CustomerTableAdapter customerTableAdapter;
        private QLBH_v1DataSet5 qLBH_v1DataSet5;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private QLBH_v1DataSet5TableAdapters.WarehouseTableAdapter warehouseTableAdapter;
        private QLBH_v1DataSet3 qLBH_v1DataSet3;
        private System.Windows.Forms.BindingSource staffsBindingSource;
        private QLBH_v1DataSet3TableAdapters.StaffsTableAdapter staffsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}