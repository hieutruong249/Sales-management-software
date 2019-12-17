namespace GUI.Business.BuyProduct
{
    partial class frmInsertR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertR));
            this.label1 = new System.Windows.Forms.Label();
            this.lkProductID = new DevExpress.XtraEditors.LookUpEdit();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet9 = new GUI.QLBH_v1DataSet9();
            this.lkProductName = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mudCount = new System.Windows.Forms.NumericUpDown();
            this.lbToTal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.productsTableAdapter = new GUI.QLBH_v1DataSet9TableAdapters.ProductsTableAdapter();
            this.unitTableAdapter = new GUI.QLBH_v1DataSet7TableAdapters.UnitTableAdapter();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet7 = new GUI.QLBH_v1DataSet7();
            this.lkUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lkProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUnit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID:";
            // 
            // lkProductID
            // 
            this.lkProductID.Location = new System.Drawing.Point(96, 13);
            this.lkProductID.Name = "lkProductID";
            this.lkProductID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkProductID.Properties.BestFitRowCount = 7;
            this.lkProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkProductID.Properties.DataSource = this.productsBindingSource;
            this.lkProductID.Properties.DisplayMember = "ProductID";
            this.lkProductID.Properties.ValueMember = "ProductID";
            this.lkProductID.Size = new System.Drawing.Size(259, 20);
            this.lkProductID.TabIndex = 1;
            this.lkProductID.TextChanged += new System.EventHandler(this.lkProductID_TextChanged);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.qLBH_v1DataSet9;
            // 
            // qLBH_v1DataSet9
            // 
            this.qLBH_v1DataSet9.DataSetName = "QLBH_v1DataSet9";
            this.qLBH_v1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lkProductName
            // 
            this.lkProductName.Location = new System.Drawing.Point(96, 39);
            this.lkProductName.Name = "lkProductName";
            this.lkProductName.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkProductName.Properties.BestFitRowCount = 7;
            this.lkProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkProductName.Properties.DataSource = this.productsBindingSource;
            this.lkProductName.Properties.DisplayMember = "ProductName";
            this.lkProductName.Properties.ValueMember = "ProductID";
            this.lkProductName.Size = new System.Drawing.Size(259, 20);
            this.lkProductName.TabIndex = 3;
            this.lkProductName.TextChanged += new System.EventHandler(this.lkProductName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unit:";
            // 
            // mudCount
            // 
            this.mudCount.Location = new System.Drawing.Point(628, 14);
            this.mudCount.Name = "mudCount";
            this.mudCount.Size = new System.Drawing.Size(120, 21);
            this.mudCount.TabIndex = 7;
            this.mudCount.ValueChanged += new System.EventHandler(this.mudCount_ValueChanged);
            // 
            // lbToTal
            // 
            this.lbToTal.AutoSize = true;
            this.lbToTal.Location = new System.Drawing.Point(393, 89);
            this.lbToTal.Name = "lbToTal";
            this.lbToTal.Size = new System.Drawing.Size(35, 13);
            this.lbToTal.TabIndex = 9;
            this.lbToTal.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(439, 42);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Mask.EditMask = "n";
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrice.Size = new System.Drawing.Size(283, 20);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(439, 89);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Mask.EditMask = "n";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Size = new System.Drawing.Size(283, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.EditValueChanged += new System.EventHandler(this.txtTotal_EditValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(567, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(673, 132);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
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
            // lkUnit
            // 
            this.lkUnit.Location = new System.Drawing.Point(439, 13);
            this.lkUnit.Name = "lkUnit";
            this.lkUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUnit.Properties.DataSource = this.unitBindingSource;
            this.lkUnit.Properties.DisplayMember = "Name";
            this.lkUnit.Properties.ValueMember = "ID";
            this.lkUnit.Size = new System.Drawing.Size(119, 20);
            this.lkUnit.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(728, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "VND";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(728, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "VND";
            // 
            // frmInsertR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 196);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lkUnit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbToTal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mudCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lkProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lkProductID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsertR";
            this.Text = "frmInsertR";
            this.Load += new System.EventHandler(this.frmInsertR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUnit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lkProductID;
        private DevExpress.XtraEditors.LookUpEdit lkProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown mudCount;
        private System.Windows.Forms.Label lbToTal;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private QLBH_v1DataSet9 qLBH_v1DataSet9;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private QLBH_v1DataSet9TableAdapters.ProductsTableAdapter productsTableAdapter;
        private QLBH_v1DataSet7 qLBH_v1DataSet7;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private QLBH_v1DataSet7TableAdapters.UnitTableAdapter unitTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lkUnit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}