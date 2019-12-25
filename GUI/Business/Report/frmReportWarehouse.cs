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

namespace GUI
{
    public partial class frmReportWarehouse : DevExpress.XtraEditors.XtraForm
    {
        public frmReportWarehouse()
        {
            InitializeComponent();
        }

        private void frmReportWarehouse_Load(object sender, EventArgs e)
        {
        }

        public void ShowUserControl(UserControl uc)
        {
            pcMain.Controls.Clear();
            pcMain.Dock = DockStyle.Fill;
            uc.Dock = DockStyle.Fill;
            pcMain.Controls.Add(uc);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucGeneralInventory uc = new ucGeneralInventory();
            ShowUserControl(uc);
        }
    }
}