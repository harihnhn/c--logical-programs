using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_number_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reverse number
            int n, n1, rev_num=0;
            Console.WriteLine("\nEnter the number:");
            n = int.Parse(Console.ReadLine());
            
            while(n > 0)
            {
                n1 = n % 10;
                rev_num = (10*rev_num) + n1;
                n /= 10;
            }
            Console.WriteLine("\n Reversed format: " + rev_num);
            Console.ReadLine();
        }
    }
}
