using PBL3_TeamSuperGao.DAL;
using PBL3_TeamSuperGao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.BLL
{
    class BLL_ThongKe
    {
        private static BLL_ThongKe _Instance;
        public static BLL_ThongKe Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new BLL_ThongKe();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        public List<HoaDonView> ThongKeHoaDon(DateTime org, DateTime des)
        {
            List<HoaDonView> ListThongKeHoaDon = new List<HoaDonView>();
            foreach(var i in DAL_ThongKe.Instance.GetListHoaDon(org, des))
            {
                ListThongKeHoaDon.Add(new HoaDonView
                {
                    IDHoaDon = i.IDHoaDon,
                    NgayThanhToan = DAL_ThongKe.Instance.Getdate(i.IDHoaDon),
                    GiamGia = i.GiamGia.ToString() + " %",
                    TongTien = (double)i.TongTien
                });
            }
            ListThongKeHoaDon.Sort(TongTien);
            return ListThongKeHoaDon;
        }

        private int TongTien(HoaDonView x, HoaDonView y)
        {
            if (x.NgayThanhToan > y.NgayThanhToan) return 1;
            return 0;
            throw new NotImplementedException();
        }
    }
}
