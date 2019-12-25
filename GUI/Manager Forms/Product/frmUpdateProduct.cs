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

namespace GUI
{
    public partial class frmUpdateProduct : DevExpress.XtraEditors.XtraForm
    {
        public static Products product = new Products();
        public static string path = null;
        public void ReceiveData(Products p)
        {
            product = p;
        }
        public frmUpdateProduct()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
            if (string.IsNullOrEmpty(product.Image))
            {
                product.Image = "null";

            }
            else
            {
                product.Image = path;
            }

            try
            {
                ProductBUS bus = new ProductBUS();
                if (bus.UpdateProduct(product) > 0)
                {
                    MessageBox.Show("Update successfully!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Fail!!!");

            }
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet8.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.qLBH_v1DataSet8.Suppliers);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet7.Unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.qLBH_v1DataSet7.Unit);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet6.Catergories' table. You can move, or remove it, as needed.
            this.catergoriesTableAdapter.Fill(this.qLBH_v1DataSet6.Catergories);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet5.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.qLBH_v1DataSet5.Warehouse);

            try
            {
                txtPdID.Text = product.ProductID;
                txtPdName.Text = product.ProductName;
                lkCatergory.EditValue = product.CatergoryID;
                lkWarehouse.EditValue = product.WarehouseID;
                lkUnit.EditValue = product.UnitID;
                speMin_Inventory.EditValue = product.MinInventory;
                speCurr_Inventory.EditValue = product.CurrInventory;
                txtOrigin.Text = product.Origin;
                lkSupplier.EditValue = product.Supplier;
                spePurchase.EditValue = product.Purchase;
                speRetail.EditValue = product.Retail;
                speWholesale.EditValue = product.Wholesale;
                if (!string.Equals(product.Image, "null"))
                {
                    pictureEdit1.Image = Image.FromFile(path);

                }
            }
            catch (Exception ex)
            {

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
    }
}