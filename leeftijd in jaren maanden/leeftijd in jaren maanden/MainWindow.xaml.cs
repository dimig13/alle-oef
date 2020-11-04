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
using System.Windows.Threading;

namespace leeftijd_in_jaren_maanden
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

        private void Btnberekenen_Click(object sender, RoutedEventArgs e)
        {
            DateTime vandaag;
            int aantaldagen, aantalmaanden, aantaljaren;

            //test datum invoer
            if(DateTime.TryParse(txtgeboortedatum.Text, out DateTime geboortedatum)== false)
            {
                MessageBox.Show("Geef correcte datum: \nFormaat:" +
                    "(dd-mm-yyyy) of (dd/mm/yyyy) of (dd.mm.yyyy)",
                    "geboortedatum", MessageBoxButton.OK
                    , MessageBoxImage.Error);
                txtgeboortedatum.SelectAll();
                txtgeboortedatum.Focus();
            }
            else
            {
                vandaag = DateTime.Today;

                //-- jaren en maanden---
                aantaljaren = vandaag.Year - geboortedatum.Year;
                 if(vandaag.Month< geboortedatum.Month ||
                    (vandaag.Month == geboortedatum.Month
                    && vandaag.Day < geboortedatum.Day))
                {
                    aantaljaren--;
                    aantalmaanden = (aantaljaren * 12) + vandaag.Month + 1;
                }
                else
                {
                    aantalmaanden = (aantaljaren * 12) - geboortedatum.Month
                        + vandaag.Month;
                }
                Txtjaren.Text = aantaljaren.ToString();

                //--dagen--
                // substract kan sec,min,uren en dagen halen uit datetime
                aantaldagen = vandaag.Subtract(geboortedatum).Days;
                Txtdagen.Text = aantaldagen.ToString();

                //aantalmaanden
                Txtmaanden.Text = aantalmaanden.ToString();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Title = $"Leeftijd in jaren, maanden en dagen voor" +
                $"{DateTime.Today.ToLongDateString()}";

            Lbltijd.Content = DateTime.Now.ToLongDateString()
                + " | " + DateTime.Now.ToLongTimeString();
            
            // Installeren van timer dmv de klasse aan te spreken.
            DispatcherTimer wekker = new DispatcherTimer();
            // Timer laten aflopen om de seconde.
            wekker.Tick += new EventHandler(DispatcherTimer_Tick);
            wekker.Interval = new TimeSpan(0, 0, 1); //uren, minuten, seconden
                                                     // Timer laten starten
            wekker.Start();
           
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            Lbltijd.Content = $"{DateTime.Now.ToLongDateString()}" +
                 $"{DateTime.Now.ToLongTimeString()}";
        }
    }
}
