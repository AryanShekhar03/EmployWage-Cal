using System;

namespace CALCULATOR
{
   public class Program
    {
        
        public static void Main(string[] args)
        {
            Calculator ojccalculator = new Calculator();
            Console.WriteLine("total values=" + ojccalculator.isSum(40, 20));
            Console.ReadKey();
        }
    }
}
