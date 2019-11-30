using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI
{
    public abstract partial class ucFather : DevExpress.XtraEditors.XtraUserControl
    {
        public string NamePC { get; set; }
        public string FormName { get; set; }
        public string Action { get; set; }
        public string timelog { get; set; }
        public ucFather()
        {
            InitializeComponent();
        }

        private void ucFather_Load(object sender, EventArgs e)
        {
            //NamePC = SystemInformation.ComputerName;
            //Action = "seen";
            //timelog = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            //MessageBox.Show(NamePC + " " + timelog + " " + this.Tag.ToString() + " " +  Action);
        }
       

        
    }
}
