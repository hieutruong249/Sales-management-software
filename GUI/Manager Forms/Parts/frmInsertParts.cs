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
    public partial class frmInsertParts : DevExpress.XtraEditors.XtraForm
    {
        public static string str;
        public void ReceiveTxtID(string textID)
        {
            str = textID;
        }
        public frmInsertParts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Partss parts = new Partss();
            parts.ID = txtID.Text;
            parts.Name = txtName.Text;
            parts.Note = txtNote.Text;

            PartsBUS partsBUS = new PartsBUS();
            partsBUS.InsertParts(parts);
        }

        private void frmInsertParts_Load(object sender, EventArgs e)
        {
            txtID.Text = str;
        }
    }
}