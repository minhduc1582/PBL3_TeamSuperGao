
namespace PBL3_TeamSuperGao.GUI
{
    partial class FormTan
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
            this.dtmOrg = new System.Windows.Forms.DateTimePicker();
            this.dtmDes = new System.Windows.Forms.DateTimePicker();
            this.dtvThongKe = new System.Windows.Forms.DataGridView();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.cbbThongKe = new System.Windows.Forms.ComboBox();
            this.Tabcontrol = new System.Windows.Forms.TabControl();
            this.tabThongKe = new System.Windows.Forms.TabPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtvThongKe)).BeginInit();
            this.Tabcontrol.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.tabTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmOrg
            // 
            this.dtmOrg.Location = new System.Drawing.Point(89, 39);
            this.dtmOrg.Name = "dtmOrg";
            this.dtmOrg.Size = new System.Drawing.Size(200, 22);
            this.dtmOrg.TabIndex = 0;
            // 
            // dtmDes
            // 
            this.dtmDes.Location = new System.Drawing.Point(520, 39);
            this.dtmDes.Name = "dtmDes";
            this.dtmDes.Size = new System.Drawing.Size(200, 22);
            this.dtmDes.TabIndex = 1;
            // 
            // dtvThongKe
            // 
            this.dtvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvThongKe.Location = new System.Drawing.Point(33, 88);
            this.dtvThongKe.Name = "dtvThongKe";
            this.dtvThongKe.RowHeadersWidth = 51;
            this.dtvThongKe.RowTemplate.Height = 24;
            this.dtvThongKe.Size = new System.Drawing.Size(705, 205);
            this.dtvThongKe.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(60, 337);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(96, 31);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thong ke";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.ThongKe);
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(612, 337);
            this.txtTongDoanhThu.Multiline = true;
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(126, 29);
            this.txtTongDoanhThu.TabIndex = 4;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(453, 340);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(112, 17);
            this.lblTongDoanhThu.TabIndex = 5;
            this.lblTongDoanhThu.Text = "TongDoanhThu:";
            // 
            // cbbThongKe
            // 
            this.cbbThongKe.FormattingEnabled = true;
            this.cbbThongKe.Location = new System.Drawing.Point(202, 337);
            this.cbbThongKe.Name = "cbbThongKe";
            this.cbbThongKe.Size = new System.Drawing.Size(132, 24);
            this.cbbThongKe.TabIndex = 6;
            // 
            // Tabcontrol
            // 
            this.Tabcontrol.Controls.Add(this.tabThongKe);
            this.Tabcontrol.Controls.Add(this.tabTaiKhoan);
            this.Tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.Tabcontrol.Name = "Tabcontrol";
            this.Tabcontrol.SelectedIndex = 0;
            this.Tabcontrol.Size = new System.Drawing.Size(788, 438);
            this.Tabcontrol.TabIndex = 7;
            // 
            // tabThongKe
            // 
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
            this.tabThongKe.Size = new System.Drawing.Size(780, 409);
            this.tabThongKe.TabIndex = 0;
            this.tabThongKe.Text = "Thong Ke";
            this.tabThongKe.UseVisualStyleBackColor = true;
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
            this.tabTaiKhoan.Size = new System.Drawing.Size(780, 409);
            this.tabTaiKhoan.TabIndex = 1;
            this.tabTaiKhoan.Text = "Tai Khoan";
            this.tabTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnResetTK
            // 
            this.btnResetTK.Location = new System.Drawing.Point(466, 237);
            this.btnResetTK.Name = "btnResetTK";
            this.btnResetTK.Size = new System.Drawing.Size(294, 37);
            this.btnResetTK.TabIndex = 6;
            this.btnResetTK.Text = "Reset";
            this.btnResetTK.UseVisualStyleBackColor = true;
            this.btnResetTK.Click += new System.EventHandler(this.btnResetTK_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.ForeColor = System.Drawing.Color.White;
            this.lblCheck.Location = new System.Drawing.Point(593, 217);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(46, 17);
            this.lblCheck.TabIndex = 4;
            this.lblCheck.Text = "label1";
            // 
            // txtReFill
            // 
            this.txtReFill.Location = new System.Drawing.Point(596, 182);
            this.txtReFill.Name = "txtReFill";
            this.txtReFill.Size = new System.Drawing.Size(148, 22);
            this.txtReFill.TabIndex = 5;
            this.txtReFill.TextChanged += new System.EventHandler(this.txtReFill_TextChanged);
            // 
            // txtMatKhauTK
            // 
            this.txtMatKhauTK.Location = new System.Drawing.Point(596, 130);
            this.txtMatKhauTK.Name = "txtMatKhauTK";
            this.txtMatKhauTK.Size = new System.Drawing.Size(148, 22);
            this.txtMatKhauTK.TabIndex = 4;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(596, 69);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(148, 22);
            this.txtTenTK.TabIndex = 3;
            // 
            // lblReFill
            // 
            this.lblReFill.AutoSize = true;
            this.lblReFill.ForeColor = System.Drawing.Color.Black;
            this.lblReFill.Location = new System.Drawing.Point(463, 187);
            this.lblReFill.Name = "lblReFill";
            this.lblReFill.Size = new System.Drawing.Size(126, 17);
            this.lblReFill.TabIndex = 2;
            this.lblReFill.Text = "Nhập lại mật khẩu:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(463, 135);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(72, 17);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật Khẩu:";
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Location = new System.Drawing.Point(463, 72);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(106, 17);
            this.lblTenTK.TabIndex = 2;
            this.lblTenTK.Text = "Tên Tài Khoản:";
            // 
            // btnShowTK
            // 
            this.btnShowTK.Location = new System.Drawing.Point(691, 280);
            this.btnShowTK.Name = "btnShowTK";
            this.btnShowTK.Size = new System.Drawing.Size(69, 36);
            this.btnShowTK.TabIndex = 1;
            this.btnShowTK.Text = "Xem";
            this.btnShowTK.UseVisualStyleBackColor = true;
            this.btnShowTK.Click += new System.EventHandler(this.btnShowTK_Click);
            // 
            // btnEditTK
            // 
            this.btnEditTK.Location = new System.Drawing.Point(541, 280);
            this.btnEditTK.Name = "btnEditTK";
            this.btnEditTK.Size = new System.Drawing.Size(69, 36);
            this.btnEditTK.TabIndex = 1;
            this.btnEditTK.Text = "Sửa";
            this.btnEditTK.UseVisualStyleBackColor = true;
            this.btnEditTK.Click += new System.EventHandler(this.btnAddTK_Click);
            // 
            // btnDelTK
            // 
            this.btnDelTK.Location = new System.Drawing.Point(616, 280);
            this.btnDelTK.Name = "btnDelTK";
            this.btnDelTK.Size = new System.Drawing.Size(69, 36);
            this.btnDelTK.TabIndex = 1;
            this.btnDelTK.Text = "Xóa";
            this.btnDelTK.UseVisualStyleBackColor = true;
            this.btnDelTK.Click += new System.EventHandler(this.BtnDelTK_Click);
            // 
            // btnAddTK
            // 
            this.btnAddTK.Location = new System.Drawing.Point(466, 280);
            this.btnAddTK.Name = "btnAddTK";
            this.btnAddTK.Size = new System.Drawing.Size(69, 36);
            this.btnAddTK.TabIndex = 1;
            this.btnAddTK.Text = "Thêm";
            this.btnAddTK.UseVisualStyleBackColor = true;
            this.btnAddTK.Click += new System.EventHandler(this.btnAddTK_Click);
            // 
            // dtgvTaiKhoan
            // 
            this.dtgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaiKhoan.Location = new System.Drawing.Point(21, 27);
            this.dtgvTaiKhoan.Name = "dtgvTaiKhoan";
            this.dtgvTaiKhoan.RowHeadersWidth = 51;
            this.dtgvTaiKhoan.RowTemplate.Height = 24;
            this.dtgvTaiKhoan.Size = new System.Drawing.Size(422, 289);
            this.dtgvTaiKhoan.TabIndex = 0;
            this.dtgvTaiKhoan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvTaiKhoan_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tabcontrol);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtvThongKe)).EndInit();
            this.Tabcontrol.ResumeLayout(false);
            this.tabThongKe.ResumeLayout(false);
            this.tabThongKe.PerformLayout();
            this.tabTaiKhoan.ResumeLayout(false);
            this.tabTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtmOrg;
        private System.Windows.Forms.DateTimePicker dtmDes;
        private System.Windows.Forms.DataGridView dtvThongKe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.ComboBox cbbThongKe;
        private System.Windows.Forms.TabControl Tabcontrol;
        private System.Windows.Forms.TabPage tabThongKe;
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
    }
}

