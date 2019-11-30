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
using BUS;
using DTO;

namespace GUI
{
    public partial class frmInsertWarehouse : DevExpress.XtraEditors.XtraForm
    {
        public static string str;
        public void ReceiveTxtID(string textID)
        {
            str = textID;
        }
        public frmInsertWarehouse()
        {
            InitializeComponent();
        }       

        private void frmInsertWarehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet3.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.qLBH_v1DataSet3.Staffs);
            txtID.Text = str;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Warehouses warehouses = new Warehouses();
            warehouses.ID = txtID.Text;
            warehouses.Name = txtName.Text;
            warehouses.Manager = lkManager.Text;
            warehouses.Contact = txtContact.Text;
            warehouses.Address = txtAddress.Text;
            warehouses.Phone = txtPhone.Text;
            warehouses.Email = txtEmail.Text;
            warehouses.Decription = txtDescription.Text;

            WarehouseBUS warehouseBUS = new WarehouseBUS();
            warehouseBUS.InsertWarehouse(warehouses);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }
    }
}