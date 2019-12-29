namespace WindowsFormsApp2.FormGiaoVien
{
    partial class fThemmademoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemmademoi));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.lbIDmade = new System.Windows.Forms.Label();
            this.cbbKhoi = new System.Windows.Forms.ComboBox();
            this.txtIDmademoi = new System.Windows.Forms.TextBox();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.btnThemmade = new XanderUI.XUIButton();
            this.lbKhoi = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.Label();
            this.cbbDokho = new System.Windows.Forms.ComboBox();
            this.lbDokho = new System.Windows.Forms.Label();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
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
            this.xuiFormDesign1.Size = new System.Drawing.Size(631, 514);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.cbbDokho);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbDokho);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbHeader);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThemmade);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThoat);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.txtIDmademoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.cbbKhoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbKhoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbIDmade);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiSlidingPanel1);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(631, 475);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // xuiSlidingPanel1
            // 
            this.xuiSlidingPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.xuiSlidingPanel1.CollapseControl = null;
            this.xuiSlidingPanel1.Collapsed = true;
            this.xuiSlidingPanel1.Controls.Add(this.xuiClock1);
            this.xuiSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiSlidingPanel1.HideControls = false;
            this.xuiSlidingPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiSlidingPanel1.Name = "xuiSlidingPanel1";
            this.xuiSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuiSlidingPanel1.PanelWidthExpanded = 200;
            this.xuiSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiSlidingPanel1.Size = new System.Drawing.Size(203, 475);
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
            this.xuiClock1.Location = new System.Drawing.Point(39, 52);
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
            // lbIDmade
            // 
            this.lbIDmade.AutoSize = true;
            this.lbIDmade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDmade.Location = new System.Drawing.Point(281, 187);
            this.lbIDmade.Name = "lbIDmade";
            this.lbIDmade.Size = new System.Drawing.Size(90, 25);
            this.lbIDmade.TabIndex = 1;
            this.lbIDmade.Text = "ID mã đề";
            // 
            // cbbKhoi
            // 
            this.cbbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoi.FormattingEnabled = true;
            this.cbbKhoi.Location = new System.Drawing.Point(397, 124);
            this.cbbKhoi.Name = "cbbKhoi";
            this.cbbKhoi.Size = new System.Drawing.Size(121, 30);
            this.cbbKhoi.TabIndex = 2;
            // 
            // txtIDmademoi
            // 
            this.txtIDmademoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDmademoi.Location = new System.Drawing.Point(397, 186);
            this.txtIDmademoi.Name = "txtIDmademoi";
            this.txtIDmademoi.Size = new System.Drawing.Size(121, 28);
            this.txtIDmademoi.TabIndex = 3;
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
            this.btnThoat.Location = new System.Drawing.Point(519, 423);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 4;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnThemmade
            // 
            this.btnThemmade.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemmade.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnThemmade.ButtonImage")));
            this.btnThemmade.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnThemmade.ButtonText = "Thêm mã đề";
            this.btnThemmade.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnThemmade.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThemmade.CornerRadius = 5;
            this.btnThemmade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmade.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThemmade.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnThemmade.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThemmade.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThemmade.Location = new System.Drawing.Point(302, 314);
            this.btnThemmade.Name = "btnThemmade";
            this.btnThemmade.Size = new System.Drawing.Size(200, 50);
            this.btnThemmade.TabIndex = 5;
            this.btnThemmade.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnThemmade.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbKhoi
            // 
            this.lbKhoi.AutoSize = true;
            this.lbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoi.Location = new System.Drawing.Point(297, 129);
            this.lbKhoi.Name = "lbKhoi";
            this.lbKhoi.Size = new System.Drawing.Size(52, 25);
            this.lbKhoi.TabIndex = 1;
            this.lbKhoi.Text = "Khối";
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(308, 29);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(225, 32);
            this.lbHeader.TabIndex = 6;
            this.lbHeader.Text = "Thêm mã đề mới";
            // 
            // cbbDokho
            // 
            this.cbbDokho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDokho.FormattingEnabled = true;
            this.cbbDokho.Location = new System.Drawing.Point(397, 239);
            this.cbbDokho.Name = "cbbDokho";
            this.cbbDokho.Size = new System.Drawing.Size(121, 30);
            this.cbbDokho.TabIndex = 8;
            // 
            // lbDokho
            // 
            this.lbDokho.AutoSize = true;
            this.lbDokho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDokho.Location = new System.Drawing.Point(297, 244);
            this.lbDokho.Name = "lbDokho";
            this.lbDokho.Size = new System.Drawing.Size(74, 25);
            this.lbDokho.TabIndex = 7;
            this.lbDokho.Text = "Độ khó";
            // 
            // fThemmademoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 514);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fThemmademoi";
            this.Text = "fThemmademoi";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.WorkingArea.PerformLayout();
            this.xuiFormDesign1.ResumeLayout(false);
            this.xuiSlidingPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.Label lbIDmade;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private XanderUI.XUIClock xuiClock1;
        private XanderUI.XUIButton btnThemmade;
        private XanderUI.XUISuperButton btnThoat;
        private System.Windows.Forms.TextBox txtIDmademoi;
        private System.Windows.Forms.ComboBox cbbKhoi;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label lbKhoi;
        private System.Windows.Forms.ComboBox cbbDokho;
        private System.Windows.Forms.Label lbDokho;
    }
}