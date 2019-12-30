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
using GUI.Manager_Forms.Customer;
using GUI.Manager_Forms.Catergory;
using GUI.Manager_Forms.ExRate;


namespace GUI
{
    public partial class frmInputNameFile : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendFileName(String str);
        public static int tag = 0; //Tag of form required

        public frmInputNameFile()
        {
            InitializeComponent();
            this.CenterToParent();
            this.KeyPreview = true;
            txtFileName.Select();

        }

        private void frmInputNameFile_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtFileName.ResetText();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                CheckTag(tag);
               
                this.Close();
            }
        }

        private void frmInputNameFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1.Focus();
                simpleButton1.PerformClick();
            }
        }

        public bool checkFields()
        {
            var Filename = new CheckName();
            Filename.ControlToValidate = txtFileName;
           
            if (!Filename.Validate())
            {
                txtFileName.Focus();
                return false;
            }

            return true;
        }

        public void ReceiveTag(int num)
        {
            tag = num;
        }

        public void CheckTag(int tag)
        {
            if(tag == 6)
            {
                frmArea frm = new frmArea();
                SendFileName send = new SendFileName(frm.ReceiveFileName);
                send(txtFileName.Text);
            }
            else if (tag == 7)
            {
                frmCategory frm = new frmCategory();
                SendFileName send = new SendFileName(frm.ReceiveFileName);
                send(txtFileName.Text);
            }
            else if (tag == 8)
            {
                frmCustomer frm = new frmCustomer();
                SendFileName send = new SendFileName(frm.ReceiveFileName);
                send(txtFileName.Text);
            }
            else if (tag == 9)
            {
                frmExRate frm = new frmExRate();
                SendFileName send = new SendFileName(frm.ReceiveFileName);
                send(txtFileName.Text);
            }

        }
    }
}