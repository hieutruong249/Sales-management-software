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

namespace GUI.Manager_Forms.Warehouse
{
    public partial class frmUpdateWarehouse : DevExpress.XtraEditors.XtraForm
    {
        public static Warehouses warehouse = new Warehouses();
        public void ReceiveData(Warehouses u)
        {
            warehouse = u;
        }
        public frmUpdateWarehouse()
        {
            InitializeComponent();
        }

        private void frmUpdateWarehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet3.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.qLBH_v1DataSet3.Staffs);

            txtID.Text = warehouse.ID;
            txtName.Text = warehouse.Name;
            lkManager.Text = warehouse.Manager;
            txtContact.Text = warehouse.Contact;
            txtAddress.Text = warehouse.Address;
            txtPhone.Text = warehouse.Phone;
            txtEmail.Text = warehouse.Email;
            txtDescription.Text = warehouse.Decription;

            WarehouseBUS warehouseBUS = new WarehouseBUS();
            warehouseBUS.UpdateWarehouse(warehouse);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            warehouse.ID = txtID.Text;
            warehouse.Name = txtName.Text;
            warehouse.Manager = lkManager.Text;
            warehouse.Contact = txtContact.Text;
            warehouse.Address = txtAddress.Text;
            warehouse.Phone = txtPhone.Text;
            warehouse.Email = txtEmail.Text;
            warehouse.Decription = txtDescription.Text;

            WarehouseBUS warehouseBUS = new WarehouseBUS();
            warehouseBUS.UpdateWarehouse(warehouse);
        }
    }
}