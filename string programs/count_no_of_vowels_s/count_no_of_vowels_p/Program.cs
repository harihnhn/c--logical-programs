using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_no_of_vowels_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print no.of vowels in a given string
            string str;
            int count = 0;
            Console.Write("\nEnter the string:");
            str = Console.ReadLine();
            for(int i = 0; i < str.Length; i++) 
            {
                if ((str[i] == 'a') || (str[i] == 'e') || (str[i] == 'i') || (str[i] == 'o') || (str[i] == 'u'))
                    count++;
                else if ((str[i] == 'A') || (str[i] == 'E') || (str[i] == 'I') || (str[i] == 'O') || (str[i] == 'U'))
                    count++;
            }
            Console.WriteLine(count);
            Console.Read();            
        }
    }
}
