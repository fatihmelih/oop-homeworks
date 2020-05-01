using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp52
{
    public class Laptop : Urun
    {
        
        public int EkranBoyutu;
        public int EkranCozunurluk;
        public int DahiliHafiza;
        public int RamKapasitesi;
        public int PilGucu;

        public Laptop(int _HamFiyat)
        {
            StokAdedi = random.Next(1, 100);
            HamFiyat = _HamFiyat;
        }
        public double KdvUygula(int sayi)
        {
            return HamFiyat * 1.15 * sayi;
        }
    }
}