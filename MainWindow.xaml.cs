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

namespace Calculator_WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _lastNumber, _result;

        public MainWindow()
        {
            InitializeComponent();

            aCButton.Click += ACButton_Click;
            negativeButton.Click += NegativeButton_Click;
        }

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ACButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
                resultLabel.Content = "7";
            else
                resultLabel.Content += "7";
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
