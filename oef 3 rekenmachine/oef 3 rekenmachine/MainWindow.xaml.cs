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

namespace oef_3_rekenmachine
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

        private float getal1, getal2;

        private void Btnplus_Click(object sender, RoutedEventArgs e)
        {
            getal1 = Convert.ToSingle(Txtgetal1.Text);
            getal2 = Convert.ToSingle(Txtgetal2.Text);

            txtresultaat.Text = Convert.ToString(getal1 + getal2);
        }

        private void Btnmaal_Click(object sender, RoutedEventArgs e)
        {
            getal1 = Convert.ToSingle(Txtgetal1.Text);
            getal2 = Convert.ToSingle(Txtgetal2.Text);

            txtresultaat.Text = Convert.ToString(getal1 * getal2);
        }

        private void Btnmin_Click(object sender, RoutedEventArgs e)
        {
            getal1 = Convert.ToSingle(Txtgetal1.Text);
            getal2 = Convert.ToSingle(Txtgetal2.Text);

            txtresultaat.Text = Convert.ToString(getal1 - getal2);
        }

        private void Btndeel_Click(object sender, RoutedEventArgs e)
        {
            getal1 = Convert.ToSingle(Txtgetal1.Text);
            getal2 = Convert.ToSingle(Txtgetal2.Text);

            txtresultaat.Text = Convert.ToString(getal1/getal2);

        }

       

        private void Btnwissen_Click(object sender, RoutedEventArgs e)
        {
            Txtgetal1.Text = "0";
            Txtgetal2.Text = "0";
            txtresultaat.Text = string.Empty;

            Txtgetal1.Focus();
        }
    }
}
