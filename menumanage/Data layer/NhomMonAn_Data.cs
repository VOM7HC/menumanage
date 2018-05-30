using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object;

namespace Data_layer
{
    public class NhomMonAn_Data
    {
        DataClasses_QLMADataContext db;
        public NhomMonAn_Data()
        {
            db = new DataClasses_QLMADataContext();
        }
        public List<NhomObj> GetNhomMon()
        {
            db = new DataClasses_QLMADataContext();
            List<NhomObj> lst = new List<NhomObj>();
            List<NhomMonAn> templst = db.NhomMonAns.ToList();
            if(templst.Count > 0)
            {
                foreach (var item in templst)
                {
                    NhomObj tempnhomObj = new NhomObj();
                    tempnhomObj.MaNhom = item.maNhom;
                    tempnhomObj.TenNhom = item.tenNhom;
                    lst.Add(tempnhomObj);
                }
            }
            return lst;
        }
        public bool AddNhom(NhomObj nhomObj)
        {
            db = new DataClasses_QLMADataContext();
            NhomMonAn nhomMon = db.NhomMonAns.Where(x => x.maNhom == nhomObj.MaNhom).FirstOrDefault();
            if (nhomMon != null)
                throw new Exception("Nhom da co");
            else
            {
                NhomMonAn tempnhomMon = new NhomMonAn();
                tempnhomMon.maNhom = nhomObj.MaNhom;
                tempnhomMon.tenNhom = nhomObj.TenNhom;

                db.NhomMonAns.InsertOnSubmit(tempnhomMon);
                db.SubmitChanges();
                return true;
            }
        }
    }
}
