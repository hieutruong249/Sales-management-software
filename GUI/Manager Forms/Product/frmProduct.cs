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

namespace GUI
{
    public partial class frmProduct : DevExpress.XtraEditors.XtraForm
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            int FormID = int.Parse(this.Tag.ToString());
            RoleForm roleForm = GlobalVar.dicmyRoleForm[FormID];
            ucFucntion1.Controls["btnInsert"].Enabled = roleForm.f_Insert;
            ucFucntion1.Controls["btnUpdate"].Enabled = roleForm.f_Update;
            ucFucntion1.Controls["btnDelete"].Enabled = roleForm.f_Delete;
            ucFucntion1.Controls["btnExport"].Enabled = roleForm.Export;
            ucFucntion1.Controls["btnImport"].Enabled = roleForm.Import;

            //btnInsert.Enabled = GlobalVar.myRoleForm.f_Insert;
            //btnUpdate.Enabled = GlobalVar.myRoleForm.f_Update;
            //btnDelete.Enabled = GlobalVar.myRoleForm.f_Delete;
            //btnExport.Enabled = GlobalVar.myRoleForm.Export;
            //btnImport.Enabled = GlobalVar.myRoleForm.Export;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.Show();
        }
    }
}