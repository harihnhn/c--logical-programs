using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_pyramid_pattern_program_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string pyramid pattern program

            int i=0, j=0;            
            Console.Write("\nEnter the string:");
            string s = Console.ReadLine();
            Console.WriteLine("\nString pyramid pattern program : \n");
            for (i=0; i<s.Length; i++)
            {
                for(j=0; j<=i; j++)
                {

                    Console.Write(s[j]);
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\nString \"reverse pyramid\" pattern program :\n");
            for (i = (s.Length-1); i >=0; i--)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write(s[j]);
                }
                Console.WriteLine("\n");
            }

            Console.Read();
        }
    }
}
