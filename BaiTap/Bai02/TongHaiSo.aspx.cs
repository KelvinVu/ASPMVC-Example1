using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai02
{
    public partial class TongHaiSo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            //lbLoi.Text = "";// xóa thông báo lỗi khi tính lại
            //txtTong.Text = "";
            try
            {
                //cách 1
                //int a = int.Parse(txtSoA.Text);// ép kiểu cho chuổi trong textbox
                //int b = int.Parse(txtSoB.Text);
                //int kq = a + b;
                //txtTong.Text = kq.ToString("#,##0");

                //cách 2: tryparse
                int a=0,b=0;
                if(!int.TryParse(txtSoA.Text,out a))throw new Exception("số a phải là số nguyên");// ép 
                if(!int.TryParse(txtSoB.Text,out b))throw new Exception("số b phải là số nguyên");
                int kq = a + b;
                txtTong.Text = kq.ToString("#,##0");

                //cách 3: không sư dụng try catch
                //if(!int.TryParse(txtSoA.Text,out a))
                //  {
                //      txtLoi.Text="sdfasdfasdf";
                //      return;
                //  }

            }
            // lỗi chuung chung, Format Ex.... lỗi xác định
            // try part... throw... if
            catch(Exception ex)
            {
                lbLoi.Text = "ban phai nhap so nguyen"+ex.Message;// thong bao loi he thong
            }
        }

        protected void btnLamLai_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtTong.Text = "";
            lbLoi.Text = "";
            txtSoA.Focus();//chuyển con trỏ về A
        }
    }
}