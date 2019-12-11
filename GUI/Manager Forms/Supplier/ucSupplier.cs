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
using GUI.Manager_Forms.Supplier;
using BUS;
using DTO;
//using Syncfusion.XlsIO;

namespace GUI
{
    public partial class ucSupplier : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void SendData(Suppliers supplier);
        public delegate void SendTxtID(String str);
        public ucSupplier()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateSupplier frm = new frmUpdateSupplier();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }

        //public string FindNextID(DataTable dtbl)
        //{
        //    string txtID = null;
        //    if (dtbl.Rows.Count > 0)
        //    {
        //        string ma = dtbl.Rows[dtbl.Rows.Count - 1]["SupplierID"].ToString();
        //        int lastIndex = int.Parse(ma.Substring(2)) + 1;
        //        txtID = "NCC" + lastIndex.ToString("00000");
        //    }
        //    else
        //    {
        //        txtID = "NCC00001";
        //    }
        //    return txtID;
        //}

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            SupplierBUS supplierBUS = new SupplierBUS();
            DataTable dtbl = new DataTable();
            dtbl = supplierBUS.ShowSupplier();
            gcSuppliers.DataSource = dtbl;


            //send data to insert form
            //string txtID = null;
            //txtID = FindNextID(dtbl);
            //frmInserSupplier frm = new frmInserSupplier();
            //SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            //send(txtID);
        }

        private void ucSupplier_Load(object sender, EventArgs e)
        {
            SupplierBUS supplierBUS = new SupplierBUS();
            DataTable dtbl = new DataTable();
            dtbl = supplierBUS.ShowSupplier();
            gcSuppliers.DataSource = dtbl;


            ////send data to insert form
            //string txtID = null;
            //txtID = FindNextID(dtbl);
            //frmInserSupplier frm = new frmInserSupplier();
            //SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            //send(txtID);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInserSupplier frm = new frmInserSupplier();
            frm.Show();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = Enabled;
            btnDelete.Enabled = Enabled;

            Suppliers supplier = new Suppliers();
            var rowHandle = gridView1.FocusedRowHandle;
            supplier.SupplierID = gridView1.GetRowCellValue(rowHandle, "SupplierID").ToString();
            supplier.SupplierName = gridView1.GetRowCellValue(rowHandle, "SupplierName").ToString();
            supplier.Area = gridView1.GetRowCellValue(rowHandle, "Area").ToString();
            supplier.Address = gridView1.GetRowCellValue(rowHandle, "Address").ToString();
            supplier.Phone = gridView1.GetRowCellValue(rowHandle, "Phone").ToString();
            supplier.Email = gridView1.GetRowCellValue(rowHandle, "Email").ToString();
            supplier.Bank = gridView1.GetRowCellValue(rowHandle, "Bank").ToString();
            //supplier.Discount = float.Parse(gridView1.GetRowCellValue(rowHandle, "Discount").ToString());
            supplier.AccountBank = gridView1.GetRowCellValue(rowHandle, "AccountBank").ToString();

            //send data to update form
            frmUpdateSupplier frm = new frmUpdateSupplier();
            SendData send = new SendData(frm.ReceiveData);
            send(supplier);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //using (ExcelEngine excelEngine = new ExcelEngine())
            //{
            //    //Initialize Application
            //    IApplication application = excelEngine.Excel;

            //    //Set the default application version as Excel 2016
            //    application.DefaultVersion = ExcelVersion.Excel2016;

            //    //Create a new workbook
            //    IWorkbook workbook = application.Workbooks.Create(1);

            //    //Access first worksheet from the workbook instance
            //    IWorksheet worksheet = workbook.Worksheets[0];

            //    //Exporting DataTable to worksheet
            //    SupplierBUS bus = new SupplierBUS();
            //    DataTable dataTable = new DataTable();
            //    dataTable = bus.ShowSupplier();
            //    worksheet.ImportDataTable(dataTable, true, 1, 1);
            //    worksheet.UsedRange.AutofitColumns();

            //    //Save the workbook to disk in xlsx format
            //    workbook.SaveAs("Output.xlsx");

            //    MessageBox.Show("Export successfull!!\n" + @"Path: ..\QuanLyBanHang\GUI\bin\Debug");
            //}
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }
    }
}
