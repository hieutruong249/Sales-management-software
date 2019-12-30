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

namespace GUI.Business.SaleProduct
{
    public partial class frmInsertR : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendData(string pdID, string pdname, string unit, int count, float price, double total, string extra, float discount);
        public static SellProductBUS bus = new SellProductBUS();
        public static DataTable dtbl = new DataTable();
        public static ProductBUS productBUS = new ProductBUS();
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
            // TODO: This line of code loads data into the 'qLBH_v1DataSet11.ExRate' table. You can move, or remove it, as needed.
            this.exRateTableAdapter.Fill(this.qLBH_v1DataSet11.ExRate);

            lkProductID.EditValue = this.qLBH_v1DataSet9.Products.Rows[0][lkProductID.Properties.ValueMember];
            lkProductName.EditValue = this.qLBH_v1DataSet9.Products.Rows[0][lkProductName.Properties.ValueMember];
            lkUnit.EditValue = this.qLBH_v1DataSet7.Unit.Rows[0][lkUnit.Properties.ValueMember];
            lkExRate.EditValue = this.qLBH_v1DataSet11.ExRate.Rows[0][lkExRate.Properties.ValueMember];

           // txtTotal.Text = txtPrice.Text = "0";
            txtDiscount.Text = "0";
            this.CenterToParent();
            LoadData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pdID, pdname, unit, exrate;
            float price, discount;
            int count;
            double total;

            pdID = lkProductID.Text;
            pdname = lkProductName.Text;
            unit = lkUnit.EditValue.ToString();
            exrate = lkExRate.EditValue.ToString();
            discount = float.Parse(txtDiscount.Text);
            count = int.Parse(mudCount.Value.ToString());
            price = float.Parse(txtPrice.Text);


            total = CalculateTotal();

            frmSellProduct uc = new frmSellProduct();
            SendData send = new SendData(uc.ReceiveData);
            send(pdID, pdname, unit, count, price, total, exrate, discount);

        }

        private void mudCount_ValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = CalculateTotal().ToString();
        }

        public float TakeCurrency(int  indexCurrency)
        {
            float currency = 0;
            DataTable data = new DataTable();
            data = bus.ShowCurrency(indexCurrency);
            currency = float.Parse(data.Rows[0][0].ToString());
            return currency;
        }

        public double CalculateTotal()
        {
            double ttotal = 0;
            
            if (!string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtDiscount.Text))
            {
                float price = float.Parse(txtPrice.Text);
                int count = int.Parse(mudCount.Value.ToString());
                float discount = float.Parse(txtDiscount.EditValue.ToString());
                if (discount > 1)
                {
                    discount = 1;
                }
                float currency = TakeCurrency(int.Parse(lkExRate.EditValue.ToString()));
                ttotal = price*currency*count*(1 - discount);
            }
            return ttotal;
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

        private void txtPrice_EditValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = CalculateTotal().ToString();
        }

        private void txtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = CalculateTotal().ToString();
        }

        private void lkExRate_EditValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = CalculateTotal().ToString();
            lbCurrency.Text = lkExRate.Text;
           
        }

        public void LoadData()
        {
            dtbl = productBUS.ShowProducts(lkProductID.EditValue.ToString());
            lkUnit.EditValue = dtbl.Rows[0]["UnitID"];
            txtPrice.EditValue = dtbl.Rows[0]["Purchase"];
            minInventory = int.Parse(dtbl.Rows[0]["MinInventory"].ToString());
            mudCount.Maximum = int.Parse(dtbl.Rows[0]["CurrInventory"].ToString()) - minInventory;
        }
    }
}