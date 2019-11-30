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

namespace GUI
{
    public partial class frmInsertArea : DevExpress.XtraEditors.XtraForm
    {
        AreasBUS areasBUS = new AreasBUS();
        public static string str;
        
        public frmInsertArea()
        {
            InitializeComponent();
        }
        public void ReceiveTxtID(string textID)
        {
            str = textID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Areas area = new Areas();
            area.ID = txtID.Text;
            area.Name = txtName.Text;
            area.Note = txtNote.Text;

            areasBUS.InsertArea(area);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsertArea_Load(object sender, EventArgs e)
        {
            txtID.Text = str;
        }
    }
}