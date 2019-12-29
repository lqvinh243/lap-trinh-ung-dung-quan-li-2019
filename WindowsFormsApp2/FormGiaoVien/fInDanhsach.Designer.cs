namespace WindowsFormsApp2.FormGiaoVien
{
    partial class fInDanhsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInDanhsach));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.rpView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.btnThucthi = new XanderUI.XUIButton();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.cbbIDMade = new System.Windows.Forms.ComboBox();
            this.lbIDMade = new System.Windows.Forms.Label();
            this.cbbKhoikythi = new System.Windows.Forms.ComboBox();
            this.lbKhoikythi = new System.Windows.Forms.Label();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.xuiSlidingPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiFormDesign1
            // 
            this.xuiFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.ExitApplication = true;
            this.xuiFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.Ubuntu;
            this.xuiFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuiFormDesign1.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuiFormDesign1.Name = "xuiFormDesign1";
            this.xuiFormDesign1.ShowMaximize = true;
            this.xuiFormDesign1.ShowMinimize = true;
            this.xuiFormDesign1.Size = new System.Drawing.Size(1435, 811);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.rpView);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiSlidingPanel1);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 30);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1435, 781);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // rpView
            // 
            this.rpView.ActiveViewIndex = -1;
            this.rpView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpView.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpView.Location = new System.Drawing.Point(0, 0);
            this.rpView.Name = "rpView";
            this.rpView.Size = new System.Drawing.Size(1204, 781);
            this.rpView.TabIndex = 1;
            // 
            // xuiSlidingPanel1
            // 
            this.xuiSlidingPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.xuiSlidingPanel1.CollapseControl = null;
            this.xuiSlidingPanel1.Collapsed = true;
            this.xuiSlidingPanel1.Controls.Add(this.btnThucthi);
            this.xuiSlidingPanel1.Controls.Add(this.btnThoat);
            this.xuiSlidingPanel1.Controls.Add(this.cbbIDMade);
            this.xuiSlidingPanel1.Controls.Add(this.lbIDMade);
            this.xuiSlidingPanel1.Controls.Add(this.cbbKhoikythi);
            this.xuiSlidingPanel1.Controls.Add(this.lbKhoikythi);
            this.xuiSlidingPanel1.Controls.Add(this.xuiClock1);
            this.xuiSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.xuiSlidingPanel1.HideControls = false;
            this.xuiSlidingPanel1.Location = new System.Drawing.Point(1204, 0);
            this.xuiSlidingPanel1.Name = "xuiSlidingPanel1";
            this.xuiSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuiSlidingPanel1.PanelWidthExpanded = 200;
            this.xuiSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiSlidingPanel1.Size = new System.Drawing.Size(231, 781);
            this.xuiSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanel1.TabIndex = 0;
            this.xuiSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // btnThucthi
            // 
            this.btnThucthi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThucthi.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnThucthi.ButtonImage")));
            this.btnThucthi.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnThucthi.ButtonText = "Thực thi";
            this.btnThucthi.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnThucthi.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThucthi.CornerRadius = 5;
            this.btnThucthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucthi.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThucthi.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnThucthi.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThucthi.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThucthi.Location = new System.Drawing.Point(19, 503);
            this.btnThucthi.Name = "btnThucthi";
            this.btnThucthi.Size = new System.Drawing.Size(200, 50);
            this.btnThucthi.TabIndex = 6;
            this.btnThucthi.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnThucthi.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnThoat.Location = new System.Drawing.Point(119, 729);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 5;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // cbbIDMade
            // 
            this.cbbIDMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbIDMade.FormattingEnabled = true;
            this.cbbIDMade.Location = new System.Drawing.Point(65, 423);
            this.cbbIDMade.Name = "cbbIDMade";
            this.cbbIDMade.Size = new System.Drawing.Size(121, 30);
            this.cbbIDMade.TabIndex = 4;
            // 
            // lbIDMade
            // 
            this.lbIDMade.AutoSize = true;
            this.lbIDMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDMade.Location = new System.Drawing.Point(73, 377);
            this.lbIDMade.Name = "lbIDMade";
            this.lbIDMade.Size = new System.Drawing.Size(90, 25);
            this.lbIDMade.TabIndex = 3;
            this.lbIDMade.Text = "ID mã đề";
            // 
            // cbbKhoikythi
            // 
            this.cbbKhoikythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoikythi.FormattingEnabled = true;
            this.cbbKhoikythi.Location = new System.Drawing.Point(65, 323);
            this.cbbKhoikythi.Name = "cbbKhoikythi";
            this.cbbKhoikythi.Size = new System.Drawing.Size(121, 30);
            this.cbbKhoikythi.TabIndex = 2;
            // 
            // lbKhoikythi
            // 
            this.lbKhoikythi.AutoSize = true;
            this.lbKhoikythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoikythi.Location = new System.Drawing.Point(73, 277);
            this.lbKhoikythi.Name = "lbKhoikythi";
            this.lbKhoikythi.Size = new System.Drawing.Size(102, 25);
            this.lbKhoikythi.TabIndex = 1;
            this.lbKhoikythi.Text = "Khối kỳ thi";
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
            this.xuiClock1.Location = new System.Drawing.Point(65, 77);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(120, 130);
            this.xuiClock1.TabIndex = 0;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // fInDanhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 811);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fInDanhsach";
            this.Text = "fBangdiemkythi";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            this.xuiSlidingPanel1.ResumeLayout(false);
            this.xuiSlidingPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpView;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private XanderUI.XUIButton btnThucthi;
        private XanderUI.XUISuperButton btnThoat;
        private System.Windows.Forms.ComboBox cbbIDMade;
        private System.Windows.Forms.Label lbIDMade;
        private System.Windows.Forms.ComboBox cbbKhoikythi;
        private System.Windows.Forms.Label lbKhoikythi;
        private XanderUI.XUIClock xuiClock1;
    }
}