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
using GUI.Business.SaleProduct;

namespace GUI.Business.SaleProduct
{
    public partial class ucSellProduct : DevExpress.XtraEditors.XtraUserControl
    {
        public static DataTable dtbl = new DataTable();
        public static int indexCurrentRow = 0;
        public static string pdID, pdname, unit, exrate;
        public static int count, Ccount = 0;
        public static float price, total, discount, TTotal = 0;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmInserCustomer frm = new frmInserCustomer();
            frm.Show();
        }

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
            frmInsertWarehouse frm = new frmInsertWarehouse();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dgvItems.DataSource = dtbl;
        }

        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            dtbl.Rows.RemoveAt(indexCurrentRow);
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

            this.txtCount.Text = Ccount.ToString();
            this.txtTotal.Text = TTotal.ToString();
            //MessageBox.Show(Ccount.ToString() + TTotal.ToString());
        }

        public ucSellProduct()
        {
            InitializeComponent();
            btnUpdateR.Enabled = false;
            btnDeleteR.Enabled = false;
        }

        private void btnInsertR_Click(object sender, EventArgs e)
        {
            frmInsertR frm = new frmInsertR();
            frm.Show();
        }

        private void ucSellProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet3.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.qLBH_v1DataSet3.Staffs);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet5.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.qLBH_v1DataSet5.Warehouse);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet8.Suppliers' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.qLBH_v1DataSet10.Customer);

            dtbl.Columns.Add("ProductID", typeof(string));
            dtbl.Columns.Add("ProductName", typeof(string));
            dtbl.Columns.Add("Unit", typeof(string));
            dtbl.Columns.Add("ExRate", typeof(string));
            dtbl.Columns.Add("Count", typeof(int));
            dtbl.Columns.Add("Price", typeof(float));
            dtbl.Columns.Add("Total", typeof(float));
            dtbl.Columns.Add("Discount", typeof(float));

            dgvItems.DataSource = dtbl;
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateR.Enabled = true;
            btnDeleteR.Enabled = true;

            indexCurrentRow = e.RowIndex;
            if (indexCurrentRow >= 0)
            {
                pdID = dgvItems.CurrentRow.Cells["Column1"].Value.ToString();
                pdname = dgvItems.CurrentRow.Cells["Column2"].Value.ToString();
                unit = dgvItems.CurrentRow.Cells["Column3"].Value.ToString();
                exrate = dgvItems.CurrentRow.Cells["Column4"].Value.ToString();
                count = int.Parse(dgvItems.CurrentRow.Cells["Column5"].Value.ToString());
                price = float.Parse(dgvItems.CurrentRow.Cells["Column6"].Value.ToString());
                discount = float.Parse(dgvItems.CurrentRow.Cells["Column8"].Value.ToString());
                total = count * price * discount;
            }
        }
    }
}
