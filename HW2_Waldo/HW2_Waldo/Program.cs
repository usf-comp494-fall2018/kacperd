using System;

namespace HW2_Waldo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tom", "Bob", "Dana", "Julie", "Sarah", "Fred", "Waldo", "Jenny", "Cathy" };

            string catch_name = "Waldo";
            int count = 0;
            
            foreach(string name in names)
            {
                //first element in array "names" will be labeled as count 1 (instead of count 0) so it is more user friendly
                count++;
                if (catch_name == name)
                    Console.WriteLine($"Found {catch_name} at position {count}");
            }

        }
    }
}
