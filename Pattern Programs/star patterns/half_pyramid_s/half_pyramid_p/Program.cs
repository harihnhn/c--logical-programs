using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace half_pyramid_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Star Pyramid Patterns Program to print the half Pyramid
            
            int n, i, j;
            Console.Write("\nEnter the Number of rows :");
            n = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i<=n; i++)
            {              
                for (j = 1; j<i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("*\n");
            }
            Console.ReadLine();
        }
    }
}
