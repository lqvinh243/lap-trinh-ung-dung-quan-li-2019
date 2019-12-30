namespace WindowsFormsApp2.FormGiaoVien
{
    partial class fXemketquahocsinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fXemketquahocsinh));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.dgvKetqua = new System.Windows.Forms.DataGridView();
            this.txtIDhs = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btnXem = new XanderUI.XUIButton();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.lbLoi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetqua)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.xuiFormDesign1.Size = new System.Drawing.Size(1000, 725);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.panel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThoat);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.dgvKetqua);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1000, 686);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // dgvKetqua
            // 
            this.dgvKetqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetqua.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvKetqua.Location = new System.Drawing.Point(0, 0);
            this.dgvKetqua.Name = "dgvKetqua";
            this.dgvKetqua.RowTemplate.Height = 24;
            this.dgvKetqua.Size = new System.Drawing.Size(765, 686);
            this.dgvKetqua.TabIndex = 0;
            // 
            // txtIDhs
            // 
            this.txtIDhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDhs.Location = new System.Drawing.Point(18, 85);
            this.txtIDhs.Name = "txtIDhs";
            this.txtIDhs.Size = new System.Drawing.Size(193, 28);
            this.txtIDhs.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(30, 39);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(161, 25);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "Nhập ID học sinh";
            // 
            // btnXem
            // 
            this.btnXem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXem.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnXem.ButtonImage")));
            this.btnXem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnXem.ButtonText = "Xem kết quả";
            this.btnXem.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnXem.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnXem.CornerRadius = 5;
            this.btnXem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnXem.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnXem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnXem.Location = new System.Drawing.Point(35, 200);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(156, 50);
            this.btnXem.TabIndex = 3;
            this.btnXem.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnXem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnThoat.Location = new System.Drawing.Point(888, 634);
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
            this.lbLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoi.ForeColor = System.Drawing.Color.Red;
            this.lbLoi.Location = new System.Drawing.Point(90, 143);
            this.lbLoi.Name = "lbLoi";
            this.lbLoi.Size = new System.Drawing.Size(39, 18);
            this.lbLoi.TabIndex = 5;
            this.lbLoi.Text = "lbLoi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.lbLoi);
            this.panel1.Controls.Add(this.txtIDhs);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Location = new System.Drawing.Point(768, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 287);
            this.panel1.TabIndex = 6;
            // 
            // fXemketquahocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 725);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fXemketquahocsinh";
            this.Text = "fXemketquahocsinh";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetqua)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLoi;
        private XanderUI.XUISuperButton btnThoat;
        private XanderUI.XUIButton btnXem;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtIDhs;
        private System.Windows.Forms.DataGridView dgvKetqua;
    }
}