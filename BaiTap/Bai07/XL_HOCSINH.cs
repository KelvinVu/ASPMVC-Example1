using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai07
{
    public class XL_HOCSINH
    {

        public string Ma_so { get; set; }
        public string Ho_ten { get; set; }
        public string Dien_thoai { get; set; }
        public float Diem_toan { get; set; }
        public float Diem_van { get; set; }
        public float Diem_tb
        {
            get
            {
                return (Diem_toan + Diem_van) / 2;
            }
        }
        public XL_HOCSINH()
        {
        }

    }
}