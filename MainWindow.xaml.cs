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
            foreach (Kosc k in Kosci)
            {
                k.RzutKoscia();

            }
        }
    }
}