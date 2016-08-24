using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class EXDelegate : System.Web.UI.Page
    {
        //delegate dùng để tham chiếu đến các phương thức có cùng cách thức khai báo giống nhau

        public delegate int PhepTinh(int x,int y);
   
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region methods
        private int Tong(int a,int b)
        {
            return a + b;

        }
        private int Tich(int a,int b)
        {
            return a * b;
        }
        #endregion

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            PhepTinh pt;
            if(rbTong.Checked==true)
            {
                pt = new PhepTinh(Tong);// khởi tạo biến pt kiểu delegate PhepTinh tham chiếu đến phương thức tổng
            }
            else
            {
                pt = new PhepTinh(Tich);// khởi tạo biến pt kiểu delegate PhepTinh tham chiếu đến phương thức tích
            }
            //int kq = pt.Invoke(2, 5);
            int kq2 = pt(2, 5);// gọi phương thức thực thi

            lbKetQua.Text = "Kết Quả" + kq2;
        }
    }
}