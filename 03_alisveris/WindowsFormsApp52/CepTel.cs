using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp52
{
    public class CepTel : Urun
    {
        public int DahiliHafiza;
        public int RamKapasitesi;
        public int PilGucu;

        public CepTel(int _HamFiyat)
        {
            StokAdedi = random.Next(1, 100);
            HamFiyat = _HamFiyat;
        }
        public double KdvUygula(int sayi)
        {
            return HamFiyat * 2 * sayi;
        }
    }
}
