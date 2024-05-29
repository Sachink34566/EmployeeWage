using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Employee
    {
        private const int FULL_TIME = 1;
        private const int PART_TIME = 0;
        private const int EMP_RATE_PER_HOUR = 20;

        public static int CalculateWage()
        {
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else if (empCheck == PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }


            empWage = empHrs * EMP_RATE_PER_HOUR;
            return empWage;
        }
    }

    class AddPartTime
    {
        static void Main(string[] args)
        {
            int empWage = Employee.CalculateWage();
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }


}
