using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.Bai05
{
    // xây dựng interface: đưa ra quy các khai báo thuộc tính và phương thức
    // mà class thực thi (implemented) cần phải cài đặt code

    interface IHinh
    {
        //thuộc tính(read only)
        string TenHinh { get; }
        // phương thức
        double DienTich();
        double ChuVi();
        string XuatThongTin(string xuongDong = "\r\n");
    }
}
