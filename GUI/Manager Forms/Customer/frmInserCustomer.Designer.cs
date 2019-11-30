namespace GUI
{
    partial class frmInserCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserCustomer));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lkArea = new DevExpress.XtraEditors.LookUpEdit();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet1 = new GUI.QLBH_v1DataSet1();
            this.speDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.btnInserArea = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBank = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.lbAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lbName = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.areasTableAdapter = new GUI.QLBH_v1DataSet1TableAdapters.AreasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lkArea);
            this.groupControl1.Controls.Add(this.speDiscount);
            this.groupControl1.Controls.Add(this.btnInserArea);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtBank);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.textEdit5);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.lbAddress);
            this.groupControl1.Controls.Add(this.txtAddress);
            this.groupControl1.Controls.Add(this.lbName);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Location = new System.Drawing.Point(12, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(644, 238);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Information";
            // 
            // lkArea
            // 
            this.lkArea.Location = new System.Drawing.Point(393, 30);
            this.lkArea.Name = "lkArea";
            this.lkArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkArea.Properties.DataSource = this.areasBindingSource;
            this.lkArea.Properties.DisplayMember = "Name";
            this.lkArea.Properties.NullText = "[Choose a area...]";
            this.lkArea.Properties.ValueMember = "ID";
            this.lkArea.Size = new System.Drawing.Size(157, 20);
            this.lkArea.TabIndex = 21;
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataMember = "Areas";
            this.areasBindingSource.DataSource = this.qLBH_v1DataSet1;
            // 
            // qLBH_v1DataSet1
            // 
            this.qLBH_v1DataSet1.DataSetName = "QLBH_v1DataSet1";
            this.qLBH_v1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // speDiscount
            // 
            this.speDiscount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speDiscount.Location = new System.Drawing.Point(79, 186);
            this.speDiscount.Name = "speDiscount";
            this.speDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speDiscount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.speDiscount.Properties.Mask.EditMask = "p";
            this.speDiscount.Size = new System.Drawing.Size(166, 20);
            this.speDiscount.TabIndex = 20;
            this.speDiscount.EditValueChanged += new System.EventHandler(this.spinEdit1_EditValueChanged);
            // 
            // btnInserArea
            // 
            this.btnInserArea.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInserArea.ImageOptions.Image")));
            this.btnInserArea.Location = new System.Drawing.Point(550, 30);
            this.btnInserArea.Name = "btnInserArea";
            this.btnInserArea.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnInserArea.Size = new System.Drawing.Size(26, 20);
            this.btnInserArea.TabIndex = 19;
            this.btnInserArea.Click += new System.EventHandler(this.btnInserArea_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(334, 163);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Bank:";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(393, 160);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(183, 20);
            this.txtBank.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(333, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Area:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(20, 189);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(45, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Discount:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(20, 163);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Acc Bank:";
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(79, 160);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(166, 20);
            this.textEdit5.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 137);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(79, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Phone:";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(79, 108);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Mask.EditMask = "(999) 000-0000";
            this.textEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.textEdit3.Size = new System.Drawing.Size(166, 20);
            this.textEdit3.TabIndex = 8;
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(20, 85);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(43, 13);
            this.lbAddress.TabIndex = 5;
            this.lbAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(79, 82);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(497, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(20, 59);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(31, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(497, 20);
            this.txtName.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(79, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(166, 20);
            this.txtID.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(513, 258);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(395, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // frmInserCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 293);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmInserCustomer";
            this.Text = "InserCustomer form";
            this.Load += new System.EventHandler(this.frmInserCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnInserArea;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtBank;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl lbAddress;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lbName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.SpinEdit speDiscount;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LookUpEdit lkArea;
        private QLBH_v1DataSet1 qLBH_v1DataSet1;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private QLBH_v1DataSet1TableAdapters.AreasTableAdapter areasTableAdapter;
    }
}