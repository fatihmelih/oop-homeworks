using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{

    public class Atik : IAtik
    {
		private int hacim;
		public string atikIsmi;

		private System.Drawing.Image image;

		public System.Drawing.Image Image
		{
			get { return image; }
			set { image = value; }
		}

		public int Hacim
		{
			get { return hacim; }
			set { hacim = value; }
		}

		public Atik(string isim, int _Hacim)
		{
			Hacim = _Hacim;
			atikIsmi = isim;
		}

	}
}
