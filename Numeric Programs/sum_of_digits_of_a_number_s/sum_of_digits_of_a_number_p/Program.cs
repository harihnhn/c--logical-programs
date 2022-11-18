using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_digits_of_a_number_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sum of all digits of a given number

            int n, n1=0, sum=0;
            Console.WriteLine("\nEnter the number:");
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                n1 = n % 10;
                sum += n1;
                n = n / 10;
                if(n> 0)
                    Console.Write(n1 + " + ");
            }
            Console.Write(n1 + " = " + sum);

            Console.ReadLine();
        }
    }
}