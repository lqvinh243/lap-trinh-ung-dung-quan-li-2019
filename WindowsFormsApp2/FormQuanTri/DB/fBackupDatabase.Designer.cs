namespace WindowsFormsApp2.FormQuanTri.DB
{
    partial class fBackupDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBackupDatabase));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.btnBackup = new XanderUI.XUIButton();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLocation = new XanderUI.XUIButton();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiFormDesign1
            // 
            this.xuiFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.ExitApplication = true;
            this.xuiFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.Material;
            this.xuiFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuiFormDesign1.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuiFormDesign1.Name = "xuiFormDesign1";
            this.xuiFormDesign1.ShowMaximize = true;
            this.xuiFormDesign1.ShowMinimize = true;
            this.xuiFormDesign1.Size = new System.Drawing.Size(800, 450);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.White;
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnBackup);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThoat);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.textBox1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnLocation);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 74);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(800, 376);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // btnBackup
            // 
            this.btnBackup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBackup.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnBackup.ButtonImage")));
            this.btnBackup.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnBackup.ButtonText = "Backup DB";
            this.btnBackup.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnBackup.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnBackup.CornerRadius = 5;
            this.btnBackup.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBackup.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnBackup.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnBackup.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnBackup.Location = new System.Drawing.Point(448, 179);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(198, 50);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnBackup.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnThoat.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ButtonImage")));
            this.btnThoat.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnThoat.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.CornerRadius = 5;
            this.btnThoat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThoat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnThoat.HoverTextColor = System.Drawing.Color.White;
            this.btnThoat.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnThoat.Location = new System.Drawing.Point(675, 309);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(113, 55);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 2;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(291, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 38);
            this.textBox1.TabIndex = 1;
            // 
            // btnLocation
            // 
            this.btnLocation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLocation.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnLocation.ButtonImage")));
            this.btnLocation.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnLocation.ButtonText = "Backup Location";
            this.btnLocation.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnLocation.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLocation.CornerRadius = 5;
            this.btnLocation.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLocation.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnLocation.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLocation.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLocation.Location = new System.Drawing.Point(87, 68);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(198, 50);
            this.btnLocation.TabIndex = 0;
            this.btnLocation.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnLocation.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // fBackupDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBackupDatabase";
            this.Text = "BackupDatabase";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.WorkingArea.PerformLayout();
            this.xuiFormDesign1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.TextBox textBox1;
        private XanderUI.XUIButton btnLocation;
        private XanderUI.XUISuperButton btnThoat;
        private XanderUI.XUIButton btnBackup;
    }
}