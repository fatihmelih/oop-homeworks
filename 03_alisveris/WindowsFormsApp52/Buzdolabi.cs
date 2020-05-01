using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp52
{
    public class Buzdolabi : Urun
    {
        public int IcHacim;
        public string EnerjiSinifi;

        public Buzdolabi(int _HamFiyat)
        {
            StokAdedi = random.Next(1, 100);
            HamFiyat = _HamFiyat;
        }

        public double KdvUygula(int sayi)
        {
            return HamFiyat * 1.05 * sayi;
        }
    }
}
