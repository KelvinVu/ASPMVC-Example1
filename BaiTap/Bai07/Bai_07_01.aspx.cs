using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai07
{
    public partial class Bai_07_01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDoc_Click(object sender, EventArgs e)
        {

            if (thTapTin.HasFile)
            {
                string kieu = System.IO.Path.GetExtension(thTapTin.FileName).ToLower();
                if (kieu != ".txt" && kieu != ".xml")
                {
                    thKetqua.Text = "Chỉ được phép upload tập tin có kiểu là TXT hoặc XML.";
                    thKetqua.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    string duongdan = Server.MapPath("~/My_Files");
                  
                    thTapTin.SaveAs(duongdan + "/" + thTapTin.FileName);
                    thKetqua.Text = "Upload tập tin thành công.";
                }
            }
            else
            {
                thKetqua.Text = "Vui lòng chọn tập tin cần upload";
                thKetqua.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}