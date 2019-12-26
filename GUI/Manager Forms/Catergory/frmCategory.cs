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
using DTO;
using BUS;
using Syncfusion.XlsIO;

namespace GUI.Manager_Forms.Catergory
{
    public partial class frmCategory : DevExpress.XtraEditors.XtraForm
    {
        public static DataTable dtbl = new DataTable();
        public static Categories categorie = new Categories();
        public static CategoryBUS categoryBUS = new CategoryBUS();
        public static int FormID = 6;
        public static RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
        public delegate void SendData(Categories cat);
        public delegate void SendTxtID(String str);

        public string FindNextID(DataTable dtbl)
        {

            string txtID = null;
            if (dtbl.Rows.Count > 0)
            {
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["CatID"].ToString();
                int lastIndex = int.Parse(ma.Substring(2)) + 1;
                txtID = "PL" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "PL00001";
            }
            return txtID;
        }

        public void SendTextID2Form()
        {
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInsertCatergory frm = new frmInsertCatergory();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        public frmCategory()
        {
            InitializeComponent();
            int FormID = int.Parse(this.Tag.ToString());
            RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];

        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            dtbl = categoryBUS.ShowCatergories();
            gcCategories.DataSource = dtbl;

            btnInsert.Enabled = roleForm.f_Insert;

            //send data to insert form
            SendTextID2Form();

            //Record history
            string time = DateTime.Now.ToString();
            try
            {
                categoryBUS.RecordHistory(GlobalVar._username, GlobalVar.namePC, time, this.Text, "Seen", "NULL");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dtbl = categoryBUS.ShowCatergories();
            gcCategories.DataSource = dtbl;

            //send data to insert form
            SendTextID2Form();
        }

        private void gcCategories_Click(object sender, EventArgs e)
        {
            //btnUpdate.Enabled = GlobalVar.myRoleForm.f_Update;
            //btnDelete.Enabled = GlobalVar.myRoleForm.f_Delete;
            btnUpdate.Enabled = roleForm.f_Update;
            btnDelete.Enabled = roleForm.f_Delete;
  
            var rowHandle = gridView1.FocusedRowHandle;
            categorie.CategoryID = gridView1.GetRowCellValue(rowHandle, "CatID").ToString();
            categorie.CategoryName = gridView1.GetRowCellValue(rowHandle, "CatName").ToString();
            categorie.Note = gridView1.GetRowCellValue(rowHandle, "Note").ToString();

            //send data to update form
            frmUpdateCatergory frm = new frmUpdateCatergory();
            SendData send = new SendData(frm.ReceiveData);
            send(categorie);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertCatergory frm = new frmInsertCatergory();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateCatergory frm = new frmUpdateCatergory();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryBUS.DeleteCategory(categorie) != 0)
                {
                    MessageBox.Show("Delete successfull!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Fail!!!");
            }
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
                gcCategories.DataSource = categoryBUS.ImportFormExcel("Sheet1", path);

            }
        }
    }
}