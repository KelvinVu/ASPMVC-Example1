using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class ExHtmlCtr_Server : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // cài phương thức vào sự kiện
            // khai báo liên kết phương thức btnThucHien_click với sự kiện server click
            btnThucHien.ServerClick += btnThucHien_ServerClick;
        }

        void btnThucHien_ServerClick(object sender, EventArgs e)
        {
            divKetQua.InnerHtml = "Xin chào <b>" + txtHoTen.Value + "</b>";
        }

    }
}