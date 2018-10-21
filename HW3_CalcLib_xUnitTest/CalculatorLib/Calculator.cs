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

        /*
        Mean(double[]); finds arithmetic mean of an array of type double
        pre: array must not be empty
        parameter(s): array of type double
        return: double
        */
        public double Mean(double[] arr)
        {
            double sum = 0;
            int size = arr.Length;

            //summation of all array terms
            foreach (double i in arr)
            {
                sum = sum + i;
            }

            return sum / size;
        }

        /*
        Median(double[]); finds median of an array of type double
        pre: array must not be empty
        parameter(s): array of type double
        return: double
        */
        public double Median(double[] arr)
        {
            int size = arr.Length;
            
            //median is dependent on order
            Array.Sort(arr); 

            //if array is even, return mean of the two middle terms
            if (size % 2 == 0)
            {
                return (arr[(size / 2) - 1] + arr[(size / 2)]) / 2;
            }
            //if array is odd, return middle element
            else
                return arr[(size - 1) / 2];
        }

    }

}
