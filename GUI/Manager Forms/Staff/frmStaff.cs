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
using BUS;
using DTO;
using GUI.Manager_Forms.Staff;
//using Syncfusion.XlsIO;

namespace GUI.Manager_Forms.Staff
{
    public partial class frmStaff : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendData(Staffs staff);
        public delegate void SendTxtID(String str);
        public static Staffs sf = new Staffs();
        public static StaffBUS staffBUS = new StaffBUS();
        public static  DataTable dtbl = new DataTable();
        public static int FormID = 6;
        public static RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];

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
        public void SendTextID2Form()
        {
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInsertStaff frm = new frmInsertStaff();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }
        public frmStaff()
        {
            InitializeComponent();
            int FormID = int.Parse(this.Tag.ToString());
            RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
           
            btnInsert.Enabled = roleForm.f_Insert;
            btnExport.Enabled = roleForm.f_Insert;
            btnImport.Enabled = roleForm.f_Insert;

            dtbl = staffBUS.ShowStaffs();
            gcStaffs.DataSource = dtbl;

            //send data to Insert form
            SendTextID2Form();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dtbl = staffBUS.ShowStaffs();
            gcStaffs.DataSource = dtbl;

            //send data to Insert form
            SendTextID2Form();
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
            this.Close();
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
            //    StaffBUS bus = new StaffBUS();
            //    DataTable dataTable = new DataTable();
            //    dataTable = bus.ShowStaffs();
            //    worksheet.ImportDataTable(dataTable, true, 1, 1);
            //    worksheet.UsedRange.AutofitColumns();

            //    //Save the workbook to disk in xlsx format
            //    workbook.SaveAs("Output.xlsx");

            //    MessageBox.Show("Export successfull!!\n" + @"Path: ..\QuanLyBanHang\GUI\bin\Debug");
            //}
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (staffBUS.DeleteStaff(sf) != 0)
                {
                    MessageBox.Show("Delete successfull!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Fail!!!");
            }
        }

        private void gcStaffs_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = roleForm.f_Insert;
            btnDelete.Enabled = roleForm.f_Insert;
            //btnUpdate.Enabled = Enabled;
            //btnDelete.Enabled = Enabled;

            try
            {
                var rowHandle = gridView1.FocusedRowHandle;
                sf.ID = gridView1.GetRowCellValue(rowHandle, "ID").ToString();
                sf.Name = gridView1.GetRowCellValue(rowHandle, "Name").ToString();
                sf.Position = gridView1.GetRowCellValue(rowHandle, "Position").ToString();
                sf.Address = gridView1.GetRowCellValue(rowHandle, "Address").ToString();
                sf.Email = gridView1.GetRowCellValue(rowHandle, "Email").ToString();
                sf.Phone = gridView1.GetRowCellValue(rowHandle, "Phone").ToString();
                sf.Parts = gridView1.GetRowCellValue(rowHandle, "Parts").ToString();
                sf.Manager = gridView1.GetRowCellValue(rowHandle, "Manager").ToString();
            }
            catch(Exception ex)
            {
                throw ex;
            }


            //send data to update form
            frmUpdateStaff frm = new frmUpdateStaff();
            SendData send = new SendData(frm.ReceiveData);
            send(sf);
        }
    }
}