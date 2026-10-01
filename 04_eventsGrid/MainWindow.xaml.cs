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

        // NUMEROS //////////////////////////////////////////////////////////////////////////////////////
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "9";                        //9
            }
            else
            {
                tbTauler.Text = "9";
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "8";                        //8
            }
            else
            {
                tbTauler.Text = "8";
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "7";                        //7
            }
            else
            {
                tbTauler.Text = "7";
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "6";                        //6
            }
            else
            {
                tbTauler.Text = "6";
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "5";                        //5
            }
            else
            {
                tbTauler.Text = "5";
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "4";                        //4
            }
            else
            {
                tbTauler.Text = "4";
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "3";                        //3
            }
            else
            {
                tbTauler.Text = "3";
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "2";                        //2
            }
            else
            {
                tbTauler.Text = "2";
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "1";                        //1
            }
            else
            {
                tbTauler.Text = "1";
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "0";                        //0
            }
        }



        // OPERACIONS //////////////////////////////////////////////////////////////////////////////////////////
        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "+";                        //+
            }
        }

        private void btnResta_click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "-";                        //-
            }
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "X";                        //X
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "/";                        ///
            }
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + "=";                        //=
            }
        }



        // ALTRES ////////////////////////////////////////////////////////////////////////////////////////////
        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = "0";                                            //CE
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            tbTauler.Text = "0";                                            //C
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (tbTauler.Text != "0")
            {
                tbTauler.Text = tbTauler.Text + ".";                        //.
            }
        }































        
    }
}
