namespace WindowsFormsApp2.FormGiaoVien
{
    partial class fDanhsachdethi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhsachdethi));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.dgvDanhsachdethi = new System.Windows.Forms.DataGridView();
            this.dgvDanhsachcauhoi = new System.Windows.Forms.DataGridView();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.cbbKhoi = new System.Windows.Forms.ComboBox();
            this.lbKhoi = new System.Windows.Forms.Label();
            this.btnXoamade = new XanderUI.XUIButton();
            this.btnThemcauhoi = new XanderUI.XUIButton();
            this.btnXoacauhoi = new XanderUI.XUIButton();
            this.btnThemmade = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachdethi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachcauhoi)).BeginInit();
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
            this.xuiFormDesign1.Size = new System.Drawing.Size(1279, 621);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.panel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThemmade);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnXoacauhoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThemcauhoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnXoamade);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.lbKhoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.cbbKhoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThoat);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.dgvDanhsachcauhoi);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.dgvDanhsachdethi);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1279, 582);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // dgvDanhsachdethi
            // 
            this.dgvDanhsachdethi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachdethi.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDanhsachdethi.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhsachdethi.Name = "dgvDanhsachdethi";
            this.dgvDanhsachdethi.RowTemplate.Height = 24;
            this.dgvDanhsachdethi.Size = new System.Drawing.Size(356, 582);
            this.dgvDanhsachdethi.TabIndex = 0;
            // 
            // dgvDanhsachcauhoi
            // 
            this.dgvDanhsachcauhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachcauhoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvDanhsachcauhoi.Location = new System.Drawing.Point(549, 0);
            this.dgvDanhsachcauhoi.Name = "dgvDanhsachcauhoi";
            this.dgvDanhsachcauhoi.RowTemplate.Height = 24;
            this.dgvDanhsachcauhoi.Size = new System.Drawing.Size(730, 582);
            this.dgvDanhsachcauhoi.TabIndex = 1;
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
            this.btnThoat.Location = new System.Drawing.Point(443, 539);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 2;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // cbbKhoi
            // 
            this.cbbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoi.FormattingEnabled = true;
            this.cbbKhoi.Location = new System.Drawing.Point(390, 59);
            this.cbbKhoi.Name = "cbbKhoi";
            this.cbbKhoi.Size = new System.Drawing.Size(121, 30);
            this.cbbKhoi.TabIndex = 3;
            // 
            // lbKhoi
            // 
            this.lbKhoi.AutoSize = true;
            this.lbKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoi.Location = new System.Drawing.Point(415, 17);
            this.lbKhoi.Name = "lbKhoi";
            this.lbKhoi.Size = new System.Drawing.Size(52, 25);
            this.lbKhoi.TabIndex = 4;
            this.lbKhoi.Text = "Khối";
            // 
            // btnXoamade
            // 
            this.btnXoamade.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoamade.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnXoamade.ButtonImage")));
            this.btnXoamade.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnXoamade.ButtonText = "Xóa mã đề";
            this.btnXoamade.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnXoamade.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnXoamade.CornerRadius = 5;
            this.btnXoamade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoamade.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoamade.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnXoamade.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnXoamade.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnXoamade.Location = new System.Drawing.Point(377, 202);
            this.btnXoamade.Name = "btnXoamade";
            this.btnXoamade.Size = new System.Drawing.Size(146, 50);
            this.btnXoamade.TabIndex = 5;
            this.btnXoamade.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnXoamade.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnThemcauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemcauhoi.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThemcauhoi.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnThemcauhoi.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThemcauhoi.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThemcauhoi.Location = new System.Drawing.Point(377, 366);
            this.btnThemcauhoi.Name = "btnThemcauhoi";
            this.btnThemcauhoi.Size = new System.Drawing.Size(146, 50);
            this.btnThemcauhoi.TabIndex = 6;
            this.btnThemcauhoi.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnThemcauhoi.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnXoacauhoi
            // 
            this.btnXoacauhoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoacauhoi.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnXoacauhoi.ButtonImage")));
            this.btnXoacauhoi.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnXoacauhoi.ButtonText = "Xóa câu hỏi";
            this.btnXoacauhoi.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnXoacauhoi.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnXoacauhoi.CornerRadius = 5;
            this.btnXoacauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoacauhoi.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoacauhoi.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnXoacauhoi.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnXoacauhoi.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnXoacauhoi.Location = new System.Drawing.Point(377, 434);
            this.btnXoacauhoi.Name = "btnXoacauhoi";
            this.btnXoacauhoi.Size = new System.Drawing.Size(146, 50);
            this.btnXoacauhoi.TabIndex = 7;
            this.btnXoacauhoi.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnXoacauhoi.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnThemmade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmade.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThemmade.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnThemmade.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThemmade.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThemmade.Location = new System.Drawing.Point(377, 133);
            this.btnThemmade.Name = "btnThemmade";
            this.btnThemmade.Size = new System.Drawing.Size(146, 50);
            this.btnThemmade.TabIndex = 8;
            this.btnThemmade.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnThemmade.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(362, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 3);
            this.panel1.TabIndex = 9;
            // 
            // fDanhsachdethi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 621);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDanhsachdethi";
            this.Text = "fDanhsachdethi";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.WorkingArea.PerformLayout();
            this.xuiFormDesign1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachdethi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachcauhoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.Label lbKhoi;
        private System.Windows.Forms.ComboBox cbbKhoi;
        private XanderUI.XUISuperButton btnThoat;
        private System.Windows.Forms.DataGridView dgvDanhsachcauhoi;
        private System.Windows.Forms.DataGridView dgvDanhsachdethi;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btnThemmade;
        private XanderUI.XUIButton btnXoacauhoi;
        private XanderUI.XUIButton btnThemcauhoi;
        private XanderUI.XUIButton btnXoamade;
    }
}