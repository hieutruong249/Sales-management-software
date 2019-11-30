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
using DTO;
using GUI.Manager_Forms.Area;
using BUS;
using System.Data;
using Syncfusion.XlsIO;

namespace GUI.Manager_Forms
{
    public partial class uc1: DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void SendData(Areas areas);
        public delegate void SendTxtID(String str);
        
        public uc1()
        {
            InitializeComponent();
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
                txtID = "KV" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "KV00001";
            }
            return txtID;
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

        private void uc_Load(object sender, EventArgs e)
        {
            
            AreasBUS areasBUS = new AreasBUS();
            DataTable dt = new DataTable();
            dt = areasBUS.ShowArea();
            gcAreas.DataSource = dt;
            //int FormID = int.Parse(this.Tag.ToString());
            //RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
            btnInsert.Enabled = Enabled;

            //send data to insert form
            string txtID = null;
            txtID = FindNextID(dt);
            frmInsertArea frm = new frmInsertArea();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = Enabled;
            btnDelete.Enabled = Enabled;
            Areas areas = new Areas();
            var rowHandle = gridView1.FocusedRowHandle;
            areas.ID = gridView1.GetRowCellValue(rowHandle, "ID").ToString();
            areas.Name = gridView1.GetRowCellValue(rowHandle, "Name").ToString();
            areas.Note = gridView1.GetRowCellValue(rowHandle, "Note").ToString();


            frmUpdateArea frm = new frmUpdateArea();
            SendData send = new SendData(frm.ReceiveData);
            send(areas);
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
                AreasBUS areasBUS = new AreasBUS();
                DataTable dataTable = new  DataTable();
                dataTable = areasBUS.ShowArea();
                worksheet.ImportDataTable(dataTable, true, 1, 1);
                worksheet.UsedRange.AutofitColumns();

                //Save the workbook to disk in xlsx format
                workbook.SaveAs("Output.xlsx");

                MessageBox.Show("Export successfull!!\n" + @"Path: ..\QuanLyBanHang\GUI\bin\Debug");
            }
        }
    }
}
