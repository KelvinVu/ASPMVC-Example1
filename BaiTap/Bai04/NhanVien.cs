using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai04
{
    public enum Phai { Nữ , Nam , Khác };

    public class NhanVien
    {
        #region properties
        public string MaSo { get; set; }
        public string  HoTen { get; set; }
        private DateTime _ngaySinh;

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        private DateTime _ngayVaoLam=DateTime.Today;

        public DateTime NgayVaoLam
        {
            get { return _ngayVaoLam; }
            set { _ngayVaoLam = value; }
        }
        private double _heSoLuong=1; 

        public double HeSoLuong
        {
            get { return _heSoLuong; }
            set 
            {
                if (value < 1) throw new Exception("nhap sai gia tri hsl >=1");
                _heSoLuong = value; 
            }
        }
        private static int _luongCanBan=1000000;

        public static int LuongCanBan
        {
            get { return _luongCanBan; }
            set { _luongCanBan = value; }
        }

        private Phai _gioiTinh;

        public Phai GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
        public int ThamNien
        {
            get
            {
                return DateTime.Today.Year - NgayVaoLam.Year;
            }
        }
        // bài 4: bổ sung thêm
        private static int _DinhMucVang=3;

        public static int DinhMucVang
        {
            get { return _DinhMucVang; }
            set { _DinhMucVang = value; }
        }

        protected int _SoNgayVang;

        public int SoNgayVang
        {
            get { return _SoNgayVang; }
            set { _SoNgayVang = value; }
        }
        
         
        #endregion

        #region Constructors
        public NhanVien() { }

        public NhanVien(string maSo,string hoTen, DateTime ngaySinh,DateTime ngayVaoLam,Phai gioiTinh,double heSoLuong)
        {
            MaSo = maSo;
            NgaySinh = ngaySinh;
            HoTen = hoTen;
            NgayVaoLam = ngayVaoLam;
            GioiTinh = gioiTinh;
            HeSoLuong = heSoLuong;

        }
        public NhanVien(string MaSo,string HoTen, DateTime NgaySinh,DateTime NgayVaoLam,Phai GioiTinh,double HeSoLuong,int SoNgayVang)
        {
            this.MaSo = MaSo;
            this.NgaySinh = NgaySinh;
            this.HoTen = HoTen;
            this.NgayVaoLam = NgayVaoLam;
            this.GioiTinh = GioiTinh;
            this.HeSoLuong = HeSoLuong;
            this.SoNgayVang = SoNgayVang;

        }

        
        #endregion

        #region Methods

        public virtual double TinhLuong()
        {
            double Kq = _luongCanBan * _heSoLuong;
            return Kq;

        }
        public virtual double TinhThuong()// cho phép lớp con ghi đè
        {
            double kq = ThamNien * 500000;
            return kq;


        }

        public virtual string XuatThongTin()
        {
            double luong = TinhLuong();
            double thuong = TinhThuong();
            double tongcong = luong + thuong;
            return string.Format(@"Nhân Viên <b>{0}-{1}</b><br/> 
                                    Tiền Thưởng: {2}<br/> Tien Luong: {3}<br/>
                                    Tổng Cộng: {4}",
                MaSo,HoTen,thuong.ToString("#,##0VND"),
                luong.ToString("#,##0VND"),
                tongcong.ToString("#,##0VND"));

        }
        public override string ToString()// ghi đè phương thức hệ thống
        {
            string kq = XuatThongTin();
            return kq;
        }
        #endregion
    }

}