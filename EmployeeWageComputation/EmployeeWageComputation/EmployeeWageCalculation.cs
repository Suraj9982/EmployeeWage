using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
   
    class EmployeeWageCalculation
    {
        public const int IS_FULLTIME = 0, FULLTIME_HR = 8, PARTTIME_HR = 4, IS_PARTTIME = 1;
        private string Company;
        private int WAGE_PER_HR;
        private int MAX_WORKING_DAYS;
        private int MAX_WORKING_HOURS;
        private int monthlywage; 
        Random random = new Random();
        public EmployeeWageCalculation(string Company,int WAGE_PER_HR,int MAX_WORKING_DAYS, int MAX_WORKING_HOURS)
        {
            this.Company = Company;
            this.WAGE_PER_HR = WAGE_PER_HR;
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;
            this.MAX_WORKING_HOURS = MAX_WORKING_HOURS;
        }       
        public void ComputeEmployeeWage()
        {
            int emp_hours = 0, dailywage=0,emp_days=0;
            while(emp_days < this.MAX_WORKING_DAYS && emp_hours < this.MAX_WORKING_HOURS)
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
                dailywage = this.WAGE_PER_HR * emp_hours;
                monthlywage += dailywage;
                emp_days++;
            }
            Console.WriteLine("The monthly wage of:" + this.Company + "is" + this.monthlywage);
        }
        public string tostring()
        {
            return "The monthly wage of:"+this.Company + "is" + this.monthlywage;
        }
    }
}
