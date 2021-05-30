using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DAL
{
    class DAL_QLTaiKhoan
    {
        private static DAL_QLTaiKhoan _Instance;
        public static DAL_QLTaiKhoan Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new DAL_QLTaiKhoan();
                }
                return _Instance;
            }
            private set { }
        }
        public List<TaiKhoan> Show()
        {
            DTDoAn db = new DTDoAn();
            var ListTaiKhoan = db.TaiKhoans;
            return ListTaiKhoan.ToList();
        }
        public void Add(TaiKhoan tk)
        {
            DTDoAn db = new DTDoAn();
            db.TaiKhoans.Add(tk);
            db.SaveChanges();
        }
        public void Delete(int ID)
        {
            DTDoAn db = new DTDoAn();
            TaiKhoan temp =  db.TaiKhoans.Find(ID);
            db.TaiKhoans.Remove(temp);
            db.SaveChanges();
        }
        public void Edit(TaiKhoan tk)
        {
            DTDoAn db = new DTDoAn();
            var tkedit = db.TaiKhoans.Where(p => p.IDTaiKhoan == tk.IDTaiKhoan).FirstOrDefault();
            tkedit.PassWord = tk.PassWord;
            db.SaveChanges();
        }
    }
}
