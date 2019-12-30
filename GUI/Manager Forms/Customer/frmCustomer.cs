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
using GUI.Manager_Forms.Customer;
using Syncfusion.XlsIO;

namespace GUI.Manager_Forms.Customer
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendData(Customers customer);
        public delegate void SendTxtID(String str);
        public delegate void SendTag(int tag);
        public static CustomerBUS customerBUS = new CustomerBUS();
        public static DataTable dtbl = new DataTable();
        public static Customers customer = new Customers();
        public static int FormID = 8;
        public static RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
        public static string fileName = null;


        public frmCustomer()
        {
            InitializeComponent();
            //int FormID = int.Parse(this.Tag.ToString());
            //RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dtbl = customerBUS.ShowCustomer();
            gcCustomers.DataSource = dtbl;

            //send data to insert form
            SendTextID2Form();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            btnInsert.Enabled = roleForm.f_Insert;
            btnExport.Enabled = roleForm.Export;
            btnImport.Enabled = roleForm.Import;

            dtbl = customerBUS.ShowCustomer();
            gcCustomers.DataSource = dtbl;

            //send data to insert form
            SendTextID2Form();

            //Record history
            string time = DateTime.Now.ToString();
            try
            {
                customerBUS.RecordHistory(GlobalVar._username, GlobalVar.namePC, time, this.Text, "Seen", "NULL");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInserCustomer frm = new frmInserCustomer();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateCustomer frm = new frmUpdateCustomer();
            frm.Show();
        }

        private void gcCustomers_Click(object sender, EventArgs e)
        {

            btnUpdate.Enabled = roleForm.f_Update;
            btnDelete.Enabled = roleForm.f_Delete;

            var rowHandle = gridView1.FocusedRowHandle;
            customer.CustomerID = gridView1.GetRowCellValue(rowHandle, "CustomerID").ToString();
            customer.CustomerName = gridView1.GetRowCellValue(rowHandle, "CustomerName").ToString();
            customer.Area = gridView1.GetRowCellValue(rowHandle, "Area").ToString();
            customer.Address = gridView1.GetRowCellValue(rowHandle, "Address").ToString();
            customer.Phone = gridView1.GetRowCellValue(rowHandle, "Phone").ToString();
            customer.Email = gridView1.GetRowCellValue(rowHandle, "Email").ToString();
            customer.Bank = gridView1.GetRowCellValue(rowHandle, "Bank").ToString();
            customer.Discount = float.Parse(gridView1.GetRowCellValue(rowHandle, "Discount").ToString());
            customer.AccountBank = gridView1.GetRowCellValue(rowHandle, "AccountBank").ToString();

            //send data to update form
            frmUpdateCustomer frm = new frmUpdateCustomer();
            SendData send = new SendData(frm.ReceiveData);
            send(customer);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            frmInputNameFile frm = new frmInputNameFile();
            SendTag sendTag = new SendTag(frm.ReceiveTag);
            sendTag(8);
            frm.Show();
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

           
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo fInfo = new System.IO.FileInfo(fDialog.FileName);
                string path = fInfo.DirectoryName + "\\" + fInfo.Name;
                DataTable data = new DataTable();
                data = customerBUS.ImportFormExcel("Sheet1", path);
                Import(data);
                //gcCustomers.DataSource = categoryBUS.ImportFormExcel("Sheet1", path);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(customer.CustomerID);
            try
            {
                if (customerBUS.DeleteCustomer(customer.CustomerID) != 0)
                {
                    MessageBox.Show("Delete successfull!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Fail!!!");
            }
        }

        public string FindNextID(DataTable dtbl)
        {
            string txtID = null;
            try
            {
                if (dtbl.Rows.Count > 0)
                {
                    string ma = dtbl.Rows[dtbl.Rows.Count - 1]["CustomerID"].ToString();
                    int lastIndex = int.Parse(ma.Substring(2)) + 1;
                    txtID = "KH" + lastIndex.ToString("00000");
                }
                else
                {
                    txtID = "KH00001";
                }
            }
            catch (Exception ex)
            {

            }
            return txtID;
        }

        public void SendTextID2Form()
        {
            string txtID = null;
            txtID = FindNextID(dtbl);
            frmInserCustomer frm = new frmInserCustomer();
            SendTxtID send = new SendTxtID(frm.ReceiveTxtID);
            send(txtID);
        }

        public bool IsExistsCustomerID(string customerID)
        {
            DataTable data = new DataTable();
            data = customerBUS.ShowCustomer(customerID);

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
                    customer.CustomerID = row["CustomerID"].ToString();
                    if (!IsExistsCustomerID(customer.CustomerID))
                    {
                        customer.CustomerName = row["CustomerName"].ToString();
                        customer.Area = row["Area"].ToString();
                        customer.Address = row["Address"].ToString();
                        customer.Phone = row["Phone"].ToString();
                        customer.Email = row["Email"].ToString();
                        customer.Bank = row["Bank"].ToString();
                        customer.Discount = float.Parse(row["Discount"].ToString());
                        customer.AccountBank = row["AccountBank"].ToString();
                        
                        if (customerBUS.InsertCustomer(customer) != 0)
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
                MessageBox.Show("Error: CustomerID " + customer.CustomerID);
            }

            MessageBox.Show("Inserted: " + inserted + "Rows" + "\n" +
                "Error: " + err + " Rows" + "\n" +
                "Exists: " + exists + " Rows" + "\n" +
                "Total: " + data.Rows.Count + " Rows!!!");

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
                DataTable dataTable = new DataTable();
                dataTable = customerBUS.ShowCustomer();

                Export(dataTable);

                MessageBox.Show("Export successfull!!\n" + @"Path: ..\QuanLyBanHang\GUI\bin\Debug\" + fileName + ".xlsx");
            }
        }

        
    }
}