
namespace PBL3_TeamSuperGao
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSortNV = new System.Windows.Forms.Button();
            this.btnDelNV = new System.Windows.Forms.Button();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.btnShowNV = new System.Windows.Forms.Button();
            this.btnSearchNV = new System.Windows.Forms.Button();
            this.dvwNV = new System.Windows.Forms.DataGridView();
            this.txtSearchNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSortNV = new System.Windows.Forms.ComboBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSortMon = new System.Windows.Forms.Button();
            this.btnDelMon = new System.Windows.Forms.Button();
            this.btnEditMon = new System.Windows.Forms.Button();
            this.btnAddMon = new System.Windows.Forms.Button();
            this.btnShowMon = new System.Windows.Forms.Button();
            this.btnSearchMon = new System.Windows.Forms.Button();
            this.dvwMon = new System.Windows.Forms.DataGridView();
            this.txtSearchMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSortMon = new System.Windows.Forms.ComboBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwNV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwMon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 325);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSortNV);
            this.tabPage1.Controls.Add(this.btnDelNV);
            this.tabPage1.Controls.Add(this.btnEditNV);
            this.tabPage1.Controls.Add(this.btnAddNV);
            this.tabPage1.Controls.Add(this.btnShowNV);
            this.tabPage1.Controls.Add(this.btnSearchNV);
            this.tabPage1.Controls.Add(this.dvwNV);
            this.tabPage1.Controls.Add(this.txtSearchNV);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cboSortNV);
            this.tabPage1.Controls.Add(this.cboChucVu);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(621, 299);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSortNV
            // 
            this.btnSortNV.Location = new System.Drawing.Point(419, 252);
            this.btnSortNV.Name = "btnSortNV";
            this.btnSortNV.Size = new System.Drawing.Size(75, 23);
            this.btnSortNV.TabIndex = 12;
            this.btnSortNV.Text = "Sort";
            this.btnSortNV.UseVisualStyleBackColor = true;
            this.btnSortNV.Click += new System.EventHandler(this.btnSortNV_Click);
            // 
            // btnDelNV
            // 
            this.btnDelNV.Location = new System.Drawing.Point(315, 252);
            this.btnDelNV.Name = "btnDelNV";
            this.btnDelNV.Size = new System.Drawing.Size(75, 23);
            this.btnDelNV.TabIndex = 13;
            this.btnDelNV.Text = "Del";
            this.btnDelNV.UseVisualStyleBackColor = true;
            this.btnDelNV.Click += new System.EventHandler(this.btnDelNV_Click);
            // 
            // btnEditNV
            // 
            this.btnEditNV.Location = new System.Drawing.Point(218, 252);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(75, 23);
            this.btnEditNV.TabIndex = 14;
            this.btnEditNV.Text = "Edit";
            this.btnEditNV.UseVisualStyleBackColor = true;
            this.btnEditNV.Click += new System.EventHandler(this.AddandEditNV);
            // 
            // btnAddNV
            // 
            this.btnAddNV.Location = new System.Drawing.Point(121, 252);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(75, 23);
            this.btnAddNV.TabIndex = 15;
            this.btnAddNV.Text = "Add";
            this.btnAddNV.UseVisualStyleBackColor = true;
            this.btnAddNV.Click += new System.EventHandler(this.AddandEditNV);
            // 
            // btnShowNV
            // 
            this.btnShowNV.Location = new System.Drawing.Point(25, 252);
            this.btnShowNV.Name = "btnShowNV";
            this.btnShowNV.Size = new System.Drawing.Size(75, 23);
            this.btnShowNV.TabIndex = 16;
            this.btnShowNV.Text = "Show";
            this.btnShowNV.UseVisualStyleBackColor = true;
            this.btnShowNV.Click += new System.EventHandler(this.btnShowNV_Click);
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.Location = new System.Drawing.Point(518, 24);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.Size = new System.Drawing.Size(75, 23);
            this.btnSearchNV.TabIndex = 17;
            this.btnSearchNV.Text = "Search";
            this.btnSearchNV.UseVisualStyleBackColor = true;
            this.btnSearchNV.Click += new System.EventHandler(this.btnSearchNV_Click);
            // 
            // dvwNV
            // 
            this.dvwNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwNV.Location = new System.Drawing.Point(25, 69);
            this.dvwNV.Name = "dvwNV";
            this.dvwNV.Size = new System.Drawing.Size(568, 161);
            this.dvwNV.TabIndex = 11;
            // 
            // txtSearchNV
            // 
            this.txtSearchNV.Location = new System.Drawing.Point(393, 26);
            this.txtSearchNV.Name = "txtSearchNV";
            this.txtSearchNV.Size = new System.Drawing.Size(100, 20);
            this.txtSearchNV.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ho Ten:";
            // 
            // cboSortNV
            // 
            this.cboSortNV.FormattingEnabled = true;
            this.cboSortNV.Location = new System.Drawing.Point(518, 254);
            this.cboSortNV.Name = "cboSortNV";
            this.cboSortNV.Size = new System.Drawing.Size(75, 21);
            this.cboSortNV.TabIndex = 7;
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(75, 26);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(121, 21);
            this.cboChucVu.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chức vụ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSortMon);
            this.tabPage2.Controls.Add(this.btnDelMon);
            this.tabPage2.Controls.Add(this.btnEditMon);
            this.tabPage2.Controls.Add(this.btnAddMon);
            this.tabPage2.Controls.Add(this.btnShowMon);
            this.tabPage2.Controls.Add(this.btnSearchMon);
            this.tabPage2.Controls.Add(this.dvwMon);
            this.tabPage2.Controls.Add(this.txtSearchMon);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cboSortMon);
            this.tabPage2.Controls.Add(this.cboDanhMuc);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 299);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Món Ăn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSortMon
            // 
            this.btnSortMon.Location = new System.Drawing.Point(422, 252);
            this.btnSortMon.Name = "btnSortMon";
            this.btnSortMon.Size = new System.Drawing.Size(75, 23);
            this.btnSortMon.TabIndex = 24;
            this.btnSortMon.Text = "Sort";
            this.btnSortMon.UseVisualStyleBackColor = true;
            this.btnSortMon.Click += new System.EventHandler(this.btnSortMon_Click);
            // 
            // btnDelMon
            // 
            this.btnDelMon.Location = new System.Drawing.Point(318, 252);
            this.btnDelMon.Name = "btnDelMon";
            this.btnDelMon.Size = new System.Drawing.Size(75, 23);
            this.btnDelMon.TabIndex = 25;
            this.btnDelMon.Text = "Del";
            this.btnDelMon.UseVisualStyleBackColor = true;
            this.btnDelMon.Click += new System.EventHandler(this.btnDelMon_Click);
            // 
            // btnEditMon
            // 
            this.btnEditMon.Location = new System.Drawing.Point(221, 252);
            this.btnEditMon.Name = "btnEditMon";
            this.btnEditMon.Size = new System.Drawing.Size(75, 23);
            this.btnEditMon.TabIndex = 26;
            this.btnEditMon.Text = "Edit";
            this.btnEditMon.UseVisualStyleBackColor = true;
            this.btnEditMon.Click += new System.EventHandler(this.AddandEditMon);
            // 
            // btnAddMon
            // 
            this.btnAddMon.Location = new System.Drawing.Point(124, 252);
            this.btnAddMon.Name = "btnAddMon";
            this.btnAddMon.Size = new System.Drawing.Size(75, 23);
            this.btnAddMon.TabIndex = 27;
            this.btnAddMon.Text = "Add";
            this.btnAddMon.UseVisualStyleBackColor = true;
            this.btnAddMon.Click += new System.EventHandler(this.AddandEditMon);
            // 
            // btnShowMon
            // 
            this.btnShowMon.Location = new System.Drawing.Point(28, 252);
            this.btnShowMon.Name = "btnShowMon";
            this.btnShowMon.Size = new System.Drawing.Size(75, 23);
            this.btnShowMon.TabIndex = 28;
            this.btnShowMon.Text = "Show";
            this.btnShowMon.UseVisualStyleBackColor = true;
            this.btnShowMon.Click += new System.EventHandler(this.btnShowMon_Click);
            // 
            // btnSearchMon
            // 
            this.btnSearchMon.Location = new System.Drawing.Point(521, 24);
            this.btnSearchMon.Name = "btnSearchMon";
            this.btnSearchMon.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMon.TabIndex = 29;
            this.btnSearchMon.Text = "Search";
            this.btnSearchMon.UseVisualStyleBackColor = true;
            this.btnSearchMon.Click += new System.EventHandler(this.btnSearchMon_Click);
            // 
            // dvwMon
            // 
            this.dvwMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwMon.Location = new System.Drawing.Point(28, 69);
            this.dvwMon.Name = "dvwMon";
            this.dvwMon.Size = new System.Drawing.Size(568, 161);
            this.dvwMon.TabIndex = 23;
            // 
            // txtSearchMon
            // 
            this.txtSearchMon.Location = new System.Drawing.Point(396, 26);
            this.txtSearchMon.Name = "txtSearchMon";
            this.txtSearchMon.Size = new System.Drawing.Size(100, 20);
            this.txtSearchMon.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ten Mon :";
            // 
            // cboSortMon
            // 
            this.cboSortMon.FormattingEnabled = true;
            this.cboSortMon.Location = new System.Drawing.Point(521, 254);
            this.cboSortMon.Name = "cboSortMon";
            this.cboSortMon.Size = new System.Drawing.Size(75, 21);
            this.cboSortMon.TabIndex = 19;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(78, 26);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(121, 21);
            this.cboDanhMuc.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Danh Mục";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 322);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwNV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}

