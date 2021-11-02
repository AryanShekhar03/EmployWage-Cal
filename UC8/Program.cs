using System;

namespace UC8_emp
{
    class Program
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;

        public static int empWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;


            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays <= numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(1, 2);
                switch (empCheck)
                {
                    case isPartTime:
                        empHrs = 4;
                        break;
                    case isFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = empHrs + totalEmpHrs;
                //Console.WriteLine(totalWorkingDays);
                Console.WriteLine(empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine(totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            empWage("microsoft", 30, 20, 60);
            empWage("tcs", 15, 20, 25);
        }
    }
}