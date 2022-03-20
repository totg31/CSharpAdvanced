using Oefening16.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Oefening16
{
    /// <summary>
    /// Interaction logic for WpfPersoon.xaml
    /// </summary>
    public partial class WpfPersoon : Window
    {
        public Persoon Persoon { get; set; }
        public WpfPersoon()
        {
            InitializeComponent();
            Persoon = new Persoon();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Persoon.Voornaam = TxtVoornaam.Text;
            Persoon.Naam = TxtNaam.Text;
            Persoon.GeboorteDatum = DtmGeboorteDatum.SelectedDate.GetValueOrDefault();
            Repository.Personen.Add(Persoon);
        }
    }
}
