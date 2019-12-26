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
            this.CenterToParent();
        }       

        private void frmInsertWarehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet3.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.qLBH_v1DataSet3.Staffs);

            lkManager.EditValue = this.qLBH_v1DataSet3.Staffs.Rows[0][lkManager.Properties.ValueMember];
            txtID.Text = str;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                Warehouses warehouses = new Warehouses();
                warehouses.ID = txtID.Text;
                warehouses.Name = txtName.Text;
                warehouses.Manager = lkManager.EditValue.ToString();
                warehouses.Contact = txtContact.Text;
                warehouses.Address = txtAddress.Text;
                warehouses.Phone = txtPhone.Text;
                warehouses.Email = txtEmail.Text;
                warehouses.Decription = txtDescription.Text;
                try
                {
                    WarehouseBUS warehouseBUS = new WarehouseBUS();
                    if (warehouseBUS.InsertWarehouse(warehouses) > 0)
                    {
                        MessageBox.Show("Insert successfully!!!");

                        DataTable data = new DataTable();
                        data = warehouseBUS.ShowWarehouses();
                        txtID.Text = FindNextID(data);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Fail!!!");
                    throw ex;
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        public string FindNextID(DataTable dtbl)
        {
            string txtID = null;
            if (dtbl.Rows.Count > 0)
            {
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["ID"].ToString();
                int lastIndex = int.Parse(ma.Substring(2)) + 1;
                txtID = "K" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "K00001";
            }
            return txtID;
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

            return true;
        }
    }
}