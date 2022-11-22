using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_pyramid_1_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // print same number

            int n, i = 0, j = 0;
            Console.Write("Enter the no. of rows : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=====================================================================================================");
            for(i = 1; i <= n; i++)
            {
                for(j = 1; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.Write(i + "\n");
            }

            Console.WriteLine("=====================================================================================================");
            for (i = n; i > 0; i--)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.Write(i + "\n");
            }

            Console.WriteLine("=====================================================================================================");
            int num=0;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(++num + " ");
                }
                Console.Write(++num + "\n");
            }

            //diamond pattern program
            /*
            Console.WriteLine("=====================================================================================================");
            bool fh;
            for(i = 1; i <= n; i++)
            {
                fh = true;
                num = i;
                do
                {
                    Console.Write(num + " ");
                    if (fh)
                    {
                        fh = false;
                        if (num > 1)
                        {
                            num--;
                            fh = true;
                        }
                        else
                            num++;
                    }

                    else
                        num++;

                } 
                while (num <= i);
                Console.Write("\n");
            }
            */

            ////diamond pattern program
            Console.WriteLine("=====================================================================================================");
            for (i = 1; i <= n; i++)
            {
                for(j = i; j>=1; j--)
                    Console.Write(j + " ");
                for(j = 2; j <= i; j++)
                    Console.Write(j+" ");
                Console.Write("\n");
            }
            for (i = n-1; i > 0; i--)
            {
                for (j = i; j >= 1; j--)
                    Console.Write(j + " ");
                for (j = 2; j <= i; j++)
                    Console.Write(j + " ");
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
