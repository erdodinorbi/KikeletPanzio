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

namespace KikeletPanzio
{
    /// <summary>
    /// Interaction logic for StatisztikakWindow.xaml
    /// </summary>
    public partial class StatisztikakWindow : Window
    {
        public static List<int> legtobbet_kiadott_szobaszamok = new List<int>();
        public StatisztikakWindow()
        {
            InitializeComponent();
            if (legtobbet_kiadott_szobaszamok.Count > 0)
            {
                int legtobbet_kiadott_szobaszam_index = MainWindow.foglalasok[0].Szobaszam;
                int legtobbet_kiadott_szobaszam_gyakorisaga = 0;
                for (int i = 0; i < MainWindow.foglalasok.Count; i++)
                {
                    if (MainWindow.foglalasok[i].Szobaszam > legtobbet_kiadott_szobaszam_index)
                    {
                        legtobbet_kiadott_szobaszam_index = MainWindow.foglalasok[i].Szobaszam;
                    }
                }
                legtobbet_kiadott_szobaszamok.Add(MainWindow.foglalasok[legtobbet_kiadott_szobaszam_index].Szobaszam);
                for (int i = 0; i < MainWindow.foglalasok.Count; i++)
                {
                    if (MainWindow.foglalasok[i].Szobaszam == legtobbet_kiadott_szobaszam_index)
                    {
                        legtobbet_kiadott_szobaszamok.Add(MainWindow.foglalasok[i].Szobaszam);
                    }
                }
                lstbx_visszajaro_vendegek.ItemsSource = legtobbet_kiadott_szobaszamok;
            }
        }

        private void Btn_Bezaras_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
