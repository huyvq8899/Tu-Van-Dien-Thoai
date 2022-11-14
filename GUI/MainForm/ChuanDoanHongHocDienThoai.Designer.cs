namespace ChuanDoanHongHocDienThoai
{
    partial class _frmChuanDoanHongHocDienThoai
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
            this._pnlRight = new System.Windows.Forms.Panel();
            this._pnlLeft = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this._btnChuanDoan = new System.Windows.Forms.Button();
            this._btnGioiThieu = new System.Windows.Forms.Button();
            this._btnQuanLyTapLuat = new System.Windows.Forms.Button();
            this._btnQuanLySuKien = new System.Windows.Forms.Button();
            this._pnlBottom = new System.Windows.Forms.Panel();
            this.lblInformation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._pnlTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this._lblMiniMax = new System.Windows.Forms.Label();
            this._lblClose = new System.Windows.Forms.Label();
            this._pnlLeft.SuspendLayout();
            this._pnlBottom.SuspendLayout();
            this._pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnlRight
            // 
            this._pnlRight.BackgroundImage = global::ChuanDoanHongHocDienThoai.Properties.Resources.background_top;
            this._pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlRight.Location = new System.Drawing.Point(164, 39);
            this._pnlRight.Name = "_pnlRight";
            this._pnlRight.Size = new System.Drawing.Size(836, 572);
            this._pnlRight.TabIndex = 3;
            // 
            // _pnlLeft
            // 
            this._pnlLeft.BackgroundImage = global::ChuanDoanHongHocDienThoai.Properties.Resources.background_top;
            this._pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlLeft.Controls.Add(this.button1);
            this._pnlLeft.Controls.Add(this._btnChuanDoan);
            this._pnlLeft.Controls.Add(this._btnGioiThieu);
            this._pnlLeft.Controls.Add(this._btnQuanLyTapLuat);
            this._pnlLeft.Controls.Add(this._btnQuanLySuKien);
            this._pnlLeft.Location = new System.Drawing.Point(0, 39);
            this._pnlLeft.Name = "_pnlLeft";
            this._pnlLeft.Size = new System.Drawing.Size(165, 611);
            this._pnlLeft.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ChuanDoanHongHocDienThoai.Properties.Resources.background_top;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ChuanDoanHongHocDienThoai.Properties.Resources.sukien;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(17, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 100);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kết Luận";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnQuanLyKetLuanClick);
            // 
            // _btnChuanDoan
            // 
            this._btnChuanDoan.BackgroundImage = global::ChuanDoanHongHocDienThoai.Properties.Resources.background_top;
            this._btnChuanDoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnChuanDoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnChuanDoan.Image = global::ChuanDoanHongHocDienThoai.Properties.Resources.iconhome;
            this._btnChuanDoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnChuanDoan.Location = new System.Drawing.Point(17, 19);
            this._btnChuanDoan.Name = "_btnChuanDoan";
            this._btnChuanDoan.Size = new System.Drawing.Size(125, 100);
            this._btnChuanDoan.TabIndex = 4;
            this._btnChuanDoan.Text = "Tư vấn";
            this._btnChuanDoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnChuanDoan.UseVisualStyleBackColor = true;
            this._btnChuanDoan.Click += new System.EventHandler(this.OnBtnChuanDoanClick);
            this._btnChuanDoan.MouseLeave += new System.EventHandler(this.OnBtnChuanDoanMouseLeave);
            this._btnChuanDoan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnBtnChuanDoanMouseMove);
            // 
            // _btnGioiThieu
            // 
            this._btnGioiThieu.BackgroundImage = global::ChuanDoanHongHocDienThoai.Properties.Resources.background_top;
            this._btnGioiThieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnGioiThieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnGioiThieu.Image = global::ChuanDoanHongHocDienThoai.Properties.Resources.information___Copy;
            this._btnGioiThieu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnGioiThieu.Location = new System.Drawing.Point(19, 505);
            this._btnGioiThieu.Name = "_btnGioiThieu";
            this._btnGioiThieu.Size = new System.Drawing.Size(125, 100);
            this._btnGioiThieu.TabIndex = 3;
            this._btnGioiThieu.Text = "Giới thiệu";
            this._btnGioiThieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnGioiThieu.UseVisualStyleBackColor = true;
            this._btnGioiThieu.Click += new System.EventHandler(this.OnBtnGioiThieuClick);
            this._btnGioiThieu.MouseLeave += new System.EventHandler(this.OnBtnGioiThieuMouseLeave);
            this._btnGioiThieu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnBtnGioiThieuMouseMove);
            // 
            // _btnQuanLyTapLuat
            // 
            this._btnQuanLyTapLuat.BackgroundImage = global::ChuanDoanHongHocDienThoai.Properties.Resources.background_top;
            this._btnQuanLyTapLuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnQuanLyTapLuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnQuanLyTapLuat.Image = global::ChuanDoanHongHocDienThoai.Properties.Resources.icon_resource;
            this._btnQuanLyTapLuat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnQuanLyTapLuat.Location = new System.Drawing.Point(17, 383);
            this._btnQuanLyTapLuat.Name = "_btnQuanLyTapLuat";
            this._btnQuanLyTapLuat.Size = new System.Drawing.Size(125, 100);
            this._btnQuanLyTapLuat.TabIndex = 2;
            this._btnQuanLyTapLuat.Text = "Tập luật";
            this._btnQuanLyTapLuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnQuanLyTapLuat.UseVisualStyleBackColor = true;
            this._btnQuanLyTapLuat.Click += new System.EventHandler(this.OnQuanLyTapLuatClick);
            this._btnQuanLyTapLuat.MouseLeave += new System.EventHandler(this.OnBtnQuanLyTapLuatMouseLeave);
            this._btnQuanLyTapLuat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnBtnQuanLyTapLuatMouseMove);
            // 
            // _btnQuanLySuKien
            // 
            this._btnQuanLySuKien.BackgroundImage = global::ChuanDoanHongHocDienThoai.Properties.Resources.background_top;
            this._btnQuanLySuKien.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnQuanLySuKien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnQuanLySuKien.Image = global::ChuanDoanHongHocDienThoai.Properties.Resources.Event_20_10;
            this._btnQuanLySuKien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._btnQuanLySuKien.Location = new System.Drawing.Point(19, 138);
            this._btnQuanLySuKien.Name = "_btnQuanLySuKien";
            this._btnQuanLySuKien.Size = new System.Drawing.Size(125, 100);
            this._btnQuanLySuKien.TabIndex = 1;
            this._btnQuanLySuKien.Text = "Sự kiện";
            this._btnQuanLySuKien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnQuanLySuKien.UseVisualStyleBackColor = true;
            this._btnQuanLySuKien.Click += new System.EventHandler(this.OnQuanLySuKienClick);
            this._btnQuanLySuKien.MouseLeave += new System.EventHandler(this.OnBtnQuanLySuKienMouseLeave);
            this._btnQuanLySuKien.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnBtnQuanLySuKienMouseMove);
            // 
            // _pnlBottom
            // 
            this._pnlBottom.BackgroundImage = global::ChuanDoanHongHocDienThoai.Properties.Resources.background_top;
            this._pnlBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlBottom.Controls.Add(this.lblInformation);
            this._pnlBottom.Controls.Add(this.label1);
            this._pnlBottom.Location = new System.Drawing.Point(164, 610);
            this._pnlBottom.Name = "_pnlBottom";
            this._pnlBottom.Size = new System.Drawing.Size(836, 40);
            this._pnlBottom.TabIndex = 1;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Image = global::ChuanDoanHongHocDienThoai.Properties.Resources.header_TuVan;
            this.lblInformation.Location = new System.Drawing.Point(280, 9);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(0, 20);
            this.lblInformation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::ChuanDoanHongHocDienThoai.Properties.Resources.header_TuVan;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // _pnlTop
            // 
            this._pnlTop.BackColor = System.Drawing.SystemColors.Control;
            this._pnlTop.BackgroundImage = global::ChuanDoanHongHocDienThoai.Properties.Resources.background;
            this._pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlTop.Controls.Add(this.label2);
            this._pnlTop.Controls.Add(this._lblMiniMax);
            this._pnlTop.Controls.Add(this._lblClose);
            this._pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlTop.Location = new System.Drawing.Point(0, 0);
            this._pnlTop.Name = "_pnlTop";
            this._pnlTop.Size = new System.Drawing.Size(1000, 40);
            this._pnlTop.TabIndex = 0;
            this._pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this._pnlTop_Paint);
            this._pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPnlTopMouseDown);
            this._pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPnlTopMouseMove);
            this._pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPnlTopMouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::ChuanDoanHongHocDienThoai.Properties.Resources.background;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tư vấn mua điện thoại";
            // 
            // _lblMiniMax
            // 
            this._lblMiniMax.BackColor = System.Drawing.Color.WhiteSmoke;
            this._lblMiniMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblMiniMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._lblMiniMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMiniMax.Location = new System.Drawing.Point(899, 5);
            this._lblMiniMax.Name = "_lblMiniMax";
            this._lblMiniMax.Size = new System.Drawing.Size(42, 27);
            this._lblMiniMax.TabIndex = 1;
            this._lblMiniMax.Text = "-";
            this._lblMiniMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblMiniMax.Click += new System.EventHandler(this.OnLblMiniMaxClick);
            this._lblMiniMax.MouseLeave += new System.EventHandler(this.OnLblMinMaxMouseLeave);
            this._lblMiniMax.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblMinMaxMouseMove);
            // 
            // _lblClose
            // 
            this._lblClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this._lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblClose.Location = new System.Drawing.Point(949, 5);
            this._lblClose.Name = "_lblClose";
            this._lblClose.Size = new System.Drawing.Size(42, 27);
            this._lblClose.TabIndex = 0;
            this._lblClose.Tag = "";
            this._lblClose.Text = "X";
            this._lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblClose.Click += new System.EventHandler(this.OnLblCloseClick);
            this._lblClose.MouseLeave += new System.EventHandler(this.OnLblCloseMouseLeave);
            this._lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnLblCloseMouseMove);
            // 
            // _frmChuanDoanHongHocDienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this._pnlRight);
            this.Controls.Add(this._pnlLeft);
            this.Controls.Add(this._pnlBottom);
            this.Controls.Add(this._pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "_frmChuanDoanHongHocDienThoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuẩn đoán hỏng hóc điện thoại";
            this.Load += new System.EventHandler(this.OnFrmChuanDoanBenhTimLoad);
            this._pnlLeft.ResumeLayout(false);
            this._pnlBottom.ResumeLayout(false);
            this._pnlBottom.PerformLayout();
            this._pnlTop.ResumeLayout(false);
            this._pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pnlTop;
        private System.Windows.Forms.Label _lblClose;
        private System.Windows.Forms.Label _lblMiniMax;
        private System.Windows.Forms.Panel _pnlBottom;
        private System.Windows.Forms.Panel _pnlLeft;
        private System.Windows.Forms.Panel _pnlRight;
        private System.Windows.Forms.Button _btnGioiThieu;
        private System.Windows.Forms.Button _btnQuanLyTapLuat;
        private System.Windows.Forms.Button _btnQuanLySuKien;
        private System.Windows.Forms.Button _btnChuanDoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

