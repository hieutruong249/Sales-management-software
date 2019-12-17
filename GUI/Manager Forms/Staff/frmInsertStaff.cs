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

namespace GUI.Manager_Forms.Staff
{
    public partial class frmInsertStaff : DevExpress.XtraEditors.XtraForm
    {
        public static string str;
        public void ReceiveTxtID(string textID)
        {
            str = textID;
        }
        public frmInsertStaff()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void frmInsertStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet3.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.qLBH_v1DataSet3.Staffs);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet2.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.qLBH_v1DataSet2.Parts);

            lkManager.EditValue = this.qLBH_v1DataSet3.Staffs.Rows[0][lkManager.Properties.ValueMember];
            lkParts.EditValue = this.qLBH_v1DataSet2.Parts.Rows[0][lkParts.Properties.ValueMember];

            txtID.Text = str;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StaffBUS staffBUS = new StaffBUS();
            Staffs staffs = new Staffs();
            staffs.ID = txtID.Text;
            staffs.Name = txtID.Text;
            staffs.Phone = txtID.Text;
            staffs.Address = txtID.Text;
            staffs.Email = txtID.Text;
            staffs.Position = txtID.Text;
            staffs.Parts = lkParts.EditValue.ToString();
            staffs.Manager = lkManager.EditValue.ToString();
            try
            {   if (staffBUS.InsertStaff(staffs) > 0)
                {
                    MessageBox.Show("Insert susscessfully!!!");

                    DataTable data = new DataTable();
                    data = staffBUS.ShowStaffs();
                    txtID.Text = FindNextID(data);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Insert fail!!!");
            }
        }

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
    }
}