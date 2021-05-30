using PBL3_TeamSuperGao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DAL
{
    class DAL_QLBan
    {

        private static DAL_QLBan _Instance;
        public static DAL_QLBan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLBan();
                }
                return _Instance;
            }

            private set
            { }
        }
        private DAL_QLBan()
        {

        }
        //liet ke danh sach ban 
        public List<Ban> GetAllBan()
        {
            DTDoAn st = new DTDoAn();
            var l1 = st.Ban;
            return l1.ToList();
        }
        //xoa ban
        public void DeleteBan(string ID)
        {
            DTDoAn st = new DTDoAn();
            Ban s = st.Ban.Find(ID);
            st.Ban.Remove(s);
            st.SaveChanges();
        }
        //cap nhat trang thai ban tu Trong sang Co Nguoi va nguoc lai
        public void UpdateTTB(string u)
        {
            DTDoAn st = new DTDoAn();
            foreach (Ban i in st.Ban)
            {
                if (u.CompareTo(i.IDBan.ToString()) == 0 && i.TinhTrangBan == "Trong") i.TinhTrangBan = "Co Nguoi";
                else if (u.CompareTo(i.IDBan.ToString()) == 0 && i.TinhTrangBan == "Co Nguoi") i.TinhTrangBan = "Trong";
            }
            st.SaveChanges();
        }
        //tra ve ban hien tai theo ID ban
        public Ban GetBanID(int ID)
        {
            DTDoAn st = new DTDoAn();
            Ban u = st.Ban.Find(ID);
            return u;
        }

        //cap nhat trang thai ban theo ID ban thanh Trong
        public void UpdateTTBIDB_T(int u)
        {
            DTDoAn st = new DTDoAn();
            foreach (Ban i in st.Ban)
            {
                if (u == i.IDBan && i.TinhTrangBan == "Co Nguoi") i.TinhTrangBan = "Trong";
            }
            st.SaveChanges();
        }
        //cap nhat trang thai ban theo ID trong thanh Co Nguoi
        public void UpdateTTBIDT_B(int u)
        {
            DTDoAn st = new DTDoAn();
            foreach (Ban i in st.Ban)
            {
                if (u == i.IDBan && i.TinhTrangBan == "Trong") i.TinhTrangBan = "Co Nguoi";

            }
            st.SaveChanges();
        }
        //Them ban
        public void AddBan(Ban u)
        {
            DTDoAn st = new DTDoAn();
            st.Ban.Add(u);
            st.SaveChanges();
        }
        //Chuyen Ban 
        public void ChuyenBan(int IDCu, int IDMoi)
        {
            int IDHD = DAL_QLHoaDon.Instance.GetIDHoaDonForIDBan(IDCu);
            DTDoAn st = new DTDoAn();
            HoaDon u = st.HoaDon.Find(IDHD);
            Ban t1 = st.Ban.Find(IDCu);
            Ban t2 = st.Ban.Find(IDMoi);
            t1.TinhTrangBan = "Trong";
            t2.TinhTrangBan = "Co Nguoi";
            u.IDBan = IDMoi;
            st.SaveChanges();
        }
        /// <summary>
        ///gop ban 1 voi ban 2
        /// </summary>
        /// <param name="IDB1"></param>
        /// <param name="IDB2"></param>
        public void GopBan(int IDB1, int IDB2)
        {
            DTDoAn st = new DTDoAn();
            Ban t1 = st.Ban.Find(IDB1);
            Ban t2 = st.Ban.Find(IDB2);
            t1.TinhTrangBan = "Co Nguoi";
            t2.TinhTrangBan = "Trong";
            int IDHDBan2 = DAL_QLHoaDon.Instance.GetIDHoaDonForIDBan(IDB2);
            HoaDon b2 = st.HoaDon.Find(IDHDBan2);
            foreach (MonSL i in DAL_QLChiTietHoaDon.Instance.GetBill(IDB2))
            {
                DAL_QLChiTietHoaDon.Instance.AddMon(DAL_QLMon.Instance.GetMonTheoTen(i.TenMon), Convert.ToInt32(i.SoLuong), IDB1);
            }
            var ListCTHD = st.ChiTietHoaDon.Where(p => p.IDHoaDon == IDHDBan2);
            foreach (ChiTietHoaDon j in ListCTHD)
            {
                st.ChiTietHoaDon.Remove(j);
            }
            st.HoaDon.Remove(b2);
            st.SaveChanges();
        }
    }
}
