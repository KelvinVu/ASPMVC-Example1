using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.Bai04
{
   public class NhanViensx:NhanVien
    {
        #region Fields
        int _SoSanPham=0;
        static int _DinhMucSanPham = 312;   
        static double _DonGiaSanPham = 10000;
        static int _DinhMucVang;
       #endregion
       #region properties
       
        public int SoSanPham
        {
            get { return _SoSanPham; }
            set { _SoSanPham = value; }
        }
        public static int DinhMucSanPham
        {
            get { return _DinhMucSanPham; }
            set { _DinhMucSanPham = value; }
        }
        public static double DonGiaSanPham
        {
            get { return _DonGiaSanPham; }
            set { _DonGiaSanPham = value; }
        }
        public static int DinhMucVang
        {
            get { return _DinhMucVang; }
            set { _DinhMucVang = value; }
        }
        #endregion
       #region Constructors
        public NhanViensx() 
        { 
              DinhMucVang = NhanVien.DinhMucVang + 2; 

        } 
        public NhanViensx(string maso, string hoTen, DateTime ngaySinh, DateTime ngayVaoLam, Phai gioiTinh, int soNgayVang, int soSanPham)
            : base(maso, hoTen, ngaySinh, ngayVaoLam, gioiTinh, 1, soNgayVang)
        {
            
            DinhMucVang = NhanVien.DinhMucVang + 2;
            this.SoSanPham = soSanPham;
        }
        
       #endregion 
       #region Method
        public override double TinhThuong()
        {
            double tienThuong = 0;
            if (_SoSanPham > _DinhMucSanPham)
                tienThuong = (_SoSanPham - _DinhMucSanPham) * _DonGiaSanPham*1.05;
            if (SoNgayVang > DinhMucVang)
            {
                int soNgayVDM = (SoNgayVang - DinhMucVang);
                double tienPhat=(_DinhMucSanPham/26) * (0.1*_DonGiaSanPham);
                tienThuong = tienThuong - (soNgayVDM * tienPhat);
            }
            return tienThuong;
        }
        public override double TinhLuong()
        {
            return SoSanPham*DonGiaSanPham + TinhThuong();
        }
       
        public override string XuatThongTin()
        {
            double thuong = TinhThuong();
            double luong = TinhLuong();
            
            return string.Format("Nhân viên {0}-{1}<br/>Loại nhân viên:Sản xuất<br/>Tiền thưởng: {2}<br/>Tiền lương: {3}",
                                    MaSo, HoTen, thuong.ToString("#,##0.00"), luong.ToString("#,##0.00"));
        }
       #endregion
    }
}
