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
using GUI.Manager_Forms.ExRate;
using BUS;
using DTO;
//using Syncfusion.XlsIO;

namespace GUI
{
    public partial class ucExRate : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void SendData(ExRates rate);
        public delegate void SendTxtID(String str);

        public ucExRate()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertExRate frm = new frmInsertExRate();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateExRate frm = new frmUpdateExRate();
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
                txtID = lastIndex.ToString();
            }
            else
            {
                txtID = "1";
            }
            return txtID;
        }
        private void ucExRate_Load(object sender, EventArgs e)
        {
            ExRateBUS exRateBUS = new ExRateBUS();
            DataTable dtbl = new DataTable();
            dtbl = exRateBUS.ShowExRate();
            gcExRate.DataSource = dtbl;
            
            //int FormID = int.Parse(this.Tag.ToString());
            //RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
            btnInsert.Enabled = Enabled;

            //send data to insert form
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInsertExRate frm = new frmInsertExRate();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            ExRateBUS exRateBUS = new ExRateBUS();
            DataTable dtbl = new DataTable();
            dtbl = exRateBUS.ShowExRate();
            gcExRate.DataSource = dtbl;

            //send data to insert form
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInsertExRate frm = new frmInsertExRate();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = Enabled;
            btnDelete.Enabled = Enabled;
            ExRates rate = new ExRates();
            var rowHandle = gridView1.FocusedRowHandle;
            rate.ID = int.Parse(gridView1.GetRowCellValue(rowHandle, "ID").ToString());
            rate.Name = gridView1.GetRowCellValue(rowHandle, "Name").ToString();
            rate.Rate = float.Parse(gridView1.GetRowCellValue(rowHandle, "Rate").ToString());


            //send data to update form
            frmUpdateExRate frm = new frmUpdateExRate();
            SendData send = new SendData(frm.ReceiveData);
            send(rate);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Create an instance of ExcelEngine
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
            //    ExRateBUS bus = new ExRateBUS();
            //    DataTable dataTable = new DataTable();
            //    dataTable = bus.ShowExRate();
            //    worksheet.ImportDataTable(dataTable, true, 1, 1);
            //    worksheet.UsedRange.AutofitColumns();

            //    //Save the workbook to disk in xlsx format
            //    workbook.SaveAs("Output.xlsx");

            //    MessageBox.Show("Export successfull!!\n" + @"Path: ..\QuanLyBanHang\GUI\bin\Debug");
            //}
        }
    }
}
