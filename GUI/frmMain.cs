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
using GUI.Business.SaleProduct;
using GUI.Business.Collect_Monney;
using GUI.Business.BuyProduct;
using GUI.Help;
using System.Diagnostics;

using GUI.Manager_Forms.Catergory;
using GUI.Manager_Forms.Customer;
using GUI.Manager_Forms.ExRate;
using GUI.Manager_Forms.Parts;
using GUI.Manager_Forms.Product;
using GUI.Manager_Forms.Staff;
using GUI.Manager_Forms.Supplier;
using GUI.Manager_Forms.Unit;
using GUI.Manager_Forms.Warehouse;
using DTO;


namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Timer timer = new Timer();
        public static FormCollection fc = Application.OpenForms;

        public frmMain()
        {
            InitializeComponent();
        }

        private bool IsFormActived(Form form)
        {

            bool IsOpenend = false;
            //If there is more than one form opened
            if (MdiChildren.Count() > 0)
            {
                foreach (Form frm in fc)
                {
                    //iterate through
                    if (frm.Name == form.Name)
                    {
                        //Active this form
                        IsOpenend = true;
                    }
                }
            }
            return IsOpenend;
        }

        public void ShowForm(Form frm)
        {
            if (!IsFormActived(frm))
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            GlobalVar.dicmyRoleForm.Clear();

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
            frmProduct1 frm = new frmProduct1();
            ShowForm(frm);
        }

        private void btnChange_password_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.Show();
        }

        private void btnArea_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmArea frm = new frmArea();
            ShowForm(frm);
        }

        private void btnCustomers_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            ShowForm(frm);
        }

        private void btnWarehouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmWarehouse frm = new frmWarehouse();
            ShowForm(frm);
        }

        private void btnUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUnit frm = new frmUnit();
            ShowForm(frm);
        }

        private void btnExchange_rate_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmExRate frm = new frmExRate();
            ShowForm(frm);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbNamePC.Caption = SystemInformation.ComputerName;
            if (GlobalVar._username != null)
            {
                lbUsername.Caption = GlobalVar._username;
            }
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
            frmPermission frm = new frmPermission();
            ShowForm(frm);
        }

        private void btnSuppliers_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSupplier frm = new frmSupplier();
            ShowForm(frm);
        }

        private void btnGroup_product_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCategory frm = new frmCategory();
            ShowForm(frm);
        }

        private void btnStaffs_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStaff frm = new frmStaff();
            ShowForm(frm);
        }

        private void btnParts_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPart frm = new frmPart();
            ShowForm(frm);
        }

        private void pcMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrders_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBuyProduct frm = new frmBuyProduct();
            ShowForm(frm);
        }

        private void btnSales_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            frmSellProduct frm = new frmSellProduct();
            ShowForm(frm);
        }

        private void btnCollect_money_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCollectMoney frm = new frmCollectMoney();
            ShowForm(frm);
        }

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.Show();
        }

        private void btnContact_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(@"C:\Program Files(x86)\TeamViewer\TeamViewer.exe");
                info.Arguments = "-silent";
                Process.Start(info);
            }
            catch (Exception ex)
            {
                DialogResult h = MessageBox.Show("Sorry can't open TeamViewer!!!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void btnUsermanual_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Process.Start("http://www.perfect.com.vn/huong-dan-su-dung-phan-mem-quan-ly-ban-hang.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry can't open Browser!!!");
            }
        }

        private void btnInformation_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.Show();
        }

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBackup frm = new frmBackup();
            frm.Show();
        }

        private void btnHistory_systerm_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHistory frm = new frmHistory();
            ShowForm(frm);
        }

        private void btnReportWarehouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReportWarehouse frm = new frmReportWarehouse();
            ShowForm(frm);
        }
    }
        
}