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

namespace Toepassing07
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
        Bankrekening bankRekening = new Bankrekening();
        public void TxtBedrag_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return)
                {
                    decimal bedrag = 0;
                    if (decimal.TryParse(TxtBedrag.Text, out bedrag))
                    {
                        if (bedrag > 0)
                        {
                            bankRekening.Storting(bedrag);
                            TxtStandRekening.Text = bankRekening.HuidigeSaldo.ToString("N2");
                        }
                        else
                        {
                            bankRekening.OpnameBedrag(bedrag);
                            TxtStandRekening.Text = bankRekening.HuidigeSaldo.ToString("N2");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
