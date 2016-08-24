using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai05
{
    public class HinhVuong:IHinh
    {
        private double _Canh;

        public double Canh
        {
            get { return _Canh; }
            set { _Canh = value; }
        }

        public HinhVuong(double Canh)
        {
            this.Canh = Canh;
        }
        public HinhVuong()
        {

        }

        
        public string TenHinh
        {
            get { return "HinhVuong"; }
        }

        public double DienTich()
        {
            double kq=_Canh*_Canh;
            return kq;
        }
        public double ChuVi()
        {
            double kq = _Canh * 4;
            return kq;
        }

        public string XuatThongTin(string xuongDong = "\r\n")
        {
           string noiDung=string.Format ("{1}{0}Cạnh: {2}{0}Diện Tích:{3}{0} Chu Vi:{4}",xuongDong,TenHinh,_Canh,DienTich(),ChuVi());
           return noiDung;
        }
    }
}