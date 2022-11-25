using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abbrevation_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input => World Health Organization
            //output => WHO
            string str, s1="";
            Console.Write("\nEnter the string:");
            str = Console.ReadLine();
            s1 += str[0];
            
            for(int i = 1; i < str.Length; i++)            
                if (str[i] == ' ')                
                    s1 += str[++i];
            Console.Write(s1.ToUpper());
            Console.Read();
        }
    }
}
