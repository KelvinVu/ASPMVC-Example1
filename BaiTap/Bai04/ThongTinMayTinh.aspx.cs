using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai04
{
    public partial class ThongTinMayTinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if (rdbMTDB.Checked == false)
                {
                    Label2.Visible = true;
                    txtTrongLuong.Visible = true;
                    Label3.Visible = true;
                    txtThoiGianPin.Visible = true;
                    Label4.Visible = true;
                    txtKichThuocManHinh.Visible = true;

                    label0.Visible = false;
                    Label1.Visible = false;
                    txtRAM.Visible = false;
                    txtCPU.Visible = false;
                }
                else
                {
                    Label2.Visible = false;
                    txtTrongLuong.Visible = false;
                    Label3.Visible = false;
                    txtThoiGianPin.Visible = false;
                    Label4.Visible = false;
                    txtKichThuocManHinh.Visible = false;

                    label0.Visible = true;
                    Label1.Visible = true;
                    txtRAM.Visible = true;
                    txtCPU.Visible = true;

                }

            
        }

        protected void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            string SoHieu = txtSoHieu.Text;
            int DonGia = int.Parse(txtDonGia.Text);
            string HangSX = txtHangSanXuat.Text;

            MayTinh mt;

            if(rdbMTDB.Checked)
            {
                string RAM = txtRAM.Text;
                string CPU = txtCPU.Text;
                mt = new MayTinhDeBan(SoHieu, DonGia, HangSX, RAM, CPU);
            }

            else
            {
                double TrongLuong = double.Parse(txtTrongLuong.Text);
                double KichThuocMH = double.Parse(txtKichThuocManHinh.Text);
                double ThoiGianPin = double.Parse(txtThoiGianPin.Text);
                mt = new MayTinhXachTay(SoHieu, DonGia, HangSX, TrongLuong, ThoiGianPin, KichThuocMH);
            }
            txtXuatThongTin.Text = txtXuatThongTin.Text + mt.XuatThongTin();
        }
    }
}