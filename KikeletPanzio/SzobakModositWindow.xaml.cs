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
    /// Interaction logic for SzobakModositWindow.xaml
    /// </summary>
    public partial class SzobakModositWindow : Window
    {
        public SzobakModositWindow()
        {
            InitializeComponent();
            tbx_szobaszam.Text = MainWindow.szobak[SzobakWindow.kivalasztott_szoba_index].Szobaszam.ToString();
            tbx_ferohely.Text = MainWindow.szobak[SzobakWindow.kivalasztott_szoba_index].Ferohely.ToString();
            tbx_ar.Text = MainWindow.szobak[SzobakWindow.kivalasztott_szoba_index].Ar.ToString();
        }

        private void Btn_Modositas_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbx_szobaszam.Text, out int int_szobaszam) && int.TryParse(tbx_ferohely.Text, out int int_ferohely) && int.TryParse(tbx_ar.Text, out int int_ar))
            {
                MainWindow.szobak[SzobakWindow.kivalasztott_szoba_index].Szobaszam = int.Parse(tbx_szobaszam.Text);
                MainWindow.szobak[SzobakWindow.kivalasztott_szoba_index].Ferohely = int.Parse(tbx_ferohely.Text);
                MainWindow.szobak[SzobakWindow.kivalasztott_szoba_index].Ar = int.Parse(tbx_ar.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Hibás szám adat lett megadva. Kérem adjon meg valós számokat!");
            }
        }

        private void Btn_Megse_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
