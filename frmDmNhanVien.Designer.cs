
namespace QLTPKS
{
    partial class frmDmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmNhanVien));
            this.txtGtNV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.txtSdtNV = new System.Windows.Forms.TextBox();
            this.txtCccdNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GridViewDSNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CccdNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SdtNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GtNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNapLai = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxChucVu = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGtNV
            // 
            this.txtGtNV.FormattingEnabled = true;
            this.txtGtNV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGtNV.Location = new System.Drawing.Point(356, 182);
            this.txtGtNV.Name = "txtGtNV";
            this.txtGtNV.Size = new System.Drawing.Size(78, 28);
            this.txtGtNV.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(906, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Nhập từ khóa:";
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(1020, 119);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(186, 26);
            this.txtKeyWord.TabIndex = 47;
            this.txtKeyWord.TextChanged += new System.EventHandler(this.txtKeyWord_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(328, 94);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 54);
            this.btnDel.TabIndex = 45;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(208, 94);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 54);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1247, 469);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 50);
            this.btnNext.TabIndex = 43;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(1247, 557);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(94, 50);
            this.btnFirst.TabIndex = 42;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(1247, 645);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(94, 50);
            this.btnLast.TabIndex = 41;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.Location = new System.Drawing.Point(1247, 381);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(94, 50);
            this.btnPrv.TabIndex = 40;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(142, 230);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(234, 26);
            this.txtTenNV.TabIndex = 39;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Location = new System.Drawing.Point(142, 279);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(878, 26);
            this.txtDiaChiNV.TabIndex = 38;
            // 
            // txtSdtNV
            // 
            this.txtSdtNV.Location = new System.Drawing.Point(553, 184);
            this.txtSdtNV.Name = "txtSdtNV";
            this.txtSdtNV.Size = new System.Drawing.Size(234, 26);
            this.txtSdtNV.TabIndex = 37;
            this.txtSdtNV.TextChanged += new System.EventHandler(this.txtSdtNV_TextChanged);
            // 
            // txtCccdNV
            // 
            this.txtCccdNV.Location = new System.Drawing.Point(553, 230);
            this.txtCccdNV.Name = "txtCccdNV";
            this.txtCccdNV.Size = new System.Drawing.Size(234, 26);
            this.txtCccdNV.TabIndex = 36;
            this.txtCccdNV.TextChanged += new System.EventHandler(this.txtCccdNV_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Giới tính: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Họ và tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Địa chỉ:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Số ĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "CCCD";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(142, 184);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(115, 26);
            this.txtMaNV.TabIndex = 30;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã NV:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Enabled = false;
            this.btnAddNew.Location = new System.Drawing.Point(448, 91);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(100, 54);
            this.btnAddNew.TabIndex = 28;
            this.btnAddNew.Text = "Tạo mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Location = new System.Drawing.Point(1361, 746);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 53);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(568, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(315, 41);
            this.label8.TabIndex = 51;
            this.label8.Text = "Danh mục Nhân viên";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GridViewDSNV
            // 
            this.GridViewDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.ChucVu,
            this.DiaChiNV,
            this.CccdNV,
            this.SdtNV,
            this.GtNV});
            this.GridViewDSNV.Location = new System.Drawing.Point(51, 353);
            this.GridViewDSNV.Name = "GridViewDSNV";
            this.GridViewDSNV.RowHeadersWidth = 62;
            this.GridViewDSNV.RowTemplate.Height = 28;
            this.GridViewDSNV.Size = new System.Drawing.Size(1168, 434);
            this.GridViewDSNV.TabIndex = 52;
            this.GridViewDSNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSNV_CellClick);
            this.GridViewDSNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSNV_CellContentClick);
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
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Họ và tên";
            this.TenNV.MinimumWidth = 8;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 113;
            // 
            // ChucVu
            // 
            this.ChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.MinimumWidth = 8;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 106;
            // 
            // DiaChiNV
            // 
            this.DiaChiNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DiaChiNV.DataPropertyName = "DiaChiNV";
            this.DiaChiNV.HeaderText = "Địa chỉ";
            this.DiaChiNV.MinimumWidth = 8;
            this.DiaChiNV.Name = "DiaChiNV";
            this.DiaChiNV.Width = 93;
            // 
            // CccdNV
            // 
            this.CccdNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CccdNV.DataPropertyName = "CccdNV";
            this.CccdNV.HeaderText = "Số CCCD";
            this.CccdNV.MinimumWidth = 8;
            this.CccdNV.Name = "CccdNV";
            this.CccdNV.Width = 114;
            // 
            // SdtNV
            // 
            this.SdtNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SdtNV.DataPropertyName = "SdtNV";
            this.SdtNV.HeaderText = "Số điện thoại";
            this.SdtNV.MinimumWidth = 8;
            this.SdtNV.Name = "SdtNV";
            this.SdtNV.Width = 138;
            // 
            // GtNV
            // 
            this.GtNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GtNV.DataPropertyName = "GtNV";
            this.GtNV.HeaderText = "Giới tính";
            this.GtNV.MinimumWidth = 8;
            this.GtNV.Name = "GtNV";
            this.GtNV.Width = 103;
            // 
            // btnNapLai
            // 
            this.btnNapLai.Location = new System.Drawing.Point(88, 91);
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.Size = new System.Drawing.Size(100, 54);
            this.btnNapLai.TabIndex = 53;
            this.btnNapLai.Text = "Thêm";
            this.btnNapLai.UseVisualStyleBackColor = true;
            this.btnNapLai.Click += new System.EventHandler(this.btnNapLai_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 23);
            this.label9.TabIndex = 54;
            this.label9.Text = "Bảng thông tin nhân viên:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(816, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Chức vụ: ";
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.FormattingEnabled = true;
            this.cbxChucVu.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbxChucVu.Location = new System.Drawing.Point(899, 230);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Size = new System.Drawing.Size(121, 28);
            this.cbxChucVu.TabIndex = 57;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(1361, 677);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(111, 53);
            this.btnIn.TabIndex = 58;
            this.btnIn.Text = "In DS";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmDmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1484, 826);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.cbxChucVu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnNapLai);
            this.Controls.Add(this.GridViewDSNV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGtNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtDiaChiNV);
            this.Controls.Add(this.txtSdtNV);
            this.Controls.Add(this.txtCccdNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(260, 85);
            this.Name = "frmDmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Danh mục Nhân viên";
            this.Load += new System.EventHandler(this.frmDmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtGtNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.TextBox txtSdtNV;
        private System.Windows.Forms.TextBox txtCccdNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView GridViewDSNV;
        private System.Windows.Forms.Button btnNapLai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxChucVu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CccdNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SdtNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GtNV;
        private System.Windows.Forms.Button btnIn;
    }
}