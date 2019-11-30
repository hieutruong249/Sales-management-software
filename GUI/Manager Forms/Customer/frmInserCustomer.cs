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
    public partial class frmInserCustomer : DevExpress.XtraEditors.XtraForm
    {
        public static string str;
        public void ReceiveTxtID(string textID)
        {
            str = textID;
        }

        public frmInserCustomer()
        {
            InitializeComponent();
        }


        private void btnInserArea_Click(object sender, EventArgs e)
        {
            frmInsertArea frm = new frmInsertArea();
            frm.Show();
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmInserCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet1.Areas' table. You can move, or remove it, as needed.
            this.areasTableAdapter.Fill(this.qLBH_v1DataSet1.Areas);
            txtID.Text = str;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.CustomerID = txtID.Text;
            customers.CustomerName = txtName.Text;
            customers.Address = txtAddress.Text;
            customers.Email = txtEmail.Text;
            customers.Bank = txtBank.Text;
            customers.Area = lkArea.Text;
            customers.Discount = float.Parse(speDiscount.Text);

            CustomerBUS customerBUS = new CustomerBUS();
            customerBUS.InsertCustomer(customers);

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}