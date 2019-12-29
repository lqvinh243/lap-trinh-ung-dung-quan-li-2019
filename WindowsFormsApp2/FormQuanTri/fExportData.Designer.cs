namespace WindowsFormsApp2.FormQuanTri
{
    partial class fExportData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fExportData));
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTatca = new XanderUI.XUIButton();
            this.rpView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
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
            this.xuiFormDesign1.Size = new System.Drawing.Size(1550, 900);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnThoat);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.panel1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.btnTatca);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.rpView);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 30);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1550, 870);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
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
            this.btnThoat.Location = new System.Drawing.Point(1404, 613);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(143, 51);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 5;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1357, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 223);
            this.panel1.TabIndex = 4;
            // 
            // btnTatca
            // 
            this.btnTatca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTatca.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnTatca.ButtonImage")));
            this.btnTatca.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnTatca.ButtonText = "Tất cả";
            this.btnTatca.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnTatca.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTatca.CornerRadius = 5;
            this.btnTatca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatca.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTatca.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnTatca.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTatca.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnTatca.Location = new System.Drawing.Point(1369, 15);
            this.btnTatca.Name = "btnTatca";
            this.btnTatca.Size = new System.Drawing.Size(149, 49);
            this.btnTatca.TabIndex = 1;
            this.btnTatca.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnTatca.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // rpView
            // 
            this.rpView.ActiveViewIndex = -1;
            this.rpView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpView.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpView.Dock = System.Windows.Forms.DockStyle.Left;
            this.rpView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpView.Location = new System.Drawing.Point(0, 0);
            this.rpView.Name = "rpView";
            this.rpView.Size = new System.Drawing.Size(1351, 870);
            this.rpView.TabIndex = 0;
            // 
            // fExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 900);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fExportData";
            this.Text = "fExportDataHs";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpView;
        private XanderUI.XUISuperButton btnThoat;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btnTatca;
    }
}