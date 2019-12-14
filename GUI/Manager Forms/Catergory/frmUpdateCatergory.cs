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

namespace GUI.Manager_Forms.Catergory
{
    public partial class frmUpdateCatergory : DevExpress.XtraEditors.XtraForm
    {
        public static Categories categorie = new Categories();

        public frmUpdateCatergory()
        {
            InitializeComponent();
            this.CenterToParent();
        }
        public void ReceiveData(Categories c)
        {
            categorie = c;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmUpdateCatergory_Load(object sender, EventArgs e)
        {
            txtID.Text = categorie.CategoryID;
            txtName.Text = categorie.CategoryName;
            txtNote.Text = categorie.Note;
        }
    }
}