using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class CalWageForMonth
    {
        public const int IsPartTime = 1;
        public const int IsFullTime = 2;
        public const int EmpRatePerHour = 20;
        public const int NumOfWorkingDays = 2;
        public const int Max_HRS_IN_MONTH = 10;

        public static void CalculateWagesForMonth()
        {
            int empHrs = 0, empWage = 0, totalEmpWage = 0;

            for (int day = 0; day < NumOfWorkingDays; day++)
            {
                Random rand = new Random();
                int empCheck = rand.Next(0, 3);

                switch (empCheck)
                {
                    case IsPartTime:
                        empHrs = 4;
                        break;
                    case IsFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EmpRatePerHour;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage for day " + (day + 1) + " : " + empWage);
            }
            Console.WriteLine("Total Emp Wage for " + NumOfWorkingDays + " days: " + totalEmpWage);
        }
    }

    public class Monthwage
    {
        static void Main(string[] args)
        {
            CalWageForMonth.CalculateWagesForMonth();
        }
    }
}
