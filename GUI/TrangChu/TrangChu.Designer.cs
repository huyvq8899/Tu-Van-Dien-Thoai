namespace ChuanDoanHongHocDienThoai.GUI
{
    partial class TrangChu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTrieuChung = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstMota = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChuanDoan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbGiaiThich = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrieuChung)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTrieuChung);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 534);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tập các mô tả";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvTrieuChung
            // 
            this.dgvTrieuChung.AllowUserToAddRows = false;
            this.dgvTrieuChung.AllowUserToDeleteRows = false;
            this.dgvTrieuChung.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTrieuChung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrieuChung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Column2});
            this.dgvTrieuChung.Location = new System.Drawing.Point(6, 29);
            this.dgvTrieuChung.Name = "dgvTrieuChung";
            this.dgvTrieuChung.RowHeadersVisible = false;
            this.dgvTrieuChung.Size = new System.Drawing.Size(308, 499);
            this.dgvTrieuChung.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mô tả";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMota);
            this.groupBox2.Location = new System.Drawing.Point(479, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các dữ kiện";
            // 
            // lstMota
            // 
            this.lstMota.FormattingEnabled = true;
            this.lstMota.ItemHeight = 16;
            this.lstMota.Location = new System.Drawing.Point(7, 19);
            this.lstMota.Name = "lstMota";
            this.lstMota.Size = new System.Drawing.Size(329, 164);
            this.lstMota.TabIndex = 0;
            // 
            // btnChon
            // 
            this.btnChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Location = new System.Drawing.Point(366, 99);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(87, 29);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn >>";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.OnBtnChonClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Location = new System.Drawing.Point(366, 159);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 29);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "<< Hủy ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.OnBtnHuyClick);
            // 
            // btnChuanDoan
            // 
            this.btnChuanDoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuanDoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuanDoan.Location = new System.Drawing.Point(170, 21);
            this.btnChuanDoan.Name = "btnChuanDoan";
            this.btnChuanDoan.Size = new System.Drawing.Size(203, 56);
            this.btnChuanDoan.TabIndex = 4;
            this.btnChuanDoan.Text = "Tư vấn";
            this.btnChuanDoan.UseVisualStyleBackColor = true;
            this.btnChuanDoan.Click += new System.EventHandler(this.OnBtnChuanDoanClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChuanDoan);
            this.groupBox3.Location = new System.Drawing.Point(366, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tư vấn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbGiaiThich);
            this.groupBox4.Location = new System.Drawing.Point(366, 355);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(455, 204);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giải thích";
            // 
            // rtbGiaiThich
            // 
            this.rtbGiaiThich.Location = new System.Drawing.Point(6, 21);
            this.rtbGiaiThich.Name = "rtbGiaiThich";
            this.rtbGiaiThich.Size = new System.Drawing.Size(443, 177);
            this.rtbGiaiThich.TabIndex = 0;
            this.rtbGiaiThich.Text = "";
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrangChu";
            this.Size = new System.Drawing.Size(835, 572);
            this.Load += new System.EventHandler(this.OnTrangChuLoad);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrieuChung)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnChuanDoan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstMota;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtbGiaiThich;
        private System.Windows.Forms.DataGridView dgvTrieuChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
