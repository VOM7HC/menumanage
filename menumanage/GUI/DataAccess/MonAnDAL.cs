using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Entities;

namespace GUI.DataAccess
{
    public class MonAnDAL
    {
        DataClassesQLTDDataContext db;
        public MonAnDAL()
        {
            db = new DataClassesQLTDDataContext();
        }
        public List<MonAnEntity> LayDanhSachMonAnTheoNhom(int manhom)
        {
            List<MonAnEntity> lst = new List<MonAnEntity>();
            db = new DataClassesQLTDDataContext();
            foreach (var item in db.MonAns.Where(x => x.maNhom == manhom))
            {
                MonAnEntity m = new MonAnEntity();
                m.MaMonAn = item.maMonAn;
                m.TenMonAn = item.tenMonAn;
                m.DonViTinh = item.donViTinh;
                m.MaNhom = (int)item.maNhom;
                m.DonGia = (decimal)item.donGia;
                lst.Add(m);
            }
            return lst;
        }
        public bool ThemMonAn(MonAnEntity m)
        {
            db = new DataClassesQLTDDataContext();
            MonAn q = db.MonAns.Where(x => x.maMonAn == m.MaMonAn).FirstOrDefault();
            if (q != null) throw new Exception("Mon an da co!");
            else
            {
                MonAn qnew = new MonAn();
                qnew.maMonAn = m.MaMonAn;
                qnew.tenMonAn = m.TenMonAn;
                qnew.donGia = m.DonGia;
                qnew.donViTinh = m.DonViTinh;
                qnew.maNhom = m.MaNhom;
                db.MonAns.InsertOnSubmit(qnew);
                db.SubmitChanges();
                return true;
            }

        }
        public bool SuaMonAn(MonAnEntity m)
        {
            db = new DataClassesQLTDDataContext();
            MonAn q = db.MonAns.Where(x => x.maMonAn == m.MaMonAn).FirstOrDefault();
            if (q != null)
            {
                q.maMonAn = m.MaMonAn;
                q.tenMonAn = m.TenMonAn;
                q.donGia = m.DonGia;
                q.donViTinh = m.DonViTinh;
                q.maNhom = m.MaNhom;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
