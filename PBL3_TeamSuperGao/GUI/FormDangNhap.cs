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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int u = 0;
            foreach(TaiKhoan i in BLL_QLTK.Instance.GetAllTaiKhoan())
            {
                
                if(i.UserName.Contains(textBox1.Text) && i.PassWord.Contains(textBox2.Text))
                {
                    u = 1;
                }
            }
            if (u == 0) MessageBox.Show("Ban da nhap sai, vui long nhap lai");
            else
            {
                CAFEVIEW st = new CAFEVIEW();
                this.Visible = false;
                //lay ma nhan vien 
                st.t = BLL_QLNhanVien.Instance.GetIDNVForIDTK(BLL_QLTK.Instance.GetIDTK(textBox1.Text, textBox2.Text));
                st.ShowDialog();
                this.Close();
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDoiMK st = new FormDoiMK();
            this.Visible = false;
            st.ShowDialog();
            this.Close();
        }
    }
}
