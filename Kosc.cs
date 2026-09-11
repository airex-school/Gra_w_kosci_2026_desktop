using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_kosci_2026_desktop
{
    public class Kosc
    {
        public static int LiczbaInstancji;
        public string[] NazwyPlikow = { "kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png" };
        public int LiczbaOczek;
        public int IdentyfikatorPlikuGraficznego;
        public bool CzyDostepna;

        public Kosc(int WartoscWyrzuconejKosci)
        {
            int[] DozwoloneLiczby = { 1, 2, 3, 4, 5, 6 };
            if (!DozwoloneLiczby.Contains(WartoscWyrzuconejKosci))
            {
                WartoscWyrzuconejKosci = 0;
            }

            this.LiczbaOczek = WartoscWyrzuconejKosci;
            this.IdentyfikatorPlikuGraficznego = WartoscWyrzuconejKosci;
            this.CzyDostepna = true;
            Kosc.LiczbaInstancji++;
        }

        public Kosc()
        {
            int LosowaLiczba = new Random().Next(1, 7);
            this.LiczbaOczek = LosowaLiczba;
            this.IdentyfikatorPlikuGraficznego = LosowaLiczba;
            this.CzyDostepna = true;
            Kosc.LiczbaInstancji++;
        }

        public void RzutKoscia()
        {
            if (CzyDostepna == true)
            {
                int LosowaLiczba = new Random().Next(1, 7);
                this.LiczbaOczek = LosowaLiczba;
                this.IdentyfikatorPlikuGraficznego = LosowaLiczba;
            }
        }

        public void ZablokujKosc()
        {
            this.CzyDostepna = false;
        }

        public string ZwrocWyrzuconaWartosc()
        {
            string[] Wartosci = { "jeden", "dwa", "trzy", "cztery", "pięć", "sześć" };
            string WartoscSlownie = Wartosci[this.LiczbaOczek - 1];
            return WartoscSlownie;
        }
    }
}
