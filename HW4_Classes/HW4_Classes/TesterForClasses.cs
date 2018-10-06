using System;
using Employees;

namespace HW4_Classes
{
    class TesterForClasses
    {
        static void Main(string[] args)
        {
            //creating all types of employees

            Employee Emp1 = new Employee
            {
                FirstName = "Rich",
                LastName = "Ritchmann",
                DateHired = new DateTime(1980, 12, 10),
                EmployeeCode = 1142
            };

            SalariedEmployee SalEmp1 = new SalariedEmployee
            {
                FirstName = "Markov",
                LastName = "Kasovanovitch",
                DateHired = new DateTime(1949, 06, 10),
                EmployeeCode = 0025,
                AnnualSalary = 10
            };

            PartTimeEmployee PartEmp1 = new PartTimeEmployee
            {
                FirstName = "Pour",
                LastName = "Pohrgai",
                DateHired = new DateTime(2018, 04, 26),
                EmployeeCode = 0026,
                HourlyRate = .25
            };

            //displaying employees

            Emp1.WriteToConsole();
            Console.WriteLine(" ");
            SalEmp1.WriteToConsole();
            Console.WriteLine(" ");
            PartEmp1.WriteToConsole();
            Console.WriteLine("\n\n");

            //showcasing "override" vs. "new" keywords

            Employee Emp2 = SalEmp1;
            Emp2.WriteToConsole(); //will call the overriden method (in this case SalEmp1's WriteToConsole())
            Console.WriteLine(" ");

            Employee Emp3 = PartEmp1;
            Emp3.WriteToConsole(); //will NOT call the "new" method since it 
                                   //was initialized as our base class
                                   //"Employee", so in this case Employee's WriteToConsole() will run
            Console.WriteLine(" ");

            PartTimeEmployee PartEmp2 = PartEmp1;
            PartEmp2.WriteToConsole();//will call the "new" method since it 
                                      //was initialized as our derived class
                                      //"PartTimeEmployee", so in this case PartTimeEmployee's WriteToConsole() will run
            Console.WriteLine(" ");

        }
    }
}
