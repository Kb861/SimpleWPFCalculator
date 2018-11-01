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

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double variable;
        char sign;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            txt_wypisz.AppendText("1"); 
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            txt_wypisz.AppendText("2");
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            txt_wypisz.AppendText("3");
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            txt_wypisz.AppendText("4");
        }
        private void b5_Click(object sender, RoutedEventArgs e)
        {
            txt_wypisz.AppendText("5");
        }
        private void b6_Click(object sender, RoutedEventArgs e)
        {
            txt_wypisz.AppendText("6");
        }
        private void b7_Click(object sender, RoutedEventArgs e)
        {
            txt_wypisz.AppendText("7");

        }
        private void b8_Click(object sender, RoutedEventArgs e)
        {
            txt_wypisz.AppendText("8");
        }
        private void b9_Click(object sender, RoutedEventArgs e)
        {
            txt_wypisz.AppendText("9");
        }

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            variable = double.Parse(txt_wypisz.Text);
      
            sign = '+'; 
            txt_wypisz.Clear();               
        }

        private void bWynik_Click(object sender, RoutedEventArgs e)
        {
            switch (sign) 
            {
                case '+':
                    txt_wypisz.Text = (variable + double.Parse(txt_wypisz.Text)).ToString();
                    break;
                case '-':
                    txt_wypisz.Text = (variable - double.Parse(txt_wypisz.Text)).ToString();
                    break;
            }
        }

        private void bOdejmij_Click(object sender, RoutedEventArgs e)
        {
            variable = double.Parse(txt_wypisz.Text);
            sign = '-';
            txt_wypisz.Clear();
        }
    }
}

