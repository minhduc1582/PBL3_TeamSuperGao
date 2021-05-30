﻿using PBL3_TeamSuperGao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DAL
{
    class DAL_QLHoaDon
    {
        private static DAL_QLHoaDon _Instance;
        public static DAL_QLHoaDon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLHoaDon();
                }
                return _Instance;
            }

            private set
            { }
        }
        private DAL_QLHoaDon()
        {

        }
        //liet ke full hoa don
        public List<HoaDon> GetAllHoaDon()
        {
            DTDoAn st = new DTDoAn();
            var l1 = st.HoaDon;
            return l1.ToList();
        }

        //tra ve IDHoaDon max;
        public int GetIDHoaDonMax()
        {
            int i = 0;
            foreach (HoaDon j in GetAllHoaDon())
            {
                if (i < j.IDHoaDon) i = j.IDHoaDon;
            }
            return i;
        }
        //them 1 hoa don
        public void AddHD_CTHD(int IDBan, int GG, int IDNhanVien)
        {
            DTDoAn st = new DTDoAn();
            HoaDon k = new HoaDon();
            int u = GetIDHoaDonMax() + 1;
            k.IDHoaDon = u;
            k.IDBan = IDBan;
            k.TinhTrang = "Chua Thanh Toan";
            k.GiamGia = GG;
            k.IDNhanVien = IDNhanVien;
            k.TongHoaDon = 0;
            st.HoaDon.Add(k);
            st.SaveChanges();
        }
        //cap nhat khi thanh toan hoa don
        public void ThanhToan(int IDHoaDon)
        {
            DTDoAn st = new DTDoAn();
            foreach (HoaDon i in st.HoaDon)
            {
                if (i.IDHoaDon == IDHoaDon) i.TinhTrang = "Da Thanh Toan";
            }
            foreach (ChiTietHoaDon j in st.ChiTietHoaDon)
            {
                if (j.IDHoaDon == IDHoaDon) j.NgayGioThanhToan = DateTime.Now;
            }
            st.SaveChanges();
        }
        //tong tien theo ID ban
        public float TongTien(int ID)
        {
            List<MonSL> st = DAL_QLChiTietHoaDon.Instance.GetBill(ID);
            float s = 0;
            foreach (MonSL i in st)
            {
                s = s + (float)i.DonGia * i.SoLuong;
            }
            return s;
        }
        //cap nhat tong tien hoa don theo ID ban
        public void UpdateTT(int ID)
        {
            if (ID != -1)
            {
                DTDoAn st = new DTDoAn();
                float TT = TongTien(ID);
                int IDHD = GetIDHoaDonForIDBan(ID);
                HoaDon i = st.HoaDon.Find(IDHD);
                i.TongHoaDon = TT;
                st.SaveChanges();
            }
        }
        //get ID Hoa Don theo ID ban
        public int GetIDHoaDonForIDBan(int ID)
        {
            List<HoaDon> s = new List<HoaDon>();
            try
            {
                DTDoAn st = new DTDoAn();
                var t1 = st.HoaDon.Where(p => p.IDBan == ID);
                foreach (HoaDon i in t1)
                {
                    if (i.TinhTrang == "Chua Thanh Toan") return i.IDHoaDon;
                }
            }
            catch
            {

            }
            return -1;
        }
    }
}
