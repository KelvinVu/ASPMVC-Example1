using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai03
{
    public class Diem
    {
        #region Properties

        public int X { get; set; }
        public int Y { get; set; }

        #endregion

        #region Constructors
        public Diem() { }
        public Diem(int x ,int y) 
        {
            X = x;
            Y = y;
        }


        #endregion

        #region methods
        public double KhoangCach(Diem d)
        {
            double ketQua = Math.Sqrt((d.X - X) * (d.X - X) + (d.Y - Y) * (d.Y - Y));
            return ketQua;

        }

        public static Diem Parse(string chuoi)
        {

            Diem a = new Diem();
            string[] s;
            s = chuoi.Split(',');
            a.X =int.Parse(s[0]);
            a.Y = int.Parse(s[1]);
            return a;

        }
        #endregion
    }
}