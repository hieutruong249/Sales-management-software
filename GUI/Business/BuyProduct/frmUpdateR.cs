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
    public partial class frmUpdateR : DevExpress.XtraEditors.XtraForm
    {
        

        public delegate void SendData(string pdID, string pdname, string unit, int count, float price, float total);

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pdID, pdname, unit;
            int count, Ccount = 0;
            float price, total, TTotal = 0;

            pdID = lkProductID.Text;
            pdname = lkProductName.Text;
            unit = lkUnit.Text;
            count = int.Parse(mudCount.Value.ToString());
            price = float.Parse(txtPrice.Text);
            total = (count * price);

            frmBuyProduct uc = new frmBuyProduct();
            SendData send = new SendData(uc.ReceiveData);
            send(pdID, pdname, unit, count, price, total);
        }

        

        public void ReceiveData(string ID, string name, string uni, int cou, float pprice, float ttotal)
        {
            lkProductID.Text = ID;
            lkProductName.Text = name;
            lkUnit.Text = uni;
            mudCount.Value = cou;
           
            txtPrice.Text = pprice.ToString();
            txtTotal.Text = ttotal.ToString();
        }

        public frmUpdateR()
        {
            InitializeComponent();
        }

        private void frmUpdateR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet7.Unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.qLBH_v1DataSet7.Unit);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet9.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.qLBH_v1DataSet9.Products);
            this.CenterToParent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}