namespace WindowsFormsApp2.FormGiaoVien
{
    partial class fThaotaccauhoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThaotaccauhoi));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.dgvCauhoi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCauHoi = new System.Windows.Forms.RichTextBox();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.txtDAA = new System.Windows.Forms.TextBox();
            this.txtDAB = new System.Windows.Forms.TextBox();
            this.txtDAC = new System.Windows.Forms.TextBox();
            this.txtDAD = new System.Windows.Forms.TextBox();
            this.txtDAE = new System.Windows.Forms.TextBox();
            this.btnCapnhat = new XanderUI.XUIButton();
            this.btnChinhsua = new XanderUI.XUIButton();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbD = new System.Windows.Forms.Label();
            this.lbE = new System.Windows.Forms.Label();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauhoi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiFormDesign1
            // 
            this.xuiFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.ExitApplication = true;
            this.xuiFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.Material;
            this.xuiFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuiFormDesign1.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuiFormDesign1.Name = "xuiFormDesign1";
            this.xuiFormDesign1.ShowMaximize = true;
            this.xuiFormDesign1.ShowMinimize = true;
            this.xuiFormDesign1.Size = new System.Drawing.Size(1407, 752);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.White;
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.panel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.dgvCauhoi);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 74);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1407, 678);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // dgvCauhoi
            // 
            this.dgvCauhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauhoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCauhoi.Location = new System.Drawing.Point(0, 0);
            this.dgvCauhoi.Name = "dgvCauhoi";
            this.dgvCauhoi.RowTemplate.Height = 24;
            this.dgvCauhoi.Size = new System.Drawing.Size(557, 678);
            this.dgvCauhoi.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbE);
            this.panel1.Controls.Add(this.lbD);
            this.panel1.Controls.Add(this.lbC);
            this.panel1.Controls.Add(this.lbB);
            this.panel1.Controls.Add(this.lbA);
            this.panel1.Controls.Add(this.btnChinhsua);
            this.panel1.Controls.Add(this.btnCapnhat);
            this.panel1.Controls.Add(this.txtDAE);
            this.panel1.Controls.Add(this.txtDAD);
            this.panel1.Controls.Add(this.txtDAC);
            this.panel1.Controls.Add(this.txtDAB);
            this.panel1.Controls.Add(this.txtDAA);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.txtCauHoi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(552, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 678);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết câu hỏi";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauHoi.Location = new System.Drawing.Point(70, 95);
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(756, 121);
            this.txtCauHoi.TabIndex = 1;
            this.txtCauHoi.Text = "";
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
            this.btnThoat.Location = new System.Drawing.Point(743, 626);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 2;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // txtDAA
            // 
            this.txtDAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDAA.Location = new System.Drawing.Point(70, 256);
            this.txtDAA.Multiline = true;
            this.txtDAA.Name = "txtDAA";
            this.txtDAA.Size = new System.Drawing.Size(361, 99);
            this.txtDAA.TabIndex = 3;
            // 
            // txtDAB
            // 
            this.txtDAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDAB.Location = new System.Drawing.Point(508, 256);
            this.txtDAB.Multiline = true;
            this.txtDAB.Name = "txtDAB";
            this.txtDAB.Size = new System.Drawing.Size(342, 99);
            this.txtDAB.TabIndex = 4;
            // 
            // txtDAC
            // 
            this.txtDAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDAC.Location = new System.Drawing.Point(70, 375);
            this.txtDAC.Multiline = true;
            this.txtDAC.Name = "txtDAC";
            this.txtDAC.Size = new System.Drawing.Size(361, 98);
            this.txtDAC.TabIndex = 5;
            // 
            // txtDAD
            // 
            this.txtDAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDAD.Location = new System.Drawing.Point(508, 375);
            this.txtDAD.Multiline = true;
            this.txtDAD.Name = "txtDAD";
            this.txtDAD.Size = new System.Drawing.Size(342, 98);
            this.txtDAD.TabIndex = 6;
            // 
            // txtDAE
            // 
            this.txtDAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDAE.Location = new System.Drawing.Point(70, 503);
            this.txtDAE.Multiline = true;
            this.txtDAE.Name = "txtDAE";
            this.txtDAE.Size = new System.Drawing.Size(361, 85);
            this.txtDAE.TabIndex = 7;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCapnhat.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnCapnhat.ButtonImage")));
            this.btnCapnhat.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCapnhat.ButtonText = "Cập nhật";
            this.btnCapnhat.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCapnhat.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCapnhat.CornerRadius = 5;
            this.btnCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCapnhat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCapnhat.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCapnhat.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCapnhat.Location = new System.Drawing.Point(508, 550);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(146, 50);
            this.btnCapnhat.TabIndex = 8;
            this.btnCapnhat.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnCapnhat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnChinhsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhsua.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChinhsua.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnChinhsua.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChinhsua.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnChinhsua.Location = new System.Drawing.Point(704, 550);
            this.btnChinhsua.Name = "btnChinhsua";
            this.btnChinhsua.Size = new System.Drawing.Size(146, 50);
            this.btnChinhsua.TabIndex = 9;
            this.btnChinhsua.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnChinhsua.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(26, 292);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(28, 29);
            this.lbA.TabIndex = 10;
            this.lbA.Text = "A";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(454, 292);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(29, 29);
            this.lbB.TabIndex = 11;
            this.lbB.Text = "B";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.Location = new System.Drawing.Point(24, 406);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(30, 29);
            this.lbC.TabIndex = 12;
            this.lbC.Text = "C";
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbD.Location = new System.Drawing.Point(472, 406);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(30, 29);
            this.lbD.TabIndex = 13;
            this.lbD.Text = "D";
            // 
            // lbE
            // 
            this.lbE.AutoSize = true;
            this.lbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbE.Location = new System.Drawing.Point(23, 525);
            this.lbE.Name = "lbE";
            this.lbE.Size = new System.Drawing.Size(29, 29);
            this.lbE.TabIndex = 14;
            this.lbE.Text = "E";
            // 
            // fThaotaccauhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 752);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fThaotaccauhoi";
            this.Text = "fThaotaccauhoi";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauhoi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btnChinhsua;
        private XanderUI.XUIButton btnCapnhat;
        private System.Windows.Forms.TextBox txtDAE;
        private System.Windows.Forms.TextBox txtDAD;
        private System.Windows.Forms.TextBox txtDAC;
        private System.Windows.Forms.TextBox txtDAB;
        private System.Windows.Forms.TextBox txtDAA;
        private XanderUI.XUISuperButton btnThoat;
        private System.Windows.Forms.RichTextBox txtCauHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCauhoi;
        private System.Windows.Forms.Label lbE;
        private System.Windows.Forms.Label lbD;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbA;
    }
}