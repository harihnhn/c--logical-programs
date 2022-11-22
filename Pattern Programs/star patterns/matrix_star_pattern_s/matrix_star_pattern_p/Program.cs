using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_star_pattern_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matrix star pattern

            int row, col;

            Console.Write("\nEnter the no. of rows :");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the no. of col :");
            col = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < row; i++)
            {
                for(int j = 1; j < col; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("*\n");
            }

            Console.ReadLine();
        }
    }
}
