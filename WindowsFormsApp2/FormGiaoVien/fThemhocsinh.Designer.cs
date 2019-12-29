namespace WindowsFormsApp2.FormGiaoVien
{
    partial class fThemhocsinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemhocsinh));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.dgvDaco = new System.Windows.Forms.DataGridView();
            this.lbLoc = new System.Windows.Forms.Label();
            this.txtKhoikythi = new System.Windows.Forms.TextBox();
            this.lbKhoikythi = new System.Windows.Forms.Label();
            this.txtIDkythi = new System.Windows.Forms.TextBox();
            this.lbIDKythi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKhoimade = new System.Windows.Forms.Label();
            this.cbbIDMade = new System.Windows.Forms.ComboBox();
            this.cbbKhoimade = new System.Windows.Forms.ComboBox();
            this.btnThem = new XanderUI.XUIButton();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.lbKhoi = new System.Windows.Forms.Label();
            this.cbbKhoi = new System.Windows.Forms.ComboBox();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.dgvHocsinh = new System.Windows.Forms.DataGridView();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocsinh)).BeginInit();
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
            this.xuiFormDesign1.Size = new System.Drawing.Size(1210, 648);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.White;
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.dgvDaco);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbLoc);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.txtKhoikythi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbKhoikythi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.txtIDkythi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbIDKythi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.panel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.label1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbKhoimade);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.cbbIDMade);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.cbbKhoimade);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThem);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiClock1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbKhoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.cbbKhoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThoat);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.dgvHocsinh);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 74);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1210, 574);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // dgvDaco
            // 
            this.dgvDaco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaco.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDaco.Location = new System.Drawing.Point(494, 0);
            this.dgvDaco.Name = "dgvDaco";
            this.dgvDaco.RowTemplate.Height = 24;
            this.dgvDaco.Size = new System.Drawing.Size(275, 574);
            this.dgvDaco.TabIndex = 18;
            // 
            // lbLoc
            // 
            this.lbLoc.AutoSize = true;
            this.lbLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoc.Location = new System.Drawing.Point(950, 42);
            this.lbLoc.Name = "lbLoc";
            this.lbLoc.Size = new System.Drawing.Size(134, 24);
            this.lbLoc.TabIndex = 17;
            this.lbLoc.Text = "Lọc danh sách";
            // 
            // txtKhoikythi
            // 
            this.txtKhoikythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoikythi.Location = new System.Drawing.Point(837, 328);
            this.txtKhoikythi.Name = "txtKhoikythi";
            this.txtKhoikythi.Size = new System.Drawing.Size(118, 27);
            this.txtKhoikythi.TabIndex = 16;
            // 
            // lbKhoikythi
            // 
            this.lbKhoikythi.AutoSize = true;
            this.lbKhoikythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoikythi.Location = new System.Drawing.Point(833, 288);
            this.lbKhoikythi.Name = "lbKhoikythi";
            this.lbKhoikythi.Size = new System.Drawing.Size(95, 24);
            this.lbKhoikythi.TabIndex = 15;
            this.lbKhoikythi.Text = "Khối kỳ thi";
            // 
            // txtIDkythi
            // 
            this.txtIDkythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDkythi.Location = new System.Drawing.Point(837, 248);
            this.txtIDkythi.Name = "txtIDkythi";
            this.txtIDkythi.Size = new System.Drawing.Size(118, 27);
            this.txtIDkythi.TabIndex = 14;
            // 
            // lbIDKythi
            // 
            this.lbIDKythi.AutoSize = true;
            this.lbIDKythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDKythi.Location = new System.Drawing.Point(833, 208);
            this.lbIDKythi.Name = "lbIDKythi";
            this.lbIDKythi.Size = new System.Drawing.Size(74, 24);
            this.lbIDKythi.TabIndex = 13;
            this.lbIDKythi.Text = "ID kỳ thi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(790, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 2);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1019, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Mã đề";
            // 
            // lbKhoimade
            // 
            this.lbKhoimade.AutoSize = true;
            this.lbKhoimade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoimade.Location = new System.Drawing.Point(1019, 208);
            this.lbKhoimade.Name = "lbKhoimade";
            this.lbKhoimade.Size = new System.Drawing.Size(107, 24);
            this.lbKhoimade.TabIndex = 10;
            this.lbKhoimade.Text = "Khối mã đề";
            // 
            // cbbIDMade
            // 
            this.cbbIDMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbIDMade.FormattingEnabled = true;
            this.cbbIDMade.Location = new System.Drawing.Point(1023, 326);
            this.cbbIDMade.Name = "cbbIDMade";
            this.cbbIDMade.Size = new System.Drawing.Size(121, 28);
            this.cbbIDMade.TabIndex = 9;
            // 
            // cbbKhoimade
            // 
            this.cbbKhoimade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoimade.FormattingEnabled = true;
            this.cbbKhoimade.Location = new System.Drawing.Point(1023, 248);
            this.cbbKhoimade.Name = "cbbKhoimade";
            this.cbbKhoimade.Size = new System.Drawing.Size(121, 28);
            this.cbbKhoimade.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThem.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ButtonImage")));
            this.btnThem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnThem.ButtonText = "Thêm học sinh";
            this.btnThem.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnThem.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.CornerRadius = 5;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnThem.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThem.Location = new System.Drawing.Point(875, 393);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(200, 50);
            this.btnThem.TabIndex = 7;
            this.btnThem.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.xuiClock1.Location = new System.Drawing.Point(803, 42);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(120, 130);
            this.xuiClock1.TabIndex = 6;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // lbKhoi
            // 
            this.lbKhoi.AutoSize = true;
            this.lbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoi.Location = new System.Drawing.Point(944, 84);
            this.lbKhoi.Name = "lbKhoi";
            this.lbKhoi.Size = new System.Drawing.Size(48, 24);
            this.lbKhoi.TabIndex = 4;
            this.lbKhoi.Text = "Khối";
            // 
            // cbbKhoi
            // 
            this.cbbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoi.FormattingEnabled = true;
            this.cbbKhoi.Location = new System.Drawing.Point(1032, 80);
            this.cbbKhoi.Name = "cbbKhoi";
            this.cbbKhoi.Size = new System.Drawing.Size(121, 28);
            this.cbbKhoi.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnThoat.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ButtonImage")));
            this.btnThoat.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnThoat.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.CornerRadius = 5;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThoat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnThoat.HoverTextColor = System.Drawing.Color.White;
            this.btnThoat.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnThoat.Location = new System.Drawing.Point(1044, 475);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 1;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // dgvHocsinh
            // 
            this.dgvHocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocsinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvHocsinh.Location = new System.Drawing.Point(0, 0);
            this.dgvHocsinh.Name = "dgvHocsinh";
            this.dgvHocsinh.RowTemplate.Height = 24;
            this.dgvHocsinh.Size = new System.Drawing.Size(494, 574);
            this.dgvHocsinh.TabIndex = 0;
            // 
            // fThemhocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 648);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fThemhocsinh";
            this.Text = "fThemhocsinh";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.WorkingArea.PerformLayout();
            this.xuiFormDesign1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocsinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.Label lbLoc;
        private System.Windows.Forms.TextBox txtKhoikythi;
        private System.Windows.Forms.Label lbKhoikythi;
        private System.Windows.Forms.TextBox txtIDkythi;
        private System.Windows.Forms.Label lbIDKythi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbKhoimade;
        private System.Windows.Forms.ComboBox cbbIDMade;
        private System.Windows.Forms.ComboBox cbbKhoimade;
        private XanderUI.XUIButton btnThem;
        private XanderUI.XUIClock xuiClock1;
        private System.Windows.Forms.Label lbKhoi;
        private System.Windows.Forms.ComboBox cbbKhoi;
        private XanderUI.XUISuperButton btnThoat;
        private System.Windows.Forms.DataGridView dgvHocsinh;
        private System.Windows.Forms.DataGridView dgvDaco;
    }
}