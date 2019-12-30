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

namespace GUI
{
    public partial class frmArea : DevExpress.XtraEditors.XtraForm
    {
        public static DataTable dt = new DataTable();
        public static AreasBUS areasBUS = new AreasBUS();
        public static int FormID = 6;
        public static RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
        public static Areas areas = new Areas();
        public delegate void SendData(Areas areas);
        public delegate void SendTxtID(String str);
        public static string fileName = null;
        public delegate void SendTag(int tag);

        public frmArea()
        {
            InitializeComponent();
            //Permission
            //int FormID = int.Parse(this.Tag.ToString());
            //RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
        }

        public string FindNextID(DataTable dtbl)
        {
            string txtID = null;
            if (dtbl.Rows.Count > 0)
            {
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["ID"].ToString();
                int lastIndex = int.Parse(ma.Substring(2)) + 1;
                txtID = "KV" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "KV00001";
            }
            return txtID;
        }

        public void SendTextID2Form()
        {
            string txtID = null;
            txtID = FindNextID(dt);
            frmInsertArea frm = new frmInsertArea();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            dt = areasBUS.ShowArea();
            gcAreas.DataSource = dt;
            
            btnInsert.Enabled = roleForm.f_Insert;
            btnExport.Enabled = roleForm.Export;

            //send data to insert form
            SendTextID2Form();

            //Record history
            string time = DateTime.Now.ToString();
            try
            {
                areasBUS.RecordHistory(GlobalVar._username, GlobalVar.namePC, time, this.Text, "Seen", "NULL");
            }
            catch(Exception ex)
            {

            }
        }

        private void gcAreas_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate.Enabled = roleForm.f_Update;
            btnDelete.Enabled = roleForm.f_Delete;
           
            var rowHandle = gridView1.FocusedRowHandle;
            areas.ID = gridView1.GetRowCellValue(rowHandle, "ID").ToString();
            areas.Name = gridView1.GetRowCellValue(rowHandle, "Name").ToString();
            areas.Note = gridView1.GetRowCellValue(rowHandle, "Note").ToString();

            frmUpdateArea frm = new frmUpdateArea();
            SendData send = new SendData(frm.ReceiveData);
            send(areas);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dt = areasBUS.ShowArea();
            gcAreas.DataSource = dt;

            //send data to insert form
            SendTextID2Form();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertArea frm = new frmInsertArea();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateArea frm = new frmUpdateArea();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(areasBUS.DeleteArea(areas.ID) != 0)
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
            sendTag(6);
            frm.Show();
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

        public void ReceiveFileName(string str)
        {
            fileName = str;

            if (!string.IsNullOrEmpty(fileName))
            {
                DataTable data = new DataTable();
                data = areasBUS.ShowArea();

                Export(data);

                MessageBox.Show("Export successfull!!\n" + @"Path: ..\QuanLyBanHang\GUI\bin\Debug\" + fileName + ".xlsx");
            }
        }

        
    }
}