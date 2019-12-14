namespace GUI.Business.BuyProduct
{
    partial class frmUpdateR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateR));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.lbToTal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mudCount = new System.Windows.Forms.NumericUpDown();
            this.lkUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet7 = new GUI.QLBH_v1DataSet7();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lkProductName = new DevExpress.XtraEditors.LookUpEdit();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet9 = new GUI.QLBH_v1DataSet9();
            this.label2 = new System.Windows.Forms.Label();
            this.lkProductID = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.productsTableAdapter = new GUI.QLBH_v1DataSet9TableAdapters.ProductsTableAdapter();
            this.unitTableAdapter = new GUI.QLBH_v1DataSet7TableAdapters.UnitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProductID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(517, 139);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(411, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(408, 84);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(184, 20);
            this.txtTotal.TabIndex = 25;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(470, 23);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(122, 20);
            this.txtPrice.TabIndex = 24;
            // 
            // lbToTal
            // 
            this.lbToTal.AutoSize = true;
            this.lbToTal.Location = new System.Drawing.Point(367, 87);
            this.lbToTal.Name = "lbToTal";
            this.lbToTal.Size = new System.Drawing.Size(35, 13);
            this.lbToTal.TabIndex = 23;
            this.lbToTal.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Price:";
            // 
            // mudCount
            // 
            this.mudCount.Location = new System.Drawing.Point(283, 50);
            this.mudCount.Name = "mudCount";
            this.mudCount.Size = new System.Drawing.Size(120, 21);
            this.mudCount.TabIndex = 21;
            // 
            // lkUnit
            // 
            this.lkUnit.Location = new System.Drawing.Point(283, 22);
            this.lkUnit.Name = "lkUnit";
            this.lkUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUnit.Properties.DataSource = this.unitBindingSource;
            this.lkUnit.Properties.DisplayMember = "Name";
            this.lkUnit.Properties.ValueMember = "ID";
            this.lkUnit.Size = new System.Drawing.Size(120, 20);
            this.lkUnit.TabIndex = 20;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Unit:";
            // 
            // lkProductName
            // 
            this.lkProductName.Location = new System.Drawing.Point(101, 49);
            this.lkProductName.Name = "lkProductName";
            this.lkProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkProductName.Properties.DataSource = this.productsBindingSource;
            this.lkProductName.Properties.DisplayMember = "ProductName";
            this.lkProductName.Properties.ValueMember = "ProductID";
            this.lkProductName.Size = new System.Drawing.Size(100, 20);
            this.lkProductName.TabIndex = 17;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product Name:";
            // 
            // lkProductID
            // 
            this.lkProductID.Location = new System.Drawing.Point(101, 23);
            this.lkProductID.Name = "lkProductID";
            this.lkProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkProductID.Properties.DataSource = this.productsBindingSource;
            this.lkProductID.Properties.DisplayMember = "ProductID";
            this.lkProductID.Properties.ValueMember = "ProductID";
            this.lkProductID.Size = new System.Drawing.Size(100, 20);
            this.lkProductID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Product ID:";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // frmUpdateR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 184);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbToTal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mudCount);
            this.Controls.Add(this.lkUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lkProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lkProductID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateR";
            this.Text = "frmUpdateR";
            this.Load += new System.EventHandler(this.frmUpdateR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProductID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private System.Windows.Forms.Label lbToTal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown mudCount;
        private DevExpress.XtraEditors.LookUpEdit lkUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit lkProductName;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lkProductID;
        private System.Windows.Forms.Label label1;
        private QLBH_v1DataSet9 qLBH_v1DataSet9;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private QLBH_v1DataSet9TableAdapters.ProductsTableAdapter productsTableAdapter;
        private QLBH_v1DataSet7 qLBH_v1DataSet7;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private QLBH_v1DataSet7TableAdapters.UnitTableAdapter unitTableAdapter;
    }
}