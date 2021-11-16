using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage computation");
            EmployeeWageCalculation relaince = new EmployeeWageCalculation("relaince",15,25,100);
            EmployeeWageCalculation tata = new EmployeeWageCalculation("tata", 15, 25, 100);
            relaince.ComputeEmployeeWage();
            Console.WriteLine(relaince.tostring());
            tata.ComputeEmployeeWage();
            Console.WriteLine(tata.tostring());
        }
    }
}
