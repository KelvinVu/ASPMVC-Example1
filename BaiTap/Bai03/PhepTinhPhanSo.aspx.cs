using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai03
{
    public partial class PhepTinhPhanSo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCong_Click(object sender, ImageClickEventArgs e)
        {
            PhanSo ps1 = PhanSo.Parse(txtPhanSo1.Text);
            PhanSo ps2 = PhanSo.Parse(txtPhanSo2.Text);
            PhanSo psKq = ps1.Cong(ps2);
            txtKetQua.Text = psKq.Xuat();
        }

        protected void btnTru_Click(object sender, ImageClickEventArgs e)
        {
           
        }

        protected void btnNhan_Click(object sender, ImageClickEventArgs e)
        {
           
        }

        protected void btnChia_Click(object sender, ImageClickEventArgs e)
        {
           
        }

        protected void btnXoaNoiDung_Click(object sender, ImageClickEventArgs e)
        {
            txtPhanSo1.Text = "";
            txtPhanSo2.Text = "";
            txtKetQua.Text = "";
            lblKetQua.Text = "Kết quả";
            txtPhanSo1.Focus();
        }
    }
}