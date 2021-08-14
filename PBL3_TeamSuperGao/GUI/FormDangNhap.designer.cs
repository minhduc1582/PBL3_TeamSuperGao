
namespace PBL3_TeamSuperGao.GUI
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user.ico");
            this.imageList1.Images.SetKeyName(1, "Cancel_32px.ico");
            this.imageList1.Images.SetKeyName(2, "key.ico");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::PBL3_TeamSuperGao.Properties.Resources.Columbia_Blue_Gradient_Wallpaper;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 457);
            this.panel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(144, 306);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(257, 40);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "1234";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(144, 243);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(257, 39);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.Text = "user";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(255, 395);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "Đổi Mật Khẩu";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(173)))), ((int)(((byte)(248)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(46, 395);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(135, 40);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.Handle_btnDangNhap);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(178)))), ((int)(((byte)(247)))));
            this.pictureBox3.Image = global::PBL3_TeamSuperGao.Properties.Resources.key_1;
            this.pictureBox3.Location = new System.Drawing.Point(46, 306);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(230)))), ((int)(((byte)(246)))));
            this.pictureBox4.Image = global::PBL3_TeamSuperGao.Properties.Resources.Cancel_32px;
            this.pictureBox4.Location = new System.Drawing.Point(377, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.pictureBox2.Image = global::PBL3_TeamSuperGao.Properties.Resources.user1;
            this.pictureBox2.Location = new System.Drawing.Point(46, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::PBL3_TeamSuperGao.Properties.Resources.personal;
            this.pictureBox1.Location = new System.Drawing.Point(170, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 457);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDangNhap;
    }
}