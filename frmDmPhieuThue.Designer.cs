
namespace QLTPKS
{
    partial class frmDmPhieuThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmPhieuThue));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grdDmPhieuthue = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCttp = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgayDen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtExit = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnThemphong = new System.Windows.Forms.Button();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.grdDSPT = new System.Windows.Forms.DataGridView();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhongTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtTimPhieu = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDmPhieuthue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCttp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSPT)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(437, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 41);
            this.label2.TabIndex = 135;
            this.label2.Text = "Danh mục phiếu thuê";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 134;
            this.pictureBox1.TabStop = false;
            // 
            // grdDmPhieuthue
            // 
            this.grdDmPhieuthue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDmPhieuthue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.NgayDen,
            this.TienCoc,
            this.TrangThai,
            this.MaNV,
            this.MaKH});
            this.grdDmPhieuthue.Location = new System.Drawing.Point(32, 146);
            this.grdDmPhieuthue.Name = "grdDmPhieuthue";
            this.grdDmPhieuthue.RowHeadersWidth = 62;
            this.grdDmPhieuthue.RowTemplate.Height = 28;
            this.grdDmPhieuthue.Size = new System.Drawing.Size(817, 200);
            this.grdDmPhieuthue.TabIndex = 136;
            this.grdDmPhieuthue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDmPhieuthue_CellContentClick);
            // 
            // MaPhieu
            // 
            this.MaPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã Phiếu";
            this.MaPhieu.MinimumWidth = 8;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Width = 111;
            // 
            // NgayDen
            // 
            this.NgayDen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayDen.DataPropertyName = "NgayDen";
            this.NgayDen.HeaderText = "Ngày đến";
            this.NgayDen.MinimumWidth = 8;
            this.NgayDen.Name = "NgayDen";
            this.NgayDen.Width = 112;
            // 
            // TienCoc
            // 
            this.TienCoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TienCoc.DataPropertyName = "TienCoc";
            this.TienCoc.HeaderText = "Tiền cọc";
            this.TienCoc.MinimumWidth = 8;
            this.TienCoc.Name = "TienCoc";
            this.TienCoc.Width = 104;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 116;
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 93;
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 93;
            // 
            // grdCttp
            // 
            this.grdCttp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCttp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.NgayDatPhong,
            this.LoaiPhong,
            this.DonGia,
            this.NgayO,
            this.NgayTraPhong});
            this.grdCttp.Location = new System.Drawing.Point(32, 627);
            this.grdCttp.Name = "grdCttp";
            this.grdCttp.RowHeadersWidth = 62;
            this.grdCttp.RowTemplate.Height = 28;
            this.grdCttp.Size = new System.Drawing.Size(795, 216);
            this.grdCttp.TabIndex = 137;
            this.grdCttp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCttp_CellContentClick);
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 8;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 116;
            // 
            // NgayDatPhong
            // 
            this.NgayDatPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayDatPhong.DataPropertyName = "NgayDatPhong";
            this.NgayDatPhong.HeaderText = "Ngày đặt";
            this.NgayDatPhong.MinimumWidth = 8;
            this.NgayDatPhong.Name = "NgayDatPhong";
            this.NgayDatPhong.Width = 108;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.MinimumWidth = 8;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Width = 124;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            // 
            // NgayO
            // 
            this.NgayO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayO.DataPropertyName = "NgayO";
            this.NgayO.HeaderText = "Ngày ở";
            this.NgayO.MinimumWidth = 8;
            this.NgayO.Name = "NgayO";
            this.NgayO.Width = 94;
            // 
            // NgayTraPhong
            // 
            this.NgayTraPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayTraPhong.DataPropertyName = "NgayTraPhong";
            this.NgayTraPhong.HeaderText = "Ngày trả";
            this.NgayTraPhong.MinimumWidth = 8;
            this.NgayTraPhong.Name = "NgayTraPhong";
            this.NgayTraPhong.Width = 104;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(1048, 133);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(121, 26);
            this.txtMaPhieu.TabIndex = 138;
            this.txtMaPhieu.TextChanged += new System.EventHandler(this.txtMaPhieu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(940, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 139;
            this.label1.Text = "Mã phiếu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(940, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 140;
            this.label3.Text = "Ngảy đến:";
            // 
            // txtNgayDen
            // 
            this.txtNgayDen.Location = new System.Drawing.Point(1048, 185);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(173, 26);
            this.txtNgayDen.TabIndex = 141;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(940, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 142;
            this.label4.Text = "Tiền cọc";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(1048, 237);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(173, 26);
            this.txtTienCoc.TabIndex = 143;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(940, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 146;
            this.label6.Text = "Mã KH:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(1048, 289);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(121, 26);
            this.txtMaKH.TabIndex = 147;
            // 
            // txtExit
            // 
            this.txtExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExit.ForeColor = System.Drawing.Color.Red;
            this.txtExit.Location = new System.Drawing.Point(1176, 764);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(109, 55);
            this.txtExit.TabIndex = 148;
            this.txtExit.Text = "Thoát";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1176, 682);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 55);
            this.btnHuy.TabIndex = 149;
            this.btnHuy.Text = "Hủy phiếu";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(1048, 343);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(173, 26);
            this.txtTrangThai.TabIndex = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(940, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 151;
            this.label5.Text = "Trạng thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(942, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 23);
            this.label7.TabIndex = 152;
            this.label7.Text = "Thông tin phiếu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 23);
            this.label8.TabIndex = 153;
            this.label8.Text = "Chi tiết phòng thuê:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 23);
            this.label9.TabIndex = 154;
            this.label9.Text = "Danh sách phiếu thuê:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(942, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 155;
            this.label10.Text = "Số phòng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(942, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 156;
            this.label11.Text = "Ngày đặt:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(942, 538);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 157;
            this.label12.Text = "Loại phòng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(942, 577);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 158;
            this.label13.Text = "Đơn giá:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(1050, 457);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(100, 26);
            this.txtMaPhong.TabIndex = 159;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(1050, 539);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(171, 26);
            this.txtLoaiPhong.TabIndex = 161;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(1048, 580);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(178, 26);
            this.txtDonGia.TabIndex = 162;
            // 
            // btnThemphong
            // 
            this.btnThemphong.Location = new System.Drawing.Point(552, 401);
            this.btnThemphong.Name = "btnThemphong";
            this.btnThemphong.Size = new System.Drawing.Size(118, 59);
            this.btnThemphong.TabIndex = 163;
            this.btnThemphong.Text = "Thêm phòng";
            this.btnThemphong.UseVisualStyleBackColor = true;
            this.btnThemphong.Click += new System.EventHandler(this.btnThemphong_Click);
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Location = new System.Drawing.Point(1050, 493);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(211, 26);
            this.dtNgayDat.TabIndex = 165;
            // 
            // grdDSPT
            // 
            this.grdDSPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDSPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhong,
            this.LoaiPhongTrong,
            this.GiaPhong});
            this.grdDSPT.Location = new System.Drawing.Point(34, 401);
            this.grdDSPT.Name = "grdDSPT";
            this.grdDSPT.RowHeadersWidth = 62;
            this.grdDSPT.RowTemplate.Height = 28;
            this.grdDSPT.Size = new System.Drawing.Size(482, 185);
            this.grdDSPT.TabIndex = 169;
            this.grdDSPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDSPT_CellClick);
            // 
            // SoPhong
            // 
            this.SoPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SoPhong.DataPropertyName = "SoPhong";
            this.SoPhong.HeaderText = "Mã phòng";
            this.SoPhong.MinimumWidth = 8;
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.Width = 116;
            // 
            // LoaiPhongTrong
            // 
            this.LoaiPhongTrong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LoaiPhongTrong.DataPropertyName = "LoaiPhongTrong";
            this.LoaiPhongTrong.HeaderText = "Loại phòng";
            this.LoaiPhongTrong.MinimumWidth = 8;
            this.LoaiPhongTrong.Name = "LoaiPhongTrong";
            this.LoaiPhongTrong.Width = 124;
            // 
            // GiaPhong
            // 
            this.GiaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GiaPhong.DataPropertyName = "GiaPhong";
            this.GiaPhong.HeaderText = "Đơn giá";
            this.GiaPhong.MinimumWidth = 8;
            this.GiaPhong.Name = "GiaPhong";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 375);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 23);
            this.label14.TabIndex = 170;
            this.label14.Text = "Danh sách phòng trống:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(552, 479);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(118, 59);
            this.btnCapNhat.TabIndex = 171;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtTimPhieu
            // 
            this.txtTimPhieu.Location = new System.Drawing.Point(550, 109);
            this.txtTimPhieu.Name = "txtTimPhieu";
            this.txtTimPhieu.Size = new System.Drawing.Size(149, 26);
            this.txtTimPhieu.TabIndex = 172;
            this.txtTimPhieu.Text = "Nhập thông tin";
            this.txtTimPhieu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimPhieu_MouseClick);
            this.txtTimPhieu.TextChanged += new System.EventHandler(this.txtTimPhieu_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(942, 422);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 23);
            this.label15.TabIndex = 173;
            this.label15.Text = "Thông tin phòng:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(440, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 20);
            this.label16.TabIndex = 174;
            this.label16.Text = "Tìm phiếu: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(906, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 277);
            this.panel1.TabIndex = 175;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(906, 437);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 191);
            this.panel2.TabIndex = 176;
            // 
            // frmDmPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1371, 855);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTimPhieu);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.grdDSPT);
            this.Controls.Add(this.dtNgayDat);
            this.Controls.Add(this.btnThemphong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNgayDen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.grdCttp);
            this.Controls.Add(this.grdDmPhieuthue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(225, 65);
            this.Name = "frmDmPhieuThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Danh mục phiếu thuê phòng";
            this.Load += new System.EventHandler(this.frmDmPhieuThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDmPhieuthue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCttp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView grdDmPhieuthue;
        private System.Windows.Forms.DataGridView grdCttp;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNgayDen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnThemphong;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraPhong;
        private System.Windows.Forms.DataGridView grdDSPT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtTimPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhongTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}