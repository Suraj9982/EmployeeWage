using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWageCalculation
    {
        const int IS_PRESENT = 1;
        Random random = new Random();
        public void checkattendance()
        {
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
