using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai03
{
    public class PhuongTrinhBac1
    {
        #region properties
        public float HeSoA { get; set; }
        public float HeSoB { get; set; }
        #endregion

        #region Constructor
        public PhuongTrinhBac1() { }
        public PhuongTrinhBac1(float A,float B) 
        {
            HeSoA = A;
            HeSoB = B;
        }

        #endregion

        #region method
        public string Giai()
        {
            string ketQua=" ";
            float nghiem = 0;
            if(HeSoA==0)
            {
                if (HeSoB == 0)
                    ketQua = "phuong trinh co vo so nghiem";
                else
                    ketQua = "phuon trinh vo nghiem";

            }
            else
            {
                nghiem = -HeSoB / HeSoA;
                ketQua = string.Format("phuong trinh co nghiem= {0}", nghiem);

            }


            return ketQua;

        }

        #endregion

    }
}