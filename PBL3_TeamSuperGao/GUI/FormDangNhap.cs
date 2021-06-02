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

        private void button4_Click(object sender, EventArgs e)
        {
            FormDoiMK st = new FormDoiMK();
            this.Visible = false;
            st.ShowDialog();
            this.Close();
        }

        private void Handle_btnDangNhap(object sender, EventArgs e)
        {
            int u = 0;
            foreach (TaiKhoan i in BLL_QLTaiKhoan.Instance.BLL_ShowTK())
            {

                if (String.Compare(i.UserName.Trim(), txtUserName.Text, true) == 0 && i.PassWord == txtPassword.Text)
                {
                    u = 1;
                }
            }
            if (u == 0) MessageBox.Show("Sai Tài khoản hoặc mật khẩu, vui lòng nhập lại");
            else
            {
                CAFEVIEW st = new CAFEVIEW();
                st.SendForm_ += new CAFEVIEW.mydel(ShowForm);
                this.Hide();
                //lay ma nhan vien 
                st.t = BLL_QLNhanVien.Instance.GetIDNVForIDTK(BLL_QLTK.Instance.GetIDTK(txtUserName.Text, txtPassword.Text));
                st.ShowDialog();
            }

        }
        void ShowForm()
        {
            this.Show();
            txtPassword.Text = "";
        }
    }
}
