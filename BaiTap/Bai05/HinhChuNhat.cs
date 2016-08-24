using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai05
{
    public class HinhChuNhat:IHinh
    {
        private double _ChieuRong;

        public double ChieuRong
        {
            get { return _ChieuRong; }
            set { _ChieuRong = value; }
        }

        private double  _ChieuDai;

        public double  ChieuDai
        {
            get { return _ChieuDai; }
            set { _ChieuDai = value; }
        }
        
        public HinhChuNhat()
        {

        }

        public HinhChuNhat(double ChieuRong,double ChieuDai)
        {
            this.ChieuDai = ChieuDai;
            this.ChieuRong = ChieuRong;
        }
        
        public string TenHinh
        {
            get { return "Hinh Chu Nhat"; }
        }

        public double DienTich()
        {
            return ChieuDai*ChieuRong;
        }

        public double ChuVi()
        {
            return (ChieuRong + ChieuDai) * 2;
        }
        public string XuatThongTin(string xuongDong = "\r\n")
        {
            string noiDung = string.Format("{1}{0}Chieu Dai: {2}{0} Chieu Dai: {3}{0} Diện Tích:{4}{0} Chu Vi:{5}", xuongDong, TenHinh, ChieuDai, ChieuRong, DienTich(), ChuVi());
            return noiDung; ;
        }
    }
}