using System;

namespace EmployeeWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int isFulltime = 1;
            int empRatePerHours = 20;

            int empHrs = 0;
            int empwage = 0;
            Random random = new Random();

            int empcheck = random.Next(0, 2);
            if (empcheck == isFulltime)
            {
                //Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                //console.WriteLine("Employee is not present");
                empHrs = 0;
            }
            empwage = empHrs * empRatePerHours;
            Console.WriteLine("Employee Days wage:" + empwage);
        }
    }
}

            

            
