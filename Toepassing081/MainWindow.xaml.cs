using ClassLibTest.TellerObjecten;
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

namespace Toepassing081
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Teller teller = new Teller();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLezen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(teller.Counter.ToString());
        }

        private void BtnVerhoog_Click(object sender, RoutedEventArgs e)
        {
            teller.VerhoogTeller();
        }

        private void BtnVerlaag_Click(object sender, RoutedEventArgs e)
        {
            teller.VerminderTeller();
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            teller.ResetTeller();
        }

        private void BtnWaarde_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int waarde = int.Parse(TxtWaarde.Text);
                teller.Waarde(waarde);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEinde_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
