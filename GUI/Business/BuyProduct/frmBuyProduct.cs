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
using BUS;

namespace GUI.Business.BuyProduct
{
    public partial class frmBuyProduct : DevExpress.XtraEditors.XtraForm
    {
        public static DataTable dtbl = new DataTable();
        public static string pdID, pdname, unit;
        public static int count, Ccount = 0;
        public static float price, total, TTotal = 0;
        public static int rowHandle = 0;
        public static BuyProducts bp = new BuyProducts();
        public static BuyProductDetail bpDetail = new BuyProductDetail();
        public static BuyProductBUS bus = new BuyProductBUS();

        public frmBuyProduct()
        {
            InitializeComponent();
            DataTable data = new DataTable();
            data = bus.ShowBill();
            txtBill.Text = FindNextID(data);
           
        }

        private void frmBuyProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet3.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.qLBH_v1DataSet3.Staffs);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet5.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.qLBH_v1DataSet5.Warehouse);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet8.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.qLBH_v1DataSet8.Suppliers);

            lkSupplierName.EditValue = this.qLBH_v1DataSet8.Suppliers.Rows[0][lkSupplierName.Properties.ValueMember];
            lkWarehouse.EditValue = this.qLBH_v1DataSet5.Warehouse.Rows[0][lkWarehouse.Properties.ValueMember];
            lkStaffID.EditValue = this.qLBH_v1DataSet3.Staffs.Rows[0][lkStaffID.Properties.ValueMember];

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

        public string FindNextID(DataTable dtbl)
        {

            string txtID = null;
            if (dtbl.Rows.Count > 0)
            {
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["BillID"].ToString();
                int lastIndex = int.Parse(ma.Substring(3)) + 1;
                txtID = "BLL" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "BLL00001";
            }
            return txtID;
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
            RemoveDuplicates(dtbl);
            gcItems.DataSource = dtbl;
           
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
            frmInsertR frm = new frmInsertR();
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lkSupplierName.EditValue.ToString());
        }

        private void lookUpEdit1_TextChanged(object sender, EventArgs e)
        {
            lkSupplierName.Text = lkSupplierID.EditValue.ToString();
        }

        private void lkSupplierName_TextChanged(object sender, EventArgs e)
        {
            lkSupplierID.Text = lkSupplierName.EditValue.ToString();

        }

        public void InsertBill()
        {
            bp.BillID = txtBill.Text;
            bp.SupplierID = lkSupplierID.Text;
            bp.WarehouseID = lkWarehouse.EditValue.ToString();
            bp.StaffID = lkStaffID.Text;
            bp.Phone = txtPhone.Text;
            bp.Date = txtDate.Text;
            bp.ExperiDate = txtExdate.Text;
            bp.Note = txtNote.Text;
            bp.Address = txtAddress.Text;
            bp.NumVAT = txtNumVat.Text;
            bp.Total = 0;
            foreach (DataRow row in dtbl.Rows)
            {
                bp.Total += int.Parse(row["Total"].ToString());

            }
            try
            {
                if (bus.InsertBillBuyProduct(bp) > 0)
                {
                    int err = InsertBillDetail();
                    if (err == 0)
                    {
                        MessageBox.Show("Sussecc");
                        DataTable data = new DataTable();
                        data = bus.ShowBill();
                        txtBill.Text = FindNextID(data);

                    }
                    else
                    {
                        MessageBox.Show("There are " + err.ToString() + " rows failed while inserting!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail!!");
            }
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
                            dt.Rows[j]["Total"] = (float.Parse(dt.Rows[i]["Total"].ToString()) + float.Parse(dt.Rows[j]["Total"].ToString())).ToString();
                            dt.Rows[i].Delete();
                            break;
                        }
                    }


                }
                dt.AcceptChanges();
            }
        }

        public int InsertBillDetail()
        {
            int countERR = 0;
            bpDetail.BillID = txtBill.Text;
            try
            {
                foreach (DataRow row in dtbl.Rows)
                {
                    bpDetail.ProductID = row["ProductID"].ToString();
                    bpDetail.ProductName = row["ProductName"].ToString();
                    bpDetail.UnitID = row["Unit"].ToString();
                    bpDetail.Price = double.Parse(row["Price"].ToString());
                    bpDetail.Amount = int.Parse(row["Count"].ToString());
                    bpDetail.Total = double.Parse(row["Total"].ToString());

                    if (bus.InsertBillBuyProductDetail(bpDetail) == 0)
                    {
                        countERR++;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ProductID" + bpDetail.ProductID);
            }


            return countERR;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertBill();
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