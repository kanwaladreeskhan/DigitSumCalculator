using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSumCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of all digits in integer = " + Sum(3456));
        }
        public static int Sum(int num)
            {
            if (num < 0){
                num = -num;
            }
            if (num == 0)
            {
                return 0;
            }
            else
            {
                return (num % 10) + Sum(num / 10);
            }
        }
    }
}
