using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai03
{
    public partial class CapNhatNhanVien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NhanVien nv1 = new NhanVien("NV01", "NVA", new DateTime(1985, 2, 20), new DateTime(2015, 1, 25), Phai.Nam, 1.5);
            NhanVien nv2 = new NhanVien("NV02", "NVB", new DateTime(1985, 2, 20), new DateTime(2015, 1, 25), Phai.Nam, 1.5);

            double tienluong = nv1.TinhLuong();
            int tn = nv1.ThamNien;
        }

        protected void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien();
                nv.MaSo = txtMaso.Text;
                nv.HoTen = txtHoTen.Text;
                nv.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                nv.NgayVaoLam = DateTime.Parse(txtNgayVaoLam.Text);
                nv.GioiTinh = chkGioiTinh.Checked == true ? Phai.Nam : Phai.Nữ;
                nv.HeSoLuong = double.Parse(txtHeSoLuong.Text);

                MultiView1.ActiveViewIndex = 1;
                lblThongTin.Text = nv.XuatThongTin();
            }
            catch(FormatException ex)
            {
                lbBaoLoi.Text = "dữ liệu không hợp lệ";

            }
            catch(Exception ex)
            {
                lbBaoLoi.Text = ex.Message;

            }
        }

        protected void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtMaso.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            txtNgayVaoLam.Text = "";
            txtHeSoLuong.Text = "";
            chkGioiTinh.Checked = false;
            lbBaoLoi.Text = "";
           
            txtMaso.Focus();
            MultiView1.ActiveViewIndex = 0;
        }
    }
}