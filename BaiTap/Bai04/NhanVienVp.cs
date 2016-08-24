using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai04
{
    public class NhanVienVp : NhanVien
    {
        #region properties
        private double _DonGiaPhat;
            
        public double DonGiaPhat
        {
            get { return _DonGiaPhat; }
            set { _DonGiaPhat = value; }
        }
        #endregion

        #region contructors
        public NhanVienVp() { }

        public NhanVienVp(string maSo,string hoTen, DateTime ngaySinh,DateTime ngayVaoLam,Phai gioiTinh,double heSoLuong,int soNgayVang)
            :base(maSo,hoTen,ngaySinh,ngayVaoLam,gioiTinh,heSoLuong,soNgayVang)
        {


        }
       
        #endregion

        #region methods
        public double TinhPhat()
        {
            double kq = 0;
            if (_SoNgayVang > DinhMucVang) kq = (_SoNgayVang - DinhMucVang)*DonGiaPhat;

            return kq;
        }
        public override double TinhThuong()// ghi đè phương thức của lớp cha
        {
            double kq = 0;
            kq = LuongCanBan * HeSoLuong * 0.1;
            return kq;
        }
        public override double TinhLuong()
        {
            double kq = 0;
            //TH1: tiền lương của nhân viên văn phòng thì bằng tiền lương của nhân viên cộng thêm tiền thưởng và trừ tiền phạt
            kq = base.TinhLuong() + TinhThuong() - TinhPhat();

            return kq;
        }
        public override string XuatThongTin()
        {
            string kq = "";
            string thuong = this.TinhThuong().ToString("#,##0VND");
            string luong = base.TinhThuong().ToString("#,##0VND");//cua lop cha
            string phat = this.TinhPhat().ToString("#,##0VND");
            string thucLanh = this.TinhLuong().ToString("#,##0VND");// cua NV VP
            kq = string.Format(@"Nhân Viên <b>{0}-{1}</b><br/> 
                                    Tiền Thưởng: {2}<br/> 
                                    Tien phạt: {3}<br/>
                                    Tiền lương: {4}<br/>
                                    Thực Lãnh: {5}<br/>",
                MaSo, HoTen, thuong,
                phat,luong,
                thucLanh);
            return kq;
        }
        #endregion
    }
}