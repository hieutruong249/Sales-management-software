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
    public partial class frmSellProduct : DevExpress.XtraEditors.XtraForm
    {
        public static DataTable dtbl = new DataTable();
        public static int indexCurrentRow = 0;
        public static string pdID, pdname, unit, exrate;
        public static int count, Ccount = 0;
        public static float price, total, discount, TTotal = 0;
        public static int rowHandle = 0;

        private void navBarProduct_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmInsertProduct frm = new frmInsertProduct();
            frm.Show();
        }

        private void navBarCustomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmInserCustomer frm = new frmInserCustomer();
            frm.Show();
        }

        private void navBarWarehouse_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmInserCustomer frm = new frmInserCustomer();
            frm.Show();
        }

        private void gcItems_Click(object sender, EventArgs e)
        {
            btnUpdateR.Enabled = true;
            btnDeleteR.Enabled = true;

            rowHandle = gridView1.FocusedRowHandle;
            try
            {
                if (indexCurrentRow >= 0)
                {
                    pdID = gridView1.GetRowCellValue(rowHandle, "gridColumn1").ToString();
                    pdname = gridView1.GetRowCellValue(rowHandle, "gridColumn2").ToString();
                    unit = gridView1.GetRowCellValue(rowHandle, "gridColumn3").ToString();
                    exrate = gridView1.GetRowCellValue(rowHandle, "gridColumn4").ToString();
                    count = int.Parse(gridView1.GetRowCellValue(rowHandle, "gridColumn5").ToString());
                    price = float.Parse(gridView1.GetRowCellValue(rowHandle, "gridColumn6").ToString());
                    discount = float.Parse(gridView1.GetRowCellValue(rowHandle, "gridColumn8").ToString());
                    total = count * price * discount;
                }
            }
            catch (Exception ex)
            {

            }
           
        }

        public frmSellProduct()
        {
            InitializeComponent();
        }

        public void ReceiveData(string ID, string name, string uni, int cou, float pprice, float ttotal, string exra, float ddiscount)
        {
            pdID = ID;
            pdname = name;
            unit = uni;
            count = cou;
            price = pprice;
            total = ttotal;
            exrate = exra;
            discount = ddiscount;

            var row = dtbl.NewRow();

            row["ProductID"] = pdID;
            row["ProductName"] = pdname;
            row["Unit"] = unit;
            row["ExRate"] = exrate;
            row["Count"] = count;
            row["Price"] = price;
            row["Total"] = total;
            row["Discount"] = discount;

            dtbl.Rows.Add(row);

            Ccount += count;
            TTotal += total;

            //this.txtCount.Text = Ccount.ToString();
            //this.txtTotal.Text = TTotal.ToString();
            //MessageBox.Show(Ccount.ToString() + TTotal.ToString());
        }

        private void frmSellProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet3.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.qLBH_v1DataSet3.Staffs);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet5.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.qLBH_v1DataSet5.Warehouse);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet10.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.qLBH_v1DataSet10.Customer);

            if (!dtbl.Columns.Contains("ProductID"))
            {
                dtbl.Columns.Add("ProductID", typeof(string));
                dtbl.Columns.Add("ProductName", typeof(string));
                dtbl.Columns.Add("Unit", typeof(string));
                dtbl.Columns.Add("ExRate", typeof(string));
                dtbl.Columns.Add("Count", typeof(int));
                dtbl.Columns.Add("Price", typeof(float));
                dtbl.Columns.Add("Total", typeof(float));
                dtbl.Columns.Add("Discount", typeof(float));
            }
            gcItems.DataSource = dtbl;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertR_Click(object sender, EventArgs e)
        {
            frmInsertR frm = new frmInsertR();
            frm.Show();
        }

        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            dtbl.Rows.RemoveAt(indexCurrentRow);
        }
    }
}