using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai05
{
    public class HocSinhLop1:IHocSinh
    {
        private double _Toan;

        public double Toan
        {
            get { return _Toan; }
            set { if (value >= 0 && value <= 10) _Toan = value; }
        }
        private double _TiengViet;

        public double TiengViet
        {
            get { return _TiengViet; }
            set { if (value >= 0 && value <= 10) _TiengViet = value; }
        }
        private double _TapViet;

        public double TapViet
        {
            get { return _TapViet; }
            set { if (value >= 0 && value <= 10) _TapViet = value; }
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

        public HocSinhLop1()
        {

        }
        public HocSinhLop1(string MaSo,string HoTen,string Lop,double Toan,double TiengViet,double TapViet)
        {
            this.MaSo = MaSo;
            this.HoTen = HoTen;
            this.Lop = Lop;
            this.Toan = Toan;
            this.TiengViet = TiengViet;
            this.TapViet = TapViet;
        }

        public double DiemTrungBinh()
        {
            return (Toan * 2 + TapViet + TiengViet) / 3;
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
                return "Tang 2 bong hoa hong";
            else if (DiemTrungBinh()>=5)
                return "Tang 1 bong hoa hong";
            else
                return "khong co bong hoa hong";
        }
    }
}