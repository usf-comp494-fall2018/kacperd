using System;
using System.IO;
using System.Collections.Generic;
using CalculatorLib;

namespace CalcApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculator calc = new Calculator();
            double[] numbers;

            //Console.WriteLine($"{calc.Mean(numbers)}");

            //Console.WriteLine($"{calc.Median(numbers)}");

            //string userFolder = Environment.GetFolderPath();

            string cur_dir = Environment.CurrentDirectory;

            string inputTextPath = Path.Combine(cur_dir, "CalcInput.txt");
            string outputTextPath = Path.Combine(cur_dir, "CalcOutput.txt");

            StreamReader textReader = File.OpenText(inputTextPath);
            string line;
            int i = 0;
            while ((line = textReader.ReadLine()) != null)
            {
                numbers[i] = Convert.ToDouble(line);
            }

        }
    }
}
