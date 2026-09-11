using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gra_w_kosci_2026_desktop
{
    public partial class MainWindow : Window
    {
        public Kosc[] Kosci = {
            new Kosc(0),
            new Kosc(0),
            new Kosc(0),
            new Kosc(0),
            new Kosc(0),
        };
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rzut(object sender, RoutedEventArgs e)
        {
            Image[] Obrazki = { Obrazek1, Obrazek2, Obrazek3, Obrazek4, Obrazek5 };
            int SumaWynikow = 0;

            for (int i = 0; i < Kosci.Length; i++)
            {
                Kosci[i].RzutKoscia();

                SumaWynikow += Kosci[i].LiczbaOczek;
                Wynik.Text = SumaWynikow.ToString();

                Obrazki[i].Source = new BitmapImage(
                    new Uri(
                        "/Obrazki/" + Kosci[i].NazwyPlikow[Kosci[i].IdentyfikatorPlikuGraficznego],
                        UriKind.Relative
                    )
                );
            }
        }

        private void Zablokuj(object sender, MouseButtonEventArgs e)
        {
            Image Obrazek = (Image)sender;
            int Numer = Convert.ToInt32(Obrazek.Tag);

            if (Kosci[Numer].CzyDostepna == true)
            {
                Kosci[Numer].ZablokujKosc();
                Obrazek.Opacity = 0.5;
            }
            else
            {
                Kosci[Numer].CzyDostepna = true;
                Obrazek.Opacity = 1;
            }

        }
    }
}