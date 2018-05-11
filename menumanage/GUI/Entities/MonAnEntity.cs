using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Entities
{
    class MonAnEntity
    {
        private string maMonAn;

        public string MaMonAn
        {
            get { return maMonAn; }
            set
            {
                if (!String.IsNullOrEmpty(value)) maMonAn = value;
                else throw new Exception("Ma mon an khong de trong!");
            }
        }

        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
        public int MaNhom { get => maNhom; set => maNhom = value; }

        private string tenMonAn;
        private string donViTinh;
        private decimal donGia;
        private int maNhom;

        public MonAnEntity() { }
        public MonAnEntity(string mamon, string tenmon, string dvtinh, decimal dongia, int nhom)
        {
            MaMonAn = mamon;
            TenMonAn = tenmon;
            DonViTinh = dvtinh;
            DonGia = dongia;
            MaNhom = nhom;
        }
    }
}
