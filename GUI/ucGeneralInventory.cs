using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;

namespace GUI
{
    public partial class ucGeneralInventory : DevExpress.XtraEditors.XtraUserControl
    {
        public static ReportBUS bus = new ReportBUS();
        public static DataTable dtbl = new DataTable();

        public ucGeneralInventory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void ucGeneralInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet5.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.qLBH_v1DataSet5.Warehouse);

            dtbl = bus.ShowReport();
            if (!dtbl.Columns.Contains("Total"))
            {
                dtbl.Columns.Add("Total", typeof(double));
            }
            CalculateTotal(dtbl);
            gcItems.DataSource = dtbl;
        }

        private void lkWarehouses_EditValueChanged(object sender, EventArgs e)
        {
            dtbl = bus.ShowReport(lkWarehouses.EditValue.ToString());
            CalculateTotal(dtbl);
            gcItems.DataSource = dtbl;
        }

        public void CalculateTotal(DataTable dt)
        {

            if (dt.Rows.Count > 0)
            {
                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {
                    dt.Rows[i]["Total"] = (float.Parse(dt.Rows[i]["CurrInventory"].ToString()) * float.Parse(dt.Rows[i]["Purchase"].ToString())).ToString();
                }
                dt.AcceptChanges();
            }
        }
    }
}
