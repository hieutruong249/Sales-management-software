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
using DTO;
using BUS;

namespace GUI.Manager_Forms.Area
{
    public partial class frmUpdateArea : DevExpress.XtraEditors.XtraForm
    {
        AreasBUS areasBUS = new AreasBUS();
        public static Areas area = new Areas();
        public frmUpdateArea()
        {
            InitializeComponent();
        }
        public void ReceiveData(Areas a)
        {
            area = a;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            area.ID = txtID.Text;
            area.Name = txtName.Text;
            area.Note = txtNote.Text;

            areasBUS.InsertArea(area);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateArea_Load(object sender, EventArgs e)
        {
            txtID.Text = area.ID;
            txtName.Text = area.Name;
            txtNote.Text = area.Note;
        }
    }
}