using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWageCalculation
    {
        const int IS_FULLTIME = 0,FULLTIME_HR=8,PARTTIME_HR=4, IS_PARTTIME=1;
        Random random = new Random();
        public void employeewagestillcondition(string Company, int WAGE_PER_HR,int MAX_WORKING_DAYS,int MAX_WORKING_HOURS)
        {
            int emp_hours = 0, dailywage=0,monthlywage = 0,emp_days=0;
            while(emp_days < MAX_WORKING_DAYS && emp_hours < MAX_WORKING_HOURS)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULLTIME:
                        emp_hours += FULLTIME_HR;
                        break;
                    case IS_PARTTIME:
                        emp_hours += PARTTIME_HR;
                        break;
                    default:
                        emp_hours += 0;
                        break;
                }
                dailywage = WAGE_PER_HR * emp_hours;
                monthlywage += dailywage;
                emp_days++;
            }
            Console.WriteLine("The monthly wage of {0} is {1} ",Company,monthlywage);
        }
    }
}
