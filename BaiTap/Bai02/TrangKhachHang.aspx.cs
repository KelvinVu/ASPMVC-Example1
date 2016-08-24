using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace BaiTap.Bai02
{
    public partial class TrangKhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)// lần đầu vào trang(ko phải load lại do submit sự kiện của một control)
            {
                XuatDanhSachNam();
                XuatDanhSachThang();
                XuatDanhSachNgay();

            }
        }
        #region method- phương thức tự định nghĩa
        private void XuatDanhSachNgay()
        {
            ddlNgay.Items.Add("Ngày");
            for(int i=1;i<=31;i++)
            {
                ddlNgay.Items.Add(i.ToString());
            }

        }
        private void XuatDanhSachThang()
        {
            ListItem t4 = new ListItem("Tháng 4","4");
            ddlThang.Items.Add(t4);
            ListItem t5 = new ListItem("Tháng 5", "5");
            ddlThang.Items.Add(t5);
            ListItem t6 = new ListItem("Tháng 6", "6");
            ddlThang.Items.Add(t6);

            ddlThang.Items.Add(new ListItem("Tháng Bảy","7"));
            ddlThang.Items.Insert(0, "Tháng");
        }
        private void XuatDanhSachNam()
        {
            ddlNam.Items.Add("Năm");
            for(int i =1970; i <=DateTime.Today.Year;i++ )
            {
                ddlNam.Items.Add(i.ToString());

            }
        }

        #endregion
        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Cách 2: string builder
            StringBuilder SoThich = new StringBuilder();
            foreach (Control ct in panelSoThich.Controls)
            { 
                if(ct.GetType().Name=="CheckBox")
                {
                    CheckBox chk = (CheckBox)ct;
                    if (chk.Checked) SoThich.AppendFormat(",{0}", chk.Text);
                }
            
            }
            string sothich = SoThich.ToString().Trim(',');
            string[] st = sothich.Split(',');
            Array.Sort(st);
            sothich = string.Join(",", st);

            //C1: sử dụng toán tử điều kiện
            //string SoThich = "";
            //if (ckbAmNhac.Checked)
            //    SoThich += ckbAmNhac.Text;
            string GioiTinh = rbtNam.Checked==true?"Nam":"Nữ";
            int nam = 0, thang = 0, ngay = 0;
            int.TryParse(ddlNam.SelectedValue, out nam);
            int.TryParse(ddlThang.SelectedValue, out thang);
            int.TryParse(ddlNgay.SelectedValue, out ngay);

            DateTime NgaySinh;
            if(nam>0&&thang>0&&ngay>0)
            {
                try
                {
                    NgaySinh = new DateTime(nam, thang, ngay);
                }
                catch
                {
                    lbThongBao.Text = "không hợp lệ ";
                    return;// thoát khỏi chương trình
                }
            }
            else
            {
                lbThongBao.Text = "bạn chưa nhập đủ thông tin ";
                return;// thoát khỏi chương trình

            }

            string NoiDung = string.Format(@"<b>Tên đăng nhập: </b>{0}<br/>
                                                <b>Mật Khẩu:</b>{1}<br/>
                                                <b>Họ Tên </b>{2}<br/>
                                                <b>Giới Tính</b>{3}<br/>
                                                <b>Sở Thích</b>{4}<br/>
                                                <b>Ngày Sinh</b>{5}<br/>"
                , txtDangNhap.Text,txtMatKhau.Text,txtHoTen.Text,GioiTinh,sothich,NgaySinh.ToString("dd-MM-yyyy"));
            lbThongBao.Text = NoiDung;
            MultiView1.ActiveViewIndex = 1;
        }
    }
}