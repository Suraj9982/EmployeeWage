using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWageCalculation
    {
        const int IS_FULLTIME = 0,IS_PARTTIME=1,WAGE_PER_HR=20,FULLTIME_HR=8,PARTTIME_HR=4,TOTAL_DAYS=20;
        Random random = new Random();
        public void monthlyemployeewages()
        {
            int emp_hours = 0, Dailywage=0,Monthlywage = 0;
            for (int day = 0; day < TOTAL_DAYS; day++)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULLTIME:
                        emp_hours += FULLTIME_HR;
                        Console.WriteLine("emolyee is fulltime");
                        break;
                    case IS_PARTTIME:
                        emp_hours += PARTTIME_HR;
                        Console.WriteLine("employee is parttime");
                        break;
                    default:
                        emp_hours = 0;
                        break;
                }
                Dailywage = WAGE_PER_HR * emp_hours;
                Monthlywage += Dailywage;
            }
            Console.WriteLine("employee is monthly wage is " + Monthlywage);
        }
    }
}
