using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage computation");
            Console.WriteLine("how many companies you want to enter");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                EmployeeWageCalculation emp = new EmployeeWageCalculation();
                Console.WriteLine("enter the company name");
                string company = Console.ReadLine();
                Console.WriteLine("enter the rate per hour");
                int rate_per_hour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the maximum working days");
                int max_days = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the maximum working hours");
                int max_hr = Convert.ToInt32(Console.ReadLine());
                emp.employeewagestillcondition(company, rate_per_hour, max_days, max_hr);
            }
        }
    }
}
