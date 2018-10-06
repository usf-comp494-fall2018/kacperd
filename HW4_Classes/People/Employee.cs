using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateHired { get; set; }
        public int EmployeeCode { get; set; }

        public Employee()
        {
            FirstName = "-";
            LastName = "-";
            DateHired = new DateTime(01/01/0001);
            EmployeeCode = -1;
        }

        public virtual void WriteToConsole()
        {
            Console.WriteLine($"Employee {FirstName} {LastName} with an employee code #{EmployeeCode} " +
                $"was hired on {DateHired:MM/dd/yyyy}");
        }

        
    }
}
