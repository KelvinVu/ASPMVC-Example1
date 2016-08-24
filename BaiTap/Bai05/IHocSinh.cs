using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.Bai05
{
    interface IHocSinh
    {
        string MaSo { get; set; }
        string HoTen { get; set; }
        string Lop { get; set; }
        double DiemTrungBinh();
        string KetQuaHocTap();
        string XepLoaiKhenThuong(string phanCach="\r\n");
    }
}
