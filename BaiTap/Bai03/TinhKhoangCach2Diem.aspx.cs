using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai03
{
    public partial class TinhKhoangCach2Diem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiai_Click(object sender, EventArgs e)
        {
            Diem A = Diem.Parse(txtDiemA.Text);
            Diem B = Diem.Parse(txtDiemB.Text);
            double khoangcach = A.KhoangCach(B);
            txtKhoangCach.Text = string.Format("Khoang cach la = {0}", khoangcach);
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            txtDiemA.Text = "";
            txtDiemB.Text = "";
            txtKhoangCach.Text = "";
        }
    }
}