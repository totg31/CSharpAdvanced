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

namespace WpfStreamReaderTest
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

        private void BtnFile_Click(object sender, RoutedEventArgs e)
        {
            FileStream fsRead = new FileStream(@"c:\oefeningen\MyTest.Txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsRead);
            string test = "";
            while (!sr.EndOfStream)
            {
                test += sr.ReadLine();
            }
            sr.Close();
            fsRead.Close();
            MessageBox.Show(test);
        }
        private void BestandOpslaan()
        {
            string bestand = @"c:\oefeningen\MyTest.txt";
            FileStream fs = new FileStream(bestand, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Volgorde van getallen:");
            for (int i = 0; i < 10; i++)
            {
                sw.Write(i + " ");
            }
            sw.WriteLine();

            sw.Close();
            fs.Close();
        }

        private void BtnNumbers_Click(object sender, RoutedEventArgs e)
        {
            BestandOpslaan();
        }
    }
}
