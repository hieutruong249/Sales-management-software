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
    public partial class frmInsertExRate : DevExpress.XtraEditors.XtraForm
    {
        public static string str;
        public frmInsertExRate()
        {
            InitializeComponent();
        }
        public void ReceiveTxtID(string textID)
        {
            str = textID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ExRates exRate = new ExRates();
            //exRate.ID = int.Parse(txtID.Text);
            exRate.Name = txtName.Text;
            exRate.Rate = float.Parse(speRate.Text);

            ExRateBUS exRateBUS = new ExRateBUS();
            exRateBUS.InserCategory(exRate);
        }

        private void frmInsertExRate_Load(object sender, EventArgs e)
        {
            txtID.Text = str;
        }
    }
}