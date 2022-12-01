using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrome_string_check_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //check the input string it is polindrome or not
            string str, str_rev = "";
            Console.Write("Enter the string : ");
            str = Console.ReadLine();

            //string reverse
            for(int i = (str.Length-1); i>=0; i--)
            {
                //str_rev[i] = str[i]; //doubt
                str_rev += str[i];
            }

            //check the string is polindrome or not
            if (str == str_rev)
                Console.WriteLine("\n" + str + " is a \"polindrome\" string");
            else
                Console.WriteLine("\n" + str + " is not a \"polindrome\" string");

            //(str == str_rev) ? Console.WriteLine("\n" + str + " is a \"polindrome\" string") : Console.WriteLine("\n" + str + " is not a \"polindrome\" string");

            Console.Read();
        }
    }
}
