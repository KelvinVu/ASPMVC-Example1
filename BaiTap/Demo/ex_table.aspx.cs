using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class ex_table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            string noidung = "xin chao ban" + txtHoTen.Text+"!<br/> thong tin cua ban da duoc ghi nhan";
            lbDangKyThanhCong.Text = noidung;
        }
    }
}