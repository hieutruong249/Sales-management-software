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

namespace GUI.Manager_Forms.ExRate
{
    public partial class frmUpdateExRate : DevExpress.XtraEditors.XtraForm
    {
        public static ExRates exRate = new ExRates();

        public frmUpdateExRate()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            exRate.ID = int.Parse(txtID.Text);
            exRate.Name = txtName.Text;
            exRate.Rate = float.Parse(speRate.Text);

            ExRateBUS exRateBUS = new ExRateBUS();
            exRateBUS.UpdateExRate(exRate);
        }

        private void frmUpdateExRate_Load(object sender, EventArgs e)
        {
            txtID.Text = exRate.ID.ToString();
            txtName.Text = exRate.Name;
            speRate.Text = exRate.Rate.ToString();
        }

        public void ReceiveData(ExRates rate)
        {
            exRate = rate;
        }
    }
}