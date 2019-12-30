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

        public string Path = string.Empty;

        public string Servername = "DESKTOP-CNT6SBG";
        public string Username = "sa";
        public string Password = "123";
        public string Dbname = "DG";
        public fRestoreDatabase()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
           
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
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
                Dbname = this.txtDbName.Text;
                try{
                    Server dbserver = new Server(new ServerConnection(Servername, Username, Password));

                    Restore dbRetore = new Restore() { Database = Dbname, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = true };
                    dbRetore.Devices.AddDevice(@Path, DeviceType.File);
                    dbRetore.SqlRestore(dbserver);
                    //Restore restore = new Restore();
                    //restore.Action = RestoreActionType.Database;
                    //restore.Database = Dbname;
                    //BackupDeviceItem backupDeviceItem = new BackupDeviceItem(Path, DeviceType.File);
                    //restore.Devices.Add(backupDeviceItem);
                    //restore.ReplaceDatabase = true;
                    //restore.NoRecovery = true;
                    //restore.SqlRestore(dbserver);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Messs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Restore thành công!", "Thông báo", MessageBoxButtons.OK);
            }
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
