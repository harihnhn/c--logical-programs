using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_series_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FIBONACCI SERIES
            //a series of numbers in which each number ( Fibonacci number ) is the sum of the two preceding numbers. The simplest is the series 0, 1, 1, 2, 3, 5, 8, etc.
            long n, i, n1, n2, n3;
            n1 = 0;
            n2 = 1;
            Console.WriteLine("\nEnter the count of numbers you want to print on fibonacci series : ");
            n = long.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2);
            for (i=n; i>0; i--)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.Write(" " + n2);
            }
            Console.ReadLine();
        }
    }
}