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
    public partial class frmInsertUnit : DevExpress.XtraEditors.XtraForm
    {
        public static string str;
        public void ReceiveTxtID(string textID)
        {
            str = textID;
        }
        public frmInsertUnit()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Units units = new Units();
            units.ID = txtID.Text;
            units.Name = txtName.Text;
            units.Note = txtNote.Text;

            UnitBUS unitBUS = new UnitBUS();
            unitBUS.InsertUnit(units);
        }

        private void frmInsertUnit_Load(object sender, EventArgs e)
        {
            txtID.Text = str;
        }
    }
}