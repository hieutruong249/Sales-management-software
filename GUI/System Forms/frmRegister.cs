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

namespace GUI
{
    public partial class frmRegister : DevExpress.XtraEditors.XtraForm
    {
        UserBUS bll_User = new UserBUS();
        public frmRegister()
        {
            InitializeComponent();
            this.CenterToParent();
        }

       
        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
            txtName.ResetText();
            txtEmail.ResetText();
            txtDoB.ResetText(); 
        }
        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User us = new User();
            if (checkFields())
            {
                us.Username = txtUsername.Text;
                us.Password = txtPassword.Text;
                us.Name = txtName.Text;
                us.Email = txtEmail.Text;
                us.DoB = txtDoB.Text;
                MessageBox.Show(txtDoB.Text);

                //if (bll_User.InsertUser(us) != 0)
                //{
                //    MessageBox.Show("Register successfully");
                //}
                //else
                //{
                //    MessageBox.Show("ERROR", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }
        }

        public bool checkFields()
        {
            var Username = new CheckUserName();
            Username.ControlToValidate = txtUsername;

            var Password = new CheckPassword();
            Password.ControlToValidate = txtPassword;

            var Name = new CheckName();
            Name.ControlToValidate = txtName;

            var Email = new CheckEmail();
            Email.ControlToValidate = txtEmail;

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
            else if (!Name.Validate())
            {
                txtName.Focus();
                return false;
            }
            else if (!Email.Validate())
            {
                txtEmail.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtDoB.Text))
            {
                MessageBox.Show("DOB is Null!!");
                txtDoB.Focus();
                return false;
            }
            //else if (!checkDOB())
            //{
            //    MessageBox.Show("Date invalid!");
            //    mtxtDOB.ResetText();
            //    mtxtDOB.Focus();
            //    return false;
            //}
            return true;
        }
    }
}