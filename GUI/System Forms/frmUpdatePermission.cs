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

namespace GUI.System_Forms
{
    public partial class frmUpdatePermission : DevExpress.XtraEditors.XtraForm
    {
        public static string _formname, _username;
        public static RoleForm rf = new RoleForm();
        public frmUpdatePermission()
        {
            InitializeComponent();
        }
        public void ReceiveData(string username, string formname, RoleForm rf)
        {
            _formname = formname;
            _username = username;
            cbAccess.Checked = rf.Access;
            cbInsert.Checked = rf.f_Insert;
            cbUpdate.Checked = rf.f_Update;
            cbDelete.Checked = rf.f_Delete;
            cbExport.Checked = rf.Export;
            cbImport.Checked = rf.Import;
        }
        private void frmUpdatePermission_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool access, insert, update, delete, import, export;
            rf.Access = cbAccess.Checked;
            rf.f_Insert = cbInsert.Checked;
            rf.f_Update = cbUpdate.Checked;
            rf.f_Delete = cbDelete.Checked;
            rf.Import = cbImport.Checked;
            rf.Export = cbExport.Checked;
            PermisionFormBUS bus = new PermisionFormBUS();
            try
            {
                
                if (bus.UpdatePermission(_username, _formname, rf) > 0)
                {
                    MessageBox.Show("Update successfully!!");
                }
                else
                {
                    MessageBox.Show(_username +  _formname + rf.Access + rf.Access + rf.f_Insert + rf.f_Update);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
            //MessageBox.Show((cbAccess.Checked).ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}