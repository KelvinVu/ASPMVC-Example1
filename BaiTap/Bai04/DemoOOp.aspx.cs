using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai04
{
    public partial class DemoOOp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NhanVien nv1 = new NhanVien();
            NhanVienVp nv2 = new NhanVienVp("NV02", "NVB", new DateTime(1985, 2, 20), new DateTime(2015, 1, 25), Phai.Nam, 1.5,2);

            double tienThuong = nv2.TinhThuong();
            double tienluong = nv2.TinhLuong();
        }
    }
}