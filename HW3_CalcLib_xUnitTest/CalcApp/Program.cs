using System;
using System.IO;
using System.Linq; //necessary for Count() of File class; could be avoided by using a dynamic list if Calc methods
                   //were adjusted, but the instructions called for an array which I assume means static array
using System.Collections.Generic;
using CalculatorLib;

namespace CalcApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining paths
            string cur_dir = Environment.CurrentDirectory;
            string inputTextPath = Path.Combine(cur_dir, "CalcInput.txt");
            string outputTextPath = Path.Combine(cur_dir, "CalcOutput.txt");

            //check to see if CalcInput exists
            //if not, create a blank text file to that path
            StreamReader textReader;
            if (!File.Exists(inputTextPath))
            {
                Console.WriteLine("Input file does not exist, creating CalcInput.txt with 0 as default value");
                //necessary writing to blank file
                StreamWriter tempWriter;
                tempWriter = File.CreateText(inputTextPath);
                tempWriter.WriteLine(0);
                tempWriter.Close();
            }
            //reader stream opened to input text file
            textReader = File.OpenText(inputTextPath);

            //amount of lines determine size of array
            int s = File.ReadLines(inputTextPath).Count();
            double[] numbers = new double[s];

            //filling of array from input file
            string line;
            int i = 0;
            while ((line = textReader.ReadLine()) != null)
            {
                //string to double conversion and input into array
                numbers[i] = Convert.ToDouble(line);
                i++;
            }
            //done reading, info from input file is now in array
            textReader.Close();

            //opens writing stream to output path if file exists
            //if file does not exists, creates that file and opens writing stream to it
            StreamWriter textWriter;
            if (!File.Exists(outputTextPath))
            {
                textWriter = File.CreateText(outputTextPath);
            }
            else
            {
                textWriter = new StreamWriter(outputTextPath);
            }

            //using Calculator class to determine mean and median of array, then outputting to correct output file
            Calculator calc = new Calculator();
            textWriter.WriteLine("|--------------------------------|--------------------------------|");
            textWriter.WriteLine("| Mean                           | Median                         |");
            textWriter.WriteLine("|--------------------------------|--------------------------------|");
            textWriter.WriteLine($"| {Math.Round(calc.Mean(numbers), 2),-30} | {Math.Round(calc.Median(numbers), 2),-30} |");
            textWriter.WriteLine("|--------------------------------|--------------------------------|");
            //done writing
            textWriter.Close();

            Console.WriteLine("Output complete in: \n");
            Console.WriteLine(outputTextPath);
            Console.WriteLine("");
            Console.WriteLine("Results output with 2 decimal places\n");
        }
    }
}
