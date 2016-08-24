using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai05
{
    public class HocSinhLop6:IHocSinh
    {
private double _Toan;

        public double Toan
        {
            get { return _Toan; }
            set { if (value >= 0 && value <= 10) _Toan = value; }
        }
        private double _NguVan;

        public double NguVan
        {
            get { return _NguVan; }
            set { if (value >= 0 && value <= 10) _NguVan = value; }
        }
        private string _MaSo;

        public string MaSo
        {
            get
            {
                return _MaSo;
            }
            set
            {
                _MaSo = value;
            }
        }

        private string _HoTen;
        public string HoTen
        {
            get
            {
                return _HoTen;
            }
            set
            {
                _HoTen = value;
            }
        }

        private string _Lop;
        public string Lop
        {
            get
            {
                return _Lop;
            }
            set
            {
                value=_Lop;
            }
        }

        public HocSinhLop6()
        {

        }
        public HocSinhLop6(string MaSo,string HoTen,string Lop,double Toan,double TiengViet)
        {
            this.MaSo = MaSo;
            this.HoTen = HoTen;
            this.Lop = Lop;
            this.Toan = Toan;
            this.NguVan = NguVan;
        }

        public double DiemTrungBinh()
        {
            return (Toan * 2 + NguVan*2) / 4;
        }

        public string KetQuaHocTap()
        {
            if (DiemTrungBinh() >= 5)
                return "Duoc Len Lop";
            else
                return "O lai Lop";
        }

        public string XepLoaiKhenThuong(string phanCach = "\r\n")
        {
            if (DiemTrungBinh() >= 8)
                return "Gioi";
            else if (DiemTrungBinh() >= 6.5)
                return "Kha";
            else if (DiemTrungBinh() >= 5)
                return "Trung Binh  ";
            else
                return "Yeu";
        }
    }
}