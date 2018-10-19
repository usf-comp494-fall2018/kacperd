using System;
using System.IO;
using System.Linq; //
using System.Collections.Generic;
using CalculatorLib;

namespace CalcApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            string cur_dir = Environment.CurrentDirectory;

            string inputTextPath = Path.Combine(cur_dir, "CalcInput.txt");
            string outputTextPath = Path.Combine(cur_dir, "CalcOutput.txt");


            //StreamReader textReader;
            //if (!File.Exists(inputTextPath))
            //{
            //    Console.WriteLine("correct input file does not exist, creating blank CalcInput.txt");
            //    File.CreateText(inputTextPath);
            //    textReader = File.OpenText(inputTextPath);
            //}
            //else
            //{
            //    textReader = File.OpenText(inputTextPath);
            //}

            StreamReader textReader = File.OpenText(inputTextPath);

            int s = File.ReadLines(inputTextPath).Count();
            
            Console.WriteLine(s);

            double[] numbers = new double[s];


            string line;
            int i = 0;
            while ((line = textReader.ReadLine()) != null)
            {
                numbers[i] = Convert.ToDouble(line);
                i++;
            }


            Console.WriteLine($"Does it exist? {File.Exists(outputTextPath)}");


            StreamWriter textWriter;
            if (!File.Exists(outputTextPath))
            {
                textWriter = File.CreateText(outputTextPath);
            }
            else
            {
                textWriter = new StreamWriter(outputTextPath);
            }



            textWriter.WriteLine("|--------------------------------|--------------------------------|");
            textWriter.WriteLine("| Mean                           | Median                         |");
            textWriter.WriteLine("|--------------------------------|--------------------------------|");

            textWriter.WriteLine($"| {Math.Round(calc.Mean(numbers), 2),-30} | {Math.Round(calc.Median(numbers), 2),-30} |");






            textWriter.Close(); // close file and release resources
            textReader.Close();

            //int j = numbers.Length-1;
            //while (j >= 0)
            //{
            //    Console.WriteLine(numbers[j]);
            //    j--;
            //}


        }
    }
}
