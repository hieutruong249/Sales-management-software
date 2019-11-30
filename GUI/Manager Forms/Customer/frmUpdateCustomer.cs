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

namespace GUI.Manager_Forms.Customer
{
    public partial class frmUpdateCustomer : DevExpress.XtraEditors.XtraForm
    {
        public static Customers customer = new Customers();
        public void ReceiveData(Customers u)
        {
            customer = u;
        }
        public frmUpdateCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            customer.CustomerID = txtID.Text;
            customer.CustomerName = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.Email = txtEmail.Text;
            customer.Bank = txtBank.Text;
            customer.Area = lkArea.Text;
            customer.Discount = float.Parse(speDiscount.Text);

            CustomerBUS customerBUS = new CustomerBUS();
            customerBUS.UpdateCustomer(customer);
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

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            txtID.Text = customer.CustomerID;
            txtName.Text = customer.CustomerName;
            txtAddress.Text = customer.Address;
            txtEmail.Text = customer.Email;
            txtBank.Text = customer.Bank;
            lkArea.Text = customer.Area;
            speDiscount.Text = customer.Discount.ToString();
        }
    }
}