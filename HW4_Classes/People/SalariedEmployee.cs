using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    public class SalariedEmployee : Employee
    {
        public double AnnualSalary { get; set; }

        public override void WriteToConsole()
        {
            Console.WriteLine($"Salaried employee {FirstName} {LastName} with an employee code #{EmployeeCode} " +
                $"has a yearly salary of ${AnnualSalary} and was hired on {DateHired:MM/dd/yyyy}");
        }
    }
}
