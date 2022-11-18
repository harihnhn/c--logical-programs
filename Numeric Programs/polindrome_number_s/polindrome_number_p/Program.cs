using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrome_number_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A palindromic number is a number (such as 16461) that remains the same when its digits are reversed.
            int n, n1, n2, rev_num = 0;
            Console.WriteLine("\nEnter the number:");
            n = int.Parse(Console.ReadLine());
            n1 = n;

            while (n1 > 0)
            {
                n2 = n1 % 10;
                rev_num = (10 * rev_num) + n2;
                n1 /= 10;
            }
            if (rev_num == n)
                Console.WriteLine("\n\"" + n + "\" is a polindrome number");
            else
                Console.WriteLine("\n\"" + n + "\" is not a polindrome number");

            Console.ReadLine();
        }
    }
}
