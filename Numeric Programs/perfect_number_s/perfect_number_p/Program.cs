using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PERFECT NUMBER
            //A perfect number is a positive integer that is equal to the sum of its positive divisors, excluding the number itself.

            int n, i, sum=0;

            Console.WriteLine("\nEnter the number:");
            n = int.Parse(Console.ReadLine());

            if (n <= 0)
                Console.WriteLine("\n\"" + n + "\" is not a perfect number");
            else
            {
                for(i=1; i<=(n/2); i++)
                {
                    if(n%i == 0)
                        sum += i;
                }

                if(sum == n)
                    Console.WriteLine("\n\"" + n + "\" is a perfect number");
                else
                    Console.WriteLine("\n\"" + n + "\" is not a perfect number");
            }
            Console.ReadLine();
        }
    }
}
