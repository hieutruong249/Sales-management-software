using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using GUI.Manager_Forms;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Timer timer = new Timer();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.Show();
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult h = MessageBox.Show("Do you wat exit program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmProduct frm = new frmProduct();
            //this.Hide();
            //frm.Show();
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucProduct uc = new ucProduct();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void btnChange_password_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.Show();
        }

        private void btnArea_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            uc1 uc = new uc1();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void btnCustomers_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucCustomer uc = new ucCustomer();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void btnWarehouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucWarehouse uc = new ucWarehouse();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void btnUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucUnit uc = new ucUnit();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void btnExchange_rate_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucExRate uc = new ucExRate();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbNamePC.Caption = SystemInformation.ComputerName;
            lbdate.Caption =   DateTime.Today.ToString("dd/MM/yyyy");

            lbTime.Caption = DateTime.Now.ToString("HH:mm:ss tt");
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 1000;
            timer.Enabled = true;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Caption = DateTime.Now.ToString("HH:mm:ss tt");
        }


        private void btnRegister_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.Show();
        }

        private void btnPermission_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnSuppliers_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucSupplier uc = new ucSupplier();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void btnGroup_product_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucCatergory uc = new ucCatergory();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void btnStaffs_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucStaff uc = new ucStaff();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void btnParts_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucParts uc = new ucParts();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }
    }
        
}