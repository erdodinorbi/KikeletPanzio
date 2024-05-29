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
    /// Interaction logic for UgyfelekModositWindow.xaml
    /// </summary>
    public partial class UgyfelekModositWindow : Window
    {
        public UgyfelekModositWindow()
        {
            InitializeComponent();
            tbx_nev.Text = MainWindow.ugyfelek[UgyfelekWindow.kivalasztott_ugyfel_index].Nev;
            dtpk_szuletesi_datum.Text = MainWindow.ugyfelek[UgyfelekWindow.kivalasztott_ugyfel_index].Szuletesi_datum.ToString();
            tbx_email.Text = MainWindow.ugyfelek[UgyfelekWindow.kivalasztott_ugyfel_index].Email;
            chbx_vip.IsChecked = MainWindow.ugyfelek[UgyfelekWindow.kivalasztott_ugyfel_index].Vip;
        }

        private void Btn_Modositas_Click(object sender, RoutedEventArgs e)
        {
            if (tbx_nev.Text != "" && dtpk_szuletesi_datum.Text != "" && tbx_email.Text != "")
            {
                int felhasznalo_mar_letezik = 0;
                for (int i = 0; i < MainWindow.ugyfelek.Count; i++)
                {
                    if (MainWindow.ugyfelek[i].Email == tbx_email.Text && i != UgyfelekWindow.kivalasztott_ugyfel_index)
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
                    MainWindow.ugyfelek[UgyfelekWindow.kivalasztott_ugyfel_index].Azonosito = tbx_nev.Text + DateTime.Now.ToString();
                    MainWindow.ugyfelek[UgyfelekWindow.kivalasztott_ugyfel_index].Nev = tbx_nev.Text;
                    MainWindow.ugyfelek[UgyfelekWindow.kivalasztott_ugyfel_index].Szuletesi_datum = DateTime.Parse(dtpk_szuletesi_datum.Text);
                    MainWindow.ugyfelek[UgyfelekWindow.kivalasztott_ugyfel_index].Email = tbx_email.Text;
                    MainWindow.ugyfelek[UgyfelekWindow.kivalasztott_ugyfel_index].Vip = chbx_vip.IsChecked.Value;
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
