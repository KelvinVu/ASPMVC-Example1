using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai04
{
    public class MayTinhDeBan:MayTinh
    {
        #region Fields and Properties

        private string _CPU;

        public string CPU
        {
            get { return _CPU; }
            set { _CPU = value; }
        }

        private string _RAM;

        public string RAM
        {
            get { return _RAM; }
            set { _RAM = value; }
        }

        #endregion

        #region Constructors
        public MayTinhDeBan()
        {

        }
        public MayTinhDeBan(string SoHieu, int DonGia,string HangSanXuat,string CPU, string RAM)
            :base (SoHieu,DonGia,HangSanXuat)
        {
            this.RAM = RAM;
            this.CPU = CPU;
        }
        #endregion

        #region Methods
        public override string XuatThongTin()
        {
            string kq = " ";
            kq = string.Format("May Tinh De Ban: So Hieu La: {0} Don Gia La: {1} Hang San Xuat La: {2}  RAM La: {3}  CPU La: {4}", SoHieu, DonGia, HangSanXuat,RAM,CPU);
            return kq;
        }
        #endregion

    }
}