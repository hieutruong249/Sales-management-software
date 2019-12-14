using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI.Business.Collect_Monney
{
    public partial class ucCollect : DevExpress.XtraEditors.XtraUserControl
    {
        public ucCollect()
        {
            InitializeComponent();

            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucDetailedDebt uc = new ucDetailedDebt();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void pcMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucReceiptCollectMoney uc = new ucReceiptCollectMoney();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucTrackCookDebt uc = new ucTrackCookDebt();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucDetailedDebt uc = new ucDetailedDebt();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucCouponsImmediately uc = new ucCouponsImmediately();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;

            ucAggregateDebt uc = new ucAggregateDebt();
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
