using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai07
{
    public partial class Bai_07_03 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void thGhitaptin_Click(object sender, EventArgs e)
        {
            if (thNoidung.Text.Trim() != "")
            {
                try
                {
                    string duongdan = Server.MapPath("~/My_Files");
                    string tenfile = "Bai_07_03.txt";
                    FileStream fs = new FileStream(duongdan + "/" + tenfile, FileMode.Create);
                    StreamWriter writeFile = new StreamWriter(fs, Encoding.UTF8); //dùng streamwriter để ghi file
               
                    //mã hóa cac the html
                    string noidung = HttpUtility.HtmlEncode(thNoidung.Text);

                    writeFile.Write(thNoidung.Text);
                    writeFile.Close();
                    thKetqua.Text = "Nội dung đã được ghi thành công vào tập tin " + tenfile;
                }
                catch
                {
                    thKetqua.Text = "Không ghi được tập tin";
                    thKetqua.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        protected void thDoctaptin_Click(object sender, EventArgs e)
        {
            try
            {
                string duongdan = Server.MapPath("~/My_Files");
                string tenfile = "Bai_07_03.txt";
                if (!File.Exists(duongdan + "/" + tenfile))
                {
                    thKetqua.Text = "Tập tin không tồn tại. Vui lòng nhập nội dung và ghi vào tập tin trước khi đọc.";
                    thKetqua.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    FileStream fs = new FileStream(duongdan + "/" + tenfile, FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    string kq = sr.ReadToEnd();
                    fs.Close();
                    //giai ma cac the html
                    string noiDung = HttpUtility.HtmlDecode(kq);
                    thKetqua.Text = kq.Replace("\r\n","<br/>");
                }
            }
            catch
            {
                thKetqua.Text = "Có lỗi xảy ra trong quá trình đọc tập tin";
                thKetqua.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}