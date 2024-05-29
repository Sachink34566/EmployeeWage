using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class DailyEmployee
    {
        private const int FullTime = 1;
    private const int HourlyWage = 20;

    public void CalculateDailyWage()
    {
        int employeeHoursWorked = 0;
        int employeeWage = 0;
        Random random = new Random();

        int employeeCheck = random.Next(0, 2);
        if (employeeCheck == FullTime)
        {
            employeeHoursWorked = 8;
        }
        else
        {
            employeeHoursWorked = 0;
        }

        employeeWage = employeeHoursWorked * HourlyWage;
        Console.WriteLine("Employee Wage: " + employeeWage);
    }
}

class DailyEmployeeWage
{
    static void Main(string[] args)
    {
        DailyEmployee dailyEmployee = new DailyEmployee();
        dailyEmployee.CalculateDailyWage();
    }
}
}
