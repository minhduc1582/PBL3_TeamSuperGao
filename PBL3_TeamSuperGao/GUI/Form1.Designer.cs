
namespace PBL3_TeamSuperGao.GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabMon = new System.Windows.Forms.TabControl();
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmOrg = new System.Windows.Forms.DateTimePicker();
            this.dtvThongKe = new System.Windows.Forms.DataGridView();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.cbbThongKe = new System.Windows.Forms.ComboBox();
            this.dtmDes = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.tabTaiKhoan = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.btnResetTK = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.txtReFill = new System.Windows.Forms.TextBox();
            this.txtMatKhauTK = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.lblReFill = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.btnShowTK = new System.Windows.Forms.Button();
            this.btnEditTK = new System.Windows.Forms.Button();
            this.btnDelTK = new System.Windows.Forms.Button();
            this.btnAddTK = new System.Windows.Forms.Button();
            this.dtgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.btnSortNV = new System.Windows.Forms.Button();
            this.btnDelNV = new System.Windows.Forms.Button();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.btnShowNV = new System.Windows.Forms.Button();
            this.dvwNV = new System.Windows.Forms.DataGridView();
            this.txtSearchNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSortNV = new System.Windows.Forms.ComboBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchNV = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSortMon = new System.Windows.Forms.Button();
            this.btnDelMon = new System.Windows.Forms.Button();
            this.btnEditMon = new System.Windows.Forms.Button();
            this.btnAddMon = new System.Windows.Forms.Button();
            this.btnShowMon = new System.Windows.Forms.Button();
            this.dvwMon = new System.Windows.Forms.DataGridView();
            this.txtSearchMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSortMon = new System.Windows.Forms.ComboBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchMon = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.tabMon.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvThongKe)).BeginInit();
            this.tabTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwNV)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwMon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMon
            // 
            this.tabMon.Controls.Add(this.tabThongKe);
            this.tabMon.Controls.Add(this.tabTaiKhoan);
            this.tabMon.Controls.Add(this.tabNhanVien);
            this.tabMon.Controls.Add(this.tabPage1);
            this.tabMon.Location = new System.Drawing.Point(0, 0);
            this.tabMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMon.Name = "tabMon";
            this.tabMon.SelectedIndex = 0;
            this.tabMon.Size = new System.Drawing.Size(742, 437);
            this.tabMon.TabIndex = 7;
            // 
            // tabThongKe
            // 
            this.tabThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabThongKe.Controls.Add(this.label6);
            this.tabThongKe.Controls.Add(this.label5);
            this.tabThongKe.Controls.Add(this.dtmOrg);
            this.tabThongKe.Controls.Add(this.dtvThongKe);
            this.tabThongKe.Controls.Add(this.txtTongDoanhThu);
            this.tabThongKe.Controls.Add(this.lblTongDoanhThu);
            this.tabThongKe.Controls.Add(this.cbbThongKe);
            this.tabThongKe.Controls.Add(this.dtmDes);
            this.tabThongKe.Controls.Add(this.btnThongKe);
            this.tabThongKe.Location = new System.Drawing.Point(4, 22);
            this.tabThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabThongKe.Size = new System.Drawing.Size(734, 411);
            this.tabThongKe.TabIndex = 0;
            this.tabThongKe.Text = "Thống Kê";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Đến ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Từ ngày:";
            // 
            // dtmOrg
            // 
            this.dtmOrg.Location = new System.Drawing.Point(92, 32);
            this.dtmOrg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmOrg.Name = "dtmOrg";
            this.dtmOrg.Size = new System.Drawing.Size(151, 20);
            this.dtmOrg.TabIndex = 0;
            // 
            // dtvThongKe
            // 
            this.dtvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvThongKe.Location = new System.Drawing.Point(16, 72);
            this.dtvThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtvThongKe.Name = "dtvThongKe";
            this.dtvThongKe.RowHeadersWidth = 51;
            this.dtvThongKe.RowTemplate.Height = 24;
            this.dtvThongKe.Size = new System.Drawing.Size(706, 262);
            this.dtvThongKe.TabIndex = 2;
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(610, 359);
            this.txtTongDoanhThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongDoanhThu.Multiline = true;
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(96, 24);
            this.txtTongDoanhThu.TabIndex = 4;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(497, 365);
            this.lblTongDoanhThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(92, 13);
            this.lblTongDoanhThu.TabIndex = 5;
            this.lblTongDoanhThu.Text = "Tổng Doanh Thu:";
            // 
            // cbbThongKe
            // 
            this.cbbThongKe.FormattingEnabled = true;
            this.cbbThongKe.Location = new System.Drawing.Point(142, 359);
            this.cbbThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbThongKe.Name = "cbbThongKe";
            this.cbbThongKe.Size = new System.Drawing.Size(100, 21);
            this.cbbThongKe.TabIndex = 6;
            // 
            // dtmDes
            // 
            this.dtmDes.Location = new System.Drawing.Point(526, 32);
            this.dtmDes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmDes.Name = "dtmDes";
            this.dtmDes.Size = new System.Drawing.Size(151, 20);
            this.dtmDes.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = global::PBL3_TeamSuperGao.Properties.Resources.statistics_32px;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(27, 349);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(95, 40);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.ThongKe);
            // 
            // tabTaiKhoan
            // 
            this.tabTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabTaiKhoan.Controls.Add(this.comboBox1);
            this.tabTaiKhoan.Controls.Add(this.lblTenNV);
            this.tabTaiKhoan.Controls.Add(this.btnResetTK);
            this.tabTaiKhoan.Controls.Add(this.lblCheck);
            this.tabTaiKhoan.Controls.Add(this.txtReFill);
            this.tabTaiKhoan.Controls.Add(this.txtMatKhauTK);
            this.tabTaiKhoan.Controls.Add(this.txtTenTK);
            this.tabTaiKhoan.Controls.Add(this.lblReFill);
            this.tabTaiKhoan.Controls.Add(this.lblMatKhau);
            this.tabTaiKhoan.Controls.Add(this.lblTenTK);
            this.tabTaiKhoan.Controls.Add(this.btnShowTK);
            this.tabTaiKhoan.Controls.Add(this.btnEditTK);
            this.tabTaiKhoan.Controls.Add(this.btnDelTK);
            this.tabTaiKhoan.Controls.Add(this.btnAddTK);
            this.tabTaiKhoan.Controls.Add(this.dtgvTaiKhoan);
            this.tabTaiKhoan.Location = new System.Drawing.Point(4, 22);
            this.tabTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabTaiKhoan.Name = "tabTaiKhoan";
            this.tabTaiKhoan.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabTaiKhoan.Size = new System.Drawing.Size(734, 411);
            this.tabTaiKhoan.TabIndex = 1;
            this.tabTaiKhoan.Text = "Tài Khoản";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(574, 182);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(448, 182);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(79, 13);
            this.lblTenNV.TabIndex = 7;
            this.lblTenNV.Text = "Tên Nhân Viên";
            // 
            // btnResetTK
            // 
            this.btnResetTK.Image = global::PBL3_TeamSuperGao.Properties.Resources.reset_32px;
            this.btnResetTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetTK.Location = new System.Drawing.Point(451, 226);
            this.btnResetTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetTK.Name = "btnResetTK";
            this.btnResetTK.Size = new System.Drawing.Size(124, 37);
            this.btnResetTK.TabIndex = 6;
            this.btnResetTK.Text = "Reset";
            this.btnResetTK.UseVisualStyleBackColor = true;
            this.btnResetTK.Click += new System.EventHandler(this.btnResetTK_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.ForeColor = System.Drawing.Color.White;
            this.lblCheck.Location = new System.Drawing.Point(572, 155);
            this.lblCheck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(35, 13);
            this.lblCheck.TabIndex = 4;
            this.lblCheck.Text = "label1";
            // 
            // txtReFill
            // 
            this.txtReFill.Location = new System.Drawing.Point(574, 131);
            this.txtReFill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReFill.Name = "txtReFill";
            this.txtReFill.Size = new System.Drawing.Size(124, 20);
            this.txtReFill.TabIndex = 5;
            this.txtReFill.TextChanged += new System.EventHandler(this.txtReFill_TextChanged);
            // 
            // txtMatKhauTK
            // 
            this.txtMatKhauTK.Location = new System.Drawing.Point(574, 84);
            this.txtMatKhauTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatKhauTK.Name = "txtMatKhauTK";
            this.txtMatKhauTK.Size = new System.Drawing.Size(124, 20);
            this.txtMatKhauTK.TabIndex = 4;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(574, 39);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(124, 20);
            this.txtTenTK.TabIndex = 3;
            // 
            // lblReFill
            // 
            this.lblReFill.AutoSize = true;
            this.lblReFill.ForeColor = System.Drawing.Color.Black;
            this.lblReFill.Location = new System.Drawing.Point(448, 131);
            this.lblReFill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReFill.Name = "lblReFill";
            this.lblReFill.Size = new System.Drawing.Size(96, 13);
            this.lblReFill.TabIndex = 2;
            this.lblReFill.Text = "Nhập lại mật khẩu:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(448, 89);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(56, 13);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật Khẩu:";
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Location = new System.Drawing.Point(448, 37);
            this.lblTenTK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(81, 13);
            this.lblTenTK.TabIndex = 2;
            this.lblTenTK.Text = "Tên Tài Khoản:";
            // 
            // btnShowTK
            // 
            this.btnShowTK.Image = global::PBL3_TeamSuperGao.Properties.Resources.show_32px;
            this.btnShowTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTK.Location = new System.Drawing.Point(580, 225);
            this.btnShowTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowTK.Name = "btnShowTK";
            this.btnShowTK.Size = new System.Drawing.Size(118, 40);
            this.btnShowTK.TabIndex = 1;
            this.btnShowTK.Text = "Show";
            this.btnShowTK.UseVisualStyleBackColor = true;
            this.btnShowTK.Click += new System.EventHandler(this.btnShowTK_Click);
            // 
            // btnEditTK
            // 
            this.btnEditTK.Image = global::PBL3_TeamSuperGao.Properties.Resources.edit_32px;
            this.btnEditTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTK.Location = new System.Drawing.Point(530, 268);
            this.btnEditTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditTK.Name = "btnEditTK";
            this.btnEditTK.Size = new System.Drawing.Size(82, 40);
            this.btnEditTK.TabIndex = 1;
            this.btnEditTK.Text = "Edit";
            this.btnEditTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditTK.UseVisualStyleBackColor = true;
            this.btnEditTK.Click += new System.EventHandler(this.btnAddTK_Click);
            // 
            // btnDelTK
            // 
            this.btnDelTK.Image = global::PBL3_TeamSuperGao.Properties.Resources.trash_32px;
            this.btnDelTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelTK.Location = new System.Drawing.Point(616, 268);
            this.btnDelTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelTK.Name = "btnDelTK";
            this.btnDelTK.Size = new System.Drawing.Size(81, 40);
            this.btnDelTK.TabIndex = 1;
            this.btnDelTK.Text = "Del";
            this.btnDelTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelTK.UseVisualStyleBackColor = true;
            this.btnDelTK.Click += new System.EventHandler(this.BtnDelTK_Click);
            // 
            // btnAddTK
            // 
            this.btnAddTK.Image = global::PBL3_TeamSuperGao.Properties.Resources.add_icon_32px;
            this.btnAddTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTK.Location = new System.Drawing.Point(451, 268);
            this.btnAddTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTK.Name = "btnAddTK";
            this.btnAddTK.Size = new System.Drawing.Size(74, 40);
            this.btnAddTK.TabIndex = 1;
            this.btnAddTK.Text = "Add";
            this.btnAddTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTK.UseVisualStyleBackColor = true;
            this.btnAddTK.Click += new System.EventHandler(this.btnAddTK_Click);
            // 
            // dtgvTaiKhoan
            // 
            this.dtgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaiKhoan.Location = new System.Drawing.Point(6, 20);
            this.dtgvTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvTaiKhoan.Name = "dtgvTaiKhoan";
            this.dtgvTaiKhoan.RowHeadersWidth = 51;
            this.dtgvTaiKhoan.RowTemplate.Height = 24;
            this.dtgvTaiKhoan.Size = new System.Drawing.Size(410, 373);
            this.dtgvTaiKhoan.TabIndex = 0;
            this.dtgvTaiKhoan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvTaiKhoan_MouseClick);
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabNhanVien.Controls.Add(this.btnSortNV);
            this.tabNhanVien.Controls.Add(this.btnDelNV);
            this.tabNhanVien.Controls.Add(this.btnEditNV);
            this.tabNhanVien.Controls.Add(this.btnAddNV);
            this.tabNhanVien.Controls.Add(this.btnShowNV);
            this.tabNhanVien.Controls.Add(this.dvwNV);
            this.tabNhanVien.Controls.Add(this.txtSearchNV);
            this.tabNhanVien.Controls.Add(this.label2);
            this.tabNhanVien.Controls.Add(this.cboSortNV);
            this.tabNhanVien.Controls.Add(this.cboChucVu);
            this.tabNhanVien.Controls.Add(this.label1);
            this.tabNhanVien.Controls.Add(this.btnSearchNV);
            this.tabNhanVien.ImageKey = "(none)";
            this.tabNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabNhanVien.Size = new System.Drawing.Size(734, 411);
            this.tabNhanVien.TabIndex = 2;
            this.tabNhanVien.Text = "Nhân VIên";
            // 
            // btnSortNV
            // 
            this.btnSortNV.Image = global::PBL3_TeamSuperGao.Properties.Resources.sort_32px;
            this.btnSortNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortNV.Location = new System.Drawing.Point(507, 358);
            this.btnSortNV.Name = "btnSortNV";
            this.btnSortNV.Size = new System.Drawing.Size(82, 38);
            this.btnSortNV.TabIndex = 24;
            this.btnSortNV.Text = "Sort";
            this.btnSortNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSortNV.UseVisualStyleBackColor = true;
            this.btnSortNV.Click += new System.EventHandler(this.btnSortNV_Click);
            // 
            // btnDelNV
            // 
            this.btnDelNV.Image = global::PBL3_TeamSuperGao.Properties.Resources.trash_32px;
            this.btnDelNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelNV.Location = new System.Drawing.Point(300, 358);
            this.btnDelNV.Name = "btnDelNV";
            this.btnDelNV.Size = new System.Drawing.Size(75, 38);
            this.btnDelNV.TabIndex = 25;
            this.btnDelNV.Text = "Del";
            this.btnDelNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelNV.UseVisualStyleBackColor = true;
            this.btnDelNV.Click += new System.EventHandler(this.btnDelNV_Click);
            // 
            // btnEditNV
            // 
            this.btnEditNV.Image = global::PBL3_TeamSuperGao.Properties.Resources.edit_32px;
            this.btnEditNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditNV.Location = new System.Drawing.Point(203, 358);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(75, 38);
            this.btnEditNV.TabIndex = 26;
            this.btnEditNV.Text = "Edit";
            this.btnEditNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditNV.UseVisualStyleBackColor = true;
            this.btnEditNV.Click += new System.EventHandler(this.AddandEditNV);
            // 
            // btnAddNV
            // 
            this.btnAddNV.Image = global::PBL3_TeamSuperGao.Properties.Resources.add_icon_32px;
            this.btnAddNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNV.Location = new System.Drawing.Point(106, 358);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(75, 38);
            this.btnAddNV.TabIndex = 27;
            this.btnAddNV.Text = "Add";
            this.btnAddNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNV.UseVisualStyleBackColor = true;
            this.btnAddNV.Click += new System.EventHandler(this.AddandEditNV);
            // 
            // btnShowNV
            // 
            this.btnShowNV.Image = global::PBL3_TeamSuperGao.Properties.Resources.show_32px;
            this.btnShowNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowNV.Location = new System.Drawing.Point(9, 358);
            this.btnShowNV.Name = "btnShowNV";
            this.btnShowNV.Size = new System.Drawing.Size(76, 38);
            this.btnShowNV.TabIndex = 28;
            this.btnShowNV.Text = "Show";
            this.btnShowNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowNV.UseVisualStyleBackColor = true;
            this.btnShowNV.Click += new System.EventHandler(this.ShowAndSearchNV);
            // 
            // dvwNV
            // 
            this.dvwNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwNV.Location = new System.Drawing.Point(9, 53);
            this.dvwNV.Name = "dvwNV";
            this.dvwNV.RowHeadersWidth = 51;
            this.dvwNV.Size = new System.Drawing.Size(720, 280);
            this.dvwNV.TabIndex = 23;
            // 
            // txtSearchNV
            // 
            this.txtSearchNV.Location = new System.Drawing.Point(544, 24);
            this.txtSearchNV.Multiline = true;
            this.txtSearchNV.Name = "txtSearchNV";
            this.txtSearchNV.Size = new System.Drawing.Size(109, 24);
            this.txtSearchNV.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Họ Tên:";
            // 
            // cboSortNV
            // 
            this.cboSortNV.FormattingEnabled = true;
            this.cboSortNV.Location = new System.Drawing.Point(598, 371);
            this.cboSortNV.Name = "cboSortNV";
            this.cboSortNV.Size = new System.Drawing.Size(115, 21);
            this.cboSortNV.TabIndex = 19;
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(60, 20);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(121, 21);
            this.cboChucVu.TabIndex = 20;
            this.cboChucVu.SelectedIndexChanged += new System.EventHandler(this.cboChucVu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chức vụ";
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.BackgroundImage = global::PBL3_TeamSuperGao.Properties.Resources.search;
            this.btnSearchNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchNV.Location = new System.Drawing.Point(658, 24);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.Size = new System.Drawing.Size(53, 23);
            this.btnSearchNV.TabIndex = 29;
            this.btnSearchNV.UseVisualStyleBackColor = true;
            this.btnSearchNV.Click += new System.EventHandler(this.ShowAndSearchNV);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.btnSortMon);
            this.tabPage1.Controls.Add(this.btnDelMon);
            this.tabPage1.Controls.Add(this.btnTT);
            this.tabPage1.Controls.Add(this.btnEditMon);
            this.tabPage1.Controls.Add(this.btnAddMon);
            this.tabPage1.Controls.Add(this.btnShowMon);
            this.tabPage1.Controls.Add(this.dvwMon);
            this.tabPage1.Controls.Add(this.txtSearchMon);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cboSortMon);
            this.tabPage1.Controls.Add(this.cboDanhMuc);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnSearchMon);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(734, 411);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Món";
            // 
            // btnSortMon
            // 
            this.btnSortMon.Image = global::PBL3_TeamSuperGao.Properties.Resources.sort_32px;
            this.btnSortMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortMon.Location = new System.Drawing.Point(500, 365);
            this.btnSortMon.Name = "btnSortMon";
            this.btnSortMon.Size = new System.Drawing.Size(75, 35);
            this.btnSortMon.TabIndex = 36;
            this.btnSortMon.Text = "Sort";
            this.btnSortMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSortMon.UseVisualStyleBackColor = true;
            this.btnSortMon.Click += new System.EventHandler(this.btnSortMon_Click);
            // 
            // btnDelMon
            // 
            this.btnDelMon.Image = global::PBL3_TeamSuperGao.Properties.Resources.trash_32px;
            this.btnDelMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelMon.Location = new System.Drawing.Point(310, 362);
            this.btnDelMon.Name = "btnDelMon";
            this.btnDelMon.Size = new System.Drawing.Size(75, 35);
            this.btnDelMon.TabIndex = 37;
            this.btnDelMon.Text = "Del";
            this.btnDelMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelMon.UseVisualStyleBackColor = true;
            this.btnDelMon.Click += new System.EventHandler(this.btnDelMon_Click);
            // 
            // btnEditMon
            // 
            this.btnEditMon.Image = global::PBL3_TeamSuperGao.Properties.Resources.edit_32px;
            this.btnEditMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMon.Location = new System.Drawing.Point(214, 362);
            this.btnEditMon.Name = "btnEditMon";
            this.btnEditMon.Size = new System.Drawing.Size(75, 35);
            this.btnEditMon.TabIndex = 38;
            this.btnEditMon.Text = "Edit";
            this.btnEditMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditMon.UseVisualStyleBackColor = true;
            this.btnEditMon.Click += new System.EventHandler(this.AddandEditMon);
            // 
            // btnAddMon
            // 
            this.btnAddMon.Image = global::PBL3_TeamSuperGao.Properties.Resources.add_icon_32px;
            this.btnAddMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMon.Location = new System.Drawing.Point(116, 362);
            this.btnAddMon.Name = "btnAddMon";
            this.btnAddMon.Size = new System.Drawing.Size(75, 35);
            this.btnAddMon.TabIndex = 39;
            this.btnAddMon.Text = "Add";
            this.btnAddMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMon.UseVisualStyleBackColor = true;
            this.btnAddMon.Click += new System.EventHandler(this.AddandEditMon);
            // 
            // btnShowMon
            // 
            this.btnShowMon.Image = global::PBL3_TeamSuperGao.Properties.Resources.show_32px;
            this.btnShowMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowMon.Location = new System.Drawing.Point(20, 362);
            this.btnShowMon.Name = "btnShowMon";
            this.btnShowMon.Size = new System.Drawing.Size(75, 35);
            this.btnShowMon.TabIndex = 40;
            this.btnShowMon.Text = "Show";
            this.btnShowMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowMon.UseVisualStyleBackColor = true;
            this.btnShowMon.Click += new System.EventHandler(this.ShowAndSearchMon);
            // 
            // dvwMon
            // 
            this.dvwMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvwMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwMon.Location = new System.Drawing.Point(14, 63);
            this.dvwMon.Name = "dvwMon";
            this.dvwMon.RowHeadersWidth = 51;
            this.dvwMon.Size = new System.Drawing.Size(705, 284);
            this.dvwMon.TabIndex = 35;
            // 
            // txtSearchMon
            // 
            this.txtSearchMon.Location = new System.Drawing.Point(532, 28);
            this.txtSearchMon.Multiline = true;
            this.txtSearchMon.Name = "txtSearchMon";
            this.txtSearchMon.Size = new System.Drawing.Size(114, 22);
            this.txtSearchMon.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ten Mon :";
            // 
            // cboSortMon
            // 
            this.cboSortMon.FormattingEnabled = true;
            this.cboSortMon.Location = new System.Drawing.Point(590, 375);
            this.cboSortMon.Name = "cboSortMon";
            this.cboSortMon.Size = new System.Drawing.Size(113, 21);
            this.cboSortMon.TabIndex = 31;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(74, 28);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(121, 21);
            this.cboDanhMuc.TabIndex = 32;
            this.cboDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cboDanhMuc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Danh Mục";
            // 
            // btnSearchMon
            // 
            this.btnSearchMon.BackgroundImage = global::PBL3_TeamSuperGao.Properties.Resources.search;
            this.btnSearchMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchMon.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearchMon.Location = new System.Drawing.Point(650, 26);
            this.btnSearchMon.Name = "btnSearchMon";
            this.btnSearchMon.Size = new System.Drawing.Size(51, 23);
            this.btnSearchMon.TabIndex = 41;
            this.btnSearchMon.UseVisualStyleBackColor = true;
            this.btnSearchMon.Click += new System.EventHandler(this.ShowAndSearchMon);
            // 
            // btnTT
            // 
            this.btnTT.Image = global::PBL3_TeamSuperGao.Properties.Resources.edit_32px;
            this.btnTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTT.Location = new System.Drawing.Point(408, 362);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(75, 35);
            this.btnTT.TabIndex = 38;
            this.btnTT.Text = "Status";
            this.btnTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 438);
            this.Controls.Add(this.tabMon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Cafe Anh Em";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabMon.ResumeLayout(false);
            this.tabThongKe.ResumeLayout(false);
            this.tabThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvThongKe)).EndInit();
            this.tabTaiKhoan.ResumeLayout(false);
            this.tabTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwNV)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabMon;
        private System.Windows.Forms.TabPage tabTaiKhoan;
        private System.Windows.Forms.DataGridView dtgvTaiKhoan;
        private System.Windows.Forms.Button btnAddTK;
        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Button btnEditTK;
        private System.Windows.Forms.Button btnShowTK;
        private System.Windows.Forms.Button btnDelTK;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtReFill;
        private System.Windows.Forms.TextBox txtMatKhauTK;
        private System.Windows.Forms.Label lblReFill;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Button btnResetTK;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.Button btnSortNV;
        private System.Windows.Forms.Button btnDelNV;
        private System.Windows.Forms.Button btnEditNV;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Button btnShowNV;
        private System.Windows.Forms.Button btnSearchNV;
        private System.Windows.Forms.DataGridView dvwNV;
        private System.Windows.Forms.TextBox txtSearchNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSortNV;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSortMon;
        private System.Windows.Forms.Button btnDelMon;
        private System.Windows.Forms.Button btnEditMon;
        private System.Windows.Forms.Button btnAddMon;
        private System.Windows.Forms.Button btnShowMon;
        private System.Windows.Forms.Button btnSearchMon;
        private System.Windows.Forms.DataGridView dvwMon;
        private System.Windows.Forms.TextBox txtSearchMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSortMon;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabThongKe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtmOrg;
        private System.Windows.Forms.DataGridView dtvThongKe;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.ComboBox cbbThongKe;
        private System.Windows.Forms.DateTimePicker dtmDes;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnTT;
    }
}

