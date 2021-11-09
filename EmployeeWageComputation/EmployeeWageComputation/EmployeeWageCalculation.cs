using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWageCalculation
    {
        const int IS_FULLTIME = 0,IS_PARTTIME=1,WAGE_PER_HR=20,FULLTIME_HR=8,PARTTIME_HR=4;
        Random random = new Random();
        public void dailyemployeewageswitch()
        {
            int check = random.Next(0, 3);
            int emp_hours=0, Dailywage;
            switch (check)
            {
                case IS_FULLTIME:
                    emp_hours += FULLTIME_HR;
                    break;
                case IS_PARTTIME:
                    emp_hours += PARTTIME_HR;
                    break;
                default:
                    emp_hours = 0;
                    break;
            }
            Dailywage = WAGE_PER_HR * emp_hours;
            Console.WriteLine("employee is daily wage is " + Dailywage);
        }
    }
}
