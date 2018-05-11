using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Entities
{
    class NhomMonAnEntity
    {
        private int maNhom;
        private string tenNhom;

        public int MaNhom { get => maNhom; set => maNhom = value; }
        public string TenNhom { get => tenNhom; set => tenNhom = value; }
        public NhomMonAnEntity() { }
        public NhomMonAnEntity(int ma, string ten)
        {
            MaNhom = ma;
            TenNhom = ten;
        }

    }
}
