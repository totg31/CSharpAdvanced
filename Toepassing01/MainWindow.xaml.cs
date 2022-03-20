using System;
using System.Collections.Generic;
using System.IO;
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

namespace Toepassing01
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
        private string bestand = @"c:\oefeningen\Email.Txt";
        private List<string> BestandConverteren(List<string> lstInhoud)

        private void BtnInlezen_Click(object sender, RoutedEventArgs e)
        {
            var lst = BestandOpenen();
            var lstInhoud = BestandConverteren(lst);
            foreach (var item in lstInhoud)
            {
                LstResultaat.Items.Add($"{item.Naam.PadRight(30)} : ");
            }
        }
        private List<string> BestandOpenen()
        {
            List<string> inputLines = new List<string>();
            using (FileStream fsRead = new FileStream(bestand, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fsRead))
                {
                    while (!sr.EndOfStream)
                    {
                        inputLines.Add(sr.ReadLine());
                    }
                    LstResultaat.ItemsSource = inputLines;
                }
            }
            return inputLines;
        }
        class Inhoud
        {
            public Inhoud(string inhoud)
            {
                var arr = inhoud.Split(',');
                if (arr.Length > 1)
                {
                    Naam = arr[0].Replace('"', ' ').Trim();
                    Email = arr[1].Replace('"', ' ').Trim();
                }
            }
            public string Naam { get; set; }
            public string Email { get; set; }
        }
        
        

        private List<string>
    }
}
