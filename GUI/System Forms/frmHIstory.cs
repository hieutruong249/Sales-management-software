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
    public partial class frmHistory : DevExpress.XtraEditors.XtraForm
    {
        public static HistoryBUS bus = new HistoryBUS();
        public static DataTable dtbl = new DataTable();

        public frmHistory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;

            dtbl = bus.ShowHistory();
            gcItems.DataSource = dtbl;
        }

        private void btnSeen_Click(object sender, EventArgs e)
        {
            dtbl = bus.ShowHistory();
            gcItems.DataSource = dtbl;
        }

        private void gcItems_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = Enabled;
            string username, namePC, time, business, action, obj = null;

            //var rowHandle = gridView1.FocusedRowHandle;
            //username = gridView1.GetRowCellValue(rowHandle, "User").ToString();
            //namePC = gridView1.GetRowCellValue(rowHandle, "Computer").ToString();
            //time = gridView1.GetRowCellValue(rowHandle, "Timer").ToString();
            //business = gridView1.GetRowCellValue(rowHandle, "Business").ToString();
            //action = gridView1.GetRowCellValue(rowHandle, "Action").ToString();
            //obj = gridView1.GetRowCellValue(rowHandle, "Object").ToString();


        }
    }
}