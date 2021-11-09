using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWageCalculation
    {
        const int IS_PRESENT = 1,WAGE_PER_HR=20,FULL_HR=8;
        Random random = new Random();
        public void dailyemployeewage()
        {
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
            {
                int Dailywage = WAGE_PER_HR * FULL_HR;
                Console.WriteLine("emmloyee is dailywage is" + Dailywage);
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
