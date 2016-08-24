using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class exMultiView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            //C1: sử dụng thuộc tính
            //mtv.ActiveViewIndex = 0;

            //C2: sử dụng phương thức

            mtv.SetActiveView(View1);
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            //mtv.ActiveViewIndex = 1;
            mtv.SetActiveView(View2);
        }
    }
}