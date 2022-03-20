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
using WpfVoertuig.Data;

namespace WpfVoertuig
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Auto bmw = new Auto();
            bmw.MerkNaam = "BMW";
            Fiets f = new Fiets("Minerva");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(bmw.AutoInfo);
            sb.AppendLine(bmw.Info());
            sb.AppendLine(f.FietsInfo);
            TxtResult.Text = sb.ToString();
        }
    }
}
