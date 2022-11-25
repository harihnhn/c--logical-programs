using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_case_change_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //change the case of letters in a given string
            string str, str1="";
            Console.WriteLine("\nEnter the string : ");
            str = Console.ReadLine();                                    
            for(int i = 0; i < str.Length; i++)
            {
                int s = str[i];                
                s = (s >= 97) ? s - 32 : s + 32;
                str1 += (char)s;                
            }
            str = str1;
            Console.WriteLine(str);
            Console.Read();
        }
    }
}
