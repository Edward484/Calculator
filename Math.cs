using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator
{
    class Math
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Substract(double a, double b)
        {
            return a - b;
        }
        public static double Mulitply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            if(b == 0)
            {
                MessageBox.Show("Division by 0 is not allowed", "Wrong operation", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }
            return a / b;
        }
    }
}
