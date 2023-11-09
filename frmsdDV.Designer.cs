
namespace QLTPKS
{
    partial class frmsdDV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsdDV));
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.GridViewCTSDDV = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDvt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxMaPhong = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.GridViewDSDV = new System.Windows.Forms.DataGridView();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNgayGoi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCTSDDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(765, 224);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(100, 26);
            this.txtMaDV.TabIndex = 137;
            // 
            // GridViewCTSDDV
            // 
            this.GridViewCTSDDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCTSDDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.MaPhong,
            this.MaDichVu,
            this.SoLuong,
            this.ThanhTien,
            this.NgayGoi});
            this.GridViewCTSDDV.Location = new System.Drawing.Point(27, 498);
            this.GridViewCTSDDV.Name = "GridViewCTSDDV";
            this.GridViewCTSDDV.RowHeadersWidth = 62;
            this.GridViewCTSDDV.RowTemplate.Height = 28;
            this.GridViewCTSDDV.Size = new System.Drawing.Size(770, 222);
            this.GridViewCTSDDV.TabIndex = 134;
            this.GridViewCTSDDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCTSDDV_CellContentClick);
            // 
            // MaPhieu
            // 
            this.MaPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã Phiếu";
            this.MaPhieu.MinimumWidth = 8;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Width = 111;
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 8;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 116;
            // 
            // MaDichVu
            // 
            this.MaDichVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaDichVu.DataPropertyName = "MaDV";
            this.MaDichVu.HeaderText = "Mã DV";
            this.MaDichVu.MinimumWidth = 8;
            this.MaDichVu.Name = "MaDichVu";
            this.MaDichVu.Width = 94;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 114;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 120;
            // 
            // NgayGoi
            // 
            this.NgayGoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayGoi.DataPropertyName = "NgayGoi";
            this.NgayGoi.HeaderText = "Ngày gọi";
            this.NgayGoi.MinimumWidth = 8;
            this.NgayGoi.Name = "NgayGoi";
            this.NgayGoi.Width = 106;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(765, 384);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(200, 26);
            this.txtThanhTien.TabIndex = 133;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(643, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 23);
            this.label9.TabIndex = 132;
            this.label9.Text = "Thành tiền:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(765, 184);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(100, 26);
            this.txtMaPhieu.TabIndex = 131;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(643, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 130;
            this.label8.Text = "Mã Phiếu: ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(952, 571);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 52);
            this.btnSave.TabIndex = 129;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDvt
            // 
            this.txtDvt.Location = new System.Drawing.Point(940, 304);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(85, 26);
            this.txtDvt.TabIndex = 135;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbxMaPhong
            // 
            this.cbxMaPhong.FormattingEnabled = true;
            this.cbxMaPhong.Location = new System.Drawing.Point(765, 142);
            this.cbxMaPhong.Name = "cbxMaPhong";
            this.cbxMaPhong.Size = new System.Drawing.Size(128, 28);
            this.cbxMaPhong.TabIndex = 136;
            this.cbxMaPhong.SelectedIndexChanged += new System.EventHandler(this.cbxMaPhong_SelectedIndexChanged);
            this.cbxMaPhong.TextChanged += new System.EventHandler(this.cbxMaPhong_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(952, 647);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 52);
            this.btnExit.TabIndex = 128;
            this.btnExit.Text = "Thoát ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GridViewDSDV
            // 
            this.GridViewDSDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDSDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.LoaiDV,
            this.GiaDv,
            this.Dvt});
            this.GridViewDSDV.Location = new System.Drawing.Point(27, 148);
            this.GridViewDSDV.Name = "GridViewDSDV";
            this.GridViewDSDV.RowHeadersWidth = 62;
            this.GridViewDSDV.RowTemplate.Height = 28;
            this.GridViewDSDV.Size = new System.Drawing.Size(532, 282);
            this.GridViewDSDV.TabIndex = 118;
            this.GridViewDSDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSDV_CellClick);
            this.GridViewDSDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSDV_CellContentClick);
            // 
            // MaDV
            // 
            this.MaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã DV";
            this.MaDV.MinimumWidth = 8;
            this.MaDV.Name = "MaDV";
            this.MaDV.Width = 94;
            // 
            // LoaiDV
            // 
            this.LoaiDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LoaiDV.DataPropertyName = "LoaiDV";
            this.LoaiDV.HeaderText = "Tên dịch vụ";
            this.LoaiDV.MinimumWidth = 8;
            this.LoaiDV.Name = "LoaiDV";
            this.LoaiDV.Width = 125;
            // 
            // GiaDv
            // 
            this.GiaDv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GiaDv.DataPropertyName = "GiaDv";
            this.GiaDv.HeaderText = "Giá";
            this.GiaDv.MinimumWidth = 8;
            this.GiaDv.Name = "GiaDv";
            this.GiaDv.Width = 70;
            // 
            // Dvt
            // 
            this.Dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dvt.DataPropertyName = "Dvt";
            this.Dvt.HeaderText = "Đvt";
            this.Dvt.MinimumWidth = 8;
            this.Dvt.Name = "Dvt";
            this.Dvt.Width = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 26);
            this.label3.TabIndex = 117;
            this.label3.Text = "Danh mục Dịch vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(392, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 41);
            this.label2.TabIndex = 116;
            this.label2.Text = "Đăng ký sử dụng dịch vụ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(643, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 127;
            this.label7.Text = "Ngày gọi:";
            // 
            // dtNgayGoi
            // 
            this.dtNgayGoi.Location = new System.Drawing.Point(765, 424);
            this.dtNgayGoi.Name = "dtNgayGoi";
            this.dtNgayGoi.Size = new System.Drawing.Size(241, 26);
            this.dtNgayGoi.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(643, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 125;
            this.label6.Text = "Số phòng: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 124;
            this.label5.Text = "Số lượng:";
            // 
            // updownSoLuong
            // 
            this.updownSoLuong.Location = new System.Drawing.Point(765, 344);
            this.updownSoLuong.Name = "updownSoLuong";
            this.updownSoLuong.Size = new System.Drawing.Size(64, 26);
            this.updownSoLuong.TabIndex = 123;
            this.updownSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownSoLuong.ValueChanged += new System.EventHandler(this.updownSoLuong_ValueChanged);
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Location = new System.Drawing.Point(765, 304);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(154, 26);
            this.txtGiaDV.TabIndex = 122;
            this.txtGiaDV.TextChanged += new System.EventHandler(this.txtGiaDV_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 121;
            this.label4.Text = "Giá:";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(765, 264);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(200, 26);
            this.txtTenDV.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(643, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 119;
            this.label1.Text = "Tên dịch vụ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 26);
            this.label10.TabIndex = 140;
            this.label10.Text = "Chi tiết sử dụng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(643, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 23);
            this.label11.TabIndex = 141;
            this.label11.Text = "Mã DV: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(921, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 20);
            this.label12.TabIndex = 142;
            this.label12.Text = "/";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(642, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 23);
            this.label13.TabIndex = 143;
            this.label13.Text = "Thông tin dịch vụ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(606, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 342);
            this.panel1.TabIndex = 144;
            // 
            // frmsdDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1086, 743);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.GridViewCTSDDV);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDvt);
            this.Controls.Add(this.cbxMaPhong);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.GridViewDSDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtNgayGoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updownSoLuong);
            this.Controls.Add(this.txtGiaDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmsdDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.frmsdDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCTSDDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.DataGridView GridViewCTSDDV;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbxMaPhong;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView GridViewDSDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNgayGoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown updownSoLuong;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGoi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
    }
}