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
            this.CenterToParent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                Areas area = new Areas();
                area.ID = txtID.Text;
                area.Name = txtName.Text;
                area.Note = txtNote.Text;

                try
                {
                    if (areasBUS.InsertArea(area) > 0)
                    {
                        MessageBox.Show("Insert successfully!!!");

                        DataTable data = new DataTable();
                        data = areasBUS.ShowArea();
                        txtID.Text = FindNextID(data);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Fail!!!");

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsertArea_Load(object sender, EventArgs e)
        {
            txtID.Text = str;
        }

        public void ReceiveTxtID(string textID)
        {
            str = textID;
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
                txtID = "KV" + lastIndex.ToString("00000");
            }
            else
            {
                txtID = "KV00001";
            }
            return txtID;
        }
    }
}