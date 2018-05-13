using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class NhomObj
    {
        private int maNhom;
        private string tenNhom;

        public int MaNhom { get => maNhom; set => maNhom = value; }
        public string TenNhom { get => tenNhom; set => tenNhom = value; }        

        public NhomObj(int maNhom, string tenNhom)
        {
            MaNhom = maNhom;
            TenNhom = tenNhom;
        }

        public NhomObj()
        {
        }
    }
}
