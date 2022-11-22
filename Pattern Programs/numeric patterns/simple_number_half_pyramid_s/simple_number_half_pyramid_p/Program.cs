using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_number_half_pyramid_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Simple number half pyramid printing program
            int n, i = 0, j =0;
            Console.Write("\nEnter the no of rows : ");
            n = int.Parse(Console.ReadLine());

            for(i =1; i <= n; i++)
            {
                for(j = 1; j < i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.Write( j + "\n");
            }
            Console.ReadLine();
        }
    }
}