using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_half_pyramid_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reverse half pyramid star pattern printing

            int n;
            Console.Write("\nEnter the no. of rows to print: ");
            n = int.Parse(Console.ReadLine());
            
            for(int i = n; i > 0; i--)
            {
                for(int j = 1; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("*\n");
            }

            Console.ReadLine();
        }
    }
}
