﻿
using PBL3_TeamSuperGao;
using PBL3_TeamSuperGao.BLL;
using PBL3_TeamSuperGao.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_TeamSuperGao.GUI
{
    public partial class CAFEVIEW : Form
    {
        public CAFEVIEW()
        {
            InitializeComponent();
            GetCBBDM();
            GetCBBSL();
            LoadTable();
            GetAllBan();
        }
        //t la ma nhan vien
        public int t;
        /// <summary>
        /// ID ban hiện tại 
        /// </summary>
        private int IDBan = -1;
        public void GetCBBSL()
        {
            for (int i = 1;i<10;i++ )
            {
                comboBoxSL.Items.Add(i);
            }
        }
        //Get all ban
        public void GetAllBan()
        {
            comboBoxCB.Items.Clear();
            foreach(Ban i in BLL_QLBan.Instance.GetAllBan())
            {
                comboBoxCB.Items.Add(new CBBItem { Text = "Ban " + i.IDBan.ToString()+ " "+i.TinhTrangBan, Value = i.IDBan });
            }
        }
        //get CBBDM
        public void GetCBBDM()
        {
            foreach(DanhMucMon i in BLL_QLDanhMuc.Instance.GetDanhMucMon() )
            {
                comboBoxDM.Items.Add(new CBBItem { Value = Convert.ToInt32(i.IDDanhMucMon), Text = i.TenDanhMuc});
            }
        }
        //get cb mon 
        public void GetCBBM()
        {
            comboBoxM.Items.Clear();
            foreach (Mon i in BLL_QLMon.Instance.GetMon_DM(((CBBItem)comboBoxDM.SelectedItem).Value)) //((CBBITem)comboBoxDM.SelectedItem).Text)
            {
                comboBoxM.Items.Add(new CBBItem { Value = Convert.ToInt32(i.IDMon), Text = i.TenMon });
            }
        }
        // khi nhan cbb danh muc
        private void comboBoxDM_SelectedIndexChanged(object sender, EventArgs e)
        {
             GetCBBM();
        }
        /// <summary>
        /// them chi tiet hoa don
        /// neu hoa don chua co se them chi tiet hoa don
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)//them mon 
        {
            try
            {
                if (BLL_QLBan.Instance.GetBanID(IDBan).TinhTrangBan == "Co Nguoi")
                {
                    Mon i = BLL_QLMon.Instance.SerchForMaMon(((CBBItem)comboBoxM.SelectedItem).Value);
                    BLL_QLChiTietHoaDon.Instance.AddMon(i, Convert.ToInt32(comboBoxSL.SelectedItem), IDBan);
                    ShowBill(IDBan);
                    TongTien(IDBan);
                    GetAllBan();
                }
                else
                {
                    string u = "";
                    foreach (char j in textBoxGG.Text)
                    {
                        if (j >= '0' && j <= '9') u = u + j;
                    }
                    BLL_QLHoaDon.Instance.AddHD_CTHD(IDBan, Convert.ToInt32(u), t);
                    Mon i = BLL_QLMon.Instance.SerchForMaMon(((CBBItem)comboBoxM.SelectedItem).Value);
                    BLL_QLChiTietHoaDon.Instance.AddMon(i, Convert.ToInt32(comboBoxSL.SelectedItem), IDBan);
                    BLL_QLBan.Instance.UpdateTTBIDT_B(IDBan);
                    ShowBill(IDBan);
                    LoadTable();
                    GetAllBan();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn bàn và chọn món cần thêm");
            }
        }
        //xoa mon
        private void buttonXoaMon_Click(object sender, EventArgs e)
        {
            try 
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                BLL_QLChiTietHoaDon.Instance.RemoveMon(index, IDBan);
                ShowBill(IDBan);
                TongTien(IDBan);
                GetAllBan();
            }
            catch
            {
                MessageBox.Show("Danh sach trong");
            }
        }

        //ql nhan vien
        private void btnHeThong_Handle(object sender, EventArgs e)
        {
            Form1 t = new Form1();
            this.Visible = false;
            t.ShowDialog();
            this.Hide();
        }
        /// <summary>
        /// Hiem thi danh sach ban thanh cac ban 
        /// 
        /// </summary>
        void LoadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            int TableWidth = 90;
            int TableHight = 90;
            foreach (Ban i in BLL_QLBan.Instance.GetAllBan())
            {
                Button btn = new Button()
                {
                    Width = TableWidth,
                    Height = TableHight,
                    
                };
                btn.Tag = i;
                btn.Click += new System.EventHandler(this.btn_Click);
                btn.Text = "Ban "+ i.IDBan.ToString()+ "\n" + i.TinhTrangBan; 
                switch (i.TinhTrangBan)
                {
                    case "Trong":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        /// <summary>
        /// Hien thi bill khi chon vao tung ban
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            int IDBan1 = ((Ban)(sender as Button).Tag).IDBan;
            string TTB = ((Ban)(sender as Button).Tag).TinhTrangBan;
            IDBan = IDBan1;
            ShowBill(IDBan1);
            if (TTB.CompareTo("Co Nguoi") == 0)
            {
                BLL_QLHoaDon.Instance.UpdateTT(IDBan);
            }
            TongTien(IDBan);
        }
        //hien thi hoa don 
        public void ShowBill(int ID)
        {
            List<MonSL> st = BLL_QLChiTietHoaDon.Instance.GetBill(ID);
            dataGridView1.DataSource = st;
        }
        /// <summary>
        /// hien thi tong tien theo ID ban
        /// </summary>

        public void TongTien(int ID)
        {
            //dung de chuyen dinh dang tien sang VND
            CultureInfo culture = new CultureInfo("vi-VN");
            double tt = BLL_QLHoaDon.Instance.TongTien(ID); 
            textBoxTT.Text = tt.ToString("c", culture);
            if (1000000 >= tt && tt > 500000) textBoxGG.Text = "10%";
            else if (1000000 < tt) textBoxGG.Text = "20%";
            else textBoxGG.Text = "0%";
            //cap nhat tong tien lai vao sql
        }
        /// <summary>
        /// Thanh toan hoa don
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int IDHoaDon = BLL_QLHoaDon.Instance.GetIDHoaDonForIDBan(IDBan);
            if(IDHoaDon != -1)
            {
                if(MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn " + IDBan, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BLL_QLHoaDon.Instance.ThanhToan(IDHoaDon);
                    BLL_QLBan.Instance.UpdateTTBIDB_T(IDBan);
                    ShowBill(IDBan);
                    LoadTable();
                }
            }
            else
            {
                MessageBox.Show("Chọn bàn để thanh toán");
            }
            IDBan = -1;
        }
        /// <summary>
        /// chuyen tu ban cu sang ban trong cbbcb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int IDBanMoi = ((CBBItem)comboBoxCB.SelectedItem).Value;
                if (BLL_QLBan.Instance.GetBanID(IDBanMoi).TinhTrangBan == "Co Nguoi")
                {
                    MessageBox.Show("Vui long chon ban Trong" + System.Windows.Forms.DialogResult.OK);
                }
                else if (IDBan == IDBanMoi)
                {
                    MessageBox.Show("Vui lòng không chọn trùng bàn" + System.Windows.Forms.DialogResult.OK);
                }
                else
                {
                    BLL_QLBan.Instance.ChuyenBan(IDBan, IDBanMoi);
                    ShowBill(IDBan);
                    TongTien(IDBan);
                    GetAllBan();
                    LoadTable();
                }
            }
            catch
            {
                MessageBox.Show("Vui long chon ban can chuyen" + System.Windows.Forms.DialogResult.OK);
            }
        }
        /// <summary>
        /// gop ban 
        /// Chon ban can gop, gop 2 ban vs nhau, IDHoaDon se tra ve IDHoaDon thap hon 
        /// neu ban moi 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int IDBanMoi = ((CBBItem)comboBoxCB.SelectedItem).Value;
                if (BLL_QLBan.Instance.GetBanID(IDBanMoi).TinhTrangBan != "Co Nguoi")
                {
                    MessageBox.Show("Vui long chon ban Co Nguoi"+ MessageBoxButtons.OKCancel);         
                }
                else if(IDBan == IDBanMoi)
                {
                    MessageBox.Show("Vui lòng không chọn trùng bàn" + MessageBoxButtons.OKCancel);
                }
                else
                {
                    BLL_QLBan.Instance.GopBan(IDBan, IDBanMoi);
                    ShowBill(IDBan);
                    TongTien(IDBan);
                    GetAllBan();
                    LoadTable();
                }
             }
             catch
            {
              MessageBox.Show("Vui long chon ban can gop");
            }
        }

    }
}