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
    /// Interaction logic for FoglalasokUjWindow.xaml
    /// </summary>
    public partial class FoglalasokUjWindow : Window
    {
        public static int max_ejszakak = 14;
        public static int fizetendo_osszeg = 0;
        public static string[] allapotok = { "előjegyzett", "teljesült", "lemondott"};
        public FoglalasokUjWindow()
        {
            InitializeComponent();
            foreach (var szobaszam in MainWindow.szobak)
            {
                cbx_szobaszam.Items.Add(szobaszam.Szobaszam);
            }
            cbx_szobaszam.SelectedIndex = 0;
            for (int i = 1; i <= max_ejszakak; i++)
            {
                cbx_ejszaka.Items.Add(i);
            }
            cbx_ejszaka.SelectedIndex = 0;
            ArKalkulator();
            foreach(string allapot in allapotok)
            {
                cbx_allapot.Items.Add(allapot);
            }
            cbx_allapot.SelectedIndex = 0;
        }

        private void Btn_Foglalas_Click(object sender, RoutedEventArgs e)
        {
            if (tbx_nev.Text != "" && dtpk_erkezes.Text != "" && dtpk_tavozas.Text != "")
            {
                MainWindow.foglalasok.Add(new Foglalas(cbx_szobaszam.SelectedIndex + 1, tbx_nev.Text, DateTime.Parse(dtpk_erkezes.Text), DateTime.Parse(dtpk_tavozas.Text), cbx_fo.SelectedIndex + 1, cbx_ejszaka.SelectedIndex + 1, fizetendo_osszeg, cbx_allapot.SelectedItem.ToString()));
                Close();
            }
            else
            {
                MessageBox.Show("Hiányzó adat. Kérem adjon meg minden adatot!");
            }
        }

        private void Btn_Megse_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Cbx_Szobaszam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbx_fo.Items.Clear();
            for (int i = 1; i <= MainWindow.szobak[cbx_szobaszam.SelectedIndex].Ferohely; i++)
            {
                cbx_fo.Items.Add(i);
            }
            cbx_fo.SelectedIndex = 0;
            ArKalkulator();
        }

        private void Foglalasok_Window_Selection_Changed(object sender, SelectionChangedEventArgs e)
        {
            ArKalkulator();
        }

        public void ArKalkulator()
        {
            int fizetendo = 0;
            fizetendo = (int.Parse(cbx_ejszaka.SelectedIndex.ToString()) + 1) * MainWindow.szobak[int.Parse(cbx_szobaszam.SelectedIndex.ToString())].Ar * (int.Parse(cbx_fo.SelectedIndex.ToString()) + 1);
            tbk_fizetendo.Text = "Fizetendő: " + fizetendo.ToString() + " Ft";
            fizetendo_osszeg = fizetendo;
        }
    }
}
