namespace WindowsFormsApp2.FormHocSinh
{
    partial class fKetquaOnluyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fKetquaOnluyen));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.dtpThoigian = new System.Windows.Forms.DateTimePicker();
            this.btnTimkiem = new XanderUI.XUIButton();
            this.btnHuyloc = new XanderUI.XUISuperButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.lbTong = new System.Windows.Forms.Label();
            this.btnPre = new XanderUI.XUISuperButton();
            this.btnNext = new XanderUI.XUISuperButton();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.lbNgaylam = new System.Windows.Forms.Label();
            this.txtSolan = new System.Windows.Forms.TextBox();
            this.lbSolan = new System.Windows.Forms.Label();
            this.txtMade = new System.Windows.Forms.TextBox();
            this.lbMade = new System.Windows.Forms.Label();
            this.txtDiemso = new System.Windows.Forms.TextBox();
            this.lbDiemso = new System.Windows.Forms.Label();
            this.txtThoigian = new System.Windows.Forms.TextBox();
            this.lbThoigian = new System.Windows.Forms.Label();
            this.txtThoigianlam = new System.Windows.Forms.TextBox();
            this.lbThoigianlam = new System.Windows.Forms.Label();
            this.txtThoigianra = new System.Windows.Forms.TextBox();
            this.lbRa = new System.Windows.Forms.Label();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.xuiSlidingPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.panel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiSlidingPanel1);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 74);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(800, 376);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // xuiSlidingPanel1
            // 
            this.xuiSlidingPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.xuiSlidingPanel1.CollapseControl = null;
            this.xuiSlidingPanel1.Collapsed = true;
            this.xuiSlidingPanel1.Controls.Add(this.btnHuyloc);
            this.xuiSlidingPanel1.Controls.Add(this.btnTimkiem);
            this.xuiSlidingPanel1.Controls.Add(this.dtpThoigian);
            this.xuiSlidingPanel1.Controls.Add(this.xuiClock1);
            this.xuiSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiSlidingPanel1.HideControls = false;
            this.xuiSlidingPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiSlidingPanel1.Name = "xuiSlidingPanel1";
            this.xuiSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuiSlidingPanel1.PanelWidthExpanded = 200;
            this.xuiSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiSlidingPanel1.Size = new System.Drawing.Size(322, 376);
            this.xuiSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanel1.TabIndex = 0;
            this.xuiSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.TopRight = System.Drawing.Color.Black;
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
            this.xuiClock1.Location = new System.Drawing.Point(92, 23);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(120, 130);
            this.xuiClock1.TabIndex = 1;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // dtpThoigian
            // 
            this.dtpThoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoigian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpThoigian.Location = new System.Drawing.Point(48, 183);
            this.dtpThoigian.Name = "dtpThoigian";
            this.dtpThoigian.Size = new System.Drawing.Size(213, 34);
            this.dtpThoigian.TabIndex = 1;
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
            this.btnTimkiem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnTimkiem.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTimkiem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnTimkiem.Location = new System.Drawing.Point(73, 234);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(164, 49);
            this.btnTimkiem.TabIndex = 1;
            this.btnTimkiem.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnTimkiem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnHuyloc
            // 
            this.btnHuyloc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnHuyloc.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnHuyloc.ButtonImage")));
            this.btnHuyloc.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnHuyloc.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnHuyloc.ButtonText = "Hủy lọc";
            this.btnHuyloc.CornerRadius = 5;
            this.btnHuyloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyloc.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHuyloc.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnHuyloc.HoverTextColor = System.Drawing.Color.White;
            this.btnHuyloc.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnHuyloc.Location = new System.Drawing.Point(192, 318);
            this.btnHuyloc.Name = "btnHuyloc";
            this.btnHuyloc.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnHuyloc.SelectedTextColor = System.Drawing.Color.White;
            this.btnHuyloc.Size = new System.Drawing.Size(116, 46);
            this.btnHuyloc.SuperSelected = false;
            this.btnHuyloc.TabIndex = 1;
            this.btnHuyloc.TextColor = System.Drawing.Color.White;
            this.btnHuyloc.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtThoigianra);
            this.panel1.Controls.Add(this.lbRa);
            this.panel1.Controls.Add(this.txtThoigianlam);
            this.panel1.Controls.Add(this.lbThoigianlam);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.lbTong);
            this.panel1.Controls.Add(this.btnPre);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.txtNgay);
            this.panel1.Controls.Add(this.lbNgaylam);
            this.panel1.Controls.Add(this.txtSolan);
            this.panel1.Controls.Add(this.lbSolan);
            this.panel1.Controls.Add(this.txtMade);
            this.panel1.Controls.Add(this.lbMade);
            this.panel1.Controls.Add(this.txtDiemso);
            this.panel1.Controls.Add(this.lbDiemso);
            this.panel1.Controls.Add(this.txtThoigian);
            this.panel1.Controls.Add(this.lbThoigian);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(322, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 376);
            this.panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.btnThoat.Location = new System.Drawing.Point(356, 301);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.OliveDrab;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(116, 46);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 20;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(188, 215);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(80, 25);
            this.lbTong.TabIndex = 32;
            this.lbTong.Text = "Kết quả";
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
            this.btnPre.Location = new System.Drawing.Point(90, 243);
            this.btnPre.Name = "btnPre";
            this.btnPre.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnPre.SelectedTextColor = System.Drawing.Color.White;
            this.btnPre.Size = new System.Drawing.Size(100, 40);
            this.btnPre.SuperSelected = false;
            this.btnPre.TabIndex = 31;
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
            this.btnNext.Location = new System.Drawing.Point(274, 243);
            this.btnNext.Name = "btnNext";
            this.btnNext.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnNext.SelectedTextColor = System.Drawing.Color.White;
            this.btnNext.Size = new System.Drawing.Size(100, 40);
            this.btnNext.SuperSelected = false;
            this.btnNext.TabIndex = 30;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // txtNgay
            // 
            this.txtNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(90, 30);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(150, 30);
            this.txtNgay.TabIndex = 29;
            // 
            // lbNgaylam
            // 
            this.lbNgaylam.AutoSize = true;
            this.lbNgaylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaylam.Location = new System.Drawing.Point(5, 30);
            this.lbNgaylam.Name = "lbNgaylam";
            this.lbNgaylam.Size = new System.Drawing.Size(69, 29);
            this.lbNgaylam.TabIndex = 28;
            this.lbNgaylam.Text = "Ngày";
            // 
            // txtSolan
            // 
            this.txtSolan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolan.Location = new System.Drawing.Point(356, 77);
            this.txtSolan.Name = "txtSolan";
            this.txtSolan.Size = new System.Drawing.Size(38, 30);
            this.txtSolan.TabIndex = 27;
            // 
            // lbSolan
            // 
            this.lbSolan.AutoSize = true;
            this.lbSolan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSolan.Location = new System.Drawing.Point(269, 77);
            this.lbSolan.Name = "lbSolan";
            this.lbSolan.Size = new System.Drawing.Size(81, 29);
            this.lbSolan.TabIndex = 26;
            this.lbSolan.Text = "Số lần";
            // 
            // txtMade
            // 
            this.txtMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMade.Location = new System.Drawing.Point(356, 31);
            this.txtMade.Name = "txtMade";
            this.txtMade.Size = new System.Drawing.Size(118, 30);
            this.txtMade.TabIndex = 25;
            // 
            // lbMade
            // 
            this.lbMade.AutoSize = true;
            this.lbMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMade.Location = new System.Drawing.Point(259, 31);
            this.lbMade.Name = "lbMade";
            this.lbMade.Size = new System.Drawing.Size(80, 29);
            this.lbMade.TabIndex = 24;
            this.lbMade.Text = "Mã đề";
            // 
            // txtDiemso
            // 
            this.txtDiemso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemso.Location = new System.Drawing.Point(356, 113);
            this.txtDiemso.Name = "txtDiemso";
            this.txtDiemso.Size = new System.Drawing.Size(109, 30);
            this.txtDiemso.TabIndex = 23;
            // 
            // lbDiemso
            // 
            this.lbDiemso.AutoSize = true;
            this.lbDiemso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemso.Location = new System.Drawing.Point(248, 113);
            this.lbDiemso.Name = "lbDiemso";
            this.lbDiemso.Size = new System.Drawing.Size(102, 29);
            this.lbDiemso.TabIndex = 22;
            this.lbDiemso.Text = "Điêm số";
            // 
            // txtThoigian
            // 
            this.txtThoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoigian.Location = new System.Drawing.Point(90, 76);
            this.txtThoigian.Name = "txtThoigian";
            this.txtThoigian.Size = new System.Drawing.Size(112, 30);
            this.txtThoigian.TabIndex = 21;
            // 
            // lbThoigian
            // 
            this.lbThoigian.AutoSize = true;
            this.lbThoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoigian.Location = new System.Drawing.Point(5, 77);
            this.lbThoigian.Name = "lbThoigian";
            this.lbThoigian.Size = new System.Drawing.Size(55, 29);
            this.lbThoigian.TabIndex = 19;
            this.lbThoigian.Text = "Vào";
            // 
            // txtThoigianlam
            // 
            this.txtThoigianlam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoigianlam.Location = new System.Drawing.Point(170, 167);
            this.txtThoigianlam.Name = "txtThoigianlam";
            this.txtThoigianlam.Size = new System.Drawing.Size(75, 30);
            this.txtThoigianlam.TabIndex = 34;
            // 
            // lbThoigianlam
            // 
            this.lbThoigianlam.AutoSize = true;
            this.lbThoigianlam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoigianlam.Location = new System.Drawing.Point(5, 168);
            this.lbThoigianlam.Name = "lbThoigianlam";
            this.lbThoigianlam.Size = new System.Drawing.Size(159, 29);
            this.lbThoigianlam.TabIndex = 33;
            this.lbThoigianlam.Text = "Thời gian làm";
            // 
            // txtThoigianra
            // 
            this.txtThoigianra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoigianra.Location = new System.Drawing.Point(90, 124);
            this.txtThoigianra.Name = "txtThoigianra";
            this.txtThoigianra.Size = new System.Drawing.Size(112, 30);
            this.txtThoigianra.TabIndex = 36;
            // 
            // lbRa
            // 
            this.lbRa.AutoSize = true;
            this.lbRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRa.Location = new System.Drawing.Point(3, 124);
            this.lbRa.Name = "lbRa";
            this.lbRa.Size = new System.Drawing.Size(43, 29);
            this.lbRa.TabIndex = 35;
            this.lbRa.Text = "Ra";
            // 
            // fKetquaOnluyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fKetquaOnluyen";
            this.Text = "fKetquaOnluyen";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            this.xuiSlidingPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private XanderUI.XUIClock xuiClock1;
        private XanderUI.XUIButton btnTimkiem;
        private System.Windows.Forms.DateTimePicker dtpThoigian;
        private XanderUI.XUISuperButton btnHuyloc;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUISuperButton btnThoat;
        private System.Windows.Forms.Label lbTong;
        private XanderUI.XUISuperButton btnPre;
        private XanderUI.XUISuperButton btnNext;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label lbNgaylam;
        private System.Windows.Forms.TextBox txtSolan;
        private System.Windows.Forms.Label lbSolan;
        private System.Windows.Forms.TextBox txtMade;
        private System.Windows.Forms.Label lbMade;
        private System.Windows.Forms.TextBox txtDiemso;
        private System.Windows.Forms.Label lbDiemso;
        private System.Windows.Forms.TextBox txtThoigian;
        private System.Windows.Forms.Label lbThoigian;
        private System.Windows.Forms.TextBox txtThoigianlam;
        private System.Windows.Forms.Label lbThoigianlam;
        private System.Windows.Forms.TextBox txtThoigianra;
        private System.Windows.Forms.Label lbRa;
    }
}