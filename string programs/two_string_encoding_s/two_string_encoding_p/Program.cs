using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_string_encoding_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //encoding two string
            /*
             * Input => s1 = abc;
             *          s2 = xyz;
             * Output => az by cx             
             */
            string str1, str2, str2_rev = "", str3 = "";
            int i=0, j=0;
            label1:
            Console.Write("\nEnter the first string : ");
            str1 = Console.ReadLine();
            Console.Write("\nEnter the second string : ");
            str2 = Console.ReadLine();

            if(str1.Length == str2.Length)
            {               
                for(i = str2.Length-1; i >= 0; i--)                                
                    str2_rev += str2[i];                

                for(j = 0; j < str1.Length; j++)
                {
                    //Console.Write(str1[j] + "" + str2_rev[j] + " ");
                    //str3 += str1[j] + str2_rev[j];
                    str3 = str3 + str1[j] + str2_rev[j] + " ";                
                }
                Console.WriteLine("\n" + str3);
            }
            else
            {
                Console.WriteLine("\nInvalid input enter the strings in same length");
                goto label1;
            }
            Console.Read();
        }
    }
}
