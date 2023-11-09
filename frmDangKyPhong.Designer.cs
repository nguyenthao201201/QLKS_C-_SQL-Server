
namespace QLTPKS
{
    partial class frmDangKyPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKyPhong));
            this.GridViewDSKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SdtKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GtKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThemKH = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaoMa = new System.Windows.Forms.Button();
            this.dtNgayDen = new System.Windows.Forms.DateTimePicker();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxTrangThai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDmPhieu = new System.Windows.Forms.Button();
            this.btnNapLaiKH = new System.Windows.Forms.Button();
            this.GridViewDSPhongTrong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSPhongTrong)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewDSKH
            // 
            this.GridViewDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.DiaChiKH,
            this.SdtKH,
            this.Cccd,
            this.GtKH});
            this.GridViewDSKH.Location = new System.Drawing.Point(3, 8);
            this.GridViewDSKH.Name = "GridViewDSKH";
            this.GridViewDSKH.RowHeadersWidth = 62;
            this.GridViewDSKH.RowTemplate.Height = 28;
            this.GridViewDSKH.Size = new System.Drawing.Size(880, 202);
            this.GridViewDSKH.TabIndex = 0;
            this.GridViewDSKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSKH_CellClick);
            this.GridViewDSKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSKH_CellContentClick);
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
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Họ và tên";
            this.TenKH.MinimumWidth = 8;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 113;
            // 
            // DiaChiKH
            // 
            this.DiaChiKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DiaChiKH.DataPropertyName = "DiaChiKH";
            this.DiaChiKH.HeaderText = "Địa chỉ";
            this.DiaChiKH.MinimumWidth = 8;
            this.DiaChiKH.Name = "DiaChiKH";
            this.DiaChiKH.Width = 93;
            // 
            // SdtKH
            // 
            this.SdtKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SdtKH.DataPropertyName = "SdtKH";
            this.SdtKH.HeaderText = "Số điện thoại";
            this.SdtKH.MinimumWidth = 8;
            this.SdtKH.Name = "SdtKH";
            this.SdtKH.Width = 138;
            // 
            // Cccd
            // 
            this.Cccd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cccd.DataPropertyName = "Cccd";
            this.Cccd.HeaderText = "Số CCCD";
            this.Cccd.MinimumWidth = 8;
            this.Cccd.Name = "Cccd";
            this.Cccd.Width = 114;
            // 
            // GtKH
            // 
            this.GtKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GtKH.DataPropertyName = "GtKH";
            this.GtKH.HeaderText = "Giới tính";
            this.GtKH.MinimumWidth = 8;
            this.GtKH.Name = "GtKH";
            this.GtKH.Width = 103;
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.AccessibleDescription = "";
            this.txtKeyWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyWord.Location = new System.Drawing.Point(1049, 67);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(176, 26);
            this.txtKeyWord.TabIndex = 2;
            this.txtKeyWord.Text = "Nhập tên KH";
            this.txtKeyWord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKeyWord_MouseClick);
            this.txtKeyWord.TextChanged += new System.EventHandler(this.txtKeyWord_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(465, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 41);
            this.label2.TabIndex = 85;
            this.label2.Text = "Đăng ký Thuê phòng";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1262, 681);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 47);
            this.btnExit.TabIndex = 86;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 91;
            this.label4.Text = "Họ và tên:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(139, 73);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(240, 26);
            this.txtTenKH.TabIndex = 92;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 93;
            this.label5.Text = "CCCD:";
            // 
            // txtCccd
            // 
            this.txtCccd.Location = new System.Drawing.Point(139, 115);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(197, 26);
            this.txtCccd.TabIndex = 94;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(183, 674);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 45);
            this.btnLuu.TabIndex = 103;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(304, 20);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(75, 41);
            this.btnThemKH.TabIndex = 116;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(141, 27);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 26);
            this.txtMaKH.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 118;
            this.label1.Text = "Mã KH: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTaoMa);
            this.panel1.Controls.Add(this.dtNgayDen);
            this.panel1.Controls.Add(this.cbxMaNV);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTienCoc);
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMaPhieu);
            this.panel1.Location = new System.Drawing.Point(22, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 248);
            this.panel1.TabIndex = 119;
            // 
            // btnTaoMa
            // 
            this.btnTaoMa.Location = new System.Drawing.Point(278, 12);
            this.btnTaoMa.Name = "btnTaoMa";
            this.btnTaoMa.Size = new System.Drawing.Size(75, 32);
            this.btnTaoMa.TabIndex = 108;
            this.btnTaoMa.Text = "Tạo mã";
            this.btnTaoMa.UseVisualStyleBackColor = true;
            this.btnTaoMa.Click += new System.EventHandler(this.btnTaoMa_Click);
            // 
            // dtNgayDen
            // 
            this.dtNgayDen.Location = new System.Drawing.Point(138, 111);
            this.dtNgayDen.Name = "dtNgayDen";
            this.dtNgayDen.Size = new System.Drawing.Size(241, 26);
            this.dtNgayDen.TabIndex = 98;
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(139, 207);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(242, 28);
            this.cbxMaNV.TabIndex = 102;
            this.cbxMaNV.SelectedIndexChanged += new System.EventHandler(this.cbxMaNV_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 101;
            this.label9.Text = "Nhân viên ĐK:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 95;
            this.label6.Text = "Số phòng:";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(139, 164);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(241, 26);
            this.txtTienCoc.TabIndex = 100;
            this.txtTienCoc.TextChanged += new System.EventHandler(this.txtTienCoc_TextChanged);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(139, 62);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(120, 26);
            this.txtMaPhong.TabIndex = 96;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 99;
            this.label8.Text = "Tiền cọc:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 105;
            this.label10.Text = "Mã Phiếu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Ngày đến: ";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(139, 18);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(100, 26);
            this.txtMaPhieu.TabIndex = 107;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 620);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 108;
            this.label12.Text = "Trạng Thái:";
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã cọc",
            "Đã thanh toán",
            "Hủy"});
            this.cbxTrangThai.Location = new System.Drawing.Point(160, 612);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(175, 28);
            this.cbxTrangThai.TabIndex = 109;
            this.cbxTrangThai.Text = "Chưa thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 23);
            this.label3.TabIndex = 120;
            this.label3.Text = "Thông tin thuê phòng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 23);
            this.label11.TabIndex = 121;
            this.label11.Text = "Thông tin khách hàng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenKH);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMaKH);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnThemKH);
            this.panel2.Controls.Add(this.txtCccd);
            this.panel2.Location = new System.Drawing.Point(22, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 160);
            this.panel2.TabIndex = 122;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(948, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "Tìm KH: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GridViewDSKH);
            this.panel3.Location = new System.Drawing.Point(524, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 222);
            this.panel3.TabIndex = 123;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(549, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 23);
            this.label14.TabIndex = 124;
            this.label14.Text = "Dữ liệu khách hàng:";
            // 
            // btnDmPhieu
            // 
            this.btnDmPhieu.Location = new System.Drawing.Point(314, 674);
            this.btnDmPhieu.Name = "btnDmPhieu";
            this.btnDmPhieu.Size = new System.Drawing.Size(75, 45);
            this.btnDmPhieu.TabIndex = 125;
            this.btnDmPhieu.Text = "Chi tiết";
            this.btnDmPhieu.UseVisualStyleBackColor = true;
            // 
            // btnNapLaiKH
            // 
            this.btnNapLaiKH.Location = new System.Drawing.Point(1302, 83);
            this.btnNapLaiKH.Name = "btnNapLaiKH";
            this.btnNapLaiKH.Size = new System.Drawing.Size(73, 38);
            this.btnNapLaiKH.TabIndex = 127;
            this.btnNapLaiKH.Text = "Nạp lại";
            this.btnNapLaiKH.UseVisualStyleBackColor = true;
            this.btnNapLaiKH.Click += new System.EventHandler(this.btnNapLaiKH_Click);
            // 
            // GridViewDSPhongTrong
            // 
            this.GridViewDSPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDSPhongTrong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.LoaiPhong,
            this.DonGia});
            this.GridViewDSPhongTrong.Location = new System.Drawing.Point(3, 3);
            this.GridViewDSPhongTrong.Name = "GridViewDSPhongTrong";
            this.GridViewDSPhongTrong.RowHeadersWidth = 62;
            this.GridViewDSPhongTrong.RowTemplate.Height = 28;
            this.GridViewDSPhongTrong.Size = new System.Drawing.Size(511, 301);
            this.GridViewDSPhongTrong.TabIndex = 113;
            this.GridViewDSPhongTrong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSPhongTrong_CellClick);
            this.GridViewDSPhongTrong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSPhongTrong_CellContentClick);
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
            // LoaiPhong
            // 
            this.LoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.MinimumWidth = 8;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GridViewDSPhongTrong);
            this.panel4.Location = new System.Drawing.Point(524, 415);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(509, 322);
            this.panel4.TabIndex = 128;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(553, 395);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(208, 23);
            this.label15.TabIndex = 129;
            this.label15.Text = "Danh sách phòng trống:";
            // 
            // frmDangKyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1478, 771);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnNapLaiKH);
            this.Controls.Add(this.btnDmPhieu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbxTrangThai);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangKyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký Phòng";
            this.Load += new System.EventHandler(this.frmDangKyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSPhongTrong)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewDSKH;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SdtKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn GtKH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtNgayDen;
        private System.Windows.Forms.ComboBox cbxMaNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.ComboBox cbxTrangThai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDmPhieu;
        private System.Windows.Forms.Button btnNapLaiKH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView GridViewDSPhongTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Button btnTaoMa;
    }
}