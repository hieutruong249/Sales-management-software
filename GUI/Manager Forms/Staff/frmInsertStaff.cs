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
        }

        private void frmInsertStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet3.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.qLBH_v1DataSet3.Staffs);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet2.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.qLBH_v1DataSet2.Parts);

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
            staffs.Parts = lkParts.Text;
            staffs.Manager = lkManager.Text;

            staffBUS.InsertStaff(staffs);
        }
    }
}