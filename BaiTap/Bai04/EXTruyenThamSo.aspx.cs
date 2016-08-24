using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai04
{
    public partial class EXTruyenThamSo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double kqTong = 2;
            double kqTich = 3;
            PhepTinh3So(2, 3, 5, out kqTong, out kqTich);
            //bool kq=SoNguyen.TryParse("456",k);

            double st1 = TinhTien(2, 100);// TyGia là tham số không bắt buộc được để trong ngoặc vuông
            double st2 = TinhTien(2, 100, 25000);

            double st3 = TinhTien(SoTien: 2000, SoLuong: 3);// truyền giá trị theo định danh
        }

        private int Tong(params int[] DaySo)
        {
            //cach1
            int kq = 0;
            //foreach(int n in DaySo)
            //{
            //    kq += n;
            //}
            //cach2
            //for (int i = 0; i < DaySo.Length;i++ )
            //{
            //    kq += DaySo[i];
            //}
            //cach3
            kq = DaySo.Sum();//linq to object
                return kq;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SoLuong">Số lượng mua là số nguyên</param>
        /// <param name="SoTien">Số Tiền</param>
        /// <param name="TyGia">Tỷ Giá(mặc định =1)</param>
        /// <returns>Kết Quả là số tiền sau khi quy đổi</returns>
        public double TinhTien(int SoLuong, double SoTien,double TyGia=1)
        {
            double kq = SoLuong * SoTien * TyGia;
            return kq;
        }

        private double TinhTong(double a, ref double b)
        {
            a = a + 10;
            b = b + 5;
            double kq = a + b;
            return kq;
        }

        private void TinhTong2So(double a, double b, ref double tong)
        {
            tong = a + b;

        
        }
        private void PhepTinh2So(double a, double b, ref double tong, ref double tich)
        {
            tong = a + b;
            tich = a * b;
        }
        private void PhepTinh3So(double a, double b, double c, out double tong, out double tich)
        {
            tong = a + b + c;
            tich = a * b * c;

     
            
        }
    }
}