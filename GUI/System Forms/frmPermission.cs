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
using GUI.System_Forms;

namespace GUI
{
    public partial class frmPermission : DevExpress.XtraEditors.XtraForm
    {
        public static PermisionFormBUS bus = new PermisionFormBUS();
        //public delegate void SendData(bool access, bool insert, bool update, bool delete, bool import, bool export);
        public delegate void SendData(string username, string formname, RoleForm rf);
        public static RoleForm rf = new RoleForm();

        public frmPermission()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet.Permission' table. You can move, or remove it, as needed.
            //this.permissionTableAdapter.Fill(this.qLBH_v1DataSet.Permission);

            DataTable dt = new DataTable();
            dt = bus.ShowUsers();
            foreach (DataRow row in dt.Rows)
            {
                cbUsername.Properties.Items.Add(row["f_username"]);
            }
            cbUsername.Text = GlobalVar._username;

            try
            {
                dt = bus.ShowRole(cbUsername.Text);
                var rolename = dt.Rows[0][0];
                txtRoleName.Text = rolename.ToString();
            }
            catch(Exception ex)
            {

            }

            gcPermission.DataSource = bus.ShowPermissionForm(cbUsername.Text);



        }
       

        private void cbUsername_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = bus.ShowRole(cbUsername.Text);
                var rolename = dt.Rows[0][0];
                txtRoleName.Text = rolename.ToString();
            }
            catch (Exception ex)
            {

            }

            gcPermission.DataSource = bus.ShowPermissionForm(cbUsername.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcPermission_Click(object sender, EventArgs e)
        {
            string formName;
           
            var rowHandle = gridView1.FocusedRowHandle;

            formName = gridView1.GetRowCellValue(rowHandle, "Description").ToString();
            
            try
            {
                rf.Access = bool.Parse(gridView1.GetRowCellValue(rowHandle, "Access").ToString());
                rf.f_Insert = bool.Parse(gridView1.GetRowCellValue(rowHandle, "f_Insert").ToString());
                rf.f_Update = bool.Parse(gridView1.GetRowCellValue(rowHandle, "f_Update").ToString());
                rf.f_Delete = bool.Parse(gridView1.GetRowCellValue(rowHandle, "f_Delete").ToString());
                rf.Import = bool.Parse(gridView1.GetRowCellValue(rowHandle, "Import").ToString());
                rf.Export = bool.Parse(gridView1.GetRowCellValue(rowHandle, "Export").ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            frmUpdatePermission frm = new frmUpdatePermission();
            SendData send = new SendData(frm.ReceiveData);
            send(cbUsername.Text,formName,rf);
            frm.Show();

            
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            gcPermission.DataSource = bus.ShowPermissionForm(cbUsername.Text);
        }
    }
}