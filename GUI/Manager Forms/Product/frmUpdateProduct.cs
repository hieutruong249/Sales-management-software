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
        public static Product product = new Product();
        public void ReceiveData(Product p)
        {
            product = p;
        }
        public frmUpdateProduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
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