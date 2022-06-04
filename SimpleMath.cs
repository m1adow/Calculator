using System.Windows;

namespace Calculator_WPF_
{
    internal class SimpleMath
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                MessageBox.Show("Division by 0 is not supported",
                    "Wrong operation",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return 0;
            }

            return a / b;
        }
    }
}
