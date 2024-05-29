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
    /// Interaction logic for Ugyfelek.xaml
    /// </summary>
    public partial class UgyfelekWindow : Window
    {
        public static List<Ugyfel> ugyfelek;
        public UgyfelekWindow()
        {
            List<Ugyfel> ugyfelek = new List<Ugyfel>();
            InitializeComponent();
            dgr_ugyfelek.ItemsSource = ugyfelek;
        }

        private void Btn_Regisztral_Click(object sender, RoutedEventArgs e)
        {
            string azonosito = tbx_nev.Text + DateTime.Now.ToString();
            ugyfelek.Add(new Ugyfel(azonosito, tbx_nev.Text, dtpk_szuletesi_datum.Text.ToString(), tbx_email.Text, chbx_vip.IsChecked.Value));
            dgr_ugyfelek.Items.Refresh();
        }

        private void Btn_Torles_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
