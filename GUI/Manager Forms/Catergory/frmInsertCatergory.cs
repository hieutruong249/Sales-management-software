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
            this.CenterToParent();
        }
        private void frmInsertCatergory_Load(object sender, EventArgs e)
        {
            txtID.Text = str;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                Categories categories = new Categories();
                categories.CategoryID = txtID.Text;
                categories.CategoryName = txtName.Text;
                categories.Note = txtNote.Text;

                CategoryBUS categoryBUS = new CategoryBUS();
                try
                {
                    if (categoryBUS.InserCategory(categories) > 0)
                    {
                        MessageBox.Show("Insert successfully!!!");

                        DataTable data = new DataTable();
                        data = categoryBUS.ShowCatergories();
                        txtID.Text = FindNextID(data);
                    }

                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Insert Fail!!!");

                }
            }
            
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool checkFields()
        {
            var name = new RequiredFieldValidator();
            name.ControlToValidate = txtName;

            if (!name.Validate())
            {
                txtName.Focus();
                return false;
            }
            return true;
        }

        public string FindNextID(DataTable dtbl)
        {

            string txtID = null;
            if (dtbl.Rows.Count > 0)
            {
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["CatID"].ToString();
                int lastIndex = int.Parse(ma.Substring(2)) + 1;
                txtID = "PL" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "PL00001";
            }
            return txtID;
        }

        public void ReceiveTxtID(string textID)
        {
            str = textID;
        }


    }
}