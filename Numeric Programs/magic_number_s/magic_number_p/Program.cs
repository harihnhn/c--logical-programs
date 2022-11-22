using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_number_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Magic number 
            //ex: 1729 => 1+7+2+9 = 19
            //            19 * 91 = 1729

            int num, n, n1, tot = 0,tot_rev = 0;
            Console.WriteLine("\nEnter the number(to check it is magic number or not): ");
            num = Convert.ToInt32(Console.ReadLine());

            //add all seperate digits in a given number
            n = num;
            while(n > 0)
            {
                n1 = n % 10;
                tot += n1;
                n /= 10;
            }

            //reverse the total number
            n = tot;
            while(n > 0)
            {
                n1 = n % 10;
                tot_rev = (tot_rev * 10) + n1;
                n /= 10;
            }

            //Check it is magic number or not (multiply total number and total_reverse number and check it is equal to given number)
            if (num == (tot * tot_rev))
                Console.WriteLine("\n" + num + " is a \"Magic Number\"");
            else
                Console.WriteLine("\n" + num + " is not a \"Magic Number\"");

            Console.ReadLine();
        }
        
    }
}
