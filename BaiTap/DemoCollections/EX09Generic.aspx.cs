using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiTap.Bai06;


namespace BaiTap.Demo
{
    public partial class EX09Generic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnList1_Click(object sender, EventArgs e)
        {

            
            List<int> ds1 = new List<int>();
            ds1.Add(1);
            ds1.Add(2);
            ds1.Add(3);
            int n = ds1[0];
            int kq1 = 0;
            foreach (int p in ds1)
            {
                kq1 += p;
            }
            List<string> ds2 = new List<string>();
            ds2.Add("01");
            ds2.Add("02");
            ds2.Add("03");
            string kq2 = "";
            foreach (string p in ds2)
            {
                kq2 += p;
            }
        }

        protected void btnList2_Click(object sender, EventArgs e)
        {
            List<NhanVien> dsNV = new List<NhanVien>();
            dsNV.Add(new NhanVien("A01", "NVA", new DateTime(1990, 1, 15), DateTime.Today, Phai.Nam, 1));
            dsNV.Add(new NhanVien("A07", "NTB", new DateTime(1990, 2, 11), DateTime.Today, Phai.Nữ, 1.5));
            dsNV.Add(new NhanVien("A05", "NVC", new DateTime(1990, 2, 12), DateTime.Today, Phai.Nam, 1));
            dsNV.Add(new NhanVien("A04", "NVK", new DateTime(1990, 3, 1), DateTime.Today, Phai.Nam, 1));

            NhanVien nv = dsNV[1];
            nv.HeSoLuong = 1.5;

            dsNV[2].HeSoLuong = 2.5;

            int Tong1 = dsNV.Count();

            dsNV.Sort();
        }

        protected void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            //SortedDictionary<int, string> dict = new SortedDictionary<int, string>();
            dict[3] = "Three";
            dict[4] = "Four";
            dict[2] = "Two";
            dict[1] = "One";
            dict.Add(5, "Five");

            int t = dict.Count;
            string str = dict[3];

            string noiDung = "";
            foreach (KeyValuePair<int, string> i in dict)
            {
                noiDung+=string.Format("{0}: {1}", i.Key, i.Value);
            }
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            List<NhanVien> dsNV = new List<NhanVien>();
            dsNV.Add(new NhanVien("A01", "NVA", new DateTime(1990, 1, 15), DateTime.Today, Phai.Nam, 1));
            dsNV.Add(new NhanVien("A07", "NTB", new DateTime(1990, 2, 11), DateTime.Today, Phai.Nữ, 1.5));
            dsNV.Add(new NhanVien("A05", "NVC", new DateTime(1990, 2, 12), DateTime.Today, Phai.Nam, 1));
            dsNV.Add(new NhanVien("A04", "NVK", new DateTime(1990, 3, 1), DateTime.Today, Phai.Nam, 1));

            //int d1 = dsNV.Count(p => p.NgaySinh.Month == 2);// đếm những người có tháng sinh là 2, p là phần tử so sánh linq to obj
            //List<NhanVien> dsNV2 = dsNV.Where(p => p.HeSoLuong == 1).ToList();

            //var ds3 = dsNV.Where(p => p.HeSoLuong == 1)
            //    .Select(p => new { p.MaSo, p.HoTen, p.HeSoLuong })//anonymous type
            //    .ToList();

            List<NhanVien> dsNV2 = dsNV.FindAll(p => p.HeSoLuong == 1);
            NhanVien kqTim = dsNV.Find(p => p.HeSoLuong == 1);

            double maxHSL = dsNV.Max(p => p.HeSoLuong);
            List<NhanVien> dsNV3 = dsNV.FindAll(p => p.HeSoLuong == maxHSL);
        }
    }
}