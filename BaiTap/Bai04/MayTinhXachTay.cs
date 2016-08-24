using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai04
{
    public class MayTinhXachTay:MayTinh
    {
        #region Field and properties

        private double _TrongLuong;

        public double TrongLuong
        {
            get { return _TrongLuong; }
            set { _TrongLuong = value; }
        }

        private double _ThoiGianPin;

        public double ThoiGianPin
        {
            get { return _ThoiGianPin; }
            set { _ThoiGianPin = value; }
        }

        private double _KichThuocManHinh;

        public double KichThuocManHinh
        {
            get { return _KichThuocManHinh; }
            set { _KichThuocManHinh = value; }
        }
        

        #endregion

        #region Constructors
        public MayTinhXachTay()
        {

        }
        public MayTinhXachTay(string SoHieu, int DonGia, string HangSanXuat, double TrongLuong,double ThoiGianPin,double KichThuocManHinh)
            :base (SoHieu,DonGia,HangSanXuat)
        {
            this.TrongLuong = TrongLuong;
            this.ThoiGianPin = ThoiGianPin;
            this.KichThuocManHinh = KichThuocManHinh;
        }

        #endregion

        #region methods
        public override string XuatThongTin()
        {
            string kq = " ";
            kq = string.Format("May Tinh Xach Tay: So Hieu La: {0} Don Gia La: {1} Hang San Xuat La: {2}  Trong Luong La: {3}  Thoi Gian Pin La: {4} Kich Thuoc Man Hinh La: {5}", SoHieu, DonGia, HangSanXuat, TrongLuong,ThoiGianPin,KichThuocManHinh);
            return kq;
        }
        #endregion
    }
}