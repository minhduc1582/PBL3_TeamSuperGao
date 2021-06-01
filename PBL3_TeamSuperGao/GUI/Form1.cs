using PBL3_TeamSuperGao.BLL;
using PBL3_TeamSuperGao.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_TeamSuperGao.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCBBThongKe();
        }

        // Sett cbb to handle thong ke
        public void SetCBBThongKe()
        {
            cbbThongKe.Items.AddRange(new CBBItem[] { 
                new CBBItem{Value = 0,Text = "ThongKeHoaDon"},
                new CBBItem{Value = 1,Text = "ThongKeDoanhThu"},
                new CBBItem{Value = 2,Text = "ThongKeMon"},
            });
            cbbThongKe.SelectedIndex = 0;
        }
                                        //MODULE
        //THONG KE
        // Xu Ly su kien thong ke di kem voi CBB
        public void ThongKe(object sender,EventArgs e)
        {
            switch (((CBBItem)cbbThongKe.Items[cbbThongKe.SelectedIndex]).Value)
            {
                case 0:
                    HandleThongKeHoaDon();
                    txtTongDoanhThu.Text = TongDoanhThu().ToString();
                    break;
                case 1:
                    HandleThongKeDoanhThu();
                    txtTongDoanhThu.Text = TongDoanhThu().ToString();
                    break;
                case 2:
                    HandleThongKeMon();
                    break;
                default:
                    break;
            }
        }
        //
        public double TongDoanhThu()
        {
            double TongDoanhThu = 0;
            for(int i = 0; i< dtvThongKe.Rows.Count; i++)
            {
                TongDoanhThu += Convert.ToDouble(dtvThongKe.Rows[i].Cells["TongTien"].Value);
            }
            return TongDoanhThu;
        }
        // Xu ly su kien thong ke mon
        private void HandleThongKeMon()
        {
            dtvThongKe.DataSource = BLL_ThongKe.Instance.BLL_ThongKeMon(dtmOrg.Value, dtmDes.Value);
            dtvThongKe.Columns[0].Visible = false;
        }
        
        private void HandleThongKeHoaDon()
        {
            dtvThongKe.DataSource = BLL_ThongKe.Instance.ThongKeHoaDon(dtmOrg.Value, dtmDes.Value);
        }
        // Xu ly su kien thong ke Doanh Thu
        private void HandleThongKeDoanhThu()
        {
            dtvThongKe.DataSource = BLL_ThongKe.Instance.BLL_ThongKeDoanhThu(dtmOrg.Value, dtmDes.Value);
        }

        // MODULE
        // QUAN LY TAI KHOAN 

        // reset textbox
        public void reset()
        {
            txtReFill.Text = "";
            txtMatKhauTK.Text = "";
            txtTenTK.Text = "";
        }
        // Xử lý Exception Null
        static void ProcessString(string s1, string s2, string s3)
        {
            if (s1 == "" || s2 == "" || s3 == "")
            {
                throw new ArgumentNullException();
            }
        }
        //show list TK on Dtgv TaiKhoan
        public void Show_dtgvTK()
        {
            dtgvTaiKhoan.DataSource = BLL_QLTaiKhoan.Instance.BLL_ShowTK();
            dtgvTaiKhoan.Columns[0].Visible = false;
            dtgvTaiKhoan.Columns[3].Visible = false;
        }
        // kiem tra mat khau nhap lai co trung voi mat khau khong
        private void txtReFill_TextChanged(object sender, EventArgs e)
        {
            if (txtReFill.Text != txtMatKhauTK.Text && txtReFill.Text != "")
            {
                lblCheck.Text = "Mat khau khong khop!";
                lblCheck.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblCheck.ForeColor = System.Drawing.Color.White;
            }

        }
        // handle change selection click on dtgv 
        private void dtgvTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            txtTenTK.Text = dtgvTaiKhoan.CurrentRow.Cells["UserName"].Value.ToString();
            txtMatKhauTK.Text = dtgvTaiKhoan.CurrentRow.Cells["PassWord"].Value.ToString();
        }
        // Kiem tra user ton tai chua
        public bool Check_isExistUser(string str)
        {
            foreach(var i in BLL_QLTaiKhoan.Instance.BLL_ShowTK())
            {
                if (String.Compare(str.Trim(),i.UserName.Trim(),true) == 0) return true;
            }
            return false;
        }
        // handle event add TK and edit tk
        private void btnAddTK_Click(object sender, EventArgs eva)
        {
            try
            {
                ProcessString(txtTenTK.Text, txtMatKhauTK.Text,txtTenTK.Text);
                if ((Button)sender == btnAddTK)
                {
                    if (txtReFill.Text == txtMatKhauTK.Text && Check_isExistUser(txtTenTK.Text) == false)
                    {
                        BLL_QLTaiKhoan.Instance.BLL_AddTK(txtTenTK.Text, txtMatKhauTK.Text);
                        MessageBox.Show("Them tai khoan thanh cong!");
                        reset();
                    }
                    else if (Check_isExistUser(txtTenTK.Text) == true)
                    {
                        MessageBox.Show("Da ton tai tai khoan!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Mat khau khong trung khop!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                if((Button)sender == btnEditTK)
                {
                    if (txtReFill.Text == txtMatKhauTK.Text && Check_isExistUser(txtTenTK.Text) == true)
                    {
                        int ID = Convert.ToInt32(dtgvTaiKhoan.CurrentRow.Cells["IDTaiKhoan"].Value);
                        BLL_QLTaiKhoan.Instance.BLL_EditTK(ID,txtTenTK.Text, txtMatKhauTK.Text);
                        MessageBox.Show("Dat lai mat Khau thanh cong!");
                        reset();
                    }
                    else if (Check_isExistUser(txtTenTK.Text) == false)
                    {
                        MessageBox.Show("Khong ton tai tai khoan!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Mat khau khong trung khop!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // handle Show TK on Dtgv TaiKhoan
        private void btnShowTK_Click(object sender, EventArgs e)
        {
            Show_dtgvTK();
        }
        // handle event Delete Tai khoan
        private void BtnDelTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvTaiKhoan.CurrentRow.Selected == true)
                {
                    BLL_QLTaiKhoan.Instance.BLL_DeleteTK(Convert.ToInt32(dtgvTaiKhoan.CurrentRow.Cells["IDTaiKhoan"].Value));
                    Show_dtgvTK();
                    reset();
                }
            }
            catch(Exception et)
            {
                MessageBox.Show(et.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // handle event button reset
        private void btnResetTK_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDelMon_Click(object sender, EventArgs e)
        {

        }

        private void AddandEditMon(object sender, EventArgs e)
        {

        }

        private void btnShowMon_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchMon_Click(object sender, EventArgs e)
        {

        }
    }
}
