using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class ExHocSinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // khai báo biến đối tượng h1 kiểu học sinh
            HocSinh h1;
            // khoi tạo biến h1 học sinh
            h1 = new HocSinh(); // khởi tạo không tham số

            // khai báo và khởi tạo chung
            HocSinh h2 = new HocSinh();// khởi tạo không tham số
            //gán giá trị cho biến
            h1.MaSo = "H01"; //SET
            h1.HoTen = "Tran Anh Tuan";
            h1.DiaChi = "123NTC";
            h1.Toan = 7.5F; // kiểu float phải thêm hậu tố F
            h1.Van = 8.5F;

            string ms = h1.MaSo;//GET

            HocSinh h3;
            h3 = h1;
            h3.MaSo = "H03";
        }

        protected void btn_DK_Click(object sender, EventArgs e)
        {
            try
            {
                HocSinh h1 = new HocSinh();
                h1.MaSo = "H01"; //SET
                h1.HoTen = "Tran Anh Tuan";
                h1.DiaChi = "123NTC";
                h1.Toan = 7.5F; // kiểu float phải thêm hậu tố F
                h1.Van = 8.5F;
                float dtb = h1.DiemTrungBinh();
            }
            catch (Exception ex)
            {
                string cauBaoLoi=ex.Message;
            }
        }
    }
}