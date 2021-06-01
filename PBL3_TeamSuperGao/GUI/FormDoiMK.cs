using PBL3_TeamSuperGao.BLL;
using PBL3_TeamSuperGao.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_TeamSuperGao.GUI
{
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form t = new FormDangNhap();
            this.Visible = false;
            t.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BLL_QLTK.Instance.ChangePassword(textBox1.Text, textBox2.Text, textBox3.Text))
                MessageBox.Show("Bạn đã nhập sai mật khẩu");
            FormDangNhap t = new FormDangNhap();
            this.Visible = false;
            t.ShowDialog();
            this.Close();
        }
    }
}
