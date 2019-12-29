namespace WindowsFormsApp2.FormQuanTri
{
    partial class fDanhsachnguoidung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhsachnguoidung));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.dgvDanhsach = new System.Windows.Forms.DataGridView();
            this.lbHeader = new System.Windows.Forms.Label();
            this.lbKhoi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLop = new System.Windows.Forms.Label();
            this.cbbKhoi = new System.Windows.Forms.ComboBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.btnPre = new XanderUI.XUISuperButton();
            this.btnNext = new XanderUI.XUISuperButton();
            this.lbChimuc = new System.Windows.Forms.Label();
            this.btnThoat = new XanderUI.XUIButton();
            this.btnStart = new XanderUI.XUISuperButton();
            this.btnLast = new XanderUI.XUISuperButton();
            this.btnChinhsua = new XanderUI.XUIButton();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsach)).BeginInit();
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
            this.xuiFormDesign1.Size = new System.Drawing.Size(966, 589);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnStart);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnLast);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThoat);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbChimuc);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnPre);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnNext);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.panel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.dgvDanhsach);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 30);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(966, 559);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // dgvDanhsach
            // 
            this.dgvDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsach.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvDanhsach.Location = new System.Drawing.Point(466, 0);
            this.dgvDanhsach.Name = "dgvDanhsach";
            this.dgvDanhsach.RowTemplate.Height = 24;
            this.dgvDanhsach.Size = new System.Drawing.Size(500, 559);
            this.dgvDanhsach.TabIndex = 0;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(117, 32);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(131, 32);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "lbHeader";
            // 
            // lbKhoi
            // 
            this.lbKhoi.AutoSize = true;
            this.lbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoi.Location = new System.Drawing.Point(66, 132);
            this.lbKhoi.Name = "lbKhoi";
            this.lbKhoi.Size = new System.Drawing.Size(52, 25);
            this.lbKhoi.TabIndex = 2;
            this.lbKhoi.Text = "Khối";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChinhsua);
            this.panel1.Controls.Add(this.cbbLop);
            this.panel1.Controls.Add(this.cbbKhoi);
            this.panel1.Controls.Add(this.lbHeader);
            this.panel1.Controls.Add(this.lbLop);
            this.panel1.Controls.Add(this.lbKhoi);
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 308);
            this.panel1.TabIndex = 3;
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(66, 191);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(45, 25);
            this.lbLop.TabIndex = 3;
            this.lbLop.Text = "Lớp";
            // 
            // cbbKhoi
            // 
            this.cbbKhoi.FormattingEnabled = true;
            this.cbbKhoi.Location = new System.Drawing.Point(182, 132);
            this.cbbKhoi.Name = "cbbKhoi";
            this.cbbKhoi.Size = new System.Drawing.Size(125, 24);
            this.cbbKhoi.TabIndex = 4;
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(182, 191);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(125, 24);
            this.cbbLop.TabIndex = 5;
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
            this.btnPre.Location = new System.Drawing.Point(57, 368);
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
            this.btnNext.Location = new System.Drawing.Point(226, 368);
            this.btnNext.Name = "btnNext";
            this.btnNext.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnNext.SelectedTextColor = System.Drawing.Color.White;
            this.btnNext.Size = new System.Drawing.Size(100, 40);
            this.btnNext.SuperSelected = false;
            this.btnNext.TabIndex = 16;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbChimuc
            // 
            this.lbChimuc.AutoSize = true;
            this.lbChimuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChimuc.Location = new System.Drawing.Point(163, 372);
            this.lbChimuc.Name = "lbChimuc";
            this.lbChimuc.Size = new System.Drawing.Size(57, 36);
            this.lbChimuc.TabIndex = 18;
            this.lbChimuc.Text = "0/0";
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThoat.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ButtonImage")));
            this.btnThoat.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnThoat.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.CornerRadius = 5;
            this.btnThoat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThoat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnThoat.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThoat.Location = new System.Drawing.Point(300, 504);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 40);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnStart.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnStart.ButtonImage")));
            this.btnStart.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnStart.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnStart.ButtonText = "Start";
            this.btnStart.CornerRadius = 5;
            this.btnStart.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnStart.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnStart.HoverTextColor = System.Drawing.Color.White;
            this.btnStart.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnStart.Location = new System.Drawing.Point(21, 414);
            this.btnStart.Name = "btnStart";
            this.btnStart.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.SelectedTextColor = System.Drawing.Color.White;
            this.btnStart.Size = new System.Drawing.Size(100, 40);
            this.btnStart.SuperSelected = false;
            this.btnStart.TabIndex = 20;
            this.btnStart.TextColor = System.Drawing.Color.White;
            this.btnStart.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnLast
            // 
            this.btnLast.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnLast.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnLast.ButtonImage")));
            this.btnLast.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnLast.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnLast.ButtonText = "Last";
            this.btnLast.CornerRadius = 5;
            this.btnLast.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLast.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnLast.HoverTextColor = System.Drawing.Color.White;
            this.btnLast.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnLast.Location = new System.Drawing.Point(269, 414);
            this.btnLast.Name = "btnLast";
            this.btnLast.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnLast.SelectedTextColor = System.Drawing.Color.White;
            this.btnLast.Size = new System.Drawing.Size(100, 40);
            this.btnLast.SuperSelected = false;
            this.btnLast.TabIndex = 19;
            this.btnLast.TextColor = System.Drawing.Color.White;
            this.btnLast.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnChinhsua
            // 
            this.btnChinhsua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChinhsua.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnChinhsua.ButtonImage")));
            this.btnChinhsua.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnChinhsua.ButtonText = "Chỉnh sửa";
            this.btnChinhsua.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnChinhsua.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChinhsua.CornerRadius = 5;
            this.btnChinhsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhsua.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChinhsua.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnChinhsua.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChinhsua.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnChinhsua.Location = new System.Drawing.Point(278, 251);
            this.btnChinhsua.Name = "btnChinhsua";
            this.btnChinhsua.Size = new System.Drawing.Size(134, 42);
            this.btnChinhsua.TabIndex = 6;
            this.btnChinhsua.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnChinhsua.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // fDanhsachnguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 589);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDanhsachnguoidung";
            this.Text = "fDanhsachHs";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.WorkingArea.PerformLayout();
            this.xuiFormDesign1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.DataGridView dgvDanhsach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.ComboBox cbbKhoi;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbKhoi;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label lbChimuc;
        private XanderUI.XUISuperButton btnPre;
        private XanderUI.XUISuperButton btnNext;
        private XanderUI.XUIButton btnThoat;
        private XanderUI.XUISuperButton btnStart;
        private XanderUI.XUISuperButton btnLast;
        private XanderUI.XUIButton btnChinhsua;
    }
}