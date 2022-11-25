using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encoding_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //encription
            string str1, str2="";
            Console.Write("\nEnter the string : ");
            str1 = Console.ReadLine();            
            
            /*
            //encription using ascii value
            for (int i = 0; i < str1.Length; i++)
            {
                int n = str1[i];   
                //str2[i] = (char)++n;
                str2 += (char)++n;
            }
            Console.WriteLine(str2);
            */

            
            //encoding without using ascii value
            for (int i = 0; i < str1.Length; i++)
            {                              
                char c = str1[i];
                //c++;               
                str2 += ++c;
            }
            Console.WriteLine(str2);

            Console.Read();
        }
    }
}
