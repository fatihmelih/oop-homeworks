using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp52
{
    public class LedTv : Urun
    {
        public int EkranBoyutu;
        public int EkranCozunurlugu;


        public LedTv(int _HamFiyat)
        {
            StokAdedi = random.Next(1, 100);
            HamFiyat = _HamFiyat;
        }
        public double KdvUygula(int sayi)
        {
            return HamFiyat * 1.18 * sayi;
        }
    }
}
