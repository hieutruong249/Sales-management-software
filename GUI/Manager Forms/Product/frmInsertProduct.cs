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

namespace GUI
{
    public partial class frmInsertProduct : DevExpress.XtraEditors.XtraForm
    {
        public static string str;
        public void ReceiveTxtID(string textID)
        {
            str = textID;
        }
        public frmInsertProduct()
        {
            InitializeComponent();
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

            txtPdID.Text = str;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductID = txtPdID.Text;
            product.ProductName = txtPdName.Text;
            product.CatergoryID = lkCatergory.Text;
            product.WarehouseID = txtPdID.Text;
            product.UnitID = txtPdID.Text;
            product.MinInventory = int.Parse(speMin_Inventory.Text);
            product.CurrInventory = int.Parse(speCurr_Inventory.Text);
            product.Origin = txtOrigin.Text;
            product.Supplier = lkSupplier.Text;
            product.Purchase = double.Parse(spePurchase.Text);
            product.Retail = double.Parse(speRetail.Text);
            product.Wholesale = double.Parse(speWholesale.Text);
            product.Image = null;
        }
    }
}