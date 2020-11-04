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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace verwachte_lengte_oef_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnBerkenen_Click(object sender, RoutedEventArgs e)
        {
            float lengte;

            // Controle juistheid van gegevens

            if (float.TryParse(TxtLengteVader.Text, out float lengteVader) == false)
            {
                MessageBox.Show("Geef een correct lengte voor vader op!", "Foute invoer", MessageBoxButton.OK, MessageBoxImage.Warning);
                TxtLengteVader.SelectAll();
                TxtLengteVader.Focus();
            }

            else if (float.TryParse(TxtLengteMoeder.Text, out float lengteMoeder) == false)
            {
                MessageBox.Show("Geef een correct lengte voor moeder op!", "Foute invoer", MessageBoxButton.OK, MessageBoxImage.Warning);
                TxtLengteMoeder.SelectAll();
                TxtLengteMoeder.Focus();
            }

            else if (RadMeisje.IsChecked == true)
            {
                lengte = (lengteVader + lengteMoeder - 13) / 2 + 4.5f;
                TxtLengteMeisje.Text = $"{lengte:f2}";
            }

            else 
            {
                lengte = (lengteVader + lengteMoeder + 13) / 2 + 4.5f;
                TxtLengteJongen.Text = $"{lengte:f2}";
            }
        }

        private void RadJongen_Checked(object sender, RoutedEventArgs e)
        {
            // Enabled zetten
            TxtLengteMeisje.IsEnabled = false;
            TxtLengteMeisje.Clear();
            TxtLengteJongen.IsEnabled = true;
        }

        private void RadMeisje_Checked(object sender, RoutedEventArgs e)
        {
            // Disabled tekst wissen
            TxtLengteJongen.IsEnabled = false;
            TxtLengteJongen.Clear();
            TxtLengteMeisje.IsEnabled = true;
        }

        private void Afsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
