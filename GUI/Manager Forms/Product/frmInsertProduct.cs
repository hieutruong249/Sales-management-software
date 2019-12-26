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
    public partial class frmInsertProduct : DevExpress.XtraEditors.XtraForm
    {
        public static string str;
        public static string path = "null";

        public void ReceiveTxtID(string textID)
        {
            str = textID;
        }
        public frmInsertProduct()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void frmInsertProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet8.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.qLBH_v1DataSet8.Suppliers);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet7.Unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.qLBH_v1DataSet7.Unit);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet6.Catergories' table. You can move, or remove it, as needed.
            this.catergoriesTableAdapter.Fill(this.qLBH_v1DataSet6.Catergories);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet5.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.qLBH_v1DataSet5.Warehouse);

            lkCatergory.EditValue = this.qLBH_v1DataSet6.Catergories.Rows[0][lkCatergory.Properties.ValueMember];
            lkSupplier.EditValue = this.qLBH_v1DataSet8.Suppliers.Rows[0][lkSupplier.Properties.ValueMember];
            lkWarehouse.EditValue = this.qLBH_v1DataSet5.Warehouse.Rows[0][lkWarehouse.Properties.ValueMember];
            lkUnit.EditValue = this.qLBH_v1DataSet7.Unit.Rows[0][lkUnit.Properties.ValueMember];

            txtPdID.Text = str;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                Products product = new Products();
                product.ProductID = txtPdID.Text;
                product.ProductName = txtPdName.Text;
                product.CatergoryID = lkCatergory.EditValue.ToString();
                product.WarehouseID = lkWarehouse.EditValue.ToString();
                product.UnitID = lkUnit.EditValue.ToString();
                product.MinInventory = int.Parse(speMin_Inventory.EditValue.ToString());
                product.CurrInventory = int.Parse(speCurr_Inventory.EditValue.ToString());
                product.Origin = txtOrigin.Text;
                product.Supplier = lkSupplier.EditValue.ToString();
                product.Purchase = double.Parse(spePurchase.EditValue.ToString());
                product.Retail = double.Parse(speRetail.EditValue.ToString());
                product.Wholesale = double.Parse(speWholesale.EditValue.ToString());
                product.Image = path;

                try
                {
                    ProductBUS bus = new ProductBUS();
                    if (bus.InsertProduct(product) > 0)
                    {
                        MessageBox.Show("Insert successfully!!!");

                        DataTable data = new DataTable();
                        data = bus.ShowProducts();
                        txtPdID.Text = FindNextID(data);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                    MessageBox.Show("Insert Fail!!!");

                }
            }

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo fInfo = new System.IO.FileInfo(fDialog.FileName);
                path = fInfo.DirectoryName + "\\" + fInfo.Name;
                pictureEdit1.Image = Image.FromFile(path); 

            }
        }

        public string FindNextID(DataTable dtbl)
        {
            string txtID = null;
            if (dtbl.Rows.Count > 0)
            {
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["ProductID"].ToString();
                int lastIndex = int.Parse(ma.Substring(2)) + 1;
                txtID = "SP" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "SP00001";
            }
            return txtID;
        }

        public bool checkFields()
        {
            var name = new RequiredFieldValidator();
            name.ControlToValidate = txtPdName;

            if (!name.Validate())
            {
                txtPdName.Focus();
                return false;
            }
            return true;
        }
    }
}