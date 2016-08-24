using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai06
{
    public partial class CapNhatNhanVien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();

            //cach1:
            //nv.TangLuong += nv_TangLuong;
            //cách 2:
            //nv.XuLyTangLuong += nv_XuLyTangLuong;

            //cách 3:
            nv.XuLyTangLuong += nv_XuLyTangLuong;// gài | Liên Kết Phương thức vào sự kiện


            nv.MaSo = txtMaso.Text;
            nv.HoTen = txtHoTen.Text;
            nv.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
            nv.NgayVaoLam = DateTime.Parse(txtNgayVaoLam.Text);
            nv.GioiTinh = chkGioiTinh.Checked == true ? Phai.Nam : Phai.Nữ;
            nv.HeSoLuong = double.Parse(txtHeSoLuong.Text);

            lblThongTin.Text=nv.XuatThongTin();
			MultiView1.ActiveViewIndex = 1;
            
        }

        void nv_XuLyTangLuong(object sender, EventArgs e)
        {
            NhanVien nvTL = (NhanVien)sender;
        
            lblTangLuong.Text = "Chúc mừng bạn["+nvTL.MaSo+"-"+nvTL.HoTen+"]" +((MyEventAgrs)e).NoiDung;
        }

        //void nv_XuLyTangLuong(object sender, EventArgs e)
        //{
        //    lblTangLuong.Text = sender.ToString();
        //}

        //void nv_TangLuong(string NoiDung)
        //{
        //    lblTangLuong.Text = NoiDung;
        //}

       

        protected void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtMaso.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            txtNgayVaoLam.Text = "";
            txtHeSoLuong.Text = "";
            chkGioiTinh.Checked = false;
            txtMaso.Focus();
            MultiView1.ActiveViewIndex = 0;
        }
    }
}