namespace WindowsFormsApp2.FormQuanTri
{
    partial class fImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImport));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.lbLoi = new System.Windows.Forms.Label();
            this.btnImport = new XanderUI.XUISuperButton();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.btnChonfile = new XanderUI.XUIButton();
            this.lbDulieuloi = new System.Windows.Forms.Label();
            this.lbDulieuimport = new System.Windows.Forms.Label();
            this.dgvLoi = new System.Windows.Forms.DataGridView();
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiFormDesign1
            // 
            this.xuiFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.ExitApplication = true;
            this.xuiFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.MacOS;
            this.xuiFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuiFormDesign1.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuiFormDesign1.Name = "xuiFormDesign1";
            this.xuiFormDesign1.ShowMaximize = true;
            this.xuiFormDesign1.ShowMinimize = true;
            this.xuiFormDesign1.Size = new System.Drawing.Size(1293, 614);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbLoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnImport);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiClock1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThoat);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnChonfile);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbDulieuloi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbDulieuimport);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.dgvLoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.dgvImport);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1293, 575);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // lbLoi
            // 
            this.lbLoi.AutoSize = true;
            this.lbLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoi.ForeColor = System.Drawing.Color.Red;
            this.lbLoi.Location = new System.Drawing.Point(634, 28);
            this.lbLoi.Name = "lbLoi";
            this.lbLoi.Size = new System.Drawing.Size(0, 25);
            this.lbLoi.TabIndex = 8;
            // 
            // btnImport
            // 
            this.btnImport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnImport.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnImport.ButtonImage")));
            this.btnImport.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnImport.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnImport.ButtonText = "Import";
            this.btnImport.CornerRadius = 5;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImport.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnImport.HoverTextColor = System.Drawing.Color.White;
            this.btnImport.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnImport.Location = new System.Drawing.Point(854, 204);
            this.btnImport.Name = "btnImport";
            this.btnImport.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnImport.SelectedTextColor = System.Drawing.Color.White;
            this.btnImport.Size = new System.Drawing.Size(181, 46);
            this.btnImport.SuperSelected = false;
            this.btnImport.TabIndex = 7;
            this.btnImport.TextColor = System.Drawing.Color.White;
            this.btnImport.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiClock1
            // 
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.Location = new System.Drawing.Point(871, 287);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(144, 142);
            this.xuiClock1.TabIndex = 6;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnThoat.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ButtonImage")));
            this.btnThoat.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnThoat.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.CornerRadius = 5;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThoat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnThoat.HoverTextColor = System.Drawing.Color.White;
            this.btnThoat.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnThoat.Location = new System.Drawing.Point(932, 518);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(119, 54);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 5;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnChonfile
            // 
            this.btnChonfile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChonfile.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnChonfile.ButtonImage")));
            this.btnChonfile.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnChonfile.ButtonText = "Chọn file";
            this.btnChonfile.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnChonfile.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChonfile.CornerRadius = 5;
            this.btnChonfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonfile.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChonfile.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnChonfile.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChonfile.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnChonfile.Location = new System.Drawing.Point(835, 86);
            this.btnChonfile.Name = "btnChonfile";
            this.btnChonfile.Size = new System.Drawing.Size(200, 50);
            this.btnChonfile.TabIndex = 4;
            this.btnChonfile.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnChonfile.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbDulieuloi
            // 
            this.lbDulieuloi.AutoSize = true;
            this.lbDulieuloi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDulieuloi.Location = new System.Drawing.Point(1074, 25);
            this.lbDulieuloi.Name = "lbDulieuloi";
            this.lbDulieuloi.Size = new System.Drawing.Size(131, 29);
            this.lbDulieuloi.TabIndex = 3;
            this.lbDulieuloi.Text = "Dữ liệu lỗi";
            // 
            // lbDulieuimport
            // 
            this.lbDulieuimport.AutoSize = true;
            this.lbDulieuimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDulieuimport.Location = new System.Drawing.Point(189, 25);
            this.lbDulieuimport.Name = "lbDulieuimport";
            this.lbDulieuimport.Size = new System.Drawing.Size(183, 29);
            this.lbDulieuimport.TabIndex = 2;
            this.lbDulieuimport.Text = "Dữ liệu import ";
            // 
            // dgvLoi
            // 
            this.dgvLoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoi.Location = new System.Drawing.Point(1057, 86);
            this.dgvLoi.Name = "dgvLoi";
            this.dgvLoi.RowTemplate.Height = 24;
            this.dgvLoi.Size = new System.Drawing.Size(236, 489);
            this.dgvLoi.TabIndex = 1;
            // 
            // dgvImport
            // 
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Location = new System.Drawing.Point(2, 86);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.RowTemplate.Height = 24;
            this.dgvImport.Size = new System.Drawing.Size(810, 486);
            this.dgvImport.TabIndex = 0;
            // 
            // fImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 614);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fImport";
            this.Text = "fImportHs";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.WorkingArea.PerformLayout();
            this.xuiFormDesign1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.DataGridView dgvImport;
        private System.Windows.Forms.Label lbDulieuloi;
        private System.Windows.Forms.Label lbDulieuimport;
        private System.Windows.Forms.DataGridView dgvLoi;
        private XanderUI.XUIClock xuiClock1;
        private XanderUI.XUISuperButton btnThoat;
        private XanderUI.XUIButton btnChonfile;
        private XanderUI.XUISuperButton btnImport;
        private System.Windows.Forms.Label lbLoi;
    }
}