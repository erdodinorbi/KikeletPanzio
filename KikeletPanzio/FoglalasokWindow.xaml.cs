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
    /// Interaction logic for FoglalasokWindow.xaml
    /// </summary>
    public partial class FoglalasokWindow : Window
    {
        public static int kivalasztott_foglalas_index = -1;
        public FoglalasokWindow()
        {
            InitializeComponent();
            dgr_foglalasok.ItemsSource = MainWindow.foglalasok;
        }

        private void Btn_Uj_Szoba_Foglalasa_Click(object sender, RoutedEventArgs e)
        {
           FoglalasokUjWindow foglalasokUjWindow = new FoglalasokUjWindow();
           foglalasokUjWindow.ShowDialog();
           dgr_foglalasok.Items.Refresh();
        }

        private void Btn_Torles_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.foglalasok.RemoveAt(dgr_foglalasok.SelectedIndex);
            dgr_foglalasok.Items.Refresh();
        }

        private void Btn_Modositas_Click(object sender, RoutedEventArgs e)
        {
            FoglalasokModositWindow foglalasokModositWindow = new FoglalasokModositWindow();
            foglalasokModositWindow.ShowDialog();
            dgr_foglalasok.Items.Refresh();
        }

        private void Dgr_Foglalasok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            kivalasztott_foglalas_index = dgr_foglalasok.SelectedIndex;
            if (kivalasztott_foglalas_index > -1)
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
