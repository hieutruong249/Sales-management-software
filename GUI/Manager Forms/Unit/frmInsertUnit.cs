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
            if (checkFields())
            {
                Units units = new Units();
                units.ID = txtID.Text;
                units.Name = txtName.Text;
                units.Note = txtNote.Text;

                UnitBUS unitBUS = new UnitBUS();
                try
                {
                    if (unitBUS.InsertUnit(units) > 0)
                    {
                        MessageBox.Show("Insert successfully!!!");

                        DataTable data = new DataTable();
                        data = unitBUS.ShowUnit();
                        txtID.Text = FindNextID(data);
                    }

                }
                catch
                {
                    MessageBox.Show("Insert Fail!!!");
                }
            }
           
        }

        private void frmInsertUnit_Load(object sender, EventArgs e)
        {
            txtID.Text = str;
        }

        public string FindNextID(DataTable dtbl)
        {
            string txtID = null;
            if (dtbl.Rows.Count > 0)
            {
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["ID"].ToString();
                int lastIndex = int.Parse(ma.Substring(2)) + 1;
                txtID = "DV" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "DV00001";
            }
            return txtID;
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
    }
}