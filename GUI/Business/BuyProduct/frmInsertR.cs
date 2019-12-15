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

namespace GUI.Business.BuyProduct
{
    public partial class frmInsertR : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendData(string pdID, string pdname, string unit, int count, float price, float total);
          
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
            txtTotal.Text = txtPrice.Text = "0";
            this.CenterToParent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pdID, pdname, unit;
            float price, total;
            int count;

            pdID = lkProductID.Text;
            pdname = lkProductName.Text;
            unit = lkUnit.Text;
            count = int.Parse(mudCount.Value.ToString());
            price = float.Parse(txtPrice.Text);
            total = (count * price);
            

            frmBuyProduct frm = new frmBuyProduct();
            SendData send = new SendData(frm.ReceiveData);
            send(pdID, pdname, unit, count, price, total);

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void mudCount_ValueChanged(object sender, EventArgs e)
        {
            float price = float.Parse(txtPrice.Text);
            int count = int.Parse(mudCount.Value.ToString());
            txtTotal.Text = (count * price).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkProductID_TextChanged(object sender, EventArgs e)
        {
            lkProductName.EditValue = lkProductID.Text;
        }

        private void lkProductName_TextChanged(object sender, EventArgs e)
        {
            lkProductID.Text = lkProductName.EditValue.ToString();
        }
    }
}