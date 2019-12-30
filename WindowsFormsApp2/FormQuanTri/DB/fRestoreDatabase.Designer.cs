namespace WindowsFormsApp2.FormQuanTri.DB
{
    partial class fRestoreDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRestoreDatabase));
            this.XUIform = new XanderUI.XUIFormDesign();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnRestore = new XanderUI.XUIButton();
            this.btnChonfile = new XanderUI.XUIButton();
            this.btnThoat = new XanderUI.XUISuperButton();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.XUIform.WorkingArea.SuspendLayout();
            this.XUIform.SuspendLayout();
            this.SuspendLayout();
            // 
            // XUIform
            // 
            this.XUIform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XUIform.ExitApplication = true;
            this.XUIform.FormStyle = XanderUI.XUIFormDesign.Style.Ubuntu;
            this.XUIform.Location = new System.Drawing.Point(0, 0);
            this.XUIform.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.XUIform.MaterialForeColor = System.Drawing.Color.White;
            this.XUIform.Name = "XUIform";
            this.XUIform.ShowMaximize = true;
            this.XUIform.ShowMinimize = true;
            this.XUIform.Size = new System.Drawing.Size(800, 450);
            this.XUIform.TabIndex = 0;
            this.XUIform.TitleText = "Form Name";
            // 
            // XUIform.WorkingArea
            // 
            this.XUIform.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.XUIform.WorkingArea.Controls.Add(this.txtDbName);
            this.XUIform.WorkingArea.Controls.Add(this.txtPath);
            this.XUIform.WorkingArea.Controls.Add(this.btnRestore);
            this.XUIform.WorkingArea.Controls.Add(this.btnChonfile);
            this.XUIform.WorkingArea.Controls.Add(this.btnThoat);
            this.XUIform.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XUIform.WorkingArea.Location = new System.Drawing.Point(0, 30);
            this.XUIform.WorkingArea.Name = "WorkingArea";
            this.XUIform.WorkingArea.Size = new System.Drawing.Size(800, 420);
            this.XUIform.WorkingArea.TabIndex = 0;
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(245, 54);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(294, 38);
            this.txtPath.TabIndex = 3;
            // 
            // btnRestore
            // 
            this.btnRestore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRestore.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnRestore.ButtonImage")));
            this.btnRestore.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnRestore.ButtonText = "Khôi phục";
            this.btnRestore.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnRestore.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnRestore.CornerRadius = 5;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRestore.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnRestore.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnRestore.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnRestore.Location = new System.Drawing.Point(329, 305);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(200, 50);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnRestore.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnChonfile
            // 
            this.btnChonfile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChonfile.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnChonfile.ButtonImage")));
            this.btnChonfile.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnChonfile.ButtonText = "Chọn file";
            this.btnChonfile.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnChonfile.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChonfile.CornerRadius = 5;
            this.btnChonfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonfile.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChonfile.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnChonfile.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnChonfile.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnChonfile.Location = new System.Drawing.Point(23, 54);
            this.btnChonfile.Name = "btnChonfile";
            this.btnChonfile.Size = new System.Drawing.Size(200, 50);
            this.btnChonfile.TabIndex = 1;
            this.btnChonfile.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnChonfile.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundColor = System.Drawing.Color.Silver;
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
            this.btnThoat.Location = new System.Drawing.Point(673, 321);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThoat.SelectedTextColor = System.Drawing.Color.White;
            this.btnThoat.Size = new System.Drawing.Size(115, 43);
            this.btnThoat.SuperSelected = false;
            this.btnThoat.TabIndex = 0;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // txtDbName
            // 
            this.txtDbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDbName.Location = new System.Drawing.Point(245, 167);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(294, 38);
            this.txtDbName.TabIndex = 5;
            // 
            // fRestoreDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.XUIform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fRestoreDatabase";
            this.Text = "fRestoreDatabase";
            this.XUIform.WorkingArea.ResumeLayout(false);
            this.XUIform.WorkingArea.PerformLayout();
            this.XUIform.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign XUIform;
        private System.Windows.Forms.TextBox txtPath;
        private XanderUI.XUIButton btnRestore;
        private XanderUI.XUIButton btnChonfile;
        private XanderUI.XUISuperButton btnThoat;
        private System.Windows.Forms.TextBox txtDbName;
    }
}