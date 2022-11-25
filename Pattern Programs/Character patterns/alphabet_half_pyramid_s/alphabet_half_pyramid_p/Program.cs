using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabet_half_pyramid_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print alphabet values using ascii values
            char c1, c2, char1, char2;
            Console.Write("Enter the starting character : ");
            char1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the ending character : ");
            char2 = Convert.ToChar(Console.ReadLine());

            //if starting character is smaller than ending character (i.e. A to E)
            if (char1 <= char2)
            {
                for (c1 = char1; c1 <= char2; c1++)
                {
                    for (c2 = char1; c2 <= c1; c2++)
                    {
                        Console.Write(c2);
                    }
                    Console.WriteLine("\n");
                }
            }

            //if starting character is greater than ending character (i.e. E to A)
            else
            {
                for(c1 = char1; c1>=char2; c1--)
                {
                    for(c2 = char1; c1<=c2; c2--)                    
                        Console.Write(c2);
                    Console.WriteLine("\n");
                }
            }
            

            Console.Read();
        }
    }
}

