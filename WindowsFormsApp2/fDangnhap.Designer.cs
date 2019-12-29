namespace WindowsFormsApp2
{
    partial class fDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangnhap));
            this.fXDangnhap = new XanderUI.XUIFormDesign();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLoi = new System.Windows.Forms.Label();
            this.lbMatkhau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.btnDangnhap = new XanderUI.XUIButton();
            this.btnDangky = new XanderUI.XUIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fXDangnhap.WorkingArea.SuspendLayout();
            this.fXDangnhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // fXDangnhap
            // 
            this.fXDangnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fXDangnhap.ExitApplication = true;
            this.fXDangnhap.FormStyle = XanderUI.XUIFormDesign.Style.MacOS;
            this.fXDangnhap.Location = new System.Drawing.Point(0, 0);
            this.fXDangnhap.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.fXDangnhap.MaterialForeColor = System.Drawing.Color.White;
            this.fXDangnhap.Name = "fXDangnhap";
            this.fXDangnhap.ShowMaximize = true;
            this.fXDangnhap.ShowMinimize = true;
            this.fXDangnhap.Size = new System.Drawing.Size(800, 450);
            this.fXDangnhap.TabIndex = 0;
            this.fXDangnhap.TitleText = "Đăng nhập";
            // 
            // fXDangnhap.WorkingArea
            // 
            this.fXDangnhap.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.fXDangnhap.WorkingArea.Controls.Add(this.panel2);
            this.fXDangnhap.WorkingArea.Controls.Add(this.panel1);
            this.fXDangnhap.WorkingArea.Controls.Add(this.lbLoi);
            this.fXDangnhap.WorkingArea.Controls.Add(this.lbMatkhau);
            this.fXDangnhap.WorkingArea.Controls.Add(this.label1);
            this.fXDangnhap.WorkingArea.Controls.Add(this.txtPassword);
            this.fXDangnhap.WorkingArea.Controls.Add(this.txtUsername);
            this.fXDangnhap.WorkingArea.Controls.Add(this.xuiClock1);
            this.fXDangnhap.WorkingArea.Controls.Add(this.btnThoat);
            this.fXDangnhap.WorkingArea.Controls.Add(this.btnDangnhap);
            this.fXDangnhap.WorkingArea.Controls.Add(this.btnDangky);
            this.fXDangnhap.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fXDangnhap.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.fXDangnhap.WorkingArea.Name = "WorkingArea";
            this.fXDangnhap.WorkingArea.Size = new System.Drawing.Size(800, 411);
            this.fXDangnhap.WorkingArea.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(254, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 1);
            this.panel1.TabIndex = 9;
            // 
            // lbLoi
            // 
            this.lbLoi.AutoSize = true;
            this.lbLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoi.ForeColor = System.Drawing.Color.DarkRed;
            this.lbLoi.Location = new System.Drawing.Point(229, 221);
            this.lbLoi.Name = "lbLoi";
            this.lbLoi.Size = new System.Drawing.Size(0, 25);
            this.lbLoi.TabIndex = 8;
            // 
            // lbMatkhau
            // 
            this.lbMatkhau.AutoSize = true;
            this.lbMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatkhau.Location = new System.Drawing.Point(87, 163);
            this.lbMatkhau.Name = "lbMatkhau";
            this.lbMatkhau.Size = new System.Drawing.Size(131, 32);
            this.lbMatkhau.TabIndex = 7;
            this.lbMatkhau.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tài khoản";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(254, 161);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(239, 27);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(254, 71);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(239, 27);
            this.txtUsername.TabIndex = 4;
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
            this.xuiClock1.Location = new System.Drawing.Point(602, 24);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(137, 138);
            this.xuiClock1.TabIndex = 3;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnThoat.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ButtonImage")));
            this.btnThoat.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnThoat.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.CornerRadius = 5;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThoat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnThoat.HoverTextColor = System.Drawing.Color.White;
            this.btnThoat.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnThoat.Location = new System.Drawing.Point(671, 359);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(117, 40);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 2;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDangnhap.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnDangnhap.ButtonImage")));
            this.btnDangnhap.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDangnhap.ButtonText = "Đăng nhập";
            this.btnDangnhap.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnDangnhap.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDangnhap.CornerRadius = 5;
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDangnhap.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDangnhap.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDangnhap.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDangnhap.Location = new System.Drawing.Point(93, 268);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(210, 50);
            this.btnDangnhap.TabIndex = 1;
            this.btnDangnhap.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnDangnhap.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnDangky
            // 
            this.btnDangky.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDangky.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnDangky.ButtonImage")));
            this.btnDangky.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDangky.ButtonText = "Đăng ký";
            this.btnDangky.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnDangky.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDangky.CornerRadius = 5;
            this.btnDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangky.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDangky.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnDangky.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnDangky.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDangky.Location = new System.Drawing.Point(339, 268);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(200, 50);
            this.btnDangky.TabIndex = 0;
            this.btnDangky.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnDangky.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(254, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 1);
            this.panel2.TabIndex = 10;
            // 
            // fDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.fXDangnhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDangnhap";
            this.Text = "Form1";
            this.fXDangnhap.WorkingArea.ResumeLayout(false);
            this.fXDangnhap.WorkingArea.PerformLayout();
            this.fXDangnhap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign fXDangnhap;
        private System.Windows.Forms.Label lbMatkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private XanderUI.XUIClock xuiClock1;
        private XanderUI.XUISuperButton btnThoat;
        private XanderUI.XUIButton btnDangnhap;
        private XanderUI.XUIButton btnDangky;
        private System.Windows.Forms.Label lbLoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

