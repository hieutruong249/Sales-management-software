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
        public static int FormID = 7;
        public static string fileName = null;
        public static RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
        public delegate void SendData(Categories cat);
        public delegate void SendTxtID(String str);
        public delegate void SendTag(int tag);      

        public frmCategory()
        {
            InitializeComponent();
            //int FormID = int.Parse(this.Tag.ToString());
            //RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];

        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            dtbl = categoryBUS.ShowCatergories();
            gcCategories.DataSource = dtbl;

            btnInsert.Enabled = roleForm.f_Insert;
            btnExport.Enabled = roleForm.Export;
            btnImport.Enabled = roleForm.Import;

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
            frmInputNameFile frm = new frmInputNameFile();
            SendTag sendTag = new SendTag(frm.ReceiveTag);
            sendTag(FormID);
            frm.Show();
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
                DataTable data = new DataTable();
                data = categoryBUS.ImportFormExcel("Sheet1", path);
                Export(data);
                //gcCategories.DataSource = categoryBUS.ImportFormExcel("Sheet1", path);

            }
        }

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

        public void ReceiveFileName(string str)
        {
            fileName = str;

            if (!string.IsNullOrEmpty(fileName))
            {
                DataTable dataTable = new DataTable();
                dataTable = categoryBUS.ShowCatergories();

                Export(dataTable);

                MessageBox.Show("Export successfull!!\n" + @"Path: ..\QuanLyBanHang\GUI\bin\Debug\" + fileName + ".xlsx");
            }
        }

        public void Export(DataTable dataTable)
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
                worksheet.ImportDataTable(dataTable, true, 1, 1);
                worksheet.UsedRange.AutofitColumns();

                //Save the workbook to disk in xlsx format
                workbook.SaveAs(fileName + ".xlsx");

            }
        }

        public bool IsExistsCategoryID(string customerID)
        {
            DataTable data = new DataTable();
            data = categoryBUS.ShowCatergories(customerID);

            return (data.Rows.Count > 0 ? true : false);
        }

        public void Import(DataTable data)
        {
            int err, inserted, exists;
            inserted = err = exists = 0;

            try
            {
                foreach (DataRow row in data.Rows)
                {
                    categorie.CategoryID = row["CatID"].ToString();
                    if (!IsExistsCategoryID(categorie.CategoryID))
                    {
                        categorie.CategoryName = row["CatName"].ToString();
                        categorie.Note = row["Note"].ToString();

                        if (categoryBUS.InserCategory(categorie) != 0)
                        {
                            inserted = inserted + 1;
                        }
                        else
                        {
                            err++;
                        }
                    }
                    else
                    {
                        exists++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: CustomerID " + categorie.CategoryID);
            }

            MessageBox.Show("Inserted: " + inserted + "Rows" + "\n" +
                "Error: " + err + " Rows" + "\n" +
                "Exists: " + exists + " Rows" + "\n" +
                "Total: " + data.Rows.Count + " Rows!!!");

        }
    }
}