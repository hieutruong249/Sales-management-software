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
            customer.AccountBank = txtAccBank.Text;
            customer.Phone = txtPhone.Text;
            customer.Bank = txtBank.Text;
            customer.Area = lkArea.EditValue.ToString();
            customer.Discount = float.Parse(txtDiscount.EditValue.ToString());
            try
            {
                CustomerBUS customerBUS = new CustomerBUS();
                if (customerBUS.UpdateCustomer(customer) > 0)
                {
                    MessageBox.Show("Insert susscessfully!!");
                }

            }
            catch (Exception ex)
            {
                throw ex;
                MessageBox.Show("Insert Fail!!");

            }
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
            // TODO: This line of code loads data into the 'qLBH_v1DataSet1.Areas' table. You can move, or remove it, as needed.
            this.areasTableAdapter.Fill(this.qLBH_v1DataSet1.Areas);

            txtID.Text = customer.CustomerID;
            txtName.Text = customer.CustomerName;
            txtAddress.Text = customer.Address;
            txtEmail.Text = customer.Email;
            txtBank.Text = customer.Bank;
            txtPhone.Text = customer.Phone;
            txtAccBank.Text = customer.AccountBank;
            lkArea.EditValue = customer.Area;
            txtDiscount.EditValue = customer.Discount.ToString();
        }
    }
}