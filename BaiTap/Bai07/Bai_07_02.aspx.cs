using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace BaiTap.Bai07
{
    public partial class Bai_07_02 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void thDoctaptin_Click(object sender, EventArgs e)
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
                    string duongdan = Server.MapPath("~/My_Files/");
                    string tenfile = thTapTin.FileName;
                    thTapTin.SaveAs(duongdan + tenfile);

                    //Cach 1
                    //FileStream fs = new FileStream(duongdan + tenfile, FileMode.Open);
                    //StreamReader sr = new StreamReader(fs);

                    //Cach 2
                    // nếu dọc văn bản thường thì dùng cách 2:
                    StreamReader sr = new StreamReader(duongdan + tenfile);
                    string noidung = sr.ReadToEnd(); //Đọc toàn bộ nội dung tập tin
                    int lineCount = 0;
                    while (sr.ReadLine() !=null)
                    {
                        lineCount++;
                    }
                    sr.Close();
                    //fs.Close();
                    thKetqua.Text = "Có " + lineCount + " dòng trong tập tin " + tenfile;

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