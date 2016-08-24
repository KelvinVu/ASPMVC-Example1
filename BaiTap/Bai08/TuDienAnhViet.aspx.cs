using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace BaiTap.Bai08
{
    public partial class TuDienAnhViet : System.Web.UI.Page
    {
        Hashtable TuDien;
        protected void Page_Load(object sender, EventArgs e)
        {
            TuDien = Session["TU_DIEN"] as Hashtable;// sau 20 phút ko tương tác với server session tự giải phóng
            if(TuDien==null)
            {
                TuDien = new Hashtable();
                TuDien.Add("Hello", "Xi chào");
                TuDien.Add("flower","hoa, bông");
                TuDien.Add("sun", "mặt trời, thái dương");
                TuDien.Add("sunshine", "ánh sáng mặt trời, sự lạc quan, sự vui tươi");
                Session["TU_DIEN"] = TuDien;
            }
        }

        protected void btnThucHien_Click(object sender, EventArgs e)
        {
            string tuTA = txtTuTienAnh.Text.Trim();
            object nghiaTV=TuDien[tuTA];
            txtNghiaTiengViet.Text = nghiaTV.ToString();
        }

        protected void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtTuTienAnh.Text = "";
            txtNghiaTiengViet.Text = "";
        }
    }
}