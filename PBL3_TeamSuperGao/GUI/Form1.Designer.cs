
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
            this.tabTaiKhoan = new System.Windows.Forms.TabPage();
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
            this.btnSearchNV = new System.Windows.Forms.Button();
            this.btnSearchMon = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtmDes = new System.Windows.Forms.DateTimePicker();
            this.cbbThongKe = new System.Windows.Forms.ComboBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.dtvThongKe = new System.Windows.Forms.DataGridView();
            this.dtmOrg = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.tabMon.SuspendLayout();
            this.tabTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwNV)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvThongKe)).BeginInit();
            this.tabThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMon
            // 
            this.tabMon.Controls.Add(this.tabThongKe);
            this.tabMon.Controls.Add(this.tabTaiKhoan);
            this.tabMon.Controls.Add(this.tabNhanVien);
            this.tabMon.Controls.Add(this.tabPage1);
            this.tabMon.Location = new System.Drawing.Point(0, 0);
            this.tabMon.Name = "tabMon";
            this.tabMon.SelectedIndex = 0;
            this.tabMon.Size = new System.Drawing.Size(990, 538);
            this.tabMon.TabIndex = 7;
            // 
            // tabTaiKhoan
            // 
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
            this.tabTaiKhoan.Location = new System.Drawing.Point(4, 25);
            this.tabTaiKhoan.Name = "tabTaiKhoan";
            this.tabTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabTaiKhoan.Size = new System.Drawing.Size(982, 509);
            this.tabTaiKhoan.TabIndex = 1;
            this.tabTaiKhoan.Text = "Tài Khoản";
            this.tabTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnResetTK
            // 
            this.btnResetTK.Location = new System.Drawing.Point(601, 216);
            this.btnResetTK.Name = "btnResetTK";
            this.btnResetTK.Size = new System.Drawing.Size(329, 37);
            this.btnResetTK.TabIndex = 6;
            this.btnResetTK.Text = "Reset";
            this.btnResetTK.UseVisualStyleBackColor = true;
            this.btnResetTK.Click += new System.EventHandler(this.btnResetTK_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.ForeColor = System.Drawing.Color.White;
            this.lblCheck.Location = new System.Drawing.Point(763, 196);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(46, 17);
            this.lblCheck.TabIndex = 4;
            this.lblCheck.Text = "label1";
            // 
            // txtReFill
            // 
            this.txtReFill.Location = new System.Drawing.Point(766, 161);
            this.txtReFill.Name = "txtReFill";
            this.txtReFill.Size = new System.Drawing.Size(164, 22);
            this.txtReFill.TabIndex = 5;
            this.txtReFill.TextChanged += new System.EventHandler(this.txtReFill_TextChanged);
            // 
            // txtMatKhauTK
            // 
            this.txtMatKhauTK.Location = new System.Drawing.Point(766, 109);
            this.txtMatKhauTK.Name = "txtMatKhauTK";
            this.txtMatKhauTK.Size = new System.Drawing.Size(164, 22);
            this.txtMatKhauTK.TabIndex = 4;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(766, 48);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(164, 22);
            this.txtTenTK.TabIndex = 3;
            // 
            // lblReFill
            // 
            this.lblReFill.AutoSize = true;
            this.lblReFill.ForeColor = System.Drawing.Color.Black;
            this.lblReFill.Location = new System.Drawing.Point(598, 161);
            this.lblReFill.Name = "lblReFill";
            this.lblReFill.Size = new System.Drawing.Size(126, 17);
            this.lblReFill.TabIndex = 2;
            this.lblReFill.Text = "Nhập lại mật khẩu:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(598, 109);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(72, 17);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật Khẩu:";
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Location = new System.Drawing.Point(598, 46);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(106, 17);
            this.lblTenTK.TabIndex = 2;
            this.lblTenTK.Text = "Tên Tài Khoản:";
            // 
            // btnShowTK
            // 
            this.btnShowTK.Location = new System.Drawing.Point(852, 268);
            this.btnShowTK.Name = "btnShowTK";
            this.btnShowTK.Size = new System.Drawing.Size(78, 36);
            this.btnShowTK.TabIndex = 1;
            this.btnShowTK.Text = "Show";
            this.btnShowTK.UseVisualStyleBackColor = true;
            this.btnShowTK.Click += new System.EventHandler(this.btnShowTK_Click);
            // 
            // btnEditTK
            // 
            this.btnEditTK.Location = new System.Drawing.Point(683, 268);
            this.btnEditTK.Name = "btnEditTK";
            this.btnEditTK.Size = new System.Drawing.Size(84, 36);
            this.btnEditTK.TabIndex = 1;
            this.btnEditTK.Text = "Edit";
            this.btnEditTK.UseVisualStyleBackColor = true;
            this.btnEditTK.Click += new System.EventHandler(this.btnAddTK_Click);
            // 
            // btnDelTK
            // 
            this.btnDelTK.Location = new System.Drawing.Point(773, 268);
            this.btnDelTK.Name = "btnDelTK";
            this.btnDelTK.Size = new System.Drawing.Size(73, 36);
            this.btnDelTK.TabIndex = 1;
            this.btnDelTK.Text = "Del";
            this.btnDelTK.UseVisualStyleBackColor = true;
            this.btnDelTK.Click += new System.EventHandler(this.BtnDelTK_Click);
            // 
            // btnAddTK
            // 
            this.btnAddTK.Location = new System.Drawing.Point(601, 268);
            this.btnAddTK.Name = "btnAddTK";
            this.btnAddTK.Size = new System.Drawing.Size(76, 36);
            this.btnAddTK.TabIndex = 1;
            this.btnAddTK.Text = "Add";
            this.btnAddTK.UseVisualStyleBackColor = true;
            this.btnAddTK.Click += new System.EventHandler(this.btnAddTK_Click);
            // 
            // dtgvTaiKhoan
            // 
            this.dtgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaiKhoan.Location = new System.Drawing.Point(8, 25);
            this.dtgvTaiKhoan.Name = "dtgvTaiKhoan";
            this.dtgvTaiKhoan.RowHeadersWidth = 51;
            this.dtgvTaiKhoan.RowTemplate.Height = 24;
            this.dtgvTaiKhoan.Size = new System.Drawing.Size(546, 459);
            this.dtgvTaiKhoan.TabIndex = 0;
            this.dtgvTaiKhoan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvTaiKhoan_MouseClick);
            // 
            // tabNhanVien
            // 
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
            this.tabNhanVien.Location = new System.Drawing.Point(4, 25);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(982, 509);
            this.tabNhanVien.TabIndex = 2;
            this.tabNhanVien.Text = "Nhân VIên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnSortNV
            // 
            this.btnSortNV.Location = new System.Drawing.Point(676, 448);
            this.btnSortNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortNV.Name = "btnSortNV";
            this.btnSortNV.Size = new System.Drawing.Size(110, 28);
            this.btnSortNV.TabIndex = 24;
            this.btnSortNV.Text = "Sort";
            this.btnSortNV.UseVisualStyleBackColor = true;
            this.btnSortNV.Click += new System.EventHandler(this.btnSortNV_Click);
            // 
            // btnDelNV
            // 
            this.btnDelNV.Location = new System.Drawing.Point(400, 448);
            this.btnDelNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelNV.Name = "btnDelNV";
            this.btnDelNV.Size = new System.Drawing.Size(100, 28);
            this.btnDelNV.TabIndex = 25;
            this.btnDelNV.Text = "Del";
            this.btnDelNV.UseVisualStyleBackColor = true;
            this.btnDelNV.Click += new System.EventHandler(this.btnDelNV_Click);
            // 
            // btnEditNV
            // 
            this.btnEditNV.Location = new System.Drawing.Point(271, 448);
            this.btnEditNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(100, 28);
            this.btnEditNV.TabIndex = 26;
            this.btnEditNV.Text = "Edit";
            this.btnEditNV.UseVisualStyleBackColor = true;
            this.btnEditNV.Click += new System.EventHandler(this.AddandEditNV);
            // 
            // btnAddNV
            // 
            this.btnAddNV.Location = new System.Drawing.Point(141, 448);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(100, 28);
            this.btnAddNV.TabIndex = 27;
            this.btnAddNV.Text = "Add";
            this.btnAddNV.UseVisualStyleBackColor = true;
            this.btnAddNV.Click += new System.EventHandler(this.AddandEditNV);
            // 
            // btnShowNV
            // 
            this.btnShowNV.Location = new System.Drawing.Point(12, 448);
            this.btnShowNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowNV.Name = "btnShowNV";
            this.btnShowNV.Size = new System.Drawing.Size(101, 28);
            this.btnShowNV.TabIndex = 28;
            this.btnShowNV.Text = "Show";
            this.btnShowNV.UseVisualStyleBackColor = true;
            this.btnShowNV.Click += new System.EventHandler(this.btnShowNV_Click);
            // 
            // dvwNV
            // 
            this.dvwNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwNV.Location = new System.Drawing.Point(12, 65);
            this.dvwNV.Margin = new System.Windows.Forms.Padding(4);
            this.dvwNV.Name = "dvwNV";
            this.dvwNV.RowHeadersWidth = 51;
            this.dvwNV.Size = new System.Drawing.Size(960, 345);
            this.dvwNV.TabIndex = 23;
            // 
            // txtSearchNV
            // 
            this.txtSearchNV.Location = new System.Drawing.Point(726, 29);
            this.txtSearchNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchNV.Multiline = true;
            this.txtSearchNV.Name = "txtSearchNV";
            this.txtSearchNV.Size = new System.Drawing.Size(144, 28);
            this.txtSearchNV.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Họ Tên:";
            // 
            // cboSortNV
            // 
            this.cboSortNV.FormattingEnabled = true;
            this.cboSortNV.Location = new System.Drawing.Point(813, 451);
            this.cboSortNV.Margin = new System.Windows.Forms.Padding(4);
            this.cboSortNV.Name = "cboSortNV";
            this.cboSortNV.Size = new System.Drawing.Size(136, 24);
            this.cboSortNV.TabIndex = 19;
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(80, 25);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(160, 24);
            this.cboChucVu.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chức vụ";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSortMon);
            this.tabPage1.Controls.Add(this.btnDelMon);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 509);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Món";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSortMon
            // 
            this.btnSortMon.Location = new System.Drawing.Point(667, 454);
            this.btnSortMon.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortMon.Name = "btnSortMon";
            this.btnSortMon.Size = new System.Drawing.Size(100, 28);
            this.btnSortMon.TabIndex = 36;
            this.btnSortMon.Text = "Sort";
            this.btnSortMon.UseVisualStyleBackColor = true;
            this.btnSortMon.Click += new System.EventHandler(this.btnSortMon_Click);
            // 
            // btnDelMon
            // 
            this.btnDelMon.Location = new System.Drawing.Point(414, 450);
            this.btnDelMon.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelMon.Name = "btnDelMon";
            this.btnDelMon.Size = new System.Drawing.Size(100, 28);
            this.btnDelMon.TabIndex = 37;
            this.btnDelMon.Text = "Del";
            this.btnDelMon.UseVisualStyleBackColor = true;
            this.btnDelMon.Click += new System.EventHandler(this.btnDelMon_Click);
            // 
            // btnEditMon
            // 
            this.btnEditMon.Location = new System.Drawing.Point(285, 450);
            this.btnEditMon.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditMon.Name = "btnEditMon";
            this.btnEditMon.Size = new System.Drawing.Size(100, 28);
            this.btnEditMon.TabIndex = 38;
            this.btnEditMon.Text = "Edit";
            this.btnEditMon.UseVisualStyleBackColor = true;
            this.btnEditMon.Click += new System.EventHandler(this.AddandEditMon);
            // 
            // btnAddMon
            // 
            this.btnAddMon.Location = new System.Drawing.Point(155, 450);
            this.btnAddMon.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMon.Name = "btnAddMon";
            this.btnAddMon.Size = new System.Drawing.Size(100, 28);
            this.btnAddMon.TabIndex = 39;
            this.btnAddMon.Text = "Add";
            this.btnAddMon.UseVisualStyleBackColor = true;
            this.btnAddMon.Click += new System.EventHandler(this.AddandEditMon);
            // 
            // btnShowMon
            // 
            this.btnShowMon.Location = new System.Drawing.Point(27, 450);
            this.btnShowMon.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowMon.Name = "btnShowMon";
            this.btnShowMon.Size = new System.Drawing.Size(100, 28);
            this.btnShowMon.TabIndex = 40;
            this.btnShowMon.Text = "Show";
            this.btnShowMon.UseVisualStyleBackColor = true;
            this.btnShowMon.Click += new System.EventHandler(this.btnShowMon_Click);
            // 
            // dvwMon
            // 
            this.dvwMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvwMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwMon.Location = new System.Drawing.Point(19, 78);
            this.dvwMon.Margin = new System.Windows.Forms.Padding(4);
            this.dvwMon.Name = "dvwMon";
            this.dvwMon.RowHeadersWidth = 51;
            this.dvwMon.Size = new System.Drawing.Size(940, 349);
            this.dvwMon.TabIndex = 35;
            // 
            // txtSearchMon
            // 
            this.txtSearchMon.Location = new System.Drawing.Point(709, 35);
            this.txtSearchMon.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchMon.Name = "txtSearchMon";
            this.txtSearchMon.Size = new System.Drawing.Size(150, 22);
            this.txtSearchMon.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ten Mon :";
            // 
            // cboSortMon
            // 
            this.cboSortMon.FormattingEnabled = true;
            this.cboSortMon.Location = new System.Drawing.Point(786, 454);
            this.cboSortMon.Margin = new System.Windows.Forms.Padding(4);
            this.cboSortMon.Name = "cboSortMon";
            this.cboSortMon.Size = new System.Drawing.Size(149, 24);
            this.cboSortMon.TabIndex = 31;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(98, 34);
            this.cboDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(160, 24);
            this.cboDanhMuc.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Danh Mục";
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchNV.Location = new System.Drawing.Point(878, 29);
            this.btnSearchNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.Size = new System.Drawing.Size(71, 28);
            this.btnSearchNV.TabIndex = 29;
            this.btnSearchNV.UseVisualStyleBackColor = true;
            this.btnSearchNV.Click += new System.EventHandler(this.btnSearchNV_Click);
            // 
            // btnSearchMon
            // 
            this.btnSearchMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchMon.Location = new System.Drawing.Point(867, 32);
            this.btnSearchMon.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchMon.Name = "btnSearchMon";
            this.btnSearchMon.Size = new System.Drawing.Size(68, 28);
            this.btnSearchMon.TabIndex = 41;
            this.btnSearchMon.UseVisualStyleBackColor = true;
            this.btnSearchMon.Click += new System.EventHandler(this.btnSearchMon_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(36, 429);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(127, 49);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.ThongKe);
            // 
            // dtmDes
            // 
            this.dtmDes.Location = new System.Drawing.Point(702, 39);
            this.dtmDes.Name = "dtmDes";
            this.dtmDes.Size = new System.Drawing.Size(200, 22);
            this.dtmDes.TabIndex = 1;
            // 
            // cbbThongKe
            // 
            this.cbbThongKe.FormattingEnabled = true;
            this.cbbThongKe.Location = new System.Drawing.Point(190, 442);
            this.cbbThongKe.Name = "cbbThongKe";
            this.cbbThongKe.Size = new System.Drawing.Size(132, 24);
            this.cbbThongKe.TabIndex = 6;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(663, 449);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(120, 17);
            this.lblTongDoanhThu.TabIndex = 5;
            this.lblTongDoanhThu.Text = "Tổng Doanh Thu:";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(813, 442);
            this.txtTongDoanhThu.Multiline = true;
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(126, 29);
            this.txtTongDoanhThu.TabIndex = 4;
            // 
            // dtvThongKe
            // 
            this.dtvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvThongKe.Location = new System.Drawing.Point(21, 89);
            this.dtvThongKe.Name = "dtvThongKe";
            this.dtvThongKe.RowHeadersWidth = 51;
            this.dtvThongKe.RowTemplate.Height = 24;
            this.dtvThongKe.Size = new System.Drawing.Size(941, 322);
            this.dtvThongKe.TabIndex = 2;
            // 
            // dtmOrg
            // 
            this.dtmOrg.Location = new System.Drawing.Point(122, 39);
            this.dtmOrg.Name = "dtmOrg";
            this.dtmOrg.Size = new System.Drawing.Size(200, 22);
            this.dtmOrg.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Từ ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(602, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Đến ngày:";
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.label6);
            this.tabThongKe.Controls.Add(this.label5);
            this.tabThongKe.Controls.Add(this.dtmOrg);
            this.tabThongKe.Controls.Add(this.dtvThongKe);
            this.tabThongKe.Controls.Add(this.txtTongDoanhThu);
            this.tabThongKe.Controls.Add(this.lblTongDoanhThu);
            this.tabThongKe.Controls.Add(this.cbbThongKe);
            this.tabThongKe.Controls.Add(this.dtmDes);
            this.tabThongKe.Controls.Add(this.btnThongKe);
            this.tabThongKe.Location = new System.Drawing.Point(4, 25);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongKe.Size = new System.Drawing.Size(982, 509);
            this.tabThongKe.TabIndex = 0;
            this.tabThongKe.Text = "Thống Kê";
            this.tabThongKe.UseVisualStyleBackColor = true;
            this.tabThongKe.Click += new System.EventHandler(this.tabThongKe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 539);
            this.Controls.Add(this.tabMon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cafe Anh Em";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabMon.ResumeLayout(false);
            this.tabTaiKhoan.ResumeLayout(false);
            this.tabTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwNV)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvThongKe)).EndInit();
            this.tabThongKe.ResumeLayout(false);
            this.tabThongKe.PerformLayout();
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
    }
}

