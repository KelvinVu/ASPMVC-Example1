using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace BaiTap.Bai07
{
    public partial class ExFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDoc_Click(object sender, EventArgs e)
        {
            string s = Server.MapPath("~/Data/Data3.txt");
            string noiDung = File.ReadAllText(s);
            TextBox1.Text = noiDung;
        }

        protected void btnGhi_Click(object sender, EventArgs e)
        {
            string s = Server.MapPath("~/Data/Data3.txt");
            string noiDung =TextBox1.Text;
            File.WriteAllText(s, noiDung);
   
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string taptin = Server.MapPath("~/Data/Data3.txt");
            string[] noiDung = File.ReadAllLines(taptin);
         //   string[] ketqua = noiDung.Where(p => p.Contains("Trần")).ToArray();
           // string[] ketqua1 = noiDung.Where(p => p.StartsWith("A")).ToArray();

        }
    }
}