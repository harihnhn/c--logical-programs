using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong_number_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARMSTRONG NUMBER
            /*Armstrong number definition is the number in any given number base, which forms the total of the same number, when each of its digits is raised to the power of the number of digits in the number.*/
           
            string n;          
            Console.WriteLine("\nEnter the number:");
            n = Console.ReadLine();
            int pow = n.Length, n1 = Convert.ToInt32(n), n2;
            double sum = 0; //Math.Pow() function returns decimal value

            while(n1>0)
            {
                n2 = n1 % 10;
                sum += Math.Pow(n2, pow);
                n1 /= 10;
            }

            if (sum == float.Parse(n))
                Console.WriteLine("\n\""+n+"\" is a Armstrong number");
            else
                Console.WriteLine("\n\"" + n + "\" is not a Armstrong number");

            Console.ReadLine();
        }       
    }
}