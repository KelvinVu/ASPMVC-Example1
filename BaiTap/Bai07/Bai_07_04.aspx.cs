using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai07
{
    public partial class Bai_07_04 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        double Tinh_gia_tri_bieu_thuc(string bieuthuc)
        {
            double kq = 0;
            string[] mangso = bieuthuc.Split('+');
            string pheptoan = "+";
            if (mangso.Length <= 1)
            {
                mangso = bieuthuc.Split('-');
                pheptoan = "-";
            }
            if (mangso.Length <= 1)
            { 
                mangso = bieuthuc.Split('*');
                pheptoan = "*";
            }
            if (mangso.Length <= 1)
            { 
                mangso = bieuthuc.Split('/');
                pheptoan = "/";
            }
            if (mangso.Length == 1)
                kq = double.Parse(mangso[0]);
            else
            {
                switch(pheptoan)
                {
                    case "+":
                        kq = double.Parse(mangso[0].Trim())+double.Parse(mangso[1].Trim());
                        break;
                    case "-":
                        kq = double.Parse(mangso[0].Trim()) - double.Parse(mangso[1].Trim());
                        break;
                    case "*":
                        kq = double.Parse(mangso[0].Trim()) * double.Parse(mangso[1].Trim());
                        break;
                    default:
                        kq = double.Parse(mangso[0].Trim()) / double.Parse(mangso[1].Trim());
                        break;
                }
            }
            return kq;
        }

        protected void thDoctaptin_Click(object sender, EventArgs e)
        {
            try
            {
                string duongdan = Server.MapPath("~/My_Files");
                string tenfile = "Bai_07_04.txt";
                if (!File.Exists(duongdan + "/" + tenfile))
                {
                    thKetqua.Text = "Tập tin không tồn tại.";
                    thKetqua.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    FileStream fs = new FileStream(duongdan + "/" + tenfile, FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    string bieuthuc = "", kq = "";
                    do
                    {
                        bieuthuc = sr.ReadLine();
                        if (!string.IsNullOrEmpty(bieuthuc))
                        {
                            double giatri = Tinh_gia_tri_bieu_thuc(bieuthuc);
                            kq += bieuthuc + " = " + giatri.ToString() + "<br />";
                        }
                    }
                    while (!string.IsNullOrEmpty(bieuthuc));
                    sr.Close();
                    fs.Close();
                    thKetqua.Text = kq;
                }
            }
            catch (Exception ex)
            {
                thKetqua.Text = "Có lỗi xảy ra trong quá trình đọc tập tin";
                thKetqua.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}