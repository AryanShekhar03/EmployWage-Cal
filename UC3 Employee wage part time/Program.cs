using System;

namespace UC3_Employee_wage_part_time
{
    public class Program
    {
        public static void Main(string[] args)
         {
            int isFullTime = 2;
            int isPartTime = 1;
            int empRatePerHours = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == isPartTime)
            {
                empHrs = 4;
            }
            if (empCheck == isFullTime)
            {
                //console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                //console.WriteLine("Employee is not present");
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHours;
            Console.WriteLine("Employee Days Wage:" + empWage);        
        }
    }
}
