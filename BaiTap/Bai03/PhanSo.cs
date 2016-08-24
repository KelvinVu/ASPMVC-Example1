using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace BaiTap.Bai03
{
    public class PhanSo
    {
        #region properties
        private int _TuSo;

        public int TuSo
        {
            get { return _TuSo; }
            set { _TuSo = value; }
        }
        private int _MauSo;

        public int MauSo
        {
            get { return _MauSo; }
            set 
            {
                if (value == 0) throw new Exception("mau so phai khac 0");
                _MauSo = value; 
            }
        }
        #endregion

        #region Phương thức khởi tạo
        public PhanSo() 
        {
            _TuSo = 1;
            _MauSo = 1;
        } //khởi tạo không tham số
        public PhanSo(int tuSo,int mauSo)//khởi tạo có tham số
        {
            new PhanSo();
            TuSo = tuSo;
            MauSo = mauSo;
        }

        #endregion

        #region method

        public string Xuat()
        {
            string trave = _TuSo + "/" + _MauSo;
            return trave;

        }
        public static PhanSo Parse(string chuoi)
        {
            string[] mangchuoi=chuoi.Split('/');
            int tuSo = int.Parse(mangchuoi[0]);
            int mauSo = int.Parse(mangchuoi[1]);
            return new PhanSo(tuSo, mauSo);

        }
        private static int uscln(int soA,int soB)
        {
            soA = Math.Abs(soA);
            soB = Math.Abs(soB);
            int min = Math.Min(soA, soB);
            int kq = 1;
            for(int i=min;i>=1;i--)
            {
                if((soA%i)==0&&soB%i==0)
                {
                    kq = i;
                    break;

                }

            }
            return kq;

        }
        private static PhanSo ToiGian(PhanSo p)
        {
            if (p.TuSo == 0) return p;
            PhanSo kq = new PhanSo();
            int us= uscln(p._TuSo,p._MauSo);
            kq.TuSo=p._TuSo/us;
            kq.MauSo=p._MauSo/us;
            return kq;

        }
        public PhanSo Cong(PhanSo p)
        {
            PhanSo kq=new PhanSo();
            kq.TuSo = _TuSo * p._MauSo + _MauSo * p.TuSo;
            kq.MauSo = _MauSo * p._MauSo;
            kq = ToiGian(kq);
            return kq;
        }
        #endregion

        #region operator
        public static PhanSo operator +(PhanSo ps1,PhanSo ps2)
        {
            return ps1.Cong(ps2);

        }
        public static bool operator ==(PhanSo ps1, PhanSo ps2)
        {
            bool kq=false;
            ps1 = ToiGian(ps1);
            ps2 = ToiGian(ps2);
            if (ps1.TuSo == ps2.TuSo && ps1.MauSo == ps2.MauSo) kq = true;
            return kq;

        }
        public static bool operator !=(PhanSo ps1, PhanSo ps2)
        {
            bool kq = false;
            ps1 = ToiGian(ps1);
            ps2 = ToiGian(ps2);
            if (ps1.TuSo != ps2.TuSo || ps1.MauSo != ps2.MauSo) kq = true;
            return kq;
        }

        #endregion
    }
}