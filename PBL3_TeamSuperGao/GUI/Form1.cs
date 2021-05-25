using PBL3_TeamSuperGao.BLL;
using PBL3_TeamSuperGao.DTO;
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
        // Xu Ly su kien thong ke di kem voi CBB
        public void ThongKe(object sender,EventArgs e)
        {
            switch (((CBBItem)cbbThongKe.Items[cbbThongKe.SelectedIndex]).Value)
            {
                case 0:
                    HandleThongKeHoaDon();
                    break;
                case 1:
                    HandleThongKeDoanhThu();
                    break;
                case 2:
                    HandleThongKeMon();
                    break;
                default:
                    break;
            }
        }
        // Xu ly su kien thong ke mon
        private void HandleThongKeMon()
        {
            
        }
        
        private void HandleThongKeHoaDon()
        {
            dtvThongKe.DataSource = BLL_ThongKe.Instance.ThongKeHoaDon(dtmOrg.Value, dtmDes.Value);
        }
        // Xu ly su kien thong ke Doanh Thu
        private void HandleThongKeDoanhThu()
        {
        }

        private void btnAddTK_Click(object sender, EventArgs e)
        {

        }

        private void btnShowTK_Click(object sender, EventArgs e)
        {
            dtgvTaiKhoan.DataSource = BLL_QLTaiKhoan.Instance.BLL_ShowTK();
            dtgvTaiKhoan.Columns[0].Visible = false;
            dtgvTaiKhoan.Columns[3].Visible = false;
        }
    }
}
