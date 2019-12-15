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
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace GUI
{
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string Servername = @"DESKTOP-59A5HQG\SQLEXPRESS";
            string dataBaseName = "QLBH_v1";
            pBProcessBar.Value = 0;
            try 
            {
                Server dbServer = new Server(new ServerConnection(Servername));
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = dataBaseName };
                dbBackup.Devices.AddDevice(@"C:\Data\database.bak",DeviceType.File);
                dbBackup.Initialize = true;
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += Dbbackup_Complete;
                dbBackup.SqlBackupAsync(dbServer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dbbackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if(e.Error != null)
            {
                lbPer.Invoke((MethodInvoker)delegate 
                {
                    lbPer.Text = e.Error.Message;
                });
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            pBProcessBar.Invoke((MethodInvoker)delegate
            {
                pBProcessBar.Value = e.Percent;
                pBProcessBar.Update();
            });
            lbPer.Invoke((MethodInvoker)delegate
            {
                lbPer.Text = $"{e.Percent}%";
            });
        }
    }
}