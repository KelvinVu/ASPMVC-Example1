using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai05
{
    public partial class TinhDienTichHCN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.ChieuDai = double.Parse(txtChieuDai.Text);
            hcn.ChieuRong = double.Parse(txtChieuRong.Text);

            string dvt =((char)178).ToString();

            double dientich = hcn.DienTich();
            txtDienTich.Text =string.Format("{0}{1}",dientich.ToString("#,##0"),dvt);
        }

        protected void btnTiep_Click(object sender, EventArgs e)
        {
            txtChieuDai.Text=" ";
            txtDienTich.Text=" ";
            txtDienTich.Text=" ";
            txtChieuDai.Focus();//con tro o textbox này
        }
    }
}