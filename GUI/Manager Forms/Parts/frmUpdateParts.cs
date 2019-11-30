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

namespace GUI.Manager_Forms.Parts
{
    public partial class frmUpdateParts : DevExpress.XtraEditors.XtraForm
    {
        public static Partss parts = new Partss();
        public void ReceiveData(Partss p)
        {
            parts = p;
        }
        public frmUpdateParts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            parts.ID = txtID.Text;
            parts.Name = txtName.Text;
            parts.Note = txtNote.Text;

            PartsBUS partsBUS = new PartsBUS();
            partsBUS.UpdateParts(parts);
        }

        private void frmUpdateParts_Load(object sender, EventArgs e)
        {
            txtID.Text = parts.ID;
            txtName.Text = parts.Name;
            txtNote.Text = parts.Note;
        }
    }
}