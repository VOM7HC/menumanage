using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class MonAnObj
    {
        private string maMonAn;
        private string tenMonAn;
        private string donviTinh;
        private decimal donGia;
        private string ghiChu;
        private int maNhom;
        public string donViTinh;

        public string MaMonAn { get => maMonAn; set => maMonAn = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public string DonviTinh { get => donviTinh; set => donviTinh = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int MaNhom { get => maNhom; set => maNhom = value; }
        
        public MonAnObj(string maMonAn, string tenMonAn, string donviTinh, decimal donGia, string ghiChu, int maNhom)
        {
            MaMonAn = maMonAn;
            TenMonAn = tenMonAn;
            DonviTinh = donviTinh;
            DonGia = donGia;
            GhiChu = ghiChu;
            MaNhom = maNhom;
        }

        public MonAnObj()
        {
        }
    }
}
