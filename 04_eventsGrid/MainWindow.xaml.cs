using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace _04_eventsGrid
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = "0";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = "0";
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "/";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "9";
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "X";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "6";
        }

        private void btnResta_click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "-";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "3";
        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "+";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "0";
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + ".";
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = tbTauler.Text + "=";
        }

        private void tbTauler_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
