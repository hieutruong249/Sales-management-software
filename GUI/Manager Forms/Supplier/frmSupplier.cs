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
using Syncfusion.XlsIO;

namespace GUI.Manager_Forms.Supplier
{
    public partial class frmSupplier : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendData(Suppliers supplier);
        public delegate void SendTxtID(String str);
        public static SupplierBUS supplierBUS = new SupplierBUS();
        public static DataTable dtbl = new DataTable();
        public static Suppliers supplier = new Suppliers();
        public static int FormID = 6;
        public static RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];

        public string FindNextID(DataTable dtbl)
        {
            string txtID = null;
            if (dtbl.Rows.Count > 0)
            {
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["SupplierID"].ToString();
                int lastIndex = int.Parse(ma.Substring(3)) + 1;
                txtID = "NCC" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "NCC00001";
            }
            return txtID;
        }

        public void SendTextID2Form()
        {
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInserSupplier frm = new frmInserSupplier();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        public frmSupplier()
        {
            InitializeComponent();
            int FormID = int.Parse(this.Tag.ToString());
            RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dtbl = supplierBUS.ShowSupplier();
            gcSuppliers.DataSource = dtbl;


            ////send data to insert form
            SendTextID2Form();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            btnInsert.Enabled = roleForm.f_Insert;
            btnExport.Enabled = roleForm.Export;

            dtbl = supplierBUS.ShowSupplier();
            gcSuppliers.DataSource = dtbl;

            //send data to insert form
            SendTextID2Form();

            //Record history
            string time = DateTime.Now.ToString();
            try
            {
                supplierBUS.RecordHistory(GlobalVar._username, GlobalVar.namePC, time, this.Text, "Seen", "NULL");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInserSupplier frm = new frmInserSupplier();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateSupplier frm = new frmUpdateSupplier();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (supplierBUS.DeleteSupplier(supplier) != 0)
                {
                    MessageBox.Show("Delete successfull!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Fail!!!");
            }
        }

        private void gcSuppliers_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = roleForm.f_Update;
            btnDelete.Enabled = roleForm.f_Delete;
            try
            {
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
            }
            catch(Exception ex)
            {
                throw ex;
            }
            //send data to update form
            frmUpdateSupplier frm = new frmUpdateSupplier();
            SendData send = new SendData(frm.ReceiveData);
            send(supplier);
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
                SupplierBUS bus = new SupplierBUS();
                DataTable dataTable = new DataTable();
                dataTable = bus.ShowSupplier();
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

            AreasBUS categoryBUS = new AreasBUS();
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo fInfo = new System.IO.FileInfo(fDialog.FileName);
                string path = fInfo.DirectoryName + "\\" + fInfo.Name;
                //DataTable data = new DataTable();
                gcSuppliers.DataSource = categoryBUS.ImportFormExcel("Sheet1", path);

            }
        }
    }
}