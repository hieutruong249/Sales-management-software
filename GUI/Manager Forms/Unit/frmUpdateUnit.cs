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

namespace GUI.Manager_Forms.Unit
{
    public partial class frmUpdateUnit : DevExpress.XtraEditors.XtraForm
    {
        public static Units unit = new Units();
        public void ReceiveData(Units u)
        {
            unit = u;
        }
        public frmUpdateUnit()
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
            unit.ID = txtID.Text;
            unit.Name = txtName.Text;
            unit.Note = txtNote.Text;

            UnitBUS unitBUS = new UnitBUS();
            unitBUS.UpdateUnit(unit);
        }

        private void frmUpdateUnit_Load(object sender, EventArgs e)
        {
            txtID.Text = unit.ID;
            txtName.Text = unit.Name;
            txtNote.Text = unit.Note;
        }
    }
}