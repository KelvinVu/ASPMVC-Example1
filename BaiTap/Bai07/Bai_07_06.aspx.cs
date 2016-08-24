using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace BaiTap.Bai07
{
    public partial class Bai_07_06 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGhiFile_Click(object sender, EventArgs e)
        {
            if (txtMaSo.Text.Trim() == "")
            {
                lblKetqua.Text = "Vui lòng nhập Mã số học sinh.";
                lblKetqua.ForeColor = System.Drawing.Color.Red;
            }
            else if (txtHoTen.Text.Trim() == "")
            {
                lblKetqua.Text = "Vui lòng nhập Họ tên học sinh.";
                lblKetqua.ForeColor = System.Drawing.Color.Red;
            }
            else if (txtDienThoai.Text.Trim() == "")
            {
                lblKetqua.Text = "Vui lòng nhập Số điện thoại của học sinh.";
                lblKetqua.ForeColor = System.Drawing.Color.Red;
            }
            else if (txtDiemToan.Text.Trim() == "")
            {
                lblKetqua.Text = "Vui lòng nhập Điểm thi môn toán.";
                lblKetqua.ForeColor = System.Drawing.Color.Red;
            }
            else if (txtDiemToan.Text.Trim() == "")
            {
                lblKetqua.Text = "Vui lòng nhập Điểm thi môn văn.";
                lblKetqua.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                float diemtoan = -1, diemvan = -1;
                float.TryParse(txtDiemToan.Text.Trim(), out diemtoan);
                float.TryParse(txtDiemVan.Text.Trim(), out diemvan);
                if (diemtoan < 0)
                {
                    lblKetqua.Text = "Điểm thi môn toán không hợp lệ.";
                    lblKetqua.ForeColor = System.Drawing.Color.Red;
                }
                else if (diemvan < 0)
                {
                    lblKetqua.Text = "Điểm thi môn văn không hợp lệ.";
                    lblKetqua.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    XL_HOCSINH hocsinh = new XL_HOCSINH();
                    hocsinh.Ma_so = txtMaSo.Text.Trim();
                    hocsinh.Ho_ten = txtHoTen.Text.Trim();
                    hocsinh.Dien_thoai = txtDienThoai.Text.Trim();
                    hocsinh.Diem_toan = diemtoan;
                    hocsinh.Diem_van = diemvan;
                    string kq = Ghi_noi_dung_xml(hocsinh);
                    lblKetqua.Text = kq;
                }
            }

        }

        string Ghi_noi_dung_xml(XL_HOCSINH hocsinh)
        {
            try
            {
                string path = Server.MapPath("~/My_Files/Hoc_sinh2.xml");

                XmlDocument tailieu = new XmlDocument();
                XmlElement root;
                if (File.Exists(path))
                {
                    tailieu.Load(path);
                    root = tailieu.DocumentElement;
                }
                else
                {
                    root = tailieu.CreateElement("DANH_SACH_HOC_SINH");
                    tailieu.AppendChild(root);
                }
                XmlElement nodeHocsinh = tailieu.CreateElement("HOC_SINH");
                XmlElement nodeMaso = tailieu.CreateElement(string.Empty, "Ma_so", string.Empty);
                XmlText maso = tailieu.CreateTextNode(hocsinh.Ma_so);
                nodeMaso.AppendChild(maso);

                XmlElement nodeHoten = tailieu.CreateElement(string.Empty, "Ho_ten", string.Empty);
                XmlText hoten = tailieu.CreateTextNode(hocsinh.Ho_ten);
                nodeHoten.AppendChild(hoten);

                XmlElement nodeDienthoai = tailieu.CreateElement(string.Empty, "Dien_thoai", string.Empty);
                XmlText dienthoai = tailieu.CreateTextNode(hocsinh.Dien_thoai);
                nodeDienthoai.AppendChild(dienthoai);

                XmlElement nodeDiemtoan = tailieu.CreateElement(string.Empty, "Diem_toan", string.Empty);
                XmlText diemtoan = tailieu.CreateTextNode(hocsinh.Diem_toan.ToString());
                nodeDiemtoan.AppendChild(diemtoan);

                XmlElement nodeDiemvan = tailieu.CreateElement(string.Empty, "Diem_van", string.Empty);
                XmlText diemvan = tailieu.CreateTextNode(hocsinh.Diem_van.ToString());
                nodeDiemvan.AppendChild(diemvan);
                
                nodeHocsinh.AppendChild(nodeMaso);
                nodeHocsinh.AppendChild(nodeHoten);
                nodeHocsinh.AppendChild(nodeDienthoai);
                nodeHocsinh.AppendChild(nodeDiemtoan);
                nodeHocsinh.AppendChild(nodeDiemvan);
                
                root.AppendChild(nodeHocsinh);
                tailieu.Save(path);
                return "Cập nhật hồ sơ học sinh '" + hocsinh.Ho_ten + "' thành công.";
            }
            catch(Exception ex)
            {
                return "Không ghi được dữ liệu";
            }
        }

        protected void btnDocFile_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/My_Files/Hoc_sinh2.xml");
            if (!File.Exists(path))
            {
                lblKetqua.Text = "Chưa có danh sách học sinh. Vui lòng nhập hồ sơ học sinh để tạo danh sách.";
                lblKetqua.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                XmlDocument tailieu = new XmlDocument();
                tailieu.Load(path);
                XmlNodeList arrayNode = tailieu.GetElementsByTagName("HOC_SINH");
                string kq = "";
                int dem = 0;
                foreach (XmlNode node in arrayNode)
                {

                    XL_HOCSINH hocsinh = new XL_HOCSINH();
                    hocsinh.Ma_so = node.SelectSingleNode("Ma_so").InnerText;
                    hocsinh.Ho_ten = node.SelectSingleNode("Ho_ten").InnerText;
                    hocsinh.Dien_thoai = node.SelectSingleNode("Dien_thoai").InnerText;
                    hocsinh.Diem_toan = float.Parse(node.SelectSingleNode("Diem_toan").InnerText);
                    hocsinh.Diem_van = float.Parse(node.SelectSingleNode("Diem_van").InnerText);
                    dem++;
                    kq += dem.ToString() + ". Mã số: " + hocsinh.Ma_so + " - Họ tên: " + hocsinh.Ho_ten + "<br />";
                    kq += "&nbsp;&nbsp;&nbsp;&nbsp;Điện thoại: " + hocsinh.Dien_thoai + " - Điểm thi: toán (" + hocsinh.Diem_toan.ToString() + ") văn(" + hocsinh.Diem_van.ToString() + ") - Điểm TB: " + hocsinh.Diem_tb.ToString() + "<br /><br />";

                }
                lblKetqua.Text = kq;
            }
        }
    }
}