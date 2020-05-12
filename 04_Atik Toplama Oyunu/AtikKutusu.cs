using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class AtikKutusu : IAtikKutusu
    {
        public int BosaltmaPuani { get; set; }
        public int Kapasite { get; set; }
        public int DoluHacim { get; set; }
        public int DolulukOrani { get; set; }



        public bool Bosalt()
        {
            if (DolulukOrani > 75)
            {
                DoluHacim = 0;
                return true;
            }
            return false;
        }

        public bool Ekle(Atik atik)
        {
            DoluHacim += atik.Hacim;
            DolulukOrani += atik.Hacim * 100 / Kapasite;
            return true;
        }

        public AtikKutusu(int _BosaltmaPuani, int _Kapasite)
        {
            BosaltmaPuani = _BosaltmaPuani;
            Kapasite = _Kapasite;
        }
    }
}
