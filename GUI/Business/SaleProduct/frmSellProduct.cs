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
using DTO;

namespace GUI.Business.SaleProduct
{
    public partial class frmSellProduct : DevExpress.XtraEditors.XtraForm
    {
        public static DataTable dtbl = new DataTable();
        public static BuyProducts bp = new BuyProducts();
        public static int indexCurrentRow = 0;
        public static string pdID, pdname, unit, exrate;
        public static int count, Ccount = 0;
        public static float price, discount, TTotal = 0;
        public static double total;
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

        private void lkCustomerName_TextChanged(object sender, EventArgs e)
        {
            lkCustomerID.Text = lkCustomerName.EditValue.ToString();
        }

        private void lkCustomerID_TextChanged(object sender, EventArgs e)
        {
            lkCustomerName.EditValue = lkCustomerID.Text;
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
        private void RemoveDuplicates(DataTable dt)
        {
            bp.Total = 0;
            if (dt.Rows.Count > 0)
            {
                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        break;
                    }
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (dt.Rows[i]["ProductID"] == dt.Rows[j]["ProductID"])
                        {

                            dt.Rows[j]["Count"] = (int.Parse(dt.Rows[i]["Count"].ToString()) + int.Parse(dt.Rows[j]["Count"].ToString())).ToString();
                            dt.Rows[j]["Total"] = (int.Parse(dt.Rows[i]["Total"].ToString()) + int.Parse(dt.Rows[j]["Total"].ToString())).ToString();
                            dt.Rows[i].Delete();
                            break;
                        }
                    }
                }
                dt.AcceptChanges();
            }
        }
        public string FindNextID(DataTable dtbl)
        {

            string txtID = null;
            if (dtbl.Rows.Count > 0)
            {
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["BillID"].ToString();
                int lastIndex = int.Parse(ma.Substring(3)) + 1;
                txtID = "BLS" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "BLS00001";
            }
            return txtID;
        }
        public void ReceiveData(string ID, string name, string uni, int cou, float pprice, double ttotal, string exra, float ddiscount)
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
            RemoveDuplicates(dtbl);
            gcItems.DataSource = dtbl;
        }

        private void frmSellProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet3.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.qLBH_v1DataSet3.Staffs);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet5.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.qLBH_v1DataSet5.Warehouse);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet10.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.qLBH_v1DataSet10.Customer);

            lkCustomerName.EditValue = this.qLBH_v1DataSet10.Customer.Rows[0][lkCustomerName.Properties.ValueMember];
            lkWarehouse.EditValue = this.qLBH_v1DataSet5.Warehouse.Rows[0][lkWarehouse.Properties.ValueMember];
            lkStaffID.EditValue = this.qLBH_v1DataSet3.Staffs.Rows[0][lkStaffID.Properties.ValueMember];


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