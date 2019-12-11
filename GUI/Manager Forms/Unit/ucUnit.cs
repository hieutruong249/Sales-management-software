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
using GUI.Manager_Forms.Unit;
using BUS;
using DTO;
//using Syncfusion.XlsIO;

namespace GUI
{
    public partial class ucUnit : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void SendData(Units u);
        public delegate void SendTxtID(String str);
        public ucUnit()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertUnit frm = new frmInsertUnit();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateUnit frm = new frmUpdateUnit();
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
                txtID = "DV" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "DV00001";
            }
            return txtID;
        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            UnitBUS unitBUS = new UnitBUS();
            DataTable dtbl = new DataTable();
            dtbl = unitBUS.ShowUnit();
            gcUnit.DataSource = dtbl;

            //send data to Insert form
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInsertUnit frm = new frmInsertUnit();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        private void ucUnit_Load(object sender, EventArgs e)
        {
            UnitBUS unitBUS = new UnitBUS();
            DataTable dtbl = new DataTable();
            dtbl = unitBUS.ShowUnit();
            gcUnit.DataSource = dtbl;

            //send data to Insert form
            //string txtID = null;
            //txtID = FindNextID(dtbl);
            //frmInsertUnit frm = new frmInsertUnit();
            //SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            //send(txtID);
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = Enabled;
            btnDelete.Enabled = Enabled;
            Units unit = new Units();
            var rowHandle = gridView1.FocusedRowHandle;
            unit.ID = gridView1.GetRowCellValue(rowHandle, "ID").ToString();
            unit.Name = gridView1.GetRowCellValue(rowHandle, "Name").ToString();
            unit.Note = gridView1.GetRowCellValue(rowHandle, "Note").ToString();


            //send data to update form
            frmUpdateUnit frm = new frmUpdateUnit();
            SendData send = new SendData(frm.ReceiveData);
            send(unit);
        }

        private void gcUnit_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

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
            //    UnitBUS bus = new UnitBUS();
            //    DataTable dataTable = new DataTable();
            //    dataTable = bus.ShowUnit();
            //    worksheet.ImportDataTable(dataTable, true, 1, 1);
            //    worksheet.UsedRange.AutofitColumns();

            //    //Save the workbook to disk in xlsx format
            //    workbook.SaveAs("Output.xlsx");

            //    MessageBox.Show("Export successfull!!\n" + @"Path: ..\QuanLyBanHang\GUI\bin\Debug");
            //}
        }
    }
}
