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

namespace GUI.Manager_Forms.Warehouse
{
    public partial class frmWarehouse : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendData(Warehouses w);
        public delegate void SendTxtID(String str);
        public static WarehouseBUS warehouseBUS = new WarehouseBUS();
        public static DataTable dtbl = new DataTable();
        public static Warehouses warehouse = new Warehouses();
        public static int FormID = 6;
        public static RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];

        public frmWarehouse()
        {
            InitializeComponent();
            int FormID = int.Parse(this.Tag.ToString());
            RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
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

        public void SendTextID2Form()
        {
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInsertWarehouse frm = new frmInsertWarehouse();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            btnInsert.Enabled = roleForm.f_Insert;
            btnExport.Enabled = roleForm.Export;

            dtbl = warehouseBUS.ShowWarehouses();
            gcWarehoues.DataSource = dtbl;

            //send data to insert form
            SendTextID2Form();

            //Record history
            string time = DateTime.Now.ToString();
            try
            {
                warehouseBUS.RecordHistory(GlobalVar._username, GlobalVar.namePC, time, this.Text, "Seen", "NULL");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dtbl = warehouseBUS.ShowWarehouses();
            gcWarehoues.DataSource = dtbl;

            //send data to insert form
            SendTextID2Form();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (warehouseBUS.DeleteWarehouse(warehouse) != 0)
                {
                    MessageBox.Show("Delete successfull!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Fail!!!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                gcWarehoues.DataSource = categoryBUS.ImportFormExcel("Sheet1", path);

            }
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

        private void gcWarehoues_Click(object sender, EventArgs e)
        {
            
            btnUpdate.Enabled = roleForm.f_Update;
            btnDelete.Enabled = roleForm.f_Delete;

            //btnUpdate.Enabled = Enabled;
            //btnDelete.Enabled = Enabled;

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
    }
}