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
    public partial class frmInsertCatergory : DevExpress.XtraEditors.XtraForm
    {
        public static string str;
        public frmInsertCatergory()
        {
            InitializeComponent();
        }
        public void ReceiveTxtID(string textID)
        {
            str = textID;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.CategoryID = txtID.Text;
            categories.CategoryName = txtName.Text;
            categories.Note = txtNote.Text;

            CategoryBUS categoryBUS = new CategoryBUS();
            categoryBUS.InserCategory(categories);
        }

        private void frmInsertCatergory_Load(object sender, EventArgs e)
        {
            txtID.Text = str;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}