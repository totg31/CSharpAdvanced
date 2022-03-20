using ClassLibTest.FruitObjecten;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfFruitMand2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCitroen_Click(object sender, RoutedEventArgs e)
        {
            Fruit citroen = new Fruit();
            citroen.Naam = "citroen";
            citroen.Gewicht = 85;

            LstFruitmand.Items.Add(citroen.Info());
        }

        private void BtnAppel_Click(object sender, RoutedEventArgs e)
        {
            Fruit appel = new Fruit("appel", 107);
            LstFruitmand.Items.Add(appel);
        }

        private void BtnFruit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int gewicht = int.Parse(TxtGewicht.Text);
                Fruit f = new Fruit(TxtNaam.Text, gewicht);
                LstFruitmand.Items.Add(f);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
