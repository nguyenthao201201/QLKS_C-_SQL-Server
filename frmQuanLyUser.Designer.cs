
namespace QLTPKS
{
    partial class frmQuanLyUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyUser));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.GridViewDSID = new System.Windows.Forms.DataGridView();
            this.MaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNapLai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimNV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cbxQuyen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ID:";
            // 
            // txtMaID
            // 
            this.txtMaID.Location = new System.Drawing.Point(199, 186);
            this.txtMaID.Name = "txtMaID";
            this.txtMaID.Size = new System.Drawing.Size(116, 26);
            this.txtMaID.TabIndex = 1;
            this.txtMaID.TextChanged += new System.EventHandler(this.txtMaID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(128, 122);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(177, 26);
            this.txtPass.TabIndex = 3;
            // 
            // GridViewDSID
            // 
            this.GridViewDSID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDSID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaID,
            this.Pass,
            this.MaNV,
            this.Quyen});
            this.GridViewDSID.Location = new System.Drawing.Point(71, 377);
            this.GridViewDSID.Name = "GridViewDSID";
            this.GridViewDSID.RowHeadersWidth = 62;
            this.GridViewDSID.RowTemplate.Height = 28;
            this.GridViewDSID.Size = new System.Drawing.Size(436, 215);
            this.GridViewDSID.TabIndex = 4;
            this.GridViewDSID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSID_CellContentClick);
            // 
            // MaID
            // 
            this.MaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaID.DataPropertyName = "ID";
            this.MaID.HeaderText = "Mã ID";
            this.MaID.MinimumWidth = 8;
            this.MaID.Name = "MaID";
            this.MaID.Width = 88;
            // 
            // Pass
            // 
            this.Pass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Pass.DataPropertyName = "Pass";
            this.Pass.HeaderText = "Password";
            this.Pass.MinimumWidth = 8;
            this.Pass.Name = "Pass";
            this.Pass.Visible = false;
            this.Pass.Width = 150;
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
            // Quyen
            // 
            this.Quyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Quyen.DataPropertyName = "Quyen";
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.MinimumWidth = 8;
            this.Quyen.Name = "Quyen";
            this.Quyen.Width = 91;
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Location = new System.Drawing.Point(395, 85);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Tạo mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(180, 85);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 40);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(286, 85);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 40);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(819, 524);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 48);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(360, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 36);
            this.label8.TabIndex = 108;
            this.label8.Text = "Quản lý người dùng";
            // 
            // btnNapLai
            // 
            this.btnNapLai.Location = new System.Drawing.Point(78, 85);
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.Size = new System.Drawing.Size(75, 40);
            this.btnNapLai.TabIndex = 110;
            this.btnNapLai.Text = "Thêm";
            this.btnNapLai.UseVisualStyleBackColor = true;
            this.btnNapLai.Click += new System.EventHandler(this.btnNapLai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 111;
            this.label3.Text = "Tên nhân viên:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(690, 226);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(187, 26);
            this.txtTenNV.TabIndex = 112;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 113;
            this.label4.Text = "Chức vụ: ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(690, 270);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(187, 26);
            this.txtChucVu.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 115;
            this.label5.Text = "Số CCCD: ";
            // 
            // txtCccd
            // 
            this.txtCccd.Location = new System.Drawing.Point(130, 154);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(187, 26);
            this.txtCccd.TabIndex = 116;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(638, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 23);
            this.label6.TabIndex = 117;
            this.label6.Text = "Thông tin nhân viên: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTimNV);
            this.panel1.Controls.Add(this.txtCccd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(560, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 193);
            this.panel1.TabIndex = 118;
            // 
            // btnTimNV
            // 
            this.btnTimNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimNV.BackgroundImage")));
            this.btnTimNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimNV.Location = new System.Drawing.Point(236, 18);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(44, 38);
            this.btnTimNV.TabIndex = 0;
            this.btnTimNV.UseVisualStyleBackColor = true;
            this.btnTimNV.Click += new System.EventHandler(this.btnTimNV_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 119;
            this.label7.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(690, 182);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 26);
            this.txtMaNV.TabIndex = 120;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // cbxQuyen
            // 
            this.cbxQuyen.FormattingEnabled = true;
            this.cbxQuyen.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cbxQuyen.Location = new System.Drawing.Point(199, 230);
            this.cbxQuyen.Name = "cbxQuyen";
            this.cbxQuyen.Size = new System.Drawing.Size(121, 28);
            this.cbxQuyen.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 122;
            this.label9.Text = "Quyền:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(133, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 23);
            this.label10.TabIndex = 123;
            this.label10.Text = "Thông tin đăng nhập:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.btnHide);
            this.panel2.Location = new System.Drawing.Point(71, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 177);
            this.panel2.TabIndex = 124;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(310, 118);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(42, 38);
            this.btnShow.TabIndex = 127;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.White;
            this.btnHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHide.BackgroundImage")));
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Location = new System.Drawing.Point(310, 120);
            this.btnHide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(42, 36);
            this.btnHide.TabIndex = 117;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(700, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 23);
            this.label11.TabIndex = 125;
            this.label11.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(664, 410);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 26);
            this.txtTimKiem.TabIndex = 126;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(67, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 23);
            this.label12.TabIndex = 127;
            this.label12.Text = "Dữ liệu người dùng:";
            // 
            // frmQuanLyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(938, 604);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxQuyen);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNapLai);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.GridViewDSID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng: ";
            this.Load += new System.EventHandler(this.frmQuanLyUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.DataGridView GridViewDSID;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNapLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxQuyen;
        private System.Windows.Forms.Button btnTimNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label label12;
    }
}