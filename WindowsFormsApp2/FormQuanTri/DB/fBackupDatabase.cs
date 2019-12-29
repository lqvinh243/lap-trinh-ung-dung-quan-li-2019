using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace WindowsFormsApp2.FormQuanTri.DB
{
    public partial class fBackupDatabase : Form
    {
        string dbname = "DC";
        string destpath = string.Empty;
        string Servername = "DESKTOP-CNT6SBG";
        string Username = "sa";
        string Password = "123";
        public fBackupDatabase()
        {
            InitializeComponent();

            Load += LoadControl;
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.textBox1.Enabled = false;
            this.btnBackup.Enabled = false;

            this.btnLocation.Click += BtnLocation_Click;
            this.btnThoat.Click += XuiSuperButton1_Click;
            this.btnBackup.Click += BtnBackup_Click;


            this.textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 0)
            {
                destpath = string.Empty;
                this.btnBackup.Enabled = false;
            }
            else
            {
                this.btnBackup.Enabled = true;
                destpath = textBox1.Text;
            }
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(destpath) || string.IsNullOrWhiteSpace(dbname))
                {
                    MessageBox.Show("Chọn vị trí backup!");
                    return;
                }

                Backup backup = new Backup();
                backup.Action = BackupActionType.Database;
                backup.BackupSetDescription = "Backup of :" + dbname + " on" + DateTime.Now.ToShortDateString();
                backup.BackupSetName = "Fullbackup";
                backup.Database = dbname;

                string Backupfilename = dbname + ".bak";
                BackupDeviceItem deviceItem = new BackupDeviceItem(destpath + "\\" + Backupfilename, DeviceType.File);
                ServerConnection connection = new ServerConnection(Servername, Username, Password);
                Server server = new Server(connection);
                server.ConnectionContext.StatementTimeout = 60 * 60;
                Database db = server.Databases[dbname];
/////// đợi chút coi này rồi đi tắm ò
                backup.Incremental = true;
                backup.Checksum = true;
                backup.ContinueAfterError = true;

                backup.Devices.Add(deviceItem);
                backup.Incremental = false;

                backup.ExpirationDate = DateTime.Now.AddDays(3);
                backup.LogTruncation = BackupTruncateLogType.Truncate;

                backup.FormatMedia = false;
                backup.SqlBackup(server);

                backup.Devices.Remove(deviceItem);
                

                MessageBox.Show("Backup successfully!");
                connection.Disconnect();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Backup Errr,choose another location!");
            }

        }

        private void XuiSuperButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog  ofd = new FolderBrowserDialog();

            ofd.ShowNewFolderButton = true;
            DialogResult dl = ofd.ShowDialog();
            if(dl == DialogResult.OK)
            {
                this.textBox1.Text = ofd.SelectedPath;
                Environment.SpecialFolder root = ofd.RootFolder;
            }
        }
    }
}
