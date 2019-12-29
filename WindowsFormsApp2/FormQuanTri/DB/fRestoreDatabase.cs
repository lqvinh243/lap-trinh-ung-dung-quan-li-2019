using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.FormQuanTri.DB
{
    public partial class fRestoreDatabase : Form
    {

        public string Path =string.Empty;

        public string Servername = "DESKTOP-CNT6SBG";
        public string Username = "sa";
        public string Password = "123";
        public string Dbname = "DB";
        public fRestoreDatabase()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            this.pcsLoadBackup.Value = 0;
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.btnRestore.Enabled = false;
            
            this.btnChonfile.Click += BtnChonfile_Click;
            this.btnRestore.Click += BtnRestore_Click;
            this.txtPath.TextChanged += TxtPath_TextChanged;
            this.btnThoat.Click += BtnThoat_Click;

            
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPath_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPath.TextLength > 0)
            {
                Path = this.txtPath.Text;
                this.btnRestore.Enabled = true;
            }
            else
            {
                Path = string.Empty;
                this.btnRestore.Enabled = false;
            }
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            if (Path.Length > 0)
            {
                try
                {
                    Server dbserver = new Server(new ServerConnection(Servername,Username,Password));
                    Restore dbRetore = new Restore() { Database = Dbname, Action = RestoreActionType.Database, ReplaceDatabase = true ,NoRecovery = false};
                    dbRetore.Devices.AddDevice(@"" + txtPath.Text, DeviceType.File);
                    dbRetore.PercentComplete += DbRetore_PercentComplete;
                    dbRetore.Complete += DbRetore_Complete;
                    dbRetore.SqlRestoreAsync(dbserver);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Messs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DbRetore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lbStatus.Invoke((MethodInvoker)delegate
                {
                    lbStatus.Text = e.Error.Message;
                });
            }
        }

        private void DbRetore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            pcsLoadBackup.Invoke((MethodInvoker)delegate
            {
                pcsLoadBackup.Value = e.Percent;
                pcsLoadBackup.Update();
            });

            pcsLoadBackup.Invoke((MethodInvoker)delegate
            {
                lbPercent.Text = $"{e.Percent}%";
            });
        }

        private void BtnChonfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = "C:\\";
            openFile.Filter = "SQL Server database Restore files|*.bak";
            openFile.Title = "Restore Database";
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.txtPath.Text = openFile.FileName;
            }
        }
    }
}
