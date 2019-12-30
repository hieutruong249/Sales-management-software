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

            lkArea.EditValue = this.qLBH_v1DataSet1.Areas.Rows[0][lkArea.Properties.ValueMember];
            txtID.Text = str;
            txtDiscount.EditValue = "0";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                Customers customers = new Customers();
                customers.CustomerID = txtID.Text;
                customers.Phone = txtPhone.Text;
                customers.CustomerName = txtName.Text;
                customers.Address = txtAddress.Text;
                customers.Email = txtEmail.Text;
                customers.Bank = txtBank.Text;
                customers.Area = lkArea.EditValue.ToString();
                customers.AccountBank = txtAccBank.Text;
                customers.Discount = float.Parse(txtDiscount.EditValue.ToString());

                try
                {
                    CustomerBUS customerBUS = new CustomerBUS();
                    if (customerBUS.InsertCustomer(customers) > 0)
                    {
                        MessageBox.Show("Insert Successfull!!");

                        DataTable data = new DataTable();
                        data = customerBUS.ShowCustomer();
                        txtID.Text = FindNextID(data);
                    }
                }
                catch (Exception ex)
                {
                    //throw ex;
                    MessageBox.Show("Insert fail!!");
                }
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool checkFields()
        {
            var name = new RequiredFieldValidator();
            name.ControlToValidate = txtName;

            if (!name.Validate())
            {
                txtName.Focus();
                return false;
            }
            //else if (!Password.Validate())
            //{
            //    txtPassword.Focus();
            //    return false;
            //}

            return true;
        }

        public string FindNextID(DataTable dtbl)
        {
            string txtID = null;
            try
            {
                if (dtbl.Rows.Count > 0)
                {
                    string ma = dtbl.Rows[dtbl.Rows.Count - 1]["CustomerID"].ToString();
                    int lastIndex = int.Parse(ma.Substring(2)) + 1;
                    txtID = "KH" + lastIndex.ToString("00000");
                }
                else
                {
                    txtID = "KH00001";
                }
            }
            catch (Exception ex)
            {

            }
            return txtID;
        }

        public void ReceiveTxtID(string textID)
        {
            str = textID;
        }

    }
}