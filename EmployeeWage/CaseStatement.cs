using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class CalEmpWageUseSwitch
    {
        private const int IS_PART_TIME = 1;
        private const int IS_FULL_TIME = 2;
        private const int EMP_RATE_PER_HOUR = 20;

        public void useswitch()
        {

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage 1: " + empWage);
        }
    }
    public class CaseStatement
    {
        static void Main(string[] args)
        {
            CalEmpWageUseSwitch switchcase = new CalEmpWageUseSwitch();
            switchcase.useswitch();
        }
    }
}
