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

        public double Mean(double[] arr)
        {
            double sum = 0;
            int size;

            size = arr.Length;
            foreach (double i in arr)
            {
                sum = sum + i;
            }

            return sum / size;
        }

        public double Median(double[] arr)
        {
            //??? dont fully understand this
            Array.Sort(arr);
            int size = arr.Length;

            //if arr is even
            if (size % 2 == 0)
            {
                return (arr[(size / 2) - 1] + arr[(size / 2)]) / 2;
            }
            //if arr is odd
            else
                return arr[(size - 1) / 2];



        }

    }

}
