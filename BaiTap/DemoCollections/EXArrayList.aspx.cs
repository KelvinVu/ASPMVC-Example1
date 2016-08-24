using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;// lớp của hệ thống xây dựng sẵn
using BaiTap.Bai04;// lớp tự xây dựng
using BaiTap.Bai06;
using System.Text;

namespace BaiTap.DemoCollections
{
    public partial class EXArrayList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ArrayList a = new ArrayList();
            //thêm phần tử vào tập hợp
            a.Add("xin chào");
            a.Add(5);
            a.Add(DateTime.Today);
            // đọc và xử lý thông tin của phần tử
            string loichao = a[0].ToString();
            int doDai = loichao.Length;

            int thangHienHanh;
            double diem = (double)a[1];
            if(a[2].GetType().Name=="DateTime")
            {
                DateTime ngayHienHanh = (DateTime)a[2];
                thangHienHanh = ngayHienHanh.Month;
            }
            int namHienHanh = ((DateTime)a[2]).Year;
        }

        protected void btnAddRange_Click(object sender, EventArgs e)
        {
            string[] strA = new string[] { "A01","B01","C01" };
            ArrayList a = new ArrayList();
            a.AddRange(strA);// đẩy nguyên mảng vào 1 arraylist luôn
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string[] strA = new string[] { "A01", "B01", "C01" };
            ArrayList a = new ArrayList();
            a.AddRange(strA);

            //chèn nội dung vào vị trí phần tử có chỉ số là 1
            a.Insert(1, "A02");
            // chèn một tập hợp vào tại vị trí phần tử có chỉ số là 3
            string[] strB = new string[] { "A02", "B03" };
            a.InsertRange(3,strB);
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            ArrayList a = new ArrayList();
            a.AddRange(new string[] { "CN", "T2", "T3", "T4", "T5", "T6", "T7" });

            a.Remove("T2");
            a.RemoveAt(3); //xóa phần tử có vụ trí là 3
            a.RemoveRange(1, 3);// xóa 3 phần tử từ vị trí 1
            a.Clear(); //xóa hết

            int tongsophantu = a.Count;

        }
        
        protected void btnDS_Click(object sender, EventArgs e)
        {
            ArrayList DsNhanVien = new ArrayList();
            DsNhanVien.Add(new NhanVienVp("V01", "NVA", new DateTime(1985, 2, 15), DateTime.Today, Bai04.Phai.Nam, 1, 0));
            DsNhanVien.Add(new NhanViensx("S01", "NVB", new DateTime(1985, 3, 15), DateTime.Today, Bai04.Phai.Nam, 3, 350));
            DsNhanVien.Add(new NhanVienVp("V02", "TVA", new DateTime(1985, 4, 15), DateTime.Today, Bai04.Phai.Nam, 1.5, 4));

            NhanViensx nvsx = (NhanViensx)DsNhanVien[1];
        }

        protected void btnSort_Click(object sender, EventArgs e)
        {
            ArrayList DsNhanVien = new ArrayList();
            DsNhanVien.Add(new Bai06.NhanVien("V01", "NVAa", new DateTime(1985, 2, 15), DateTime.Today, Bai06.Phai.Nam, 1));
            DsNhanVien.Add(new Bai06.NhanVien("S01", "NVBs", new DateTime(1985, 3, 15), DateTime.Today, Bai06.Phai.Nam, 3));
            DsNhanVien.Add(new Bai06.NhanVien("V02", "TVAd", new DateTime(1985, 4, 15), DateTime.Today, Bai06.Phai.Nam, 1.5));

            DsNhanVien.Sort();

            StringBuilder sb = new StringBuilder();
            foreach(Bai06.NhanVien item in DsNhanVien)
            {
                sb.AppendLine(item.MaSo);
            }

            for (int i=0;i<DsNhanVien.Count;i++)
            {
                var nv = (Bai06.NhanVien)DsNhanVien[i];
                sb.AppendLine(nv.MaSo);
            }
            txtKQ.Text = sb.ToString();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ArrayList a = new ArrayList();
            a.AddRange(new int[] { 50, 30, 40, 60, 80, 90, 100, 30, 20 });

            int i = a.IndexOf(70);// tìm số 70
            int j = a.LastIndexOf(70);// tìm số 70 cuối cùng
            bool kq = a.Contains(100);// có chứa 100 hay ko?

            //sắp xếp tăng
            a.Sort();
            // đảo ngược vị trí của các phần tử trong tập hợp
            a.Reverse();
        }


    }
}