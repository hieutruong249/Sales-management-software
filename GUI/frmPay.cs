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

namespace GUI
{
    public partial class frmPay : DevExpress.XtraEditors.XtraForm
    {
        public frmPay()
        {
            InitializeComponent();
        }

        private void frmPay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet9.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.qLBH_v1DataSet9.Products);

        }
    }
}