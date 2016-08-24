using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class EX09SortedList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Săp xếp tăng dần theo key
            SortedList dsThang = new SortedList();
            dsThang.Add(2, "Tháng Hai"); //key,value
            dsThang.Add(3, "Tháng Ba");
            dsThang.Add(1, "Tháng Một");
            dsThang[4] = "Tháng Tư";

            //Truy xuất value theo key
            //? dsThang[2] --> "Tháng Hai"

            //Truy xuất key theo index
            //? dsThang.GetKey(1) -->2

            //Truy xuất value theo index
            //? dsThang.GetByIndex(1) --> "Tháng Hai"

            // Duyệt trên tập hợp phần tử 
            StringBuilder sb1 = new StringBuilder();
            foreach (DictionaryEntry pt in dsThang)
            {
                sb1.AppendLine(pt.Key + ": " + pt.Value);
            }


            string noiDung = "";
            for (int i = 0; i < dsThang.Count; i++)
            {
                noiDung += dsThang.GetKey(i) + " - " + dsThang.GetByIndex(i) + "<br/>";
                
            }

            StringBuilder sb2 = new StringBuilder();
            IDictionaryEnumerator n = dsThang.GetEnumerator();
            while (n.MoveNext())
            {
                sb2.AppendLine(n.Key + ": " + n.Value);

            }
        }
    }
}