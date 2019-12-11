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

namespace GUI.Business.SaleProduct
{
    public partial class frmInsertR : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendData(string pdID, string pdname, string unit, int count, float price, float total, string extra, float discount);

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
            txtTotal.Text = txtPrice.Text = "0";
            txtDiscount.Text = "0";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pdID, pdname, unit, exrate;
            float price, total, discount;
            int count;

            pdID = lkProductID.Text;
            pdname = lkProductName.Text;
            unit = lkUnit.Text;
            exrate = lkExRate.Text;
            discount = float.Parse(txtDiscount.Text);
            count = int.Parse(mudCount.Value.ToString());
            price = float.Parse(txtPrice.Text);

            //lấy giá trị từ exrate tương ứng
            //total = (count * price * exrate);

            total = (count * price);


            ucSellProduct uc = new ucSellProduct();
            SendData send = new SendData(uc.ReceiveData);
            send(pdID, pdname, unit, count, price, total, exrate, discount);

        }
    }
}