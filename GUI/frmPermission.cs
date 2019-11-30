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
    public partial class frmPermission : DevExpress.XtraEditors.XtraForm
    {
        public frmPermission()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_v1DataSet.Permission' table. You can move, or remove it, as needed.
            this.permissionTableAdapter.Fill(this.qLBH_v1DataSet.Permission);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}