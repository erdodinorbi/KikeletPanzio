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
using System.IO;

namespace KikeletPanzio
{
    /// <summary>
    /// Interaction logic for SzobakWindow.xaml
    /// </summary>
    public partial class SzobakWindow : Window
    {
        public static int kivalasztott_szoba_index = -1;
        public SzobakWindow()
        {
            InitializeComponent();
            dgr_szobak.ItemsSource = MainWindow.szobak;
        }

        private void Btn_Uj_Szoba_Click(object sender, RoutedEventArgs e)
        {
            SzobakUjWindow szobakUjWindow = new SzobakUjWindow();
            szobakUjWindow.ShowDialog();
            dgr_szobak.Items.Refresh();
        }

        private void Btn_Torles_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.szobak.RemoveAt(dgr_szobak.SelectedIndex);
            dgr_szobak.Items.Refresh();
        }

        private void Btn_Modositas_Click(object sender, RoutedEventArgs e)
        {
            SzobakModositWindow szobakModositWindow = new SzobakModositWindow();
            szobakModositWindow.ShowDialog();
            dgr_szobak.Items.Refresh();
        }

        private void Dgr_Szobak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            kivalasztott_szoba_index = dgr_szobak.SelectedIndex;
            if (kivalasztott_szoba_index > -1)
            {
                btn_modositas.IsEnabled = true;
                btn_torles.IsEnabled = true;
            }
            else
            {
                btn_modositas.IsEnabled = false;
                btn_torles.IsEnabled = false;
            }
        }

        private void Btn_Bezaras_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
