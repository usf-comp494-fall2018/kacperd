using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    public class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }

        public new void WriteToConsole()
        {
            Console.WriteLine($"Part-time employee {FirstName} {LastName} with an employee code #{EmployeeCode} " +
                $"has an hourly rate of ${HourlyRate} per hour and was hired on {DateHired:MM/dd/yyyy}");
        }
    }
}
