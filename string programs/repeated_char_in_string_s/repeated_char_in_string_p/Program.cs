using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeated_char_in_string_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print count of no. of repeated character in given string
            

            string str;
            int i, count = 0;
            char c;
            Console.Write("\nEnter the string : ");
            str = Console.ReadLine();

            /*
            input => hariharan
            output => h - 2times
                        a - 2times
                        r - 2times
                        i - 1times
                        n - 1times
            */
            
            Console.Write("\nEnter the character to find count of repetation in the string : ");
            c = char.Parse(Console.ReadLine());

            for(i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    count++;
                }
            }
            Console.WriteLine("\n\'" + c + "\' - " + count + " times");

            //print no. of empty spaces in a given strng
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("\n\'" + "empty space" + "\' - " + count + " times");
            Console.Read();
        }
    }
}
