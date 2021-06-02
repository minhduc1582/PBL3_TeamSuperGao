
namespace PBL3_TeamSuperGao.GUI
{
    partial class CAFEVIEW
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
            this.labelnamecf = new System.Windows.Forms.Label();
            this.comboBoxDM = new System.Windows.Forms.ComboBox();
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            this.comboBoxSL = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonThemMon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonChuyenBan = new System.Windows.Forms.Button();
            this.comboBoxCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTT = new System.Windows.Forms.TextBox();
            this.buttonXoaMon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonGopBan = new System.Windows.Forms.Button();
            this.textBoxGG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnamecf
            // 
            this.labelnamecf.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnamecf.ForeColor = System.Drawing.Color.Red;
            this.labelnamecf.Location = new System.Drawing.Point(399, 10);
            this.labelnamecf.Name = "labelnamecf";
            this.labelnamecf.Size = new System.Drawing.Size(377, 52);
            this.labelnamecf.TabIndex = 1;
            this.labelnamecf.Text = "Cà Phê Anh Em";
            // 
            // comboBoxDM
            // 
            this.comboBoxDM.FormattingEnabled = true;
            this.comboBoxDM.Location = new System.Drawing.Point(628, 81);
            this.comboBoxDM.Name = "comboBoxDM";
            this.comboBoxDM.Size = new System.Drawing.Size(136, 27);
            this.comboBoxDM.TabIndex = 2;
            this.comboBoxDM.SelectedIndexChanged += new System.EventHandler(this.comboBoxDM_SelectedIndexChanged);
            // 
            // comboBoxM
            // 
            this.comboBoxM.FormattingEnabled = true;
            this.comboBoxM.Location = new System.Drawing.Point(628, 114);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(136, 27);
            this.comboBoxM.TabIndex = 3;
            // 
            // comboBoxSL
            // 
            this.comboBoxSL.FormattingEnabled = true;
            this.comboBoxSL.Location = new System.Drawing.Point(789, 113);
            this.comboBoxSL.Name = "comboBoxSL";
            this.comboBoxSL.Size = new System.Drawing.Size(82, 27);
            this.comboBoxSL.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(533, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 308);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(566, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(787, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Danh Mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Món";
            // 
            // buttonThemMon
            // 
            this.buttonThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonThemMon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemMon.Location = new System.Drawing.Point(932, 83);
            this.buttonThemMon.Name = "buttonThemMon";
            this.buttonThemMon.Size = new System.Drawing.Size(79, 62);
            this.buttonThemMon.TabIndex = 9;
            this.buttonThemMon.Text = "Thêm món";
            this.buttonThemMon.UseVisualStyleBackColor = false;
            this.buttonThemMon.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1017, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 86);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thanh toán";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonChuyenBan
            // 
            this.buttonChuyenBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonChuyenBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChuyenBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonChuyenBan.Location = new System.Drawing.Point(547, 466);
            this.buttonChuyenBan.Name = "buttonChuyenBan";
            this.buttonChuyenBan.Size = new System.Drawing.Size(94, 60);
            this.buttonChuyenBan.TabIndex = 11;
            this.buttonChuyenBan.Text = "Chuyển bàn";
            this.buttonChuyenBan.UseVisualStyleBackColor = false;
            this.buttonChuyenBan.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxCB
            // 
            this.comboBoxCB.FormattingEnabled = true;
            this.comboBoxCB.Location = new System.Drawing.Point(612, 531);
            this.comboBoxCB.Name = "comboBoxCB";
            this.comboBoxCB.Size = new System.Drawing.Size(126, 27);
            this.comboBoxCB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(744, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giảm giá (%)";
            // 
            // textBoxTT
            // 
            this.textBoxTT.Location = new System.Drawing.Point(873, 532);
            this.textBoxTT.Name = "textBoxTT";
            this.textBoxTT.ReadOnly = true;
            this.textBoxTT.Size = new System.Drawing.Size(138, 26);
            this.textBoxTT.TabIndex = 15;
            // 
            // buttonXoaMon
            // 
            this.buttonXoaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonXoaMon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaMon.Location = new System.Drawing.Point(1034, 83);
            this.buttonXoaMon.Name = "buttonXoaMon";
            this.buttonXoaMon.Size = new System.Drawing.Size(79, 62);
            this.buttonXoaMon.TabIndex = 32;
            this.buttonXoaMon.Text = "Xóa Món";
            this.buttonXoaMon.UseVisualStyleBackColor = false;
            this.buttonXoaMon.Click += new System.EventHandler(this.buttonXoaMon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(744, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tổng tiền";
            // 
            // btnHeThong
            // 
            this.btnHeThong.Location = new System.Drawing.Point(1008, 14);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(87, 27);
            this.btnHeThong.TabIndex = 35;
            this.btnHeThong.Text = "Hệ thống ";
            this.btnHeThong.UseVisualStyleBackColor = true;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Handle);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(487, 393);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // buttonGopBan
            // 
            this.buttonGopBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonGopBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGopBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGopBan.Location = new System.Drawing.Point(655, 465);
            this.buttonGopBan.Name = "buttonGopBan";
            this.buttonGopBan.Size = new System.Drawing.Size(83, 60);
            this.buttonGopBan.TabIndex = 41;
            this.buttonGopBan.Text = "Gộp bàn";
            this.buttonGopBan.UseVisualStyleBackColor = false;
            this.buttonGopBan.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxGG
            // 
            this.textBoxGG.Location = new System.Drawing.Point(873, 473);
            this.textBoxGG.Name = "textBoxGG";
            this.textBoxGG.Size = new System.Drawing.Size(138, 26);
            this.textBoxGG.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(553, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Bàn";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(33, 25);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(98, 34);
            this.btnTroVe.TabIndex = 46;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // CAFEVIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1146, 571);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxGG);
            this.Controls.Add(this.buttonGopBan);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnHeThong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonXoaMon);
            this.Controls.Add(this.textBoxTT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCB);
            this.Controls.Add(this.buttonChuyenBan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonThemMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSL);
            this.Controls.Add(this.comboBoxM);
            this.Controls.Add(this.comboBoxDM);
            this.Controls.Add(this.labelnamecf);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CAFEVIEW";
            this.Text = "Cafe Anh Em";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelnamecf;
        private System.Windows.Forms.ComboBox comboBoxDM;
        private System.Windows.Forms.ComboBox comboBoxM;
        private System.Windows.Forms.ComboBox comboBoxSL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonThemMon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonChuyenBan;
        private System.Windows.Forms.ComboBox comboBoxCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTT;
        private System.Windows.Forms.Button buttonXoaMon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonGopBan;
        private System.Windows.Forms.TextBox textBoxGG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTroVe;
    }
}

