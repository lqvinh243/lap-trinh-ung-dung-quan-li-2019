namespace WindowsFormsApp2.FormHocSinh
{
    partial class fBangdiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBangdiem));
            this.rpView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnThoat = new XanderUI.XUIButton();
            this.btnLoad = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // rpView
            // 
            this.rpView.ActiveViewIndex = -1;
            this.rpView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpView.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpView.Dock = System.Windows.Forms.DockStyle.Top;
            this.rpView.Location = new System.Drawing.Point(0, 0);
            this.rpView.Name = "rpView";
            this.rpView.Size = new System.Drawing.Size(1433, 665);
            this.rpView.TabIndex = 0;
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
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThoat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnThoat.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThoat.Location = new System.Drawing.Point(1242, 671);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(179, 50);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnLoad
            // 
            this.btnLoad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLoad.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.ButtonImage")));
            this.btnLoad.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnLoad.ButtonText = "Load";
            this.btnLoad.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnLoad.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLoad.CornerRadius = 5;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLoad.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnLoad.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLoad.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLoad.Location = new System.Drawing.Point(1043, 671);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(179, 50);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnLoad.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // fBangdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 733);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.rpView);
            this.Name = "fBangdiem";
            this.Text = "fBangdiem";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpView;
        private XanderUI.XUIButton btnThoat;
        private XanderUI.XUIButton btnLoad;
    }
}