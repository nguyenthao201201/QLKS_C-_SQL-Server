
namespace QLTPKS
{
    partial class frmThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToan));
            this.GridViewDSSDDV = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTongTienDV = new System.Windows.Forms.Label();
            this.cbxMaPhong = new System.Windows.Forms.ComboBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtNgayDen = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTenNVtMaNV = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtNgayTt = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblTienphong = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxPttt = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSSDDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewDSSDDV
            // 
            this.GridViewDSSDDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDSSDDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.MaDV,
            this.SoLuong,
            this.NgayGoi,
            this.ThanhTien});
            this.GridViewDSSDDV.Location = new System.Drawing.Point(20, 87);
            this.GridViewDSSDDV.Name = "GridViewDSSDDV";
            this.GridViewDSSDDV.RowHeadersWidth = 62;
            this.GridViewDSSDDV.RowTemplate.Height = 28;
            this.GridViewDSSDDV.Size = new System.Drawing.Size(595, 201);
            this.GridViewDSSDDV.TabIndex = 1;
            this.GridViewDSSDDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSSDDV_CellContentClick);
            // 
            // MaPhieu
            // 
            this.MaPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã Phiếu";
            this.MaPhieu.MinimumWidth = 8;
            this.MaPhieu.Name = "MaPhieu";
            // 
            // MaDV
            // 
            this.MaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã DV";
            this.MaDV.MinimumWidth = 8;
            this.MaDV.Name = "MaDV";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // NgayGoi
            // 
            this.NgayGoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayGoi.DataPropertyName = "NgayGoi";
            this.NgayGoi.HeaderText = "Ngày gọi";
            this.NgayGoi.MinimumWidth = 8;
            this.NgayGoi.Name = "NgayGoi";
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số phòng:";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(827, 159);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(185, 26);
            this.txtLoaiPhong.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại Phòng:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(827, 206);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(185, 26);
            this.txtDonGia.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(723, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá Phòng:";
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(837, 369);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(185, 26);
            this.txtSoNgay.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Ngày ở:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(699, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tiền phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tiền dịch vụ:";
            // 
            // lblTongTienDV
            // 
            this.lblTongTienDV.AutoSize = true;
            this.lblTongTienDV.Location = new System.Drawing.Point(334, 306);
            this.lblTongTienDV.Name = "lblTongTienDV";
            this.lblTongTienDV.Size = new System.Drawing.Size(51, 20);
            this.lblTongTienDV.TabIndex = 14;
            this.lblTongTienDV.Text = "label7";
            // 
            // cbxMaPhong
            // 
            this.cbxMaPhong.FormattingEnabled = true;
            this.cbxMaPhong.Location = new System.Drawing.Point(827, 111);
            this.cbxMaPhong.Name = "cbxMaPhong";
            this.cbxMaPhong.Size = new System.Drawing.Size(121, 28);
            this.cbxMaPhong.TabIndex = 15;
            this.cbxMaPhong.SelectedIndexChanged += new System.EventHandler(this.cbxMaPhong_SelectedIndexChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(837, 285);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 26);
            this.txtMaHD.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(699, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mã hóa đơn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mã KH:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Họ và tên:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Số CCCD:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 449);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Số ĐT:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 529);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ngày Đến:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(146, 369);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(85, 26);
            this.txtMaKH.TabIndex = 23;
            // 
            // txtNgayDen
            // 
            this.txtNgayDen.Location = new System.Drawing.Point(146, 526);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(205, 26);
            this.txtNgayDen.TabIndex = 24;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(146, 452);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(205, 26);
            this.txtSdt.TabIndex = 25;
            // 
            // txtCccd
            // 
            this.txtCccd.Location = new System.Drawing.Point(146, 489);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(205, 26);
            this.txtCccd.TabIndex = 26;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(146, 412);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(205, 26);
            this.txtTenKH.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(636, 562);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Tiền cọc:";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(714, 559);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(129, 26);
            this.txtTienCoc.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 590);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Nhân viên phụ trách:";
            // 
            // txtTenNVtMaNV
            // 
            this.txtTenNVtMaNV.Location = new System.Drawing.Point(242, 584);
            this.txtTenNVtMaNV.Name = "txtTenNVtMaNV";
            this.txtTenNVtMaNV.Size = new System.Drawing.Size(174, 26);
            this.txtTenNVtMaNV.TabIndex = 31;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1118, 626);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 55);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtNgayTt
            // 
            this.dtNgayTt.Location = new System.Drawing.Point(837, 326);
            this.dtNgayTt.Name = "dtNgayTt";
            this.dtNgayTt.Size = new System.Drawing.Size(205, 26);
            this.dtNgayTt.TabIndex = 33;
            this.dtNgayTt.ValueChanged += new System.EventHandler(this.dtNgayTt_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(699, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Ngày thanh toán:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(849, 563);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "Tổng tiền:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(198, 631);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 50);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblTienphong
            // 
            this.lblTienphong.AutoSize = true;
            this.lblTienphong.Location = new System.Drawing.Point(833, 418);
            this.lblTienphong.Name = "lblTienphong";
            this.lblTienphong.Size = new System.Drawing.Size(60, 20);
            this.lblTienphong.TabIndex = 38;
            this.lblTienphong.Text = "label17";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(942, 556);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(155, 26);
            this.txtTongTien.TabIndex = 39;
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(892, 605);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(180, 26);
            this.txtThanhToan.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(784, 611);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 20);
            this.label17.TabIndex = 41;
            this.label17.Text = "Thanh toán:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbxPttt
            // 
            this.cbxPttt.FormattingEnabled = true;
            this.cbxPttt.Items.AddRange(new object[] {
            "Tiền mặt",
            "Thẻ",
            "Chuyển khoản"});
            this.cbxPttt.Location = new System.Drawing.Point(214, 28);
            this.cbxPttt.Name = "cbxPttt";
            this.cbxPttt.Size = new System.Drawing.Size(156, 28);
            this.cbxPttt.TabIndex = 44;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(186, 584);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(50, 26);
            this.txtMaNV.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(184, 20);
            this.label18.TabIndex = 46;
            this.label18.Text = "Phương thức thanh toán:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(77, 332);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(200, 23);
            this.label19.TabIndex = 47;
            this.label19.Text = "Thông tin Khách hàng:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(706, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 23);
            this.label20.TabIndex = 48;
            this.label20.Text = "Thông tin phòng:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkOrange;
            this.label21.Location = new System.Drawing.Point(497, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(158, 36);
            this.label21.TabIndex = 118;
            this.label21.Text = "Trả phòng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(719, 249);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(131, 23);
            this.label22.TabIndex = 119;
            this.label22.Text = "Thông tin HĐ:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxPttt);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(633, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 178);
            this.panel1.TabIndex = 120;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(654, 460);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 23);
            this.label23.TabIndex = 121;
            this.label23.Text = "Thanh Toán:";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(678, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 185);
            this.panel2.TabIndex = 122;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(678, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 159);
            this.panel3.TabIndex = 123;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(41, 346);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 220);
            this.panel4.TabIndex = 124;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1208, 680);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtThanhToan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTienphong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtNgayTt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTenNVtMaNV);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtCccd);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtNgayDen);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.cbxMaPhong);
            this.Controls.Add(this.lblTongTienDV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewDSSDDV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả phòng - Thanh Toán";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSSDDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridViewDSSDDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTongTienDV;
        private System.Windows.Forms.ComboBox cbxMaPhong;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtNgayDen;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTenNVtMaNV;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtNgayTt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblTienphong;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbxPttt;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}