using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai05
{
    public partial class NhapDiemHocSinhLop1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            string Lop = txtLop.Text;
            string Ten = txtHoTen.Text;
            string MaSo = txtMaSo.Text;

            double Toan =double.Parse( txtToan.Text);
            double TiengViet =double.Parse(txtTiengViet.Text);
            double TapViet =double.Parse(txtTapViet.Text);

            HocSinhLop1 hsl1 = new HocSinhLop1(MaSo,Ten,Lop,Toan,TiengViet,TapViet);
            txtDiemTrungBinh.Text = hsl1.DiemTrungBinh().ToString();
            txtKetQuaHocTap.Text = hsl1.KetQuaHocTap().ToString();
            txtXepLoaiKhenThuong.Text = hsl1.XepLoaiKhenThuong().ToString();
        }

        protected void btnTiep_Click(object sender, EventArgs e)
        {
            txtToan.Text="";
            txtTiengViet.Text="";
            txtTapViet.Text="";
            txtDiemTrungBinh.Text="";
            txtKetQuaHocTap.Text="";
            txtXepLoaiKhenThuong.Text = "";
        }
    }
}