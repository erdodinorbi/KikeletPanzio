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
    /// Interaction logic for SzobakUjWindow.xaml
    /// </summary>
    public partial class SzobakUjWindow : Window
    {
        public SzobakUjWindow()
        {
            InitializeComponent();
        }

        private void Btn_Regisztral_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbx_szobaszam.Text,out int int_szobaszam) && int.TryParse(tbx_ferohely.Text, out int int_ferohely) && int.TryParse(tbx_ar.Text, out int int_ar))
            {
                int szobaszam_mar_letezik = 0;
                for(int i = 0; i < MainWindow.szobak.Count; i++)
                {
                    if (MainWindow.szobak[i].Szobaszam == int.Parse(tbx_szobaszam.Text))
                    {
                        szobaszam_mar_letezik = 1;
                    }
                }
                if (szobaszam_mar_letezik == 1)
                {
                    MessageBox.Show("A megadott szobaszám már létezik. Kérem adjon meg egy másikat!");
                }
                else
                {
                    MainWindow.szobak.Add(new Szoba(int.Parse(tbx_szobaszam.Text), int.Parse(tbx_ferohely.Text), int.Parse(tbx_ar.Text)));
                    Close();
                }
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
