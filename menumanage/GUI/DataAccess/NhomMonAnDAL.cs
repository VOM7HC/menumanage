using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Entities;
namespace GUI.DataAccess
{
    public class NhomMonAnDAL
    {
        DataClassesQLTDDataContext db;
        public NhomMonAnDAL()
        {
            db = new DataClassesQLTDDataContext();
        }
        public List<NhomMonAnEntity> LayDanhSachNhom()
        {
            db = new DataClassesQLTDDataContext();
            List<NhomMonAnEntity> lst = new List<NhomMonAnEntity>();
            var q = db.NhomMonAns.ToList();
            if (q.Count > 0)
            {
                foreach (var item in q)
                {
                    NhomMonAnEntity n = new NhomMonAnEntity();
                    n.MaNhom = item.maNhom;
                    n.TenNhom = item.tenNhom;
                    lst.Add(n);
                }
                return lst;
            }
            return null;
        }
        public bool ThemNhom(NhomMonAnEntity m)
        {
            db = new DataClassesQLTDDataContext();
            NhomMonAn q = db.NhomMonAns.Where(x => x.maNhom == m.MaNhom).FirstOrDefault();
            if (q != null) throw new Exception("Mon an da co!");
            else
            {
                NhomMonAn qnew = new NhomMonAn();
                qnew.maNhom = m.MaNhom;
                qnew.tenNhom = m.TenNhom;

                db.NhomMonAns.InsertOnSubmit(qnew);
                db.SubmitChanges();
                return true;
            }

        }
    }
}
