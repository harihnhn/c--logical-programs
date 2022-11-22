using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_number_reverse_pyramid_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //simple numbers reverse pyramid
            int n, i = 0, j = 0;
            Console.Write("\nEnter the no. of rows : ");
            n = int.Parse(Console.ReadLine());

            for(i = n; i>0; i--)
            {
                for(j = i; j>1; j--)
                {
                    Console.Write(j + " ");
                }
                Console.Write(j + "\n");
            }

            Console.ReadLine();
        }
    }
}
