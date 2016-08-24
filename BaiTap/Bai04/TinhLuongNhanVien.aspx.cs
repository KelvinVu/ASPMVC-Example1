using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai04
{
    public partial class TinhLuongNhanVien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //nếu là lần load đầu tiên(ko phải load lại do submit sự kiện của control)
            // vào pageload trc khi submit
            if(!IsPostBack)
            {
                txtSoSanPham.Text = "312";
                txtSoNgayVang.Text = "0";
            }
        }

        protected void btnXuatThongTin_Click(object sender, EventArgs e)
        {

            string maso = txtMaso.Text;
            string hoten = txtHoTen.Text;
            DateTime ngaysinh = DateTime.Parse(txtNgaySinh.Text);
            DateTime ngayvaolam = DateTime.Parse(txtNgayVaoLam.Text);
            double hsl=double.Parse(txtHeSoLuong.Text);
            Phai gioitinh = chkGioiTinh.Checked ? Phai.Nam : Phai.Nữ;
            int songayvang = int.Parse(txtSoNgayVang.Text);
            //cách 1:
            //if(rdbNVVP.Checked)
            //{
            //    NhanVienVp nv = new NhanVienVp(maso,hoten,ngaysinh,ngayvaolam,gioitinh,hsl,songayvang);
            //    lblThongTin.Text = nv.XuatThongTin();


            //}
            //else
            //{
            //    int sosanpham = int.Parse(txtSoSanPham.Text);
            //    NhanViensx nv = new NhanViensx(maso, hoten, ngaysinh, ngayvaolam, gioitinh,songayvang, sosanpham);
            //    lblThongTin.Text = nv.XuatThongTin();


            //}
            // cach2: ứng dụng lateBinding


            NhanVien nv;
            if (rdbNVVP.Checked)
            {
                nv = new NhanVienVp(maso, hoten, ngaysinh, ngayvaolam, gioitinh, hsl, songayvang);
            }
            else
            {
                int sosanpham = int.Parse(txtSoSanPham.Text);
                nv = new NhanViensx(maso, hoten, ngaysinh, ngayvaolam, gioitinh, songayvang, sosanpham);
            }
            lblThongTin.Text = nv.XuatThongTin();
            //lệnh chuyển sang view 2
			MultiView1.ActiveViewIndex = 1;
        }

        protected void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtMaso.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            txtNgayVaoLam.Text = "";
            txtHeSoLuong.Text = "";
            chkGioiTinh.Checked = false;
            txtSoNgayVang.Text = "0";
            txtSoSanPham.Text = "";
            rdbNVSX.Checked = true;
            txtMaso.Focus();
            MultiView1.ActiveViewIndex = 0;
        }

        protected void rdbNVVP_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}