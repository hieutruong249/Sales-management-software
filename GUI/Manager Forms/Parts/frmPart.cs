﻿using System;
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
using GUI.Manager_Forms.Parts;
using Syncfusion.XlsIO;

namespace GUI.Manager_Forms.Parts
{
    public partial class frmPart : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendData(Partss p);
        public delegate void SendTxtID(String str);
        public static PartsBUS partsBUS = new PartsBUS();
        public static DataTable dtbl = new DataTable();
        public static Partss p = new Partss();
        public static int FormID = 6;
        public static RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];

        public frmPart()
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
                txtID = "BP" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "BP00001";
            }
            return txtID;
        }

        public void SendTextID2Form()
        {
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInsertParts frm = new frmInsertParts();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        private void frmPart_Load(object sender, EventArgs e)
        {
            btnInsert.Enabled = roleForm.f_Insert;
            btnExport.Enabled = roleForm.Export;

            dtbl = partsBUS.ShowParts();
            gcParts.DataSource = dtbl;

            //send data to Insert form
            SendTextID2Form();

            //Record history
            string time = DateTime.Now.ToString();
            try
            {
                partsBUS.RecordHistory(GlobalVar._username, GlobalVar.namePC, time, this.Text, "Seen", "NULL");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dtbl = partsBUS.ShowParts();
            gcParts.DataSource = dtbl;

            //send data to Insert form
            SendTextID2Form();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertParts frm = new frmInsertParts();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateParts frm = new frmUpdateParts();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (partsBUS.DeleteParts(p) != 0)
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
                PartsBUS bus = new PartsBUS();
                DataTable dataTable = new DataTable();
                dataTable = bus.ShowParts();
                worksheet.ImportDataTable(dataTable, true, 1, 1);
                worksheet.UsedRange.AutofitColumns();

                //Save the workbook to disk in xlsx format
                workbook.SaveAs("Output.xlsx");

                MessageBox.Show("Export successfull!!\n" + @"Path: ..\QuanLyBanHang\GUI\bin\Debug");
            }
        }

        private void gcParts_Click(object sender, EventArgs e)
        {
            
            btnUpdate.Enabled = roleForm.f_Insert;
            btnDelete.Enabled = roleForm.f_Delete;
           
            var rowHandle = gridView1.FocusedRowHandle;
            p.ID = gridView1.GetRowCellValue(rowHandle, "ID").ToString();
            p.Name = gridView1.GetRowCellValue(rowHandle, "Name").ToString();
            p.Note = gridView1.GetRowCellValue(rowHandle, "Note").ToString();


            //send data to update form
            frmUpdateParts frm = new frmUpdateParts();
            SendData send = new SendData(frm.ReceiveData);
            send(p);
        }
    }
}