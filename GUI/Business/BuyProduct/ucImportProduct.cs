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
using GUI.Business.BuyProduct;

namespace GUI
{
    public partial class ucImportProduct : DevExpress.XtraEditors.XtraUserControl
    {
        static string pdID, pdname, unit;
        public static int count, Ccount = 0;
        public static float price,  total, TTotal = 0;
        int indexCurrentRow = 0;

        //public delegate void SendData(string pdID, string pdname, string unit, int count, float price, float total);

        public static DataTable dtbl = new DataTable();
        public ucImportProduct()
        {
            InitializeComponent();
            btnUpdateR.Enabled = false;
            btnDeleteR.Enabled = false;
        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmInserSupplier frm = new frmInserSupplier();
            frm.Show();
        }

        private void txtBill_EditValueChanged(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefesh_Click_1(object sender, EventArgs e)
        {
            dgvItems.DataSource = dtbl;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            
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
                count = int.Parse(dgvItems.CurrentRow.Cells["Column4"].Value.ToString());
                price = float.Parse(dgvItems.CurrentRow.Cells["Column5"].Value.ToString());
                total = count * price;
            }
           
            //MessageBox.Show(id + pdID + pdname + unit + count + price + total);
            //frmUpdateR uc = new frmUpdateR();
            //SendData send = new SendData(uc.ReceiveData);
            //send(pdID, pdname, unit, count, price, total);
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

            this.lbTotal.Text = Ccount.ToString();
            this.txtTotal.Text = TTotal.ToString();
            MessageBox.Show(Ccount.ToString() + TTotal.ToString());
        }

        private void ucImportProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet3.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.qLBH_v1DataSet3.Staffs);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet5.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.qLBH_v1DataSet5.Warehouse);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet8.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.qLBH_v1DataSet8.Suppliers);

            dtbl.Columns.Add("ProductID", typeof(string));
            dtbl.Columns.Add("ProductName", typeof(string));
            dtbl.Columns.Add("Unit", typeof(string));
            dtbl.Columns.Add("Count", typeof(int));
            dtbl.Columns.Add("Price", typeof(float));
            dtbl.Columns.Add("Total", typeof(float));

            dgvItems.DataSource = dtbl;
        }

        private void btnUpdateR_Click(object sender, EventArgs e)
        {
            frmUpdateR frm = new frmUpdateR();
            frm.Show();
          
        }
    }
}
