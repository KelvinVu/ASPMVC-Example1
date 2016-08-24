using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;

namespace BaiTap.Bai07
{
    public partial class Bai_07_05 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string Ghi_noi_dung_xml(XL_HOCSINH hocsinh)
        {
            try
            {
                string path = Server.MapPath("~/My_Files/Bai_07_05.xml");

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
                XmlElement addNode = tailieu.CreateElement("HOC_SINH");
                addNode.SetAttribute("Ma_so", hocsinh.Ma_so);
                addNode.SetAttribute("Ho_ten", hocsinh.Ho_ten);
                addNode.SetAttribute("Dien_thoai", hocsinh.Dien_thoai);
                addNode.SetAttribute("Diem_toan", hocsinh.Diem_toan.ToString());
                addNode.SetAttribute("Diem_van", hocsinh.Diem_van.ToString());
                root.AppendChild(addNode);
                tailieu.Save(path);
                return "Cập nhật hồ sơ học sinh '" + hocsinh.Ho_ten + "' thành công.";
            }
            catch
            {
                return "Không ghi được dữ liệu";
            }
        }

        protected void thGhitaptin_Click(object sender, EventArgs e)
        {
            if (thMaso.Text.Trim() == "")
            {
                thKetqua.Text = "Vui lòng nhập Mã số học sinh.";
                thKetqua.ForeColor = System.Drawing.Color.Red;
            }
            else if (thHoten.Text.Trim() == "")
            {
                thKetqua.Text = "Vui lòng nhập Họ tên học sinh.";
                thKetqua.ForeColor = System.Drawing.Color.Red;
            }
            else if (thDienthoai.Text.Trim() == "")
            {
                thKetqua.Text = "Vui lòng nhập Số điện thoại của học sinh.";
                thKetqua.ForeColor = System.Drawing.Color.Red;
            }
            else if (thDiemtoan.Text.Trim() == "")
            {
                thKetqua.Text = "Vui lòng nhập Điểm thi môn toán.";
                thKetqua.ForeColor = System.Drawing.Color.Red;
            }
            else if (thDiemtoan.Text.Trim() == "")
            {
                thKetqua.Text = "Vui lòng nhập Điểm thi môn văn.";
                thKetqua.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                float diemtoan = -1, diemvan = -1;
                float.TryParse(thDiemtoan.Text.Trim(), out diemtoan);
                float.TryParse(thDiemvan.Text.Trim(), out diemvan);
                if (diemtoan < 0)
                {
                    thKetqua.Text = "Điểm thi môn toán không hợp lệ.";
                    thKetqua.ForeColor = System.Drawing.Color.Red;
                }
                else if (diemvan < 0)
                {
                    thKetqua.Text = "Điểm thi môn văn không hợp lệ.";
                    thKetqua.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    XL_HOCSINH hocsinh = new XL_HOCSINH();
                    hocsinh.Ma_so = thMaso.Text.Trim();
                    hocsinh.Ho_ten = thHoten.Text.Trim();
                    hocsinh.Dien_thoai = thDienthoai.Text.Trim();
                    hocsinh.Diem_toan = diemtoan;
                    hocsinh.Diem_van = diemvan;
                    string kq = Ghi_noi_dung_xml(hocsinh);
                    thKetqua.Text = kq;
                }
            }
        }

        protected void thDoctaptin_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/My_Files/Bai_07_05.xml");
            if (!File.Exists(path))
            {
                thKetqua.Text = "Chưa có danh sách học sinh. Vui lòng nhập hồ sơ học sinh để tạo danh sách.";
                thKetqua.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                XmlDocument tailieu = new XmlDocument();
                tailieu.Load(path);
                XmlElement root = tailieu.DocumentElement;
                XmlNodeList arrayNode = root.GetElementsByTagName("HOC_SINH");
                string kq = "";
                int dem = 0;
                foreach (XmlNode node in arrayNode)
                {
                    if (node.NodeType == XmlNodeType.Element)
                    {
                        XL_HOCSINH hocsinh = new XL_HOCSINH();
                        hocsinh.Ma_so = node.Attributes["Ma_so"].Value;
                        hocsinh.Ho_ten = node.Attributes["Ho_ten"].Value;
                        hocsinh.Dien_thoai = node.Attributes["Dien_thoai"].Value;
                        hocsinh.Diem_toan = float.Parse(node.Attributes["Diem_toan"].Value);
                        hocsinh.Diem_van = float.Parse(node.Attributes["Diem_van"].Value);
                        dem++;
                        kq += dem.ToString() + ". Mã số: " + hocsinh.Ma_so + " - Họ tên: " + hocsinh.Ho_ten + "<br />";
                        kq += "&nbsp;&nbsp;&nbsp;&nbsp;Điện thoại: " + hocsinh.Dien_thoai + " - Điểm thi: toán (" + hocsinh.Diem_toan.ToString() + ") văn(" + hocsinh.Diem_van.ToString() + ") - Điểm TB: " + hocsinh.Diem_tb.ToString() + "<br /><br />";
                    }
                }
                thKetqua.Text = kq;
            }
        }
    }
}