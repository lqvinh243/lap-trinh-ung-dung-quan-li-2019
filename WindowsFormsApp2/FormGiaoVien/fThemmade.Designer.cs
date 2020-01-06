namespace WindowsFormsApp2.FormGiaoVien
{
    partial class fThemmade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemmade));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLoi = new System.Windows.Forms.Label();
            this.btnThemmade = new XanderUI.XUIButton();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtKhoi = new System.Windows.Forms.TextBox();
            this.txtKythi = new System.Windows.Forms.TextBox();
            this.lbKhoiKythi = new System.Windows.Forms.Label();
            this.lbIDKythi = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.Label();
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.dgvMade = new System.Windows.Forms.DataGridView();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.xuiSlidingPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMade)).BeginInit();
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
            this.xuiFormDesign1.Size = new System.Drawing.Size(885, 487);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.dgvMade);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.panel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiSlidingPanel1);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(885, 448);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbLoi);
            this.panel1.Controls.Add(this.btnThemmade);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtKhoi);
            this.panel1.Controls.Add(this.txtKythi);
            this.panel1.Controls.Add(this.lbKhoiKythi);
            this.panel1.Controls.Add(this.lbIDKythi);
            this.panel1.Controls.Add(this.lbHeader);
            this.panel1.Location = new System.Drawing.Point(194, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 448);
            this.panel1.TabIndex = 2;
            // 
            // lbLoi
            // 
            this.lbLoi.AutoSize = true;
            this.lbLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoi.ForeColor = System.Drawing.Color.Red;
            this.lbLoi.Location = new System.Drawing.Point(129, 201);
            this.lbLoi.Name = "lbLoi";
            this.lbLoi.Size = new System.Drawing.Size(0, 20);
            this.lbLoi.TabIndex = 14;
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
            this.btnThemmade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmade.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThemmade.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnThemmade.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThemmade.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThemmade.Location = new System.Drawing.Point(99, 266);
            this.btnThemmade.Name = "btnThemmade";
            this.btnThemmade.Size = new System.Drawing.Size(175, 54);
            this.btnThemmade.TabIndex = 13;
            this.btnThemmade.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnThemmade.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnThoat.Location = new System.Drawing.Point(325, 396);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 12;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(206, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(78, 2);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(206, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 2);
            this.panel2.TabIndex = 10;
            // 
            // txtKhoi
            // 
            this.txtKhoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtKhoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoi.Location = new System.Drawing.Point(206, 117);
            this.txtKhoi.Name = "txtKhoi";
            this.txtKhoi.Size = new System.Drawing.Size(68, 27);
            this.txtKhoi.TabIndex = 9;
            // 
            // txtKythi
            // 
            this.txtKythi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtKythi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKythi.Location = new System.Drawing.Point(206, 73);
            this.txtKythi.Name = "txtKythi";
            this.txtKythi.Size = new System.Drawing.Size(68, 27);
            this.txtKythi.TabIndex = 8;
            // 
            // lbKhoiKythi
            // 
            this.lbKhoiKythi.AutoSize = true;
            this.lbKhoiKythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoiKythi.Location = new System.Drawing.Point(43, 121);
            this.lbKhoiKythi.Name = "lbKhoiKythi";
            this.lbKhoiKythi.Size = new System.Drawing.Size(146, 24);
            this.lbKhoiKythi.TabIndex = 7;
            this.lbKhoiKythi.Text = "Khối của kỳ thi";
            // 
            // lbIDKythi
            // 
            this.lbIDKythi.AutoSize = true;
            this.lbIDKythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDKythi.Location = new System.Drawing.Point(43, 71);
            this.lbIDKythi.Name = "lbIDKythi";
            this.lbIDKythi.Size = new System.Drawing.Size(86, 24);
            this.lbIDKythi.TabIndex = 6;
            this.lbIDKythi.Text = "ID Kỳ thi";
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(126, 22);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(203, 24);
            this.lbHeader.TabIndex = 5;
            this.lbHeader.Text = "Thêm mã đề cho kỳ thi";
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
            this.xuiSlidingPanel1.Size = new System.Drawing.Size(194, 448);
            this.xuiSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanel1.TabIndex = 1;
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
            this.xuiClock1.Location = new System.Drawing.Point(33, 47);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(120, 130);
            this.xuiClock1.TabIndex = 13;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // dgvMade
            // 
            this.dgvMade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMade.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvMade.Location = new System.Drawing.Point(645, 0);
            this.dgvMade.Name = "dgvMade";
            this.dgvMade.RowTemplate.Height = 24;
            this.dgvMade.Size = new System.Drawing.Size(240, 448);
            this.dgvMade.TabIndex = 3;
            // 
            // fThemmade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 487);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fThemmade";
            this.Text = "fThemmade";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.xuiSlidingPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtKhoi;
        private System.Windows.Forms.TextBox txtKythi;
        private System.Windows.Forms.Label lbKhoiKythi;
        private System.Windows.Forms.Label lbIDKythi;
        private System.Windows.Forms.Label lbHeader;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private System.Windows.Forms.Panel panel3;
        private XanderUI.XUIButton btnThemmade;
        private XanderUI.XUISuperButton btnThoat;
        private XanderUI.XUIClock xuiClock1;
        private System.Windows.Forms.Label lbLoi;
        private System.Windows.Forms.DataGridView dgvMade;
    }
}