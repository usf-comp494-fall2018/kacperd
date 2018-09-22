using System;

namespace CalculatorLib
{
    public class Calculator
    {
        
        public double Add(double a, double b)
        {
            return a + b;
        }

        //b is subtracted from a
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        //a is numerator and b is denominator
        public double Divide(double a, double b)
        {
            return a/b;
        }

    }

}
