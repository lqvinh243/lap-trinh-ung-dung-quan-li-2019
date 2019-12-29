namespace WindowsFormsApp2.FormHocSinh
{
    partial class fmainHocsinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmainHocsinh));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.btnDangxuat = new XanderUI.XUISuperButton();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.xuiFlatMenuStrip1 = new XanderUI.XUIFlatMenuStrip();
            this.ônLuyệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsLamonluyen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsKetquaonluyen = new System.Windows.Forms.ToolStripMenuItem();
            this.thiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsLichthi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsLambaithi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsKetquathi = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsXemthongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSuathongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.chungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInbangdiem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiSlidingPanel1.SuspendLayout();
            this.xuiFlatMenuStrip1.SuspendLayout();
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
            this.xuiFormDesign1.TitleText = "Chào mừng bạn";
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
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Fuchsia;
            this.xuiGradientPanel1.Controls.Add(this.btnDangxuat);
            this.xuiGradientPanel1.Controls.Add(this.xuiClock1);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(234, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(566, 411);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 7;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnDangxuat.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnDangxuat.ButtonImage")));
            this.btnDangxuat.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnDangxuat.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnDangxuat.ButtonText = "Đăng xuất";
            this.btnDangxuat.CornerRadius = 5;
            this.btnDangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDangxuat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnDangxuat.HoverTextColor = System.Drawing.Color.White;
            this.btnDangxuat.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnDangxuat.Location = new System.Drawing.Point(390, 349);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnDangxuat.SelectedTextColor = System.Drawing.Color.White;
            this.btnDangxuat.Size = new System.Drawing.Size(123, 50);
            this.btnDangxuat.SuperSelected = false;
            this.btnDangxuat.TabIndex = 0;
            this.btnDangxuat.TextColor = System.Drawing.Color.White;
            this.btnDangxuat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiClock1
            // 
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.Location = new System.Drawing.Point(138, 18);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(220, 189);
            this.xuiClock1.TabIndex = 4;
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
            this.xuiSlidingPanel1.Controls.Add(this.xuiFlatMenuStrip1);
            this.xuiSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiSlidingPanel1.HideControls = false;
            this.xuiSlidingPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiSlidingPanel1.Name = "xuiSlidingPanel1";
            this.xuiSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuiSlidingPanel1.PanelWidthExpanded = 200;
            this.xuiSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiSlidingPanel1.Size = new System.Drawing.Size(234, 411);
            this.xuiSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanel1.TabIndex = 6;
            this.xuiSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // xuiFlatMenuStrip1
            // 
            this.xuiFlatMenuStrip1.AutoSize = false;
            this.xuiFlatMenuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatMenuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiFlatMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiFlatMenuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 4);
            this.xuiFlatMenuStrip1.HoverBackColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatMenuStrip1.HoverTextColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.xuiFlatMenuStrip1.ItemBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ônLuyệnToolStripMenuItem,
            this.thiToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.chungToolStripMenuItem});
            this.xuiFlatMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiFlatMenuStrip1.Name = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.Padding = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.xuiFlatMenuStrip1.SelectedBackColor = System.Drawing.Color.DarkOrchid;
            this.xuiFlatMenuStrip1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.SeperatorColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.Size = new System.Drawing.Size(156, 411);
            this.xuiFlatMenuStrip1.TabIndex = 0;
            this.xuiFlatMenuStrip1.Text = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.TextColor = System.Drawing.Color.White;
            // 
            // ônLuyệnToolStripMenuItem
            // 
            this.ônLuyệnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsLamonluyen,
            this.mnsKetquaonluyen});
            this.ônLuyệnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ônLuyệnToolStripMenuItem.Name = "ônLuyệnToolStripMenuItem";
            this.ônLuyệnToolStripMenuItem.Size = new System.Drawing.Size(149, 42);
            this.ônLuyệnToolStripMenuItem.Text = "Ôn luyện";
            // 
            // mnsLamonluyen
            // 
            this.mnsLamonluyen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsLamonluyen.Name = "mnsLamonluyen";
            this.mnsLamonluyen.Size = new System.Drawing.Size(282, 36);
            this.mnsLamonluyen.Text = "Làm bài ôn luyện";
            // 
            // mnsKetquaonluyen
            // 
            this.mnsKetquaonluyen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsKetquaonluyen.Name = "mnsKetquaonluyen";
            this.mnsKetquaonluyen.Size = new System.Drawing.Size(282, 36);
            this.mnsKetquaonluyen.Text = "Kết quả ôn luyện";
            // 
            // thiToolStripMenuItem
            // 
            this.thiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsLichthi,
            this.mnsLambaithi,
            this.mnsKetquathi});
            this.thiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.thiToolStripMenuItem.Name = "thiToolStripMenuItem";
            this.thiToolStripMenuItem.Size = new System.Drawing.Size(149, 42);
            this.thiToolStripMenuItem.Text = "Thi";
            // 
            // mnsLichthi
            // 
            this.mnsLichthi.Name = "mnsLichthi";
            this.mnsLichthi.Size = new System.Drawing.Size(247, 42);
            this.mnsLichthi.Text = "Xem lịch thi";
            // 
            // mnsLambaithi
            // 
            this.mnsLambaithi.Name = "mnsLambaithi";
            this.mnsLambaithi.Size = new System.Drawing.Size(247, 42);
            this.mnsLambaithi.Text = "Làm bài thi";
            // 
            // mnsKetquathi
            // 
            this.mnsKetquathi.Name = "mnsKetquathi";
            this.mnsKetquathi.Size = new System.Drawing.Size(247, 42);
            this.mnsKetquathi.Text = "Kết quả thi";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsXemthongtin,
            this.mnsSuathongtin});
            this.thôngTinToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(149, 42);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // mnsXemthongtin
            // 
            this.mnsXemthongtin.Name = "mnsXemthongtin";
            this.mnsXemthongtin.Size = new System.Drawing.Size(331, 42);
            this.mnsXemthongtin.Text = "Xem thông tin";
            // 
            // mnsSuathongtin
            // 
            this.mnsSuathongtin.Name = "mnsSuathongtin";
            this.mnsSuathongtin.Size = new System.Drawing.Size(331, 42);
            this.mnsSuathongtin.Text = "Cập nhật thông tin";
            // 
            // chungToolStripMenuItem
            // 
            this.chungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsInbangdiem});
            this.chungToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.chungToolStripMenuItem.Name = "chungToolStripMenuItem";
            this.chungToolStripMenuItem.Size = new System.Drawing.Size(149, 42);
            this.chungToolStripMenuItem.Text = "Chung";
            // 
            // cmsInbangdiem
            // 
            this.cmsInbangdiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsInbangdiem.ForeColor = System.Drawing.Color.White;
            this.cmsInbangdiem.Name = "cmsInbangdiem";
            this.cmsInbangdiem.Size = new System.Drawing.Size(240, 36);
            this.cmsInbangdiem.Text = "In bảng diểm";
            // 
            // fmainHocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmainHocsinh";
            this.Text = "fmainHocsinh";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiSlidingPanel1.ResumeLayout(false);
            this.xuiFlatMenuStrip1.ResumeLayout(false);
            this.xuiFlatMenuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private XanderUI.XUIClock xuiClock1;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUISuperButton btnDangxuat;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private XanderUI.XUIFlatMenuStrip xuiFlatMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ônLuyệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsLamonluyen;
        private System.Windows.Forms.ToolStripMenuItem mnsKetquaonluyen;
        private System.Windows.Forms.ToolStripMenuItem thiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsLichthi;
        private System.Windows.Forms.ToolStripMenuItem mnsLambaithi;
        private System.Windows.Forms.ToolStripMenuItem mnsKetquathi;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsXemthongtin;
        private System.Windows.Forms.ToolStripMenuItem mnsSuathongtin;
        private System.Windows.Forms.ToolStripMenuItem chungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsInbangdiem;
    }
}