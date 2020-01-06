namespace WindowsFormsApp2.FormGiaoVien
{
    partial class fThongkekythi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongkekythi));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLoi = new System.Windows.Forms.Label();
            this.lbKhoi = new System.Windows.Forms.Label();
            this.txtIDkythi = new System.Windows.Forms.TextBox();
            this.btnXem = new XanderUI.XUIButton();
            this.cbbKhoi = new System.Windows.Forms.ComboBox();
            this.lbIDkythi = new System.Windows.Forms.Label();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.dgvHocsinh = new System.Windows.Forms.DataGridView();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocsinh)).BeginInit();
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
            this.xuiFormDesign1.Size = new System.Drawing.Size(1203, 664);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.panel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThoat);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.dgvHocsinh);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1203, 625);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbLoi);
            this.panel1.Controls.Add(this.lbKhoi);
            this.panel1.Controls.Add(this.txtIDkythi);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.cbbKhoi);
            this.panel1.Controls.Add(this.lbIDkythi);
            this.panel1.Location = new System.Drawing.Point(928, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 380);
            this.panel1.TabIndex = 7;
            // 
            // lbLoi
            // 
            this.lbLoi.AutoSize = true;
            this.lbLoi.ForeColor = System.Drawing.Color.Red;
            this.lbLoi.Location = new System.Drawing.Point(110, 228);
            this.lbLoi.Name = "lbLoi";
            this.lbLoi.Size = new System.Drawing.Size(0, 17);
            this.lbLoi.TabIndex = 6;
            // 
            // lbKhoi
            // 
            this.lbKhoi.AutoSize = true;
            this.lbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoi.Location = new System.Drawing.Point(66, 32);
            this.lbKhoi.Name = "lbKhoi";
            this.lbKhoi.Size = new System.Drawing.Size(52, 25);
            this.lbKhoi.TabIndex = 4;
            this.lbKhoi.Text = "Khối";
            // 
            // txtIDkythi
            // 
            this.txtIDkythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDkythi.Location = new System.Drawing.Point(65, 172);
            this.txtIDkythi.Name = "txtIDkythi";
            this.txtIDkythi.Size = new System.Drawing.Size(127, 28);
            this.txtIDkythi.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXem.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnXem.ButtonImage")));
            this.btnXem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnXem.ButtonText = "Xem kỳ thi";
            this.btnXem.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnXem.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnXem.CornerRadius = 5;
            this.btnXem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnXem.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnXem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnXem.Location = new System.Drawing.Point(45, 278);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(173, 50);
            this.btnXem.TabIndex = 5;
            this.btnXem.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnXem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // cbbKhoi
            // 
            this.cbbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoi.FormattingEnabled = true;
            this.cbbKhoi.Location = new System.Drawing.Point(65, 75);
            this.cbbKhoi.Name = "cbbKhoi";
            this.cbbKhoi.Size = new System.Drawing.Size(121, 30);
            this.cbbKhoi.TabIndex = 2;
            // 
            // lbIDkythi
            // 
            this.lbIDkythi.AutoSize = true;
            this.lbIDkythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDkythi.Location = new System.Drawing.Point(66, 134);
            this.lbIDkythi.Name = "lbIDkythi";
            this.lbIDkythi.Size = new System.Drawing.Size(81, 25);
            this.lbIDkythi.TabIndex = 3;
            this.lbIDkythi.Text = "ID kỳ thi";
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
            this.btnThoat.Location = new System.Drawing.Point(1091, 573);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 6;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // dgvHocsinh
            // 
            this.dgvHocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocsinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvHocsinh.Location = new System.Drawing.Point(0, 0);
            this.dgvHocsinh.Name = "dgvHocsinh";
            this.dgvHocsinh.RowTemplate.Height = 24;
            this.dgvHocsinh.Size = new System.Drawing.Size(922, 625);
            this.dgvHocsinh.TabIndex = 0;
            // 
            // fThongkekythi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 664);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fThongkekythi";
            this.Text = "fThongkekythi";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocsinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLoi;
        private System.Windows.Forms.Label lbKhoi;
        private System.Windows.Forms.TextBox txtIDkythi;
        private XanderUI.XUIButton btnXem;
        private System.Windows.Forms.ComboBox cbbKhoi;
        private System.Windows.Forms.Label lbIDkythi;
        private XanderUI.XUISuperButton btnThoat;
        private System.Windows.Forms.DataGridView dgvHocsinh;
    }
}