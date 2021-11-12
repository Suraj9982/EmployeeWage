using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWageCalculation
    {
        const int IS_FULLTIME = 0,IS_PARTTIME=1,WAGE_PER_HR=20,FULLTIME_HR=8,PARTTIME_HR=4,MAX_WORKING_DAYS=20,MAX_WORKING_HOURS=100;
        Random random = new Random();
        public void employeewagestillcondition()
        {
            int emp_hours = 0, dailywage=0,monthlywage = 0,emp_days=0;
            while(emp_days < MAX_WORKING_DAYS && emp_hours < MAX_WORKING_HOURS)
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
                        emp_hours += 0;
                        break;
                }
                dailywage = WAGE_PER_HR * emp_hours;
                monthlywage += dailywage;
                emp_days++;
            }
            Console.WriteLine("employee is monthly wage is " + monthlywage);
        }
    }
}
