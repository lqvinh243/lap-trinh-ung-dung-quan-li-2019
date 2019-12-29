namespace WindowsFormsApp2.FormHocSinh
{
    partial class fLichthi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLichthi));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.btnHuyboloc = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimkiem = new XanderUI.XUIButton();
            this.xuiGradientPanel2 = new XanderUI.XUIGradientPanel();
            this.btnThoat = new XanderUI.XUIButton();
            this.btnPre = new XanderUI.XUISuperButton();
            this.btnNext = new XanderUI.XUISuperButton();
            this.lbTongkythi = new System.Windows.Forms.Label();
            this.txtNgaythi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.dtpNgaythi = new System.Windows.Forms.DateTimePicker();
            this.bnLichthi = new XanderUI.XUIBanner();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.xuiGradientPanel1.SuspendLayout();
            this.xuiGradientPanel2.SuspendLayout();
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
            this.xuiFormDesign1.Size = new System.Drawing.Size(800, 450);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiGradientPanel1);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 30);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(800, 420);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiGradientPanel1.BottomRight = System.Drawing.SystemColors.ActiveBorder;
            this.xuiGradientPanel1.Controls.Add(this.btnHuyboloc);
            this.xuiGradientPanel1.Controls.Add(this.label1);
            this.xuiGradientPanel1.Controls.Add(this.btnTimkiem);
            this.xuiGradientPanel1.Controls.Add(this.xuiGradientPanel2);
            this.xuiGradientPanel1.Controls.Add(this.dtpNgaythi);
            this.xuiGradientPanel1.Controls.Add(this.bnLichthi);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(797, 420);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 1;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // btnHuyboloc
            // 
            this.btnHuyboloc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHuyboloc.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnHuyboloc.ButtonImage")));
            this.btnHuyboloc.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnHuyboloc.ButtonText = "Hủy lọc";
            this.btnHuyboloc.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnHuyboloc.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnHuyboloc.CornerRadius = 5;
            this.btnHuyboloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyboloc.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHuyboloc.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHuyboloc.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnHuyboloc.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnHuyboloc.Location = new System.Drawing.Point(56, 374);
            this.btnHuyboloc.Name = "btnHuyboloc";
            this.btnHuyboloc.Size = new System.Drawing.Size(131, 34);
            this.btnHuyboloc.TabIndex = 3;
            this.btnHuyboloc.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnHuyboloc.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 0;
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
            this.btnTimkiem.Location = new System.Drawing.Point(56, 308);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(131, 34);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnTimkiem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiGradientPanel2
            // 
            this.xuiGradientPanel2.BottomLeft = System.Drawing.Color.Transparent;
            this.xuiGradientPanel2.BottomRight = System.Drawing.Color.White;
            this.xuiGradientPanel2.Controls.Add(this.btnThoat);
            this.xuiGradientPanel2.Controls.Add(this.btnPre);
            this.xuiGradientPanel2.Controls.Add(this.btnNext);
            this.xuiGradientPanel2.Controls.Add(this.lbTongkythi);
            this.xuiGradientPanel2.Controls.Add(this.txtNgaythi);
            this.xuiGradientPanel2.Controls.Add(this.panel1);
            this.xuiGradientPanel2.Controls.Add(this.xuiClock1);
            this.xuiGradientPanel2.Location = new System.Drawing.Point(247, 0);
            this.xuiGradientPanel2.Name = "xuiGradientPanel2";
            this.xuiGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel2.Size = new System.Drawing.Size(553, 430);
            this.xuiGradientPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel2.TabIndex = 1;
            this.xuiGradientPanel2.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel2.TopRight = System.Drawing.Color.Fuchsia;
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
            this.btnThoat.Location = new System.Drawing.Point(421, 358);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 50);
            this.btnThoat.TabIndex = 7;
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
            this.btnPre.Location = new System.Drawing.Point(38, 285);
            this.btnPre.Name = "btnPre";
            this.btnPre.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnPre.SelectedTextColor = System.Drawing.Color.White;
            this.btnPre.Size = new System.Drawing.Size(100, 40);
            this.btnPre.SuperSelected = false;
            this.btnPre.TabIndex = 6;
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
            this.btnNext.Location = new System.Drawing.Point(206, 285);
            this.btnNext.Name = "btnNext";
            this.btnNext.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnNext.SelectedTextColor = System.Drawing.Color.White;
            this.btnNext.Size = new System.Drawing.Size(100, 40);
            this.btnNext.SuperSelected = false;
            this.btnNext.TabIndex = 5;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbTongkythi
            // 
            this.lbTongkythi.AutoSize = true;
            this.lbTongkythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongkythi.Location = new System.Drawing.Point(17, 224);
            this.lbTongkythi.Name = "lbTongkythi";
            this.lbTongkythi.Size = new System.Drawing.Size(106, 29);
            this.lbTongkythi.TabIndex = 3;
            this.lbTongkythi.Text = "Có tất cả";
            // 
            // txtNgaythi
            // 
            this.txtNgaythi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.txtNgaythi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgaythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaythi.Location = new System.Drawing.Point(23, 158);
            this.txtNgaythi.Name = "txtNgaythi";
            this.txtNgaythi.Size = new System.Drawing.Size(300, 31);
            this.txtNgaythi.TabIndex = 2;
            this.txtNgaythi.Text = "abc";
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(22, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 2);
            this.panel1.TabIndex = 1;
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
            this.xuiClock1.Location = new System.Drawing.Point(421, 14);
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
            // dtpNgaythi
            // 
            this.dtpNgaythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaythi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaythi.Location = new System.Drawing.Point(12, 247);
            this.dtpNgaythi.Name = "dtpNgaythi";
            this.dtpNgaythi.Size = new System.Drawing.Size(219, 28);
            this.dtpNgaythi.TabIndex = 1;
            // 
            // bnLichthi
            // 
            this.bnLichthi.BackColor = System.Drawing.Color.Transparent;
            this.bnLichthi.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.bnLichthi.BorderColor = System.Drawing.Color.White;
            this.bnLichthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnLichthi.ForeColor = System.Drawing.Color.White;
            this.bnLichthi.Location = new System.Drawing.Point(3, 3);
            this.bnLichthi.Name = "bnLichthi";
            this.bnLichthi.Size = new System.Drawing.Size(245, 106);
            this.bnLichthi.TabIndex = 0;
            this.bnLichthi.Text = "Lịch thi";
            // 
            // fLichthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLichthi";
            this.Text = "fLichthi";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.xuiGradientPanel2.ResumeLayout(false);
            this.xuiGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnTimkiem;
        private XanderUI.XUIGradientPanel xuiGradientPanel2;
        private System.Windows.Forms.DateTimePicker dtpNgaythi;
        private XanderUI.XUIBanner bnLichthi;
        private System.Windows.Forms.TextBox txtNgaythi;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIClock xuiClock1;
        private System.Windows.Forms.Label lbTongkythi;
        private XanderUI.XUIButton btnThoat;
        private XanderUI.XUISuperButton btnPre;
        private XanderUI.XUISuperButton btnNext;
        private XanderUI.XUIButton btnHuyboloc;
    }
}