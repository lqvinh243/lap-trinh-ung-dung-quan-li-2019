namespace WindowsFormsApp2.FormHocSinh
{
    partial class fCTKythi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCTKythi));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.lbMotacauhoi = new System.Windows.Forms.Label();
            this.btnPre = new XanderUI.XUISuperButton();
            this.btnNext = new XanderUI.XUISuperButton();
            this.btnHoanthanh = new XanderUI.XUISuperButton();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.lbMade = new System.Windows.Forms.Label();
            this.txtMade = new System.Windows.Forms.TextBox();
            this.txtNgaylam = new System.Windows.Forms.TextBox();
            this.clbDapan = new System.Windows.Forms.CheckedListBox();
            this.timingthi = new System.Windows.Forms.Timer(this.components);
            this.lbThoigian = new System.Windows.Forms.Label();
            this.lbPhut = new System.Windows.Forms.Label();
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
            this.xuiFormDesign1.Size = new System.Drawing.Size(1322, 629);
            this.xuiFormDesign1.TabIndex = 1;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbMotacauhoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnPre);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnNext);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnHoanthanh);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.label1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiSlidingPanel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.clbDapan);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1322, 590);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // lbMotacauhoi
            // 
            this.lbMotacauhoi.AutoSize = true;
            this.lbMotacauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotacauhoi.Location = new System.Drawing.Point(379, 30);
            this.lbMotacauhoi.Name = "lbMotacauhoi";
            this.lbMotacauhoi.Size = new System.Drawing.Size(108, 32);
            this.lbMotacauhoi.TabIndex = 27;
            this.lbMotacauhoi.Text = "Motach";
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
            this.btnPre.Location = new System.Drawing.Point(659, 445);
            this.btnPre.Name = "btnPre";
            this.btnPre.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnPre.SelectedTextColor = System.Drawing.Color.White;
            this.btnPre.Size = new System.Drawing.Size(100, 38);
            this.btnPre.SuperSelected = false;
            this.btnPre.TabIndex = 18;
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
            this.btnNext.Location = new System.Drawing.Point(825, 445);
            this.btnNext.Name = "btnNext";
            this.btnNext.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnNext.SelectedTextColor = System.Drawing.Color.White;
            this.btnNext.Size = new System.Drawing.Size(100, 38);
            this.btnNext.SuperSelected = false;
            this.btnNext.TabIndex = 17;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnHoanthanh
            // 
            this.btnHoanthanh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnHoanthanh.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnHoanthanh.ButtonImage")));
            this.btnHoanthanh.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnHoanthanh.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnHoanthanh.ButtonText = "Hoàn thành";
            this.btnHoanthanh.CornerRadius = 5;
            this.btnHoanthanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanthanh.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHoanthanh.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnHoanthanh.HoverTextColor = System.Drawing.Color.White;
            this.btnHoanthanh.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnHoanthanh.Location = new System.Drawing.Point(1155, 528);
            this.btnHoanthanh.Name = "btnHoanthanh";
            this.btnHoanthanh.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnHoanthanh.SelectedTextColor = System.Drawing.Color.White;
            this.btnHoanthanh.Size = new System.Drawing.Size(155, 40);
            this.btnHoanthanh.SuperSelected = false;
            this.btnHoanthanh.TabIndex = 3;
            this.btnHoanthanh.TextColor = System.Drawing.Color.White;
            this.btnHoanthanh.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Câu hỏi";
            // 
            // xuiSlidingPanel1
            // 
            this.xuiSlidingPanel1.BottomLeft = System.Drawing.Color.DarkGray;
            this.xuiSlidingPanel1.BottomRight = System.Drawing.Color.CadetBlue;
            this.xuiSlidingPanel1.CollapseControl = null;
            this.xuiSlidingPanel1.Collapsed = true;
            this.xuiSlidingPanel1.Controls.Add(this.lbPhut);
            this.xuiSlidingPanel1.Controls.Add(this.lbThoigian);
            this.xuiSlidingPanel1.Controls.Add(this.lbMade);
            this.xuiSlidingPanel1.Controls.Add(this.txtMade);
            this.xuiSlidingPanel1.Controls.Add(this.txtNgaylam);
            this.xuiSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiSlidingPanel1.HideControls = false;
            this.xuiSlidingPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiSlidingPanel1.Name = "xuiSlidingPanel1";
            this.xuiSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuiSlidingPanel1.PanelWidthExpanded = 200;
            this.xuiSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiSlidingPanel1.Size = new System.Drawing.Size(254, 590);
            this.xuiSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanel1.TabIndex = 1;
            this.xuiSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuiSlidingPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // lbMade
            // 
            this.lbMade.AutoSize = true;
            this.lbMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMade.Location = new System.Drawing.Point(28, 77);
            this.lbMade.Name = "lbMade";
            this.lbMade.Size = new System.Drawing.Size(80, 29);
            this.lbMade.TabIndex = 2;
            this.lbMade.Text = "Mã đề";
            // 
            // txtMade
            // 
            this.txtMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMade.Location = new System.Drawing.Point(125, 76);
            this.txtMade.Name = "txtMade";
            this.txtMade.Size = new System.Drawing.Size(41, 30);
            this.txtMade.TabIndex = 2;
            // 
            // txtNgaylam
            // 
            this.txtNgaylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaylam.Location = new System.Drawing.Point(12, 30);
            this.txtNgaylam.Name = "txtNgaylam";
            this.txtNgaylam.Size = new System.Drawing.Size(226, 28);
            this.txtNgaylam.TabIndex = 2;
            // 
            // clbDapan
            // 
            this.clbDapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbDapan.FormattingEnabled = true;
            this.clbDapan.Location = new System.Drawing.Point(329, 136);
            this.clbDapan.Name = "clbDapan";
            this.clbDapan.Size = new System.Drawing.Size(844, 265);
            this.clbDapan.TabIndex = 0;
            // 
            // timingthi
            // 
            this.timingthi.Interval = 1000;
            // 
            // lbThoigian
            // 
            this.lbThoigian.AutoSize = true;
            this.lbThoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoigian.Location = new System.Drawing.Point(15, 213);
            this.lbThoigian.Name = "lbThoigian";
            this.lbThoigian.Size = new System.Drawing.Size(223, 32);
            this.lbThoigian.TabIndex = 3;
            this.lbThoigian.Text = "Thời gian còn lại";
            // 
            // lbPhut
            // 
            this.lbPhut.AutoSize = true;
            this.lbPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhut.ForeColor = System.Drawing.Color.Red;
            this.lbPhut.Location = new System.Drawing.Point(73, 287);
            this.lbPhut.Name = "lbPhut";
            this.lbPhut.Size = new System.Drawing.Size(71, 32);
            this.lbPhut.TabIndex = 4;
            this.lbPhut.Text = "phút";
            // 
            // fCTKythi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 629);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCTKythi";
            this.Text = "fCTKythi";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.WorkingArea.PerformLayout();
            this.xuiFormDesign1.ResumeLayout(false);
            this.xuiSlidingPanel1.ResumeLayout(false);
            this.xuiSlidingPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.Label lbMotacauhoi;
        private XanderUI.XUISuperButton btnPre;
        private XanderUI.XUISuperButton btnNext;
        private XanderUI.XUISuperButton btnHoanthanh;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private System.Windows.Forms.Label lbMade;
        private System.Windows.Forms.TextBox txtMade;
        private System.Windows.Forms.TextBox txtNgaylam;
        private System.Windows.Forms.CheckedListBox clbDapan;
        private System.Windows.Forms.Timer timingthi;
        private System.Windows.Forms.Label lbPhut;
        private System.Windows.Forms.Label lbThoigian;
    }
}