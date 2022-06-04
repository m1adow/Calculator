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
        private SelectedOperator _selectedOperator;
        private SimpleMath _simpleMath;

        public MainWindow()
        {
            InitializeComponent();

            aCButton.Click += ACButton_Click;
            negativeButton.Click += NegativeButton_Click;
            percentageButton.Click += PercentageButton_Click;
            equalButton.Click += EqualButton_Click;
            _simpleMath = new SimpleMath();
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out double newNumber))
            {
                switch (_selectedOperator)
                {
                    case SelectedOperator.Addition:
                        _result = _simpleMath.Add(_lastNumber, newNumber);
                        break;
                    case SelectedOperator.Subtraction:
                        _result = _simpleMath.Subtract(_lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        _result = _simpleMath.Multiply(_lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                        _result = _simpleMath.Divide(_lastNumber, newNumber);
                        break;
                }

                resultLabel.Content = _result.ToString();
            }
        }

        private void PercentageButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out double temporaryNumber))
            {
                temporaryNumber /= 100;

                if (_lastNumber != 0)
                    temporaryNumber *= _lastNumber;

                resultLabel.Content = temporaryNumber.ToString();
            }
        }

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out _lastNumber))
            {
                _lastNumber = -1 * _lastNumber;
                resultLabel.Content = _lastNumber.ToString();
            }
        }

        private void ACButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            _result = 0;
            _lastNumber = 0;
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out _lastNumber))
                resultLabel.Content = "0";

            if (sender == additionButton)
                _selectedOperator = SelectedOperator.Addition;
            if (sender == subtractionButton)
                _selectedOperator = SelectedOperator.Subtraction;
            if (sender == multiplicationButton)
                _selectedOperator = SelectedOperator.Multiplication;
            if (sender == divisionButton)
                _selectedOperator = SelectedOperator.Division;
        }

        private void pointButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Contains('.'))
                return;

            resultLabel.Content += ".";
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            string? buttonContent = (sender as Button)?.Content.ToString();

            if (buttonContent is null)
                return;

            int selectedValue = int.Parse(buttonContent);

            if (resultLabel.Content.ToString() == "0")
                resultLabel.Content = $"{selectedValue}";
            else
                resultLabel.Content += $"{selectedValue}";
        }
    }
}
