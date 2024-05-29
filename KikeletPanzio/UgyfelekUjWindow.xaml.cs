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
    /// Interaction logic for UgyfelekUjWindow.xaml
    /// </summary>
    public partial class UgyfelekUjWindow : Window
    {
        public UgyfelekUjWindow()
        {
            InitializeComponent();
        }

        private void Btn_Regisztral_Click(object sender, RoutedEventArgs e)
        {
            if (tbx_nev.Text != "" && dtpk_szuletesi_datum.Text != "" && tbx_email.Text != "")
            {
                int felhasznalo_mar_letezik = 0;
                for (int i = 0; i < MainWindow.ugyfelek.Count; i++)
                {
                    if (MainWindow.ugyfelek[i].Email == tbx_email.Text)
                    {
                        felhasznalo_mar_letezik = 1;
                    }
                }
                if (felhasznalo_mar_letezik == 1)
                {
                    MessageBox.Show("A megadott email cím már létezik. Kérem adjon meg egy másikat!");
                }
                else
                {
                    string azonosito = tbx_nev.Text + DateTime.Now.ToString();
                    MainWindow.ugyfelek.Add(new Ugyfel(azonosito, tbx_nev.Text, DateTime.Parse(dtpk_szuletesi_datum.Text), tbx_email.Text, chbx_vip.IsChecked.Value));
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Hiányos adat. Kérem adjon meg minden adatot!");
            }
        }

        private void Btn_Megse_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
