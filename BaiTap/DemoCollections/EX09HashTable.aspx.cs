using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Collections;
namespace BaiTap.Demo
{
    public partial class EX09HashTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Hashtable dsThang = new Hashtable();
            dsThang.Add(1, "Tháng Một");
            dsThang.Add(2, "Tháng Hai");
            dsThang.Add(3, "Tháng Ba");
            dsThang.Add(4, "Tháng Bốn");

            dsThang[5] = "Tháng Năm";
            dsThang[4] = "Tháng Tư";
            dsThang[1] = "Tháng Giêng";
            object gt = "Tháng Ba";

            // dsThang.ContainsValue("Tháng Ba") //--> false
            // dsThang.ContainsValue(gt) //--> true
            StringBuilder sb1 = new StringBuilder();
            // Duyệt trên tập hợp phần tử 
            foreach (DictionaryEntry pt in dsThang)
            {
                sb1.AppendLine(pt.Key + ": " + pt.Value);
            }
            
            StringBuilder sb2 = new StringBuilder();
            // Duyệt trên tập hợp keys 
            foreach (object pt in dsThang.Keys)
            {
                sb2.AppendFormat("Key là: {0}\r\n", pt);
            }
            
        }
    }
}