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
    public partial class frmBuyProduct : DevExpress.XtraEditors.XtraForm
    {
        public static DataTable dtbl = new DataTable();
        public static string pdID, pdname, unit;
        public static int count, Ccount = 0;
        public static float price, total, TTotal = 0;
        public static int rowHandle = 0;

        public frmBuyProduct()
        {
            InitializeComponent();
        }
        public void ReceiveData(string ID, string name, string uni, int cou, float pprice, float ttotal)
        {
            pdID = ID;
            pdname = name;
            unit = uni;
            count = cou;
            price = pprice;
            total = ttotal;

            var row = dtbl.NewRow();

            row["ProductID"] = pdID;
            row["ProductName"] = pdname;
            row["Unit"] = unit;
            row["Count"] = count;
            row["Price"] = price;
            row["Total"] = total;

            dtbl.Rows.Add(row);

            Ccount += count;
            TTotal += total;

            //this.lbTotal.Text = Ccount.ToString();
            //this.txtTotal.Text = TTotal.ToString();
            MessageBox.Show(Ccount.ToString() + TTotal.ToString());
        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void gcItems_Click(object sender, EventArgs e)
        {
            btnUpdateR.Enabled = true;
            btnDeleteR.Enabled = true;

            rowHandle = gridView1.FocusedRowHandle;
            try
            {
                if (rowHandle >= 0)
                {
                    pdID = gridView1.GetRowCellValue(rowHandle, "gridColumn1").ToString();
                    pdname = gridView1.GetRowCellValue(rowHandle, "gridColumn2").ToString();
                    unit = gridView1.GetRowCellValue(rowHandle, "gridColumn3").ToString();
                    count = int.Parse(gridView1.GetRowCellValue(rowHandle, "gridColumn4").ToString());
                    price = float.Parse(gridView1.GetRowCellValue(rowHandle, "gridColumn5").ToString()); ;
                    total = count * price;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnUpdateR_Click(object sender, EventArgs e)
        {
            //frmUpdateR frm = new frmUpdateR();
            //frm.Show();
        }

        private void btnInsertR_Click(object sender, EventArgs e)
        {
            frmUpdateR frm = new frmUpdateR();
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmInserSupplier frm = new frmInserSupplier();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            dtbl.Rows.RemoveAt(rowHandle);
        }

        private void frmBuyProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet3.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.qLBH_v1DataSet3.Staffs);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet5.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.qLBH_v1DataSet5.Warehouse);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet8.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.qLBH_v1DataSet8.Suppliers);

            if (!dtbl.Columns.Contains("ProductID"))
            {
                dtbl.Columns.Add("ProductID", typeof(string));
                dtbl.Columns.Add("ProductName", typeof(string));
                dtbl.Columns.Add("Unit", typeof(string));
                dtbl.Columns.Add("Count", typeof(int));
                dtbl.Columns.Add("Price", typeof(float));
                dtbl.Columns.Add("Total", typeof(float));
            }
            gcItems.DataSource = dtbl;

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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
            frmInsertWarehouse frm = new frmInsertWarehouse();
            frm.Show();
        }
    }
}