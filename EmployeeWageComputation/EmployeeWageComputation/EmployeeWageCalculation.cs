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
        public void dailyemployeewage()
        {
            int check = random.Next(0, 3);
            int emp_hours=0;
            if (check == IS_FULLTIME)
            {
                emp_hours += FULLTIME_HR;
            }
            if(check==IS_PARTTIME)
            {
                emp_hours += PARTTIME_HR;
            }
            else
            {
                Console.WriteLine("employee is absent");
                emp_hours = 0;
            }
            int Dailywage = WAGE_PER_HR * emp_hours;
            Console.WriteLine("employee is daily wage is " + Dailywage);
        }
    }
}
