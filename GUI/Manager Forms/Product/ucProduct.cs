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
using Syncfusion.XlsIO;

namespace GUI
{
    public partial class ucProduct : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void SendData(Product Product);
        public delegate void SendTxtID(String str);
        public ucProduct()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertProduct frm = new frmInsertProduct();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateProduct frm = new frmUpdateProduct();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }

        public string FindNextID(DataTable dtbl)
        {
            string txtID = null;
            if (dtbl.Rows.Count > 0)
            {
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["ProductID"].ToString();
                int lastIndex = int.Parse(ma.Substring(2)) + 1;
                txtID = "SP" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "SP00001";
            }
            return txtID;
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            //int FormID = int.Parse(this.Tag.ToString());
            //RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
            //btnInsert.Enabled = roleForm.f_Insert;
            //btnUpdate.Enabled = roleForm.f_Insert;
            //btnDelete.Enabled = roleForm.f_Insert;
            //btnExport.Enabled = roleForm.f_Insert;
            //btnImport.Enabled = roleForm.f_Insert;

            ProductBUS productBUS = new ProductBUS();
            DataTable dtbl = new DataTable();
            dtbl = productBUS.ShowProducts();
            gcProducts.DataSource = dtbl;

            //send data to Insert form
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInsertProduct frm = new frmInsertProduct();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);


        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            ProductBUS productBUS = new ProductBUS();
            DataTable dtbl = new DataTable();
            dtbl = productBUS.ShowProducts();
            gcProducts.DataSource = dtbl;

            //send data to Insert form
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInsertProduct frm = new frmInsertProduct();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }
        private void gridView1_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            Product product = new Product();
            var rowHandle = gridView1.FocusedRowHandle;
            product.ProductID = gridView1.GetRowCellValue(rowHandle, "ID").ToString();
            product.ProductName = gridView1.GetRowCellValue(rowHandle, "Name").ToString();
            product.CatergoryID = gridView1.GetRowCellValue(rowHandle, "CatergoryID").ToString();
            product.WarehouseID = gridView1.GetRowCellValue(rowHandle, "WarehouseID").ToString();
            product.UnitID = gridView1.GetRowCellValue(rowHandle, "Origin").ToString();
            product.MinInventory = int.Parse(gridView1.GetRowCellValue(rowHandle, "MinInventory").ToString());
            product.CurrInventory = int.Parse(gridView1.GetRowCellValue(rowHandle, "CurrInventory").ToString());
            product.Supplier = gridView1.GetRowCellValue(rowHandle, "Supplier").ToString();
            product.Purchase = double.Parse(gridView1.GetRowCellValue(rowHandle, "Purchase").ToString());
            product.Retail = double.Parse(gridView1.GetRowCellValue(rowHandle, "Retail").ToString());
            product.Wholesale = double.Parse(gridView1.GetRowCellValue(rowHandle, "Wholesale").ToString());
            product.Image = gridView1.GetRowCellValue(rowHandle, "Image").ToString();

            //send data to update form
            frmUpdateProduct frm = new frmUpdateProduct();
            SendData send = new SendData(frm.ReceiveData);
            send(product);

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Initialize Application
                IApplication application = excelEngine.Excel;

                //Set the default application version as Excel 2016
                application.DefaultVersion = ExcelVersion.Excel2016;

                //Create a new workbook
                IWorkbook workbook = application.Workbooks.Create(1);

                //Access first worksheet from the workbook instance
                IWorksheet worksheet = workbook.Worksheets[0];

                //Exporting DataTable to worksheet
                ProductBUS bus = new ProductBUS();
                DataTable dataTable = new DataTable();
                dataTable = bus.ShowProducts();
                worksheet.ImportDataTable(dataTable, true, 1, 1);
                worksheet.UsedRange.AutofitColumns();

                //Save the workbook to disk in xlsx format
                workbook.SaveAs("Output.xlsx");

                MessageBox.Show("Export successfull!!\n" + @"Path: ..\QuanLyBanHang\GUI\bin\Debug");
            }
        }
    }
}
