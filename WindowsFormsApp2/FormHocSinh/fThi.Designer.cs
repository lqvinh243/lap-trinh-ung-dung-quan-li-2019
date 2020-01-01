namespace WindowsFormsApp2.FormHocSinh
{
    partial class fThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThi));
            this.fXOnluyen = new XanderUI.XUIFormDesign();
            this.lbChonkythi = new System.Windows.Forms.Label();
            this.cbbKythi = new System.Windows.Forms.ComboBox();
            this.lbMathisinh = new System.Windows.Forms.Label();
            this.txtMathisinh = new System.Windows.Forms.TextBox();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.txtNgaythi = new System.Windows.Forms.TextBox();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.btnBatdau = new XanderUI.XUISuperButton();
            this.lbMade = new System.Windows.Forms.Label();
            this.btnPre = new XanderUI.XUISuperButton();
            this.btnNext = new XanderUI.XUISuperButton();
            this.txtMade = new System.Windows.Forms.TextBox();
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.lbKhoi = new System.Windows.Forms.Label();
            this.txtKhoi = new System.Windows.Forms.TextBox();
            this.fXOnluyen.WorkingArea.SuspendLayout();
            this.fXOnluyen.SuspendLayout();
            this.xuiSlidingPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fXOnluyen
            // 
            this.fXOnluyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fXOnluyen.ExitApplication = true;
            this.fXOnluyen.FormStyle = XanderUI.XUIFormDesign.Style.MacOS;
            this.fXOnluyen.Location = new System.Drawing.Point(0, 0);
            this.fXOnluyen.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.fXOnluyen.MaterialForeColor = System.Drawing.Color.White;
            this.fXOnluyen.Name = "fXOnluyen";
            this.fXOnluyen.ShowMaximize = true;
            this.fXOnluyen.ShowMinimize = true;
            this.fXOnluyen.Size = new System.Drawing.Size(710, 450);
            this.fXOnluyen.TabIndex = 1;
            this.fXOnluyen.TitleText = "Ôn luyện đề thi";
            // 
            // fXOnluyen.WorkingArea
            // 
            this.fXOnluyen.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.fXOnluyen.WorkingArea.Controls.Add(this.lbKhoi);
            this.fXOnluyen.WorkingArea.Controls.Add(this.txtKhoi);
            this.fXOnluyen.WorkingArea.Controls.Add(this.lbChonkythi);
            this.fXOnluyen.WorkingArea.Controls.Add(this.cbbKythi);
            this.fXOnluyen.WorkingArea.Controls.Add(this.lbMathisinh);
            this.fXOnluyen.WorkingArea.Controls.Add(this.txtMathisinh);
            this.fXOnluyen.WorkingArea.Controls.Add(this.lbNgaysinh);
            this.fXOnluyen.WorkingArea.Controls.Add(this.txtNgaythi);
            this.fXOnluyen.WorkingArea.Controls.Add(this.btnThoat);
            this.fXOnluyen.WorkingArea.Controls.Add(this.btnBatdau);
            this.fXOnluyen.WorkingArea.Controls.Add(this.lbMade);
            this.fXOnluyen.WorkingArea.Controls.Add(this.btnPre);
            this.fXOnluyen.WorkingArea.Controls.Add(this.btnNext);
            this.fXOnluyen.WorkingArea.Controls.Add(this.txtMade);
            this.fXOnluyen.WorkingArea.Controls.Add(this.xuiSlidingPanel1);
            this.fXOnluyen.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fXOnluyen.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.fXOnluyen.WorkingArea.Name = "WorkingArea";
            this.fXOnluyen.WorkingArea.Size = new System.Drawing.Size(710, 411);
            this.fXOnluyen.WorkingArea.TabIndex = 0;
            // 
            // lbChonkythi
            // 
            this.lbChonkythi.AutoSize = true;
            this.lbChonkythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChonkythi.Location = new System.Drawing.Point(79, 142);
            this.lbChonkythi.Name = "lbChonkythi";
            this.lbChonkythi.Size = new System.Drawing.Size(130, 29);
            this.lbChonkythi.TabIndex = 22;
            this.lbChonkythi.Text = "Chọn kỳ thi";
            // 
            // cbbKythi
            // 
            this.cbbKythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKythi.FormattingEnabled = true;
            this.cbbKythi.Location = new System.Drawing.Point(236, 141);
            this.cbbKythi.Name = "cbbKythi";
            this.cbbKythi.Size = new System.Drawing.Size(159, 30);
            this.cbbKythi.TabIndex = 2;
            // 
            // lbMathisinh
            // 
            this.lbMathisinh.AutoSize = true;
            this.lbMathisinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMathisinh.Location = new System.Drawing.Point(84, 84);
            this.lbMathisinh.Name = "lbMathisinh";
            this.lbMathisinh.Size = new System.Drawing.Size(127, 29);
            this.lbMathisinh.TabIndex = 21;
            this.lbMathisinh.Text = "Mã thí sinh";
            // 
            // txtMathisinh
            // 
            this.txtMathisinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMathisinh.Location = new System.Drawing.Point(236, 78);
            this.txtMathisinh.Name = "txtMathisinh";
            this.txtMathisinh.Size = new System.Drawing.Size(159, 38);
            this.txtMathisinh.TabIndex = 20;
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaysinh.Location = new System.Drawing.Point(82, 27);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(100, 29);
            this.lbNgaysinh.TabIndex = 19;
            this.lbNgaysinh.Text = "Ngày thi";
            // 
            // txtNgaythi
            // 
            this.txtNgaythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaythi.Location = new System.Drawing.Point(195, 21);
            this.txtNgaythi.Name = "txtNgaythi";
            this.txtNgaythi.Size = new System.Drawing.Size(205, 38);
            this.txtNgaythi.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundColor = System.Drawing.Color.Gray;
            this.btnThoat.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ButtonImage")));
            this.btnThoat.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnThoat.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.CornerRadius = 5;
            this.btnThoat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThoat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnThoat.HoverTextColor = System.Drawing.Color.White;
            this.btnThoat.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnThoat.Location = new System.Drawing.Point(282, 359);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(111, 40);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 18;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnBatdau
            // 
            this.btnBatdau.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnBatdau.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnBatdau.ButtonImage")));
            this.btnBatdau.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnBatdau.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnBatdau.ButtonText = "Bắt đầu";
            this.btnBatdau.CornerRadius = 5;
            this.btnBatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatdau.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBatdau.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnBatdau.HoverTextColor = System.Drawing.Color.White;
            this.btnBatdau.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnBatdau.Location = new System.Drawing.Point(98, 313);
            this.btnBatdau.Name = "btnBatdau";
            this.btnBatdau.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnBatdau.SelectedTextColor = System.Drawing.Color.White;
            this.btnBatdau.Size = new System.Drawing.Size(132, 40);
            this.btnBatdau.SuperSelected = false;
            this.btnBatdau.TabIndex = 2;
            this.btnBatdau.TextColor = System.Drawing.Color.White;
            this.btnBatdau.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbMade
            // 
            this.lbMade.AutoSize = true;
            this.lbMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMade.Location = new System.Drawing.Point(78, 204);
            this.lbMade.Name = "lbMade";
            this.lbMade.Size = new System.Drawing.Size(143, 29);
            this.lbMade.TabIndex = 2;
            this.lbMade.Text = "Chọn mã đề";
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
            this.btnPre.Location = new System.Drawing.Point(130, 251);
            this.btnPre.Name = "btnPre";
            this.btnPre.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnPre.SelectedTextColor = System.Drawing.Color.White;
            this.btnPre.Size = new System.Drawing.Size(100, 40);
            this.btnPre.SuperSelected = false;
            this.btnPre.TabIndex = 17;
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
            this.btnNext.Location = new System.Drawing.Point(293, 251);
            this.btnNext.Name = "btnNext";
            this.btnNext.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnNext.SelectedTextColor = System.Drawing.Color.White;
            this.btnNext.Size = new System.Drawing.Size(100, 40);
            this.btnNext.SuperSelected = false;
            this.btnNext.TabIndex = 16;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // txtMade
            // 
            this.txtMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMade.Location = new System.Drawing.Point(236, 204);
            this.txtMade.Name = "txtMade";
            this.txtMade.Size = new System.Drawing.Size(56, 41);
            this.txtMade.TabIndex = 2;
            // 
            // xuiSlidingPanel1
            // 
            this.xuiSlidingPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.xuiSlidingPanel1.CollapseControl = null;
            this.xuiSlidingPanel1.Collapsed = true;
            this.xuiSlidingPanel1.Controls.Add(this.xuiClock1);
            this.xuiSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.xuiSlidingPanel1.HideControls = false;
            this.xuiSlidingPanel1.Location = new System.Drawing.Point(486, 0);
            this.xuiSlidingPanel1.Name = "xuiSlidingPanel1";
            this.xuiSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuiSlidingPanel1.PanelWidthExpanded = 200;
            this.xuiSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiSlidingPanel1.Size = new System.Drawing.Size(224, 411);
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
            this.xuiClock1.Location = new System.Drawing.Point(59, 21);
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
            // lbKhoi
            // 
            this.lbKhoi.AutoSize = true;
            this.lbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoi.Location = new System.Drawing.Point(298, 204);
            this.lbKhoi.Name = "lbKhoi";
            this.lbKhoi.Size = new System.Drawing.Size(62, 29);
            this.lbKhoi.TabIndex = 23;
            this.lbKhoi.Text = "Khối";
            // 
            // txtKhoi
            // 
            this.txtKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoi.Location = new System.Drawing.Point(366, 204);
            this.txtKhoi.Name = "txtKhoi";
            this.txtKhoi.Size = new System.Drawing.Size(56, 41);
            this.txtKhoi.TabIndex = 24;
            // 
            // fThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.fXOnluyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fThi";
            this.Text = "fThi";
            this.fXOnluyen.WorkingArea.ResumeLayout(false);
            this.fXOnluyen.WorkingArea.PerformLayout();
            this.fXOnluyen.ResumeLayout(false);
            this.xuiSlidingPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign fXOnluyen;
        private XanderUI.XUISuperButton btnThoat;
        private XanderUI.XUISuperButton btnBatdau;
        private System.Windows.Forms.Label lbMade;
        private XanderUI.XUISuperButton btnPre;
        private XanderUI.XUISuperButton btnNext;
        private System.Windows.Forms.TextBox txtMade;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private XanderUI.XUIClock xuiClock1;
        private System.Windows.Forms.Label lbMathisinh;
        private System.Windows.Forms.TextBox txtMathisinh;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.TextBox txtNgaythi;
        private System.Windows.Forms.Label lbChonkythi;
        private System.Windows.Forms.ComboBox cbbKythi;
        private System.Windows.Forms.Label lbKhoi;
        private System.Windows.Forms.TextBox txtKhoi;
    }
}