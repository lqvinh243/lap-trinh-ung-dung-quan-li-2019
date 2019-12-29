namespace WindowsFormsApp2.FormHocSinh
{
    partial class fOnluyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOnluyen));
            this.fXOnluyen = new XanderUI.XUIFormDesign();
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.lbDokho = new System.Windows.Forms.Label();
            this.txtMade = new System.Windows.Forms.TextBox();
            this.cbbDokho = new System.Windows.Forms.ComboBox();
            this.btnPre = new XanderUI.XUISuperButton();
            this.btnNext = new XanderUI.XUISuperButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatdau = new XanderUI.XUISuperButton();
            this.btnThoat = new XanderUI.XUISuperButton();
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
            this.fXOnluyen.Size = new System.Drawing.Size(548, 450);
            this.fXOnluyen.TabIndex = 0;
            this.fXOnluyen.TitleText = "Ôn luyện đề thi";
            // 
            // fXOnluyen.WorkingArea
            // 
            this.fXOnluyen.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.fXOnluyen.WorkingArea.Controls.Add(this.btnThoat);
            this.fXOnluyen.WorkingArea.Controls.Add(this.btnBatdau);
            this.fXOnluyen.WorkingArea.Controls.Add(this.label1);
            this.fXOnluyen.WorkingArea.Controls.Add(this.btnPre);
            this.fXOnluyen.WorkingArea.Controls.Add(this.btnNext);
            this.fXOnluyen.WorkingArea.Controls.Add(this.cbbDokho);
            this.fXOnluyen.WorkingArea.Controls.Add(this.txtMade);
            this.fXOnluyen.WorkingArea.Controls.Add(this.lbDokho);
            this.fXOnluyen.WorkingArea.Controls.Add(this.xuiSlidingPanel1);
            this.fXOnluyen.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fXOnluyen.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.fXOnluyen.WorkingArea.Name = "WorkingArea";
            this.fXOnluyen.WorkingArea.Size = new System.Drawing.Size(548, 411);
            this.fXOnluyen.WorkingArea.TabIndex = 0;
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
            this.xuiSlidingPanel1.Location = new System.Drawing.Point(324, 0);
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
            // lbDokho
            // 
            this.lbDokho.AutoSize = true;
            this.lbDokho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDokho.Location = new System.Drawing.Point(12, 21);
            this.lbDokho.Name = "lbDokho";
            this.lbDokho.Size = new System.Drawing.Size(160, 29);
            this.lbDokho.TabIndex = 2;
            this.lbDokho.Text = "Chọn độ khó";
            // 
            // txtMade
            // 
            this.txtMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMade.Location = new System.Drawing.Point(136, 181);
            this.txtMade.Name = "txtMade";
            this.txtMade.Size = new System.Drawing.Size(56, 41);
            this.txtMade.TabIndex = 2;
            // 
            // cbbDokho
            // 
            this.cbbDokho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDokho.FormattingEnabled = true;
            this.cbbDokho.Location = new System.Drawing.Point(102, 64);
            this.cbbDokho.Name = "cbbDokho";
            this.cbbDokho.Size = new System.Drawing.Size(150, 28);
            this.cbbDokho.TabIndex = 2;
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
            this.btnPre.Location = new System.Drawing.Point(12, 182);
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
            this.btnNext.Location = new System.Drawing.Point(218, 182);
            this.btnNext.Name = "btnNext";
            this.btnNext.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnNext.SelectedTextColor = System.Drawing.Color.White;
            this.btnNext.Size = new System.Drawing.Size(100, 40);
            this.btnNext.SuperSelected = false;
            this.btnNext.TabIndex = 16;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn mã đề";
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
            this.btnBatdau.Location = new System.Drawing.Point(17, 263);
            this.btnBatdau.Name = "btnBatdau";
            this.btnBatdau.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnBatdau.SelectedTextColor = System.Drawing.Color.White;
            this.btnBatdau.Size = new System.Drawing.Size(132, 40);
            this.btnBatdau.SuperSelected = false;
            this.btnBatdau.TabIndex = 2;
            this.btnBatdau.TextColor = System.Drawing.Color.White;
            this.btnBatdau.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnThoat.Location = new System.Drawing.Point(207, 359);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(111, 40);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 18;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // fOnluyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.fXOnluyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fOnluyen";
            this.Text = "fOnluyen";
            this.fXOnluyen.WorkingArea.ResumeLayout(false);
            this.fXOnluyen.WorkingArea.PerformLayout();
            this.fXOnluyen.ResumeLayout(false);
            this.xuiSlidingPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign fXOnluyen;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private System.Windows.Forms.ComboBox cbbDokho;
        private System.Windows.Forms.TextBox txtMade;
        private System.Windows.Forms.Label lbDokho;
        private XanderUI.XUIClock xuiClock1;
        private XanderUI.XUISuperButton btnThoat;
        private XanderUI.XUISuperButton btnBatdau;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUISuperButton btnPre;
        private XanderUI.XUISuperButton btnNext;
    }
}