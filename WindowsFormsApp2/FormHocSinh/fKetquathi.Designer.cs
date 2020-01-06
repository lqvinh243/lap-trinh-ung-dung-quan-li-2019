namespace WindowsFormsApp2.FormHocSinh
{
    partial class fKetquathi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fKetquathi));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.btnThoat = new XanderUI.XUIButton();
            this.btnPre = new XanderUI.XUISuperButton();
            this.btnNext = new XanderUI.XUISuperButton();
            this.lbDiemso = new System.Windows.Forms.Label();
            this.lbMade = new System.Windows.Forms.Label();
            this.lbKythi = new System.Windows.Forms.Label();
            this.txtDiemso = new System.Windows.Forms.TextBox();
            this.txtMade = new System.Windows.Forms.TextBox();
            this.txtKythi = new System.Windows.Forms.TextBox();
            this.txtNgaythi = new System.Windows.Forms.TextBox();
            this.pnThanhngang = new System.Windows.Forms.Panel();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.btnHuytimkiem = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimkiem = new XanderUI.XUIButton();
            this.dtpNgaythi = new System.Windows.Forms.DateTimePicker();
            this.bnKetquathi = new XanderUI.XUIBanner();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiSlidingPanel1.SuspendLayout();
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
            this.xuiFormDesign1.Size = new System.Drawing.Size(800, 450);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiGradientPanel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiSlidingPanel1);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(800, 411);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Yellow;
            this.xuiGradientPanel1.Controls.Add(this.btnThoat);
            this.xuiGradientPanel1.Controls.Add(this.btnPre);
            this.xuiGradientPanel1.Controls.Add(this.btnNext);
            this.xuiGradientPanel1.Controls.Add(this.lbDiemso);
            this.xuiGradientPanel1.Controls.Add(this.lbMade);
            this.xuiGradientPanel1.Controls.Add(this.lbKythi);
            this.xuiGradientPanel1.Controls.Add(this.txtDiemso);
            this.xuiGradientPanel1.Controls.Add(this.txtMade);
            this.xuiGradientPanel1.Controls.Add(this.txtKythi);
            this.xuiGradientPanel1.Controls.Add(this.txtNgaythi);
            this.xuiGradientPanel1.Controls.Add(this.pnThanhngang);
            this.xuiGradientPanel1.Controls.Add(this.xuiClock1);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(236, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(564, 411);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 1;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.SystemColors.ButtonShadow;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnThoat.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ButtonImage")));
            this.btnThoat.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnThoat.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnThoat.CornerRadius = 5;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThoat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnThoat.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnThoat.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThoat.Location = new System.Drawing.Point(441, 358);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 50);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnPre
            // 
            this.btnPre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnPre.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPre.ButtonImage")));
            this.btnPre.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnPre.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnPre.ButtonText = "Pre";
            this.btnPre.CornerRadius = 5;
            this.btnPre.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPre.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnPre.HoverTextColor = System.Drawing.Color.White;
            this.btnPre.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnPre.Location = new System.Drawing.Point(54, 339);
            this.btnPre.Name = "btnPre";
            this.btnPre.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnPre.SelectedTextColor = System.Drawing.Color.White;
            this.btnPre.Size = new System.Drawing.Size(100, 40);
            this.btnPre.SuperSelected = false;
            this.btnPre.TabIndex = 15;
            this.btnPre.TextColor = System.Drawing.Color.White;
            this.btnPre.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnNext.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnNext.ButtonImage")));
            this.btnNext.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnNext.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnNext.ButtonText = "Next";
            this.btnNext.CornerRadius = 5;
            this.btnNext.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNext.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnNext.HoverTextColor = System.Drawing.Color.White;
            this.btnNext.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnNext.Location = new System.Drawing.Point(213, 339);
            this.btnNext.Name = "btnNext";
            this.btnNext.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnNext.SelectedTextColor = System.Drawing.Color.White;
            this.btnNext.Size = new System.Drawing.Size(100, 40);
            this.btnNext.SuperSelected = false;
            this.btnNext.TabIndex = 14;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbDiemso
            // 
            this.lbDiemso.AutoSize = true;
            this.lbDiemso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemso.Location = new System.Drawing.Point(29, 264);
            this.lbDiemso.Name = "lbDiemso";
            this.lbDiemso.Size = new System.Drawing.Size(102, 29);
            this.lbDiemso.TabIndex = 13;
            this.lbDiemso.Text = "Điểm số";
            // 
            // lbMade
            // 
            this.lbMade.AutoSize = true;
            this.lbMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMade.Location = new System.Drawing.Point(29, 211);
            this.lbMade.Name = "lbMade";
            this.lbMade.Size = new System.Drawing.Size(80, 29);
            this.lbMade.TabIndex = 12;
            this.lbMade.Text = "Mã đề";
            // 
            // lbKythi
            // 
            this.lbKythi.AutoSize = true;
            this.lbKythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKythi.Location = new System.Drawing.Point(28, 154);
            this.lbKythi.Name = "lbKythi";
            this.lbKythi.Size = new System.Drawing.Size(71, 29);
            this.lbKythi.TabIndex = 11;
            this.lbKythi.Text = "Kỳ thi";
            // 
            // txtDiemso
            // 
            this.txtDiemso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.txtDiemso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiemso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemso.Location = new System.Drawing.Point(149, 264);
            this.txtDiemso.Name = "txtDiemso";
            this.txtDiemso.Size = new System.Drawing.Size(66, 31);
            this.txtDiemso.TabIndex = 10;
            this.txtDiemso.Text = "abc";
            // 
            // txtMade
            // 
            this.txtMade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.txtMade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMade.Location = new System.Drawing.Point(149, 211);
            this.txtMade.Name = "txtMade";
            this.txtMade.Size = new System.Drawing.Size(66, 31);
            this.txtMade.TabIndex = 9;
            this.txtMade.Text = "abc";
            // 
            // txtKythi
            // 
            this.txtKythi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.txtKythi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKythi.Location = new System.Drawing.Point(149, 151);
            this.txtKythi.Name = "txtKythi";
            this.txtKythi.Size = new System.Drawing.Size(199, 31);
            this.txtKythi.TabIndex = 7;
            this.txtKythi.Text = "abc";
            // 
            // txtNgaythi
            // 
            this.txtNgaythi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.txtNgaythi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgaythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaythi.Location = new System.Drawing.Point(34, 81);
            this.txtNgaythi.Name = "txtNgaythi";
            this.txtNgaythi.Size = new System.Drawing.Size(300, 31);
            this.txtNgaythi.TabIndex = 4;
            this.txtNgaythi.Text = "abc";
            // 
            // pnThanhngang
            // 
            this.pnThanhngang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnThanhngang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnThanhngang.Location = new System.Drawing.Point(33, 118);
            this.pnThanhngang.Name = "pnThanhngang";
            this.pnThanhngang.Size = new System.Drawing.Size(300, 2);
            this.pnThanhngang.TabIndex = 3;
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
            this.xuiClock1.Location = new System.Drawing.Point(424, 3);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(137, 139);
            this.xuiClock1.TabIndex = 0;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // xuiSlidingPanel1
            // 
            this.xuiSlidingPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.xuiSlidingPanel1.CollapseControl = null;
            this.xuiSlidingPanel1.Collapsed = true;
            this.xuiSlidingPanel1.Controls.Add(this.btnHuytimkiem);
            this.xuiSlidingPanel1.Controls.Add(this.label1);
            this.xuiSlidingPanel1.Controls.Add(this.btnTimkiem);
            this.xuiSlidingPanel1.Controls.Add(this.dtpNgaythi);
            this.xuiSlidingPanel1.Controls.Add(this.bnKetquathi);
            this.xuiSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiSlidingPanel1.HideControls = false;
            this.xuiSlidingPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiSlidingPanel1.Name = "xuiSlidingPanel1";
            this.xuiSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuiSlidingPanel1.PanelWidthExpanded = 200;
            this.xuiSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiSlidingPanel1.Size = new System.Drawing.Size(236, 411);
            this.xuiSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanel1.TabIndex = 0;
            this.xuiSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // btnHuytimkiem
            // 
            this.btnHuytimkiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHuytimkiem.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnHuytimkiem.ButtonImage")));
            this.btnHuytimkiem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnHuytimkiem.ButtonText = "Hủy lọc";
            this.btnHuytimkiem.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnHuytimkiem.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnHuytimkiem.CornerRadius = 5;
            this.btnHuytimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuytimkiem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHuytimkiem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHuytimkiem.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnHuytimkiem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnHuytimkiem.Location = new System.Drawing.Point(53, 358);
            this.btnHuytimkiem.Name = "btnHuytimkiem";
            this.btnHuytimkiem.Size = new System.Drawing.Size(131, 34);
            this.btnHuytimkiem.TabIndex = 6;
            this.btnHuytimkiem.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnHuytimkiem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm theo ngày";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTimkiem.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.ButtonImage")));
            this.btnTimkiem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnTimkiem.ButtonText = "Tìm kiếm";
            this.btnTimkiem.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnTimkiem.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTimkiem.CornerRadius = 5;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTimkiem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTimkiem.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTimkiem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnTimkiem.Location = new System.Drawing.Point(53, 314);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(131, 34);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnTimkiem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // dtpNgaythi
            // 
            this.dtpNgaythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaythi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaythi.Location = new System.Drawing.Point(11, 264);
            this.dtpNgaythi.Name = "dtpNgaythi";
            this.dtpNgaythi.Size = new System.Drawing.Size(219, 28);
            this.dtpNgaythi.TabIndex = 4;
            // 
            // bnKetquathi
            // 
            this.bnKetquathi.BackColor = System.Drawing.Color.Transparent;
            this.bnKetquathi.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.bnKetquathi.BorderColor = System.Drawing.Color.White;
            this.bnKetquathi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnKetquathi.ForeColor = System.Drawing.Color.White;
            this.bnKetquathi.Location = new System.Drawing.Point(0, 0);
            this.bnKetquathi.Name = "bnKetquathi";
            this.bnKetquathi.Size = new System.Drawing.Size(236, 127);
            this.bnKetquathi.TabIndex = 0;
            this.bnKetquathi.Text = "Kết quả thi";
            // 
            // fKetquathi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fKetquathi";
            this.Text = "fKetquathi";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiSlidingPanel1.ResumeLayout(false);
            this.xuiSlidingPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private XanderUI.XUIBanner bnKetquathi;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnTimkiem;
        private System.Windows.Forms.DateTimePicker dtpNgaythi;
        private XanderUI.XUIClock xuiClock1;
        private System.Windows.Forms.Label lbDiemso;
        private System.Windows.Forms.Label lbMade;
        private System.Windows.Forms.Label lbKythi;
        private System.Windows.Forms.TextBox txtDiemso;
        private System.Windows.Forms.TextBox txtMade;
        private System.Windows.Forms.TextBox txtKythi;
        private System.Windows.Forms.TextBox txtNgaythi;
        private System.Windows.Forms.Panel pnThanhngang;
        private XanderUI.XUIButton btnThoat;
        private XanderUI.XUISuperButton btnPre;
        private XanderUI.XUISuperButton btnNext;
        private XanderUI.XUIButton btnHuytimkiem;
    }
}