using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SachONL.Models;

namespace SachONL.Models
{
    public class GioHang
    {
        QLBanSachEntities1 db = new QLBanSachEntities1();
        public int iMasach { get; set; }
        public string sTenSach { get; set; }
        public string sAnhBia { get; set; }
        public double dDonGia { get; set; }
        public int iSoLuong { get; set; }
        public double dThanhTien { get { return iSoLuong * dDonGia; } }

        public GioHang(int ms)
        {
            iMasach = ms;
            SACH s = db.SACHes.Single(n => n.MaSach == iMasach);
            sTenSach = s.TenSach;
            sAnhBia = s.HinhMinhHoa;
            dDonGia = double.Parse(s.DonGia.ToString());
            iSoLuong = 1;
        }
    }
}