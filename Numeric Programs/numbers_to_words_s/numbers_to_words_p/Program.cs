using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_to_words_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Numbers to words convert (i.e. 153 => one five three)
            
            int n, n1, n_rev = 0;
            Console.WriteLine("\nEnter the Number:");
            n = Convert.ToInt32(Console.ReadLine());

            while(n > 0)
            {
                n1 = n % 10;
                n_rev = (n_rev * 10) + n1;
                n /= 10;
            }
            Console.WriteLine(n_rev);

            while(n_rev > 0)
            {
                n1 = n_rev % 10;

                switch (n1)
                {
                    case 0:
                        Console.Write(" Zero");              
                        break;

                    case 1:
                        Console.Write(" One");
                        break;

                    case 2:
                        Console.Write(" Two");
                        break;

                    case 3:
                        Console.Write(" Three");
                        break;

                    case 4:
                        Console.Write(" Four");
                        break;

                    case 5:
                        Console.Write(" Five");
                        break;

                    case 6:
                        Console.Write(" six");
                        break;

                    case 7:
                        Console.Write(" Seven");
                        break;

                    case 8:
                        Console.Write(" Eight");
                        break;

                    case 9:
                        Console.Write(" Nine");
                        break;

                    case 10:
                        Console.Write(" Ten");
                        break;
                }
                n_rev /= 10;
            }
            Console.ReadLine();
        }
    }
}
