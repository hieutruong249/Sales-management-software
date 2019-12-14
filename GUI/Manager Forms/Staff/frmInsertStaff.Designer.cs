namespace GUI.Manager_Forms.Staff
{
    partial class frmInsertStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertStaff));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lkManager = new DevExpress.XtraEditors.LookUpEdit();
            this.staffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet3 = new GUI.QLBH_v1DataSet3();
            this.lkParts = new DevExpress.XtraEditors.LookUpEdit();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_v1DataSet2 = new GUI.QLBH_v1DataSet2();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.partsTableAdapter = new GUI.QLBH_v1DataSet2TableAdapters.PartsTableAdapter();
            this.staffsTableAdapter = new GUI.QLBH_v1DataSet3TableAdapters.StaffsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkManager.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkParts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(366, 100);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Information";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(266, 20);
            this.txtName.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Name:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(86, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(266, 20);
            this.txtID.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ID:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lkManager);
            this.groupControl2.Controls.Add(this.lkParts);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.txtPhone);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.txtEmail);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtAddress);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtPosition);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Location = new System.Drawing.Point(12, 118);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(366, 205);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Manage";
            // 
            // lkManager
            // 
            this.lkManager.Location = new System.Drawing.Point(86, 166);
            this.lkManager.Name = "lkManager";
            this.lkManager.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkManager.Properties.DataSource = this.staffsBindingSource;
            this.lkManager.Properties.DisplayMember = "Name";
            this.lkManager.Properties.ValueMember = "ID";
            this.lkManager.Size = new System.Drawing.Size(266, 20);
            this.lkManager.TabIndex = 15;
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
            // lkParts
            // 
            this.lkParts.Location = new System.Drawing.Point(86, 140);
            this.lkParts.Name = "lkParts";
            this.lkParts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkParts.Properties.DataSource = this.partsBindingSource;
            this.lkParts.Properties.DisplayMember = "Name";
            this.lkParts.Properties.ValueMember = "ID";
            this.lkParts.Size = new System.Drawing.Size(266, 20);
            this.lkParts.TabIndex = 14;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.qLBH_v1DataSet2;
            // 
            // qLBH_v1DataSet2
            // 
            this.qLBH_v1DataSet2.DataSetName = "QLBH_v1DataSet2";
            this.qLBH_v1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(23, 169);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 13);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Manager:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(23, 143);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Parts:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(86, 114);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(266, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(23, 117);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(266, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Email:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(86, 62);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(266, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 65);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Address:";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(86, 36);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(266, 20);
            this.txtPosition.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 39);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Position:";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(171, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(289, 341);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // staffsTableAdapter
            // 
            this.staffsTableAdapter.ClearBeforeFill = true;
            // 
            // frmInsertStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 388);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsertStaff";
            this.Text = "Insert Staff form";
            this.Load += new System.EventHandler(this.frmInsertStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkManager.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkParts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_v1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPosition;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LookUpEdit lkManager;
        private DevExpress.XtraEditors.LookUpEdit lkParts;
        private QLBH_v1DataSet2 qLBH_v1DataSet2;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private QLBH_v1DataSet2TableAdapters.PartsTableAdapter partsTableAdapter;
        private QLBH_v1DataSet3 qLBH_v1DataSet3;
        private System.Windows.Forms.BindingSource staffsBindingSource;
        private QLBH_v1DataSet3TableAdapters.StaffsTableAdapter staffsTableAdapter;
    }
}