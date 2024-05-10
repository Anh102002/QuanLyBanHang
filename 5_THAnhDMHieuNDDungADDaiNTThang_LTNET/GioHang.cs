using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_THAnhDMHieuNDDungADDaiNTThang_LTNET
{
    internal class GioHang
    {
        private string mahang;
        private string tenhang;
        private int soluong;
        private string dvt;
        private float dongia;
        private float thanhtien;

        public GioHang()
        {

        }
        public GioHang(string mahang, string tenhang, int soluong, string dvt, float dongia, float thanhtien)
        {
            this.mahang = mahang;
            this.tenhang = tenhang;
            this.soluong = soluong;
            this.dvt = dvt;
            this.dongia = dongia;
            this.thanhtien = thanhtien;
        }

        public string Mahang
        {
            get { return mahang; }
            set { mahang = value; }
        }
        public string Tenhang
        {
            get { return tenhang; }
            set { tenhang = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public string Dvt
        {
            get { return dvt; }
            set { this.dvt = value; }
        }
        public float Dongia
        {
            get { return dongia; }
            set
            {
                dongia = value;
            }
        }
        public float Thanhtien
        {
            get { return thanhtien; }
            set
            {
                thanhtien = value;
            }
        }
    }
}
