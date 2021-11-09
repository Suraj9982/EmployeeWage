using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage computation");
            EmployeeWageCalculation emp = new EmployeeWageCalculation();
            emp.checkattendance();  
        }
    }
}
