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
using System.IO;

namespace KikeletPanzio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Szoba> szobak = new List<Szoba>();
        public static List<Ugyfel> ugyfelek = new List<Ugyfel>();
        public static List<Foglalas> foglalasok = new List<Foglalas>();
        public MainWindow()
        {
            InitializeComponent();
            string[] sorok = File.ReadAllLines("szobak.txt");
            foreach (string sor in sorok)
            {
                MainWindow.szobak.Add(new Szoba(sor));
            }
        }

        private void Btn_Szobak_Click(object sender, RoutedEventArgs e)
        {
            SzobakWindow szobakWindow = new SzobakWindow();
            szobakWindow.Show();
        }

        private void Btn_Regisztracio_Click(object sender, RoutedEventArgs e)
        {
            UgyfelekWindow ugyfelekWindow = new UgyfelekWindow();
            ugyfelekWindow.Show();
        }

        private void Btn_Foglalas_Click(object sender, RoutedEventArgs e)
        {
            FoglalasokWindow foglalasokWindow = new FoglalasokWindow();
            foglalasokWindow.Show();
        }

        private void Btn_Statisztikak_Click(object sender, RoutedEventArgs e)
        {
            StatisztikakWindow statisztikakWindow = new StatisztikakWindow();
            statisztikakWindow.Show();
        }
    }
}
