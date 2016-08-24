using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai05
{
    public partial class NhapDiemHocSinhLop6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnTinh_Click(object sender, EventArgs e)
        {
            string Lop = txtLop.Text;
            string Ten = txtHoTen.Text;
            string MaSo = txtMaSo.Text;

            double Toan = double.Parse(txtToan.Text);
            double NguVan = double.Parse(txtNguVan.Text);

            HocSinhLop6 hsl1 = new HocSinhLop6(MaSo, Ten, Lop, Toan, NguVan);
            txtDiemTrungBinh.Text = hsl1.DiemTrungBinh().ToString();
            txtKetQuaHocTap.Text = hsl1.KetQuaHocTap().ToString();
            txtXepLoaiKhenThuong.Text = hsl1.XepLoaiKhenThuong().ToString();
        }

        protected void btnTiep_Click(object sender, EventArgs e)
        {
            txtToan.Text = "";
            txtNguVan.Text = "";
            txtDiemTrungBinh.Text = "";
            txtKetQuaHocTap.Text = "";
            txtXepLoaiKhenThuong.Text = "";
        }
    }
}