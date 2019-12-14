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

namespace GUI.Manager_Forms.Staff
{
    public partial class frmUpdateStaff : DevExpress.XtraEditors.XtraForm
    {
        public static Staffs staff = new Staffs();
        public void ReceiveData(Staffs u)
        {
            staff = u;
        }
        public frmUpdateStaff()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void frmUpdateStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet3.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.qLBH_v1DataSet3.Staffs);
            // TODO: This line of code loads data into the 'qLBH_v1DataSet2.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.qLBH_v1DataSet2.Parts);

             txtID.Text = staff.ID;
             txtName.Text = staff.Name;
             txtPhone.Text = staff.Phone;
             txtAddress.Text = staff.Address;
             txtEmail.Text = staff.Email;
             txtPosition.Text = staff.Position;
             lkParts.Text = staff.Parts;
             lkManager.Text = staff.Manager;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StaffBUS staffBUS = new StaffBUS();
            staff.ID = txtID.Text;
            staff.Name = txtName.Text;
            staff.Phone = txtPhone.Text;
            staff.Address = txtAddress.Text;
            staff.Email = txtEmail.Text;
            staff.Position = txtPosition.Text;
            staff.Parts = lkParts.Text;
            staff.Manager = lkManager.Text;

            staffBUS.UpdateStaff(staff);
        }
    }
}