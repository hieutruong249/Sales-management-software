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
using GUI.Business.Collect_Monney;

namespace GUI
{
    public partial class frmCollectMoney : DevExpress.XtraEditors.XtraForm
    {
        public frmCollectMoney()
        {
            InitializeComponent();
        }

        public void ShowUserControl(UserControl uc)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void frmCollectMoney_Load(object sender, EventArgs e)
        {
            ucDetailedDebt uc = new ucDetailedDebt();
            ShowUserControl(uc);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucReceiptCollectMoney uc = new ucReceiptCollectMoney();
            ShowUserControl(uc);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucDetailedDebt uc = new ucDetailedDebt();
            ShowUserControl(uc);

        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucCouponsImmediately uc = new ucCouponsImmediately();
            ShowUserControl(uc);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucTrackCookDebt uc = new ucTrackCookDebt();
            ShowUserControl(uc);
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucAggregateDebt uc = new ucAggregateDebt();
            ShowUserControl(uc);
        }
    }
}