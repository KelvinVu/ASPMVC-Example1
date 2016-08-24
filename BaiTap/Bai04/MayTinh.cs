using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai04
{
    public class MayTinh
    {
        #region Fields and properties
        private string _SoHieu;

        public string SoHieu
        {
            get { return _SoHieu; }
            set { _SoHieu = value; }
        }

        private int _DonGia;

        public int DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }

        private string _HangSanXuat;

        public string HangSanXuat
        {
            get { return _HangSanXuat; }
            set { _HangSanXuat = value; }
        }
        


        #endregion Constructors

        #region Constructors
        public MayTinh()
        {

        }
        public MayTinh(string SoHieu,int DonGia, string HangSanXuat)
        {
            this.SoHieu = SoHieu;
            this.DonGia = DonGia;
            this.HangSanXuat = HangSanXuat;
        }
        #endregion

        #region Methods

        public virtual string XuatThongTin()
        {
            string kq=" ";
            kq = string.Format("So Hieu La: {0}<br/> Don Gia La: {1}<br/> Hang San Xuat La: {2}<br/>",SoHieu,DonGia,HangSanXuat);
            return kq;

        }
        #endregion


    }

}