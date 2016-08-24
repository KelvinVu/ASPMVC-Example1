using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Demo
{
    public class HocSinh
    {
        #region property
        //Full property
        string _MaSo;//Field - biến thành viên
        public string MaSo
        {
            get { return _MaSo; } // trả về giá trị lưu trữ trong biến thành viên
            set { _MaSo=value;  } // gán giá trị vào biến thành viên
        }
        //Auto-Implemented property

        public string HoTen{ get ; set ; }
        public string DiaChi { get; set; }

        private float _Toan;

        public float Toan
        {
            get { return _Toan; }
            set 
            {
                if (value < 0 || value > 10) throw new Exception("điểm phải từ 0 đến 10");
                _Toan = value; 
            }
        }
        private float _Van;

        public float Van
        {
            get { return _Van; }
            set 
            {
                if (value < 0 || value > 10) throw new Exception("điểm phải từ 0 đến 10");
                _Van = value;
            }
        }

        #endregion

        public float DiemTrungBinh()
        {
            float kq = 0;
            kq = (_Van + _Toan * 2) / 3;
            return kq;

        }
    }
}