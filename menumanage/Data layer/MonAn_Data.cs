using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object;
using Data_layer;

namespace Data_layer
{
    public class MonAn_Data
    {
        DataClasses_QLMADataContext db;
        public MonAn_Data()
        {
            db = new DataClasses_QLMADataContext();
        }

        public List<MonAnObj> GetTheoNhom(int maNhom)
        {
            List<MonAnObj> lst = new List<MonAnObj>();
            db = new DataClasses_QLMADataContext();
            foreach (var item in db.MonAns.Where(x => x.maNhom == maNhom))
            {
                MonAnObj monAn = new MonAnObj();
                monAn.MaMonAn = item.maMonAn;
                monAn.TenMonAn = item.tenMonAn;
                monAn.DonviTinh = item.donViTinh;
                monAn.MaNhom = (int)item.maNhom;
                monAn.DonGia = (decimal)item.donGia;
                monAn.GhiChu = item.ghiChu;
                lst.Add(monAn);
            }
            return lst;
        }

        public bool AddMonAn(MonAnObj monAn)
        {
            db = new DataClasses_QLMADataContext();
            MonAn temp = db.MonAns.Where(x => x.maMonAn == monAn.MaMonAn).FirstOrDefault();
            if (temp != null)
            {
                MonAn newmonAn = new MonAn();
                newmonAn.maMonAn = monAn.MaMonAn;
                newmonAn.tenMonAn = monAn.TenMonAn;
                newmonAn.donViTinh = monAn.DonviTinh;
                newmonAn.maNhom = (int)monAn.MaNhom;
                newmonAn.donGia = (decimal)monAn.DonGia;
                newmonAn.ghiChu = monAn.GhiChu;
                db.MonAns.InsertOnSubmit(newmonAn);
                db.SubmitChanges();
            }
            return true;
        }

        public bool SuaMonAn(MonAnObj monAn)
        {
            db = new DataClasses_QLMADataContext();
            MonAn temp = db.MonAns.Where(x => x.maMonAn == monAn.MaMonAn).FirstOrDefault();
            if (temp != null)
            {
                temp.maMonAn = monAn.MaMonAn;
                temp.tenMonAn = monAn.TenMonAn;
                temp.donViTinh = monAn.DonviTinh;
                temp.maNhom = (int)monAn.MaNhom;
                temp.donGia = (decimal)monAn.DonGia;
                temp.ghiChu = monAn.GhiChu;
                db.MonAns.InsertOnSubmit(temp);
                db.SubmitChanges();
            }
            return true;
        }
    }
}
