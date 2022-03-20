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
    /// Interaction logic for WpfLector.xaml
    /// </summary>
    public partial class WpfLector : Window
    {
        public WpfLector()
        {
            InitializeComponent();
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            WpfPersoon wpf = new WpfPersoon();
            wpf.ShowDialog();
            Lector l = new Lector(wpf.Persoon);
            l.InDienst = DtmInDienst.SelectedDate.GetValueOrDefault();
            l.Afdeling = TxtAfdeling.Text;
            Repository.Lectoren.Add(l);
        }
    }
}
