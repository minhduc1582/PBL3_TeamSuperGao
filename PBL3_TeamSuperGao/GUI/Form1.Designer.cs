
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
            this.dtmOrg = new System.Windows.Forms.DateTimePicker();
            this.dtmDes = new System.Windows.Forms.DateTimePicker();
            this.dtvThongKe = new System.Windows.Forms.DataGridView();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.cbbThongKe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmOrg
            // 
            this.dtmOrg.Location = new System.Drawing.Point(68, 41);
            this.dtmOrg.Name = "dtmOrg";
            this.dtmOrg.Size = new System.Drawing.Size(200, 22);
            this.dtmOrg.TabIndex = 0;
            // 
            // dtmDes
            // 
            this.dtmDes.Location = new System.Drawing.Point(526, 41);
            this.dtmDes.Name = "dtmDes";
            this.dtmDes.Size = new System.Drawing.Size(200, 22);
            this.dtmDes.TabIndex = 1;
            // 
            // dtvThongKe
            // 
            this.dtvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvThongKe.Location = new System.Drawing.Point(35, 90);
            this.dtvThongKe.Name = "dtvThongKe";
            this.dtvThongKe.RowHeadersWidth = 51;
            this.dtvThongKe.RowTemplate.Height = 24;
            this.dtvThongKe.Size = new System.Drawing.Size(753, 238);
            this.dtvThongKe.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(109, 364);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(96, 31);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thong ke";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.ThongKe);
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(651, 364);
            this.txtTongDoanhThu.Multiline = true;
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(126, 29);
            this.txtTongDoanhThu.TabIndex = 4;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(523, 373);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(112, 17);
            this.lblTongDoanhThu.TabIndex = 5;
            this.lblTongDoanhThu.Text = "TongDoanhThu:";
            // 
            // cbbThongKe
            // 
            this.cbbThongKe.FormattingEnabled = true;
            this.cbbThongKe.Location = new System.Drawing.Point(254, 369);
            this.cbbThongKe.Name = "cbbThongKe";
            this.cbbThongKe.Size = new System.Drawing.Size(132, 24);
            this.cbbThongKe.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbThongKe);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtvThongKe);
            this.Controls.Add(this.dtmDes);
            this.Controls.Add(this.dtmOrg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtmOrg;
        private System.Windows.Forms.DateTimePicker dtmDes;
        private System.Windows.Forms.DataGridView dtvThongKe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.ComboBox cbbThongKe;
    }
}

