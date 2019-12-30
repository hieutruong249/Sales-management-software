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

namespace GUI.Business.BuyProduct
{
    public partial class frmInsertR : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendData(string pdID, string pdname, string unit, int count, double price, double total);
        public static DataTable dtbl = new DataTable();
        public static ProductBUS bus = new ProductBUS();
        public static int minInventory = 0;
          
        public frmInsertR()
        {
            InitializeComponent();
        }

        private void frmInsertR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet7.Unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.qLBH_v1DataSet7.Unit);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet9.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.qLBH_v1DataSet9.Products);

            lkProductID.EditValue = this.qLBH_v1DataSet9.Products.Rows[0][lkProductID.Properties.ValueMember];
            lkProductName.EditValue = this.qLBH_v1DataSet9.Products.Rows[0][lkProductName.Properties.ValueMember];
            lkUnit.EditValue = this.qLBH_v1DataSet7.Unit.Rows[0][lkUnit.Properties.ValueMember];

            LoadData();
            this.CenterToParent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pdID, pdname, unit;
            double price, total;
            int count;

            pdID = lkProductID.Text;
            pdname = lkProductName.Text;
            unit = lkUnit.EditValue.ToString();
            count = int.Parse(mudCount.Value.ToString());
            price = double.Parse(txtPrice.EditValue.ToString());
            total = (count * price);
            

            frmBuyProduct frm = new frmBuyProduct();
            SendData send = new SendData(frm.ReceiveData);
            send(pdID, pdname, unit, count, price, total);

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = CalculateTotal().ToString();
        }

        private void mudCount_ValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = CalculateTotal().ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkProductID_TextChanged(object sender, EventArgs e)
        {
            lkProductName.EditValue = lkProductID.Text;
            LoadData();
        }

        private void lkProductName_TextChanged(object sender, EventArgs e)
        {
            lkProductID.Text = lkProductName.EditValue.ToString();
            LoadData();
        }

        private void txtTotal_EditValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = CalculateTotal().ToString();
        }

        public double CalculateTotal()
        {
            double ttotal = 0;
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                double price = float.Parse(txtPrice.EditValue.ToString());
                int count = int.Parse(mudCount.Value.ToString());
                ttotal = count * price;
            }
            return ttotal;
        }

        public void LoadData()
        {
            dtbl = bus.ShowProducts(lkProductID.EditValue.ToString());
            lkUnit.EditValue = dtbl.Rows[0]["UnitID"];
            txtPrice.EditValue = dtbl.Rows[0]["Purchase"];
            minInventory = int.Parse(dtbl.Rows[0]["MinInventory"].ToString());
            mudCount.Maximum = int.Parse(dtbl.Rows[0]["CurrInventory"].ToString()) - minInventory;
        }
    }
}