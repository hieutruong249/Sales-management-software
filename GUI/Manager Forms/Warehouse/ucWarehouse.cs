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
using GUI.Manager_Forms.Warehouse;
using BUS;
using DTO;
using Syncfusion.XlsIO;

namespace GUI
{
    public partial class ucWarehouse : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void SendData(Warehouses w);
        public delegate void SendTxtID(String str);
        public ucWarehouse()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertWarehouse frm = new frmInsertWarehouse();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateWarehouse frm = new frmUpdateWarehouse();
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
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["ID"].ToString();
                int lastIndex = int.Parse(ma.Substring(2)) + 1;
                txtID = "K" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "K00001";
            }
            return txtID;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            WarehouseBUS warehouseBUS = new WarehouseBUS();
            DataTable dtbl = new DataTable();
            dtbl = warehouseBUS.ShowWarehouses();
            gcWarehouses.DataSource = dtbl;

            //send data to insert form
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInsertWarehouse frm = new frmInsertWarehouse();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        private void ucWarehouse_Load(object sender, EventArgs e)
        {
            WarehouseBUS warehouseBUS = new WarehouseBUS();
            DataTable dtbl = new DataTable();
            dtbl = warehouseBUS.ShowWarehouses();
            gcWarehouses.DataSource = dtbl;

            //send data to insert form
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInsertWarehouse frm = new frmInsertWarehouse();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = Enabled;
            btnDelete.Enabled = Enabled;
            Warehouses warehouse = new Warehouses();
            var rowHandle = gridView1.FocusedRowHandle;
            warehouse.ID = gridView1.GetRowCellValue(rowHandle, "ID").ToString();
            warehouse.Name = gridView1.GetRowCellValue(rowHandle, "Name").ToString();
            warehouse.Manager = gridView1.GetRowCellValue(rowHandle, "Manager").ToString();
            warehouse.Contact = gridView1.GetRowCellValue(rowHandle, "Contact").ToString();
            warehouse.Address = gridView1.GetRowCellValue(rowHandle, "Address").ToString();
            warehouse.Phone = gridView1.GetRowCellValue(rowHandle, "Phone").ToString();
            warehouse.Email = gridView1.GetRowCellValue(rowHandle, "Email").ToString();
            warehouse.Decription = gridView1.GetRowCellValue(rowHandle, "Decription").ToString();

            //send data to update form
            frmUpdateWarehouse frm = new frmUpdateWarehouse();
            SendData send = new SendData(frm.ReceiveData);
            send(warehouse);
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
                WarehouseBUS bus = new WarehouseBUS();
                DataTable dataTable = new DataTable();
                dataTable = bus.ShowWarehouses();
                worksheet.ImportDataTable(dataTable, true, 1, 1);
                worksheet.UsedRange.AutofitColumns();

                //Save the workbook to disk in xlsx format
                workbook.SaveAs("Output.xlsx");

                MessageBox.Show("Export successfull!!\n" + @"Path: ..\QuanLyBanHang\GUI\bin\Debug");
            }
        }
    }
}
