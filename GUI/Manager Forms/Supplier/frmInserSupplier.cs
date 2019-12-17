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
    public partial class frmInserSupplier : DevExpress.XtraEditors.XtraForm
    {
        public static string str;
        public void ReceiveTxtID(string textID)
        {
            str = textID;
        }
        public frmInserSupplier()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnInserArea_Click(object sender, EventArgs e)
        {
            frmInsertArea frm = new frmInsertArea();
            frm.Show();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInserSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet4.Areas' table. You can move, or remove it, as needed.
            this.areasTableAdapter.Fill(this.qLBH_v1DataSet4.Areas);
            lkArea.EditValue = this.qLBH_v1DataSet4.Areas.Rows[0][lkArea.Properties.ValueMember];


            txtID.Text = str;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.SupplierID = txtID.Text;
            suppliers.SupplierName = txtName.Text;
            suppliers.Address = txtAddress.Text;
            suppliers.Phone = txtPhone.Text;
            suppliers.Email = txtEmail.Text;
            suppliers.Bank = txtBank.Text;
            suppliers.Area = lkArea.EditValue.ToString();
            suppliers.Discount = float.Parse(speDiscount.Value.ToString());
            try
            {
                SupplierBUS supplierBUS = new SupplierBUS();
                if(supplierBUS.InsertSupplier(suppliers) > 0)
                {
                    MessageBox.Show("Insert susscessfully!!!");

                    DataTable data = new DataTable();
                    data = supplierBUS.ShowSupplier();
                    txtID.Text = FindNextID(data);
                }

            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("Insert fail!!!");

            }
        }
        public string FindNextID(DataTable dtbl)
        {
            string txtID = null;
            if (dtbl.Rows.Count > 0)
            {
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["SupplierID"].ToString();
                int lastIndex = int.Parse(ma.Substring(3)) + 1;
                txtID = "NCC" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "NCC00001";
            }
            return txtID;
        }
    }
}