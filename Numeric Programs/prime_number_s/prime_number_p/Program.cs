using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PRIME NUMBER
            //a number that can be divided exactly only by itself and 1, for example 7, 17 and 41.
            int n,i;
            bool flag = true;

            Console.WriteLine("\nEnter the number:");
            n = Convert.ToInt32(Console.ReadLine());

            
            if(n == 0 )          
                Console.WriteLine("\nZero is neither a prime nor a composite number");

            else if (n < 0)
                Console.WriteLine("\n \"" + n + "\" is not a prime number");

            else if(n == 1 )            
                Console.WriteLine("\n \"" + n + "\" is a prime number");                        

            else
            {
                for(i=2; i<=(n/2); i++)
                {
                    if(n%i == 0)
                    {
                        Console.WriteLine("\n\"" + n + "\" is not a prime number");
                        flag = false;
                        break;
                    }
                }
                
                if(flag)
                    Console.WriteLine("\n\"" + n + "\" is a prime number");
            }
            Console.ReadLine();
        }
    }
}
