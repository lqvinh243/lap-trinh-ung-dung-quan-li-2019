namespace WindowsFormsApp2.FormGiaoVien
{
    partial class fThemcauhoimoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemcauhoimoi));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbIDMade = new System.Windows.Forms.Label();
            this.lbKhoimade = new System.Windows.Forms.Label();
            this.txtIDmade = new System.Windows.Forms.TextBox();
            this.txtKhoi = new System.Windows.Forms.TextBox();
            this.lbKhoich = new System.Windows.Forms.Label();
            this.cbbKhoi = new System.Windows.Forms.ComboBox();
            this.btnThemcauhoi = new XanderUI.XUIButton();
            this.btnChitiet = new XanderUI.XUIButton();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.dgvCauhoi = new System.Windows.Forms.DataGridView();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauhoi)).BeginInit();
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
            this.xuiFormDesign1.Size = new System.Drawing.Size(1138, 625);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.panel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbKhoich);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.cbbKhoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThemcauhoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnChitiet);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThoat);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.dgvCauhoi);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1138, 586);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbIDMade);
            this.panel1.Controls.Add(this.lbKhoimade);
            this.panel1.Controls.Add(this.txtIDmade);
            this.panel1.Controls.Add(this.txtKhoi);
            this.panel1.Location = new System.Drawing.Point(953, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 190);
            this.panel1.TabIndex = 6;
            // 
            // lbIDMade
            // 
            this.lbIDMade.AutoSize = true;
            this.lbIDMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDMade.Location = new System.Drawing.Point(42, 108);
            this.lbIDMade.Name = "lbIDMade";
            this.lbIDMade.Size = new System.Drawing.Size(86, 24);
            this.lbIDMade.TabIndex = 8;
            this.lbIDMade.Text = "ID Mã đề";
            // 
            // lbKhoimade
            // 
            this.lbKhoimade.AutoSize = true;
            this.lbKhoimade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoimade.Location = new System.Drawing.Point(30, 18);
            this.lbKhoimade.Name = "lbKhoimade";
            this.lbKhoimade.Size = new System.Drawing.Size(107, 24);
            this.lbKhoimade.TabIndex = 7;
            this.lbKhoimade.Text = "Khối mã đề";
            // 
            // txtIDmade
            // 
            this.txtIDmade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDmade.Location = new System.Drawing.Point(37, 147);
            this.txtIDmade.Name = "txtIDmade";
            this.txtIDmade.Size = new System.Drawing.Size(100, 28);
            this.txtIDmade.TabIndex = 1;
            // 
            // txtKhoi
            // 
            this.txtKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoi.Location = new System.Drawing.Point(37, 59);
            this.txtKhoi.Name = "txtKhoi";
            this.txtKhoi.Size = new System.Drawing.Size(100, 28);
            this.txtKhoi.TabIndex = 0;
            // 
            // lbKhoich
            // 
            this.lbKhoich.AutoSize = true;
            this.lbKhoich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoich.Location = new System.Drawing.Point(983, 11);
            this.lbKhoich.Name = "lbKhoich";
            this.lbKhoich.Size = new System.Drawing.Size(115, 24);
            this.lbKhoich.TabIndex = 5;
            this.lbKhoich.Text = "Khối câu hỏi";
            // 
            // cbbKhoi
            // 
            this.cbbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoi.FormattingEnabled = true;
            this.cbbKhoi.Location = new System.Drawing.Point(987, 51);
            this.cbbKhoi.Name = "cbbKhoi";
            this.cbbKhoi.Size = new System.Drawing.Size(103, 30);
            this.cbbKhoi.TabIndex = 4;
            // 
            // btnThemcauhoi
            // 
            this.btnThemcauhoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemcauhoi.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnThemcauhoi.ButtonImage")));
            this.btnThemcauhoi.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnThemcauhoi.ButtonText = "Thêm câu hỏi";
            this.btnThemcauhoi.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnThemcauhoi.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThemcauhoi.CornerRadius = 5;
            this.btnThemcauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemcauhoi.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThemcauhoi.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnThemcauhoi.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThemcauhoi.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThemcauhoi.Location = new System.Drawing.Point(963, 354);
            this.btnThemcauhoi.Name = "btnThemcauhoi";
            this.btnThemcauhoi.Size = new System.Drawing.Size(163, 50);
            this.btnThemcauhoi.TabIndex = 3;
            this.btnThemcauhoi.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnThemcauhoi.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnChitiet
            // 
            this.btnChitiet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChitiet.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnChitiet.ButtonImage")));
            this.btnChitiet.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnChitiet.ButtonText = "Chi tiết câu hỏi";
            this.btnChitiet.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnChitiet.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChitiet.CornerRadius = 5;
            this.btnChitiet.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChitiet.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnChitiet.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChitiet.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnChitiet.Location = new System.Drawing.Point(963, 428);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.Size = new System.Drawing.Size(163, 50);
            this.btnChitiet.TabIndex = 2;
            this.btnChitiet.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnChitiet.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnThoat.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ButtonImage")));
            this.btnThoat.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnThoat.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.CornerRadius = 5;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThoat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnThoat.HoverTextColor = System.Drawing.Color.White;
            this.btnThoat.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnThoat.Location = new System.Drawing.Point(1026, 534);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 1;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // dgvCauhoi
            // 
            this.dgvCauhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauhoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCauhoi.Location = new System.Drawing.Point(0, 0);
            this.dgvCauhoi.MultiSelect = false;
            this.dgvCauhoi.Name = "dgvCauhoi";
            this.dgvCauhoi.RowTemplate.Height = 24;
            this.dgvCauhoi.Size = new System.Drawing.Size(947, 586);
            this.dgvCauhoi.TabIndex = 0;
            // 
            // fThemcauhoimoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 625);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fThemcauhoimoi";
            this.Text = "fThemcauhoimoi";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.WorkingArea.PerformLayout();
            this.xuiFormDesign1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauhoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbIDMade;
        private System.Windows.Forms.Label lbKhoimade;
        private System.Windows.Forms.TextBox txtIDmade;
        private System.Windows.Forms.TextBox txtKhoi;
        private System.Windows.Forms.Label lbKhoich;
        private System.Windows.Forms.ComboBox cbbKhoi;
        private XanderUI.XUIButton btnThemcauhoi;
        private XanderUI.XUIButton btnChitiet;
        private XanderUI.XUISuperButton btnThoat;
        private System.Windows.Forms.DataGridView dgvCauhoi;
    }
}