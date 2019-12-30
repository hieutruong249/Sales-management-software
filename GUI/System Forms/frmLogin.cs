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

namespace GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        UserBUS usB = new UserBUS();
        RoleFormBUS roleFormBUS = new RoleFormBUS();
        public frmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.KeyPreview = true;
            
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            txtUsername.Select();
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                User us = new User();
                us.Username = txtUsername.Text;
                us.Password = txtPassword.Text;
                try
                {
                    if (usB.IsLoginSuccess(us) != 0)
                    {
                        var rol = usB.UsrRolFrm(us);
                        var lst = roleFormBUS.GetListRole(rol.RoleId);
                        foreach (var rolFrm in lst)
                        {
                            GlobalVar.dicmyRoleForm.Add(rolFrm.FormID, rolFrm);
                        }

                        MessageBox.Show("Login successfully" + rol.RoleId);
                        GlobalVar._username = txtUsername.Text;
                        frmMain frm = new frmMain();
                        this.Hide();
                        frm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Login Fail!!!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            this.Hide();
            frm.Show();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
                //btnLogin_Click(new object(), new EventArgs());
                btnLogin.PerformClick();
            }
        }

        public bool checkFields()
        {
            var Username = new CheckUserName();
            Username.ControlToValidate = txtUsername;

            var Password = new CheckPassword();
            Password.ControlToValidate = txtPassword;

            if (!Username.Validate())
            {
                txtUsername.Focus();
                return false;
            }
            else if (!Password.Validate())
            {
                txtPassword.Focus();
                return false;
            }

            return true;
        }

    }
}