using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai05
{
    public partial class TinhDienTichCvHinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            IHinh hinh;
            if(rdbHinhVuong.Checked)
            {
                //hinh = new HinhVuong// do tạo constructors nên dùng gán bằng cách gọi thuộc tính
                //{
                //    Canh = double.Parse(txtCanh.Text)
                //};

                double canh = double.Parse(txtCanh.Text);
                hinh = new HinhVuong(canh);
            }
            else
            {
                hinh=new HinhChuNhat
                {
                    ChieuDai=double.Parse(txtChieuDai.Text),
                    ChieuRong=double.Parse(txtChieuRong.Text)
                };
            }

        }

        protected void btnTiep_Click(object sender, EventArgs e)
        {
            txtChieuRong.Text = "";
            txtChieuDai.Text="";
            txtCanh.Text = "";
            txtKetQua.Text = "";
        }

        protected void rdbHinhVuong_CheckedChanged(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
            txtKetQua.Text = "";
        }

        protected void rdbHinhChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
            txtKetQua.Text = "";
        }
    }
}