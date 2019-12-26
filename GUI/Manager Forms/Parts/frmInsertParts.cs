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
                Partss parts = new Partss();
                parts.ID = txtID.Text;
                parts.Name = txtName.Text;
                parts.Note = txtNote.Text;

                PartsBUS partsBUS = new PartsBUS();
                try
                {
                    if (partsBUS.InsertParts(parts) > 0)
                    {
                        MessageBox.Show("Insert successfully!!!");

                        DataTable data = new DataTable();
                        data = partsBUS.ShowParts();
                        txtID.Text = FindNextID(data);
                    }
                }
                catch
                {
                    MessageBox.Show("Insert Fail!!!");
                }
            }
           
        }

        private void frmInsertParts_Load(object sender, EventArgs e)
        {
            txtID.Text = str;
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
                string ma = dtbl.Rows[dtbl.Rows.Count - 1]["ID"].ToString();
                int lastIndex = int.Parse(ma.Substring(2)) + 1;
                txtID = "BP" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "BP00001";
            }
            return txtID;
        }
    }
}