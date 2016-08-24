using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;

namespace BaiTap.Demo
{
    public partial class EXFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string s1 = @"D:\Sưu Tầm\12527738_588060098008628_1889231979_n.jpg";
            //string s2 = Server.MapPath("~/Data/VanBan1.txt");
            //string s3 = Server.MapPath("~/Data/VanBan2.txt");
            //if(File.Exists(s2)==true)
            //{
            //    File.Copy(s2, s3);
            //}
            //File.Delete(s1);

            //Directory.CreateDirectory("D:\\MyPhotos");
            //DirectoryInfo d = new DirectoryInfo(@"C:\Windows");
            //FileInfo f = new FileInfo(s3);
        }

        protected void btnDoc_Click(object sender, EventArgs e)
        {
            string TapTin = Server.MapPath("~/Data/VanBan1.txt");
            string NoiDung = File.ReadAllText(TapTin);

            txtNoiDung.Text = NoiDung;
        }

        protected void btnGhi_Click(object sender, EventArgs e)
        {
            string TapTin = Server.MapPath("~/Data/VanBan1.txt");
            string NoiDung = txtNoiDung.Text;
            File.WriteAllText(TapTin,NoiDung);
        }

        protected void btnDocTheoDong_Click(object sender, EventArgs e)
        {
            string TapTin = Server.MapPath("~/Data/VanBan3.txt");
            string[] NoiDung = File.ReadAllLines(TapTin);
            string[] KetQua = NoiDung.Where(p => p.StartsWith("Trần")).ToArray();//Linq To Object
            string[] KetQua2 = NoiDung.Where(p => p.StartsWith("B")).ToArray();
        }
    }
}