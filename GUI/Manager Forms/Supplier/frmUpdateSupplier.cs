using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;

namespace GUI.Manager_Forms.Supplier
{
    public partial class frmUpdateSupplier : DevExpress.XtraEditors.XtraForm
    {
        public static Suppliers supplier = new Suppliers();
        public void ReceiveData(Suppliers u)
        {
            supplier = u;
        }
        public frmUpdateSupplier()
        {
            InitializeComponent();
        }

        private void frmUpdateSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet4.Areas' table. You can move, or remove it, as needed.
            this.areasTableAdapter.Fill(this.qLBH_v1DataSet4.Areas);

            txtID.Text = supplier.SupplierID;
            txtName.Text = supplier.SupplierName;
            txtAddress.Text = supplier.Address;
            txtEmail.Text = supplier.Email;
            txtBank.Text = supplier.Bank;
            lkArea.Text = supplier.Area;
            speDiscount.Text = supplier.Discount.ToString();

        }

        private void btnInserArea_Click(object sender, EventArgs e)
        {
            frmInsertArea frm = new frmInsertArea();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            supplier.SupplierID = txtID.Text;
            supplier.SupplierName = txtName.Text;
            supplier.Address = txtAddress.Text;
            supplier.Phone = txtPhone.Text;
            supplier.Email = txtEmail.Text;
            supplier.Bank = txtBank.Text;
            supplier.Area = lkArea.Text;
            supplier.Discount = float.Parse(speDiscount.Text);

            SupplierBUS supplierBUS = new SupplierBUS();
            supplierBUS.UpdateSupplier(supplier);
        }
    }
}