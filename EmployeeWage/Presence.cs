using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Presence
    {
        public class Employee
        {
            public void printpresence()
            {
                int IS_FULL_TIME = 1;
                Random random = new Random();

                int empCheck = random.Next(0, 2);
                if (empCheck == IS_FULL_TIME)
                {
                    Console.WriteLine("Employee is Preaent");
                }
                else
                {
                    Console.WriteLine("Employee is not Present");
                }
            }
        }
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.printpresence();

        }
    }
}
