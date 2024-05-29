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
    /// Interaction logic for UgyfelekWindow.xaml
    /// </summary>
    public partial class UgyfelekWindow : Window
    {
        public static int kivalasztott_ugyfel_index = -1;
        public UgyfelekWindow()
        {
            InitializeComponent();
            dgr_ugyfelek.ItemsSource = MainWindow.ugyfelek;
        }

        private void Btn_Uj_Ugyfel_Click(object sender, RoutedEventArgs e)
        {
            UgyfelekUjWindow ugyfelekUjWindow = new UgyfelekUjWindow();
            ugyfelekUjWindow.ShowDialog();
            dgr_ugyfelek.Items.Refresh();
        }

        private void Btn_Torles_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.ugyfelek.RemoveAt(dgr_ugyfelek.SelectedIndex);
            dgr_ugyfelek.Items.Refresh();
        }

        private void Btn_Modositas_Click(object sender, RoutedEventArgs e)
        {
            UgyfelekModositWindow ugyfelekModositWindow = new UgyfelekModositWindow();
            ugyfelekModositWindow.ShowDialog();
            dgr_ugyfelek.Items.Refresh();
        }

        private void Dgr_Ugyfelek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            kivalasztott_ugyfel_index = dgr_ugyfelek.SelectedIndex;
            if (kivalasztott_ugyfel_index > -1)
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
