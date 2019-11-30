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
using GUI.Manager_Forms.Catergory;
using Syncfusion.XlsIO;
using BUS;
using DTO;
using System.Data.OleDb;

namespace GUI
{
    public partial class ucCatergory : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void SendData(Categories cat);
        public delegate void SendTxtID(String str);
        public ucCatergory()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateCatergory frm = new frmUpdateCatergory();
            frm.Show();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            CategoryBUS categoryBUS = new CategoryBUS();
            DataTable dtbl = new DataTable();
            dtbl = categoryBUS.ShowCatergories();
            gcCatergories.DataSource = dtbl;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }

        private void ucCatergory_Load(object sender, EventArgs e)
        {
           
            CategoryBUS categoryBUS = new CategoryBUS();
            DataTable dtbl = new DataTable();
            dtbl = categoryBUS.ShowCatergories();
            gcCatergories.DataSource = dtbl;
            //int FormID = int.Parse(this.Tag.ToString());
            //RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
            btnInsert.Enabled = Enabled;


            //send data to Insert form
            string txtID = null;
            if (dtbl.Rows.Count > 0)
            {
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["CatID"].ToString();
                int lastIndex = int.Parse(ma.Substring(2)) + 1;
                txtID = "PL" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "PL000001";
            }
            frmInsertCatergory frm = new frmInsertCatergory();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = Enabled;
            btnDelete.Enabled = Enabled;
            Categories categorie = new Categories();
            var rowHandle = gridView1.FocusedRowHandle;
            categorie.CategoryID = gridView1.GetRowCellValue(rowHandle, "CatID").ToString();
            categorie.CategoryName = gridView1.GetRowCellValue(rowHandle, "CatName").ToString();
            categorie.Note = gridView1.GetRowCellValue(rowHandle, "Note").ToString();


            //send data to update form
            frmUpdateCatergory frm = new frmUpdateCatergory();
            SendData send = new SendData(frm.ReceiveData);
            send(categorie);
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            frmInsertCatergory frm = new frmInsertCatergory();
            frm.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Create an instance of ExcelEngine
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
                CategoryBUS categoryBUS = new CategoryBUS();
                DataTable dataTable = new DataTable();
                dataTable = categoryBUS.ShowCatergories();
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
                gcCatergories.DataSource = categoryBUS.ImportFormExcel("Sheet1",path);
                
            }            
        }
    }
}
