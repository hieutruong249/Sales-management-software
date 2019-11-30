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
using BUS;
using DTO;
using GUI.Manager_Forms.Staff;
using Syncfusion.XlsIO;

namespace GUI
{
    public partial class ucStaff : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void SendData(Staffs staff);
        public delegate void SendTxtID(String str);
        public ucStaff()
        {
            InitializeComponent();
        }

        public string FindNextID(DataTable dtbl)
        {
            string txtID = null;
            if (dtbl.Rows.Count > 0)
            {
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["ID"].ToString();
                int lastIndex = int.Parse(ma.Substring(2)) + 1;
                txtID = "NV" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "NV00001";
            }
            return txtID;
        }

        private void ucStaff_Load(object sender, EventArgs e)
        {
            StaffBUS staffBUS = new StaffBUS();
            DataTable dtbl = new DataTable();
            dtbl = staffBUS.ShowStaffs();
            gcStaffs.DataSource = dtbl;

            //send data to Insert form
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInsertStaff frm = new frmInsertStaff();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            StaffBUS staffBUS = new StaffBUS();
            DataTable dtbl = new DataTable();
            dtbl = staffBUS.ShowStaffs();
            gcStaffs.DataSource = dtbl;

            //send data to Insert form
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInsertStaff frm = new frmInsertStaff();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertStaff frm = new frmInsertStaff();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateStaff frm = new frmUpdateStaff();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = Enabled;
            btnDelete.Enabled = Enabled;

            Staffs sf = new Staffs();
            var rowHandle = gridView1.FocusedRowHandle;
            sf.ID = gridView1.GetRowCellValue(rowHandle, "ID").ToString();
            sf.Name = gridView1.GetRowCellValue(rowHandle, "Name").ToString();
            sf.Position = gridView1.GetRowCellValue(rowHandle, "Position").ToString();
            sf.Address = gridView1.GetRowCellValue(rowHandle, "Address").ToString();
            sf.Email = gridView1.GetRowCellValue(rowHandle, "Email").ToString();
            sf.Phone = gridView1.GetRowCellValue(rowHandle, "Phone").ToString();
            sf.Parts = gridView1.GetRowCellValue(rowHandle, "Parts").ToString();
            sf.Manager = gridView1.GetRowCellValue(rowHandle, "Manager").ToString();


            //send data to update form
            frmUpdateStaff frm = new frmUpdateStaff();
            SendData send = new SendData(frm.ReceiveData);
            send(sf);
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
                StaffBUS bus = new StaffBUS();
                DataTable dataTable = new DataTable();
                dataTable = bus.ShowStaffs();
                worksheet.ImportDataTable(dataTable, true, 1, 1);
                worksheet.UsedRange.AutofitColumns();

                //Save the workbook to disk in xlsx format
                workbook.SaveAs("Output.xlsx");

                MessageBox.Show("Export successfull!!\n" + @"Path: ..\QuanLyBanHang\GUI\bin\Debug");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            StaffBUS bus = new StaffBUS();
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo fInfo = new System.IO.FileInfo(fDialog.FileName);
                string path = fInfo.DirectoryName + "\\" + fInfo.Name;
                //DataTable data = new DataTable();
                gcStaffs.DataSource = bus.ImportFormExcel("Sheet1", path);

            }
        }
    }
}
