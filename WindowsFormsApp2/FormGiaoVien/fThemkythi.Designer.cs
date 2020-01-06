namespace WindowsFormsApp2.FormGiaoVien
{
    partial class fThemkythi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemkythi));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbKhoi = new System.Windows.Forms.ComboBox();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.lbLoi = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.Label();
            this.dtpNgaythi = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new XanderUI.XUIButton();
            this.txtMakythi = new System.Windows.Forms.TextBox();
            this.lbThoigian = new System.Windows.Forms.Label();
            this.txtThoigian = new System.Windows.Forms.TextBox();
            this.cbThithu = new XanderUI.XUICheckBox();
            this.lbMakythi = new System.Windows.Forms.Label();
            this.lbKhoikythi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.xuiFormDesign1.Size = new System.Drawing.Size(972, 523);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.panel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiSlidingPanel1);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 30);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(972, 493);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbKhoi);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.lbLoi);
            this.panel1.Controls.Add(this.lbHeader);
            this.panel1.Controls.Add(this.dtpNgaythi);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtMakythi);
            this.panel1.Controls.Add(this.lbThoigian);
            this.panel1.Controls.Add(this.txtThoigian);
            this.panel1.Controls.Add(this.cbThithu);
            this.panel1.Controls.Add(this.lbMakythi);
            this.panel1.Controls.Add(this.lbKhoikythi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(315, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 493);
            this.panel1.TabIndex = 12;
            // 
            // cbbKhoi
            // 
            this.cbbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoi.FormattingEnabled = true;
            this.cbbKhoi.Location = new System.Drawing.Point(305, 136);
            this.cbbKhoi.Name = "cbbKhoi";
            this.cbbKhoi.Size = new System.Drawing.Size(164, 30);
            this.cbbKhoi.TabIndex = 14;
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
            this.btnThoat.Location = new System.Drawing.Point(545, 441);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 4;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbLoi
            // 
            this.lbLoi.AutoSize = true;
            this.lbLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoi.ForeColor = System.Drawing.Color.Red;
            this.lbLoi.Location = new System.Drawing.Point(302, 365);
            this.lbLoi.Name = "lbLoi";
            this.lbLoi.Size = new System.Drawing.Size(0, 20);
            this.lbLoi.TabIndex = 13;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(189, 12);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(253, 29);
            this.lbHeader.TabIndex = 12;
            this.lbHeader.Text = "Thêm mã đề của kỳ thi";
            // 
            // dtpNgaythi
            // 
            this.dtpNgaythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaythi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaythi.Location = new System.Drawing.Point(305, 202);
            this.dtpNgaythi.Name = "dtpNgaythi";
            this.dtpNgaythi.Size = new System.Drawing.Size(164, 34);
            this.dtpNgaythi.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThem.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ButtonImage")));
            this.btnThem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnThem.ButtonText = "Thêm kỳ thi";
            this.btnThem.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnThem.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.CornerRadius = 5;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnThem.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThem.Location = new System.Drawing.Point(233, 409);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(200, 50);
            this.btnThem.TabIndex = 5;
            this.btnThem.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // txtMakythi
            // 
            this.txtMakythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakythi.Location = new System.Drawing.Point(305, 80);
            this.txtMakythi.Name = "txtMakythi";
            this.txtMakythi.Size = new System.Drawing.Size(164, 34);
            this.txtMakythi.TabIndex = 1;
            // 
            // lbThoigian
            // 
            this.lbThoigian.AutoSize = true;
            this.lbThoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoigian.Location = new System.Drawing.Point(154, 265);
            this.lbThoigian.Name = "lbThoigian";
            this.lbThoigian.Size = new System.Drawing.Size(145, 29);
            this.lbThoigian.TabIndex = 9;
            this.lbThoigian.Text = "Thời gian thi";
            // 
            // txtThoigian
            // 
            this.txtThoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoigian.Location = new System.Drawing.Point(305, 265);
            this.txtThoigian.Name = "txtThoigian";
            this.txtThoigian.Size = new System.Drawing.Size(164, 34);
            this.txtThoigian.TabIndex = 10;
            // 
            // cbThithu
            // 
            this.cbThithu.CheckboxCheckColor = System.Drawing.Color.White;
            this.cbThithu.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.cbThithu.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.cbThithu.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.cbThithu.Checked = false;
            this.cbThithu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThithu.ForeColor = System.Drawing.Color.Black;
            this.cbThithu.Location = new System.Drawing.Point(352, 316);
            this.cbThithu.Name = "cbThithu";
            this.cbThithu.Size = new System.Drawing.Size(165, 33);
            this.cbThithu.TabIndex = 3;
            this.cbThithu.Text = "Đề thi thử";
            this.cbThithu.TickThickness = 2;
            // 
            // lbMakythi
            // 
            this.lbMakythi.AutoSize = true;
            this.lbMakythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMakythi.Location = new System.Drawing.Point(177, 83);
            this.lbMakythi.Name = "lbMakythi";
            this.lbMakythi.Size = new System.Drawing.Size(101, 29);
            this.lbMakythi.TabIndex = 0;
            this.lbMakythi.Text = "Mã kì thi";
            // 
            // lbKhoikythi
            // 
            this.lbKhoikythi.AutoSize = true;
            this.lbKhoikythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoikythi.Location = new System.Drawing.Point(177, 133);
            this.lbKhoikythi.Name = "lbKhoikythi";
            this.lbKhoikythi.Size = new System.Drawing.Size(122, 29);
            this.lbKhoikythi.TabIndex = 6;
            this.lbKhoikythi.Text = "Khối kỳ thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ngày thi";
            // 
            // xuiSlidingPanel1
            // 
            this.xuiSlidingPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.xuiSlidingPanel1.CollapseControl = null;
            this.xuiSlidingPanel1.Collapsed = true;
            this.xuiSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiSlidingPanel1.HideControls = false;
            this.xuiSlidingPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiSlidingPanel1.Name = "xuiSlidingPanel1";
            this.xuiSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuiSlidingPanel1.PanelWidthExpanded = 200;
            this.xuiSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiSlidingPanel1.Size = new System.Drawing.Size(315, 493);
            this.xuiSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanel1.TabIndex = 11;
            this.xuiSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // fThemkythi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 523);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fThemkythi";
            this.Text = "fThemkythi";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.Label lbLoi;
        private System.Windows.Forms.Label lbHeader;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private System.Windows.Forms.TextBox txtThoigian;
        private System.Windows.Forms.Label lbThoigian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbKhoikythi;
        private XanderUI.XUIButton btnThem;
        private XanderUI.XUISuperButton btnThoat;
        private XanderUI.XUICheckBox cbThithu;
        private System.Windows.Forms.DateTimePicker dtpNgaythi;
        private System.Windows.Forms.TextBox txtMakythi;
        private System.Windows.Forms.Label lbMakythi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbKhoi;
    }
}