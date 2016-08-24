using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai03
{
    public partial class GiaiPhuonnTrinhBac1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiai_Click(object sender, EventArgs e)
        {
            float heSoA = float.Parse(txtSoA.Text);
            float heSoB = float.Parse(txtSoB.Text);

            PhuongTrinhBac1 phuongtrinh = new PhuongTrinhBac1(heSoA, heSoB);
            txtKetQua.Text = phuongtrinh.Giai();
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            txtSoA.Text = " ";
            txtSoB.Text = " ";
            txtKetQua.Text = " ";
        }
    }
}