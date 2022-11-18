using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_no_of_digits_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Count the number of digits in a given number
            long n, cnt = 0;
            Console.WriteLine("\nEnter the Number:");
            n = long.Parse(Console.ReadLine());
            while(n > 0)
            {
                n /= 10;
                cnt++;
            }
            Console.WriteLine("\nNo of digits = " + cnt);
            Console.ReadLine();
        }
    }
}