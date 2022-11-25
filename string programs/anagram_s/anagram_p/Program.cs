using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagram_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a word or phrase made by transposing the letters of another word or phrase.
            //The word "secure" is an anagram of "rescue"
            string s1, s2;
            int i;
            char temp;
            bool flag = true;

            Console.Write("\nEnter the string1 : ");
            s1 = Console.ReadLine();
            Console.Write("\nEnter the string2 : ");
            s2 = Console.ReadLine();

            if (s1.Length == s2.Length)
            {
                char[] arr1 = new char[s1.Length];
                char[] arr2 = new char[s2.Length];
                arr1 = s1.ToCharArray();
                arr2 = s2.ToCharArray();

                //sorting
                while(flag)
                {
                    flag = false;
                    for (i = 0; i < arr1.Length - 1; i++)
                    {
                        if (arr1[i] > arr1[i + 1])
                        {                            
                            temp = arr1[i];
                            arr1[i] = arr1[i + 1];
                            arr1[i + 1] = temp;
                            flag = true;
                        }

                        if (arr2[i] > arr2[i + 1])
                        {                            
                            temp = arr2[i];
                            arr2[i] = arr2[i + 1];
                            arr2[i + 1] = temp;
                            flag = true;
                        }
                    }
                }

                //s1 = arr1.ToString();
                //s2 = arr2.ToString();
                //Console.WriteLine("\n" + s1 + "\n" + s2);

                //compare two array is equal or not
                flag = true;
                for(i = 0; i< arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                        flag = false;
                }

                //if(arr1 == arr2)
                if (flag)
                {
                    Console.WriteLine("\nThe given two string is \"ANAGRAM\"");
                }
                else
                {
                    Console.WriteLine("\nThe given two string is \"not ANAGRAM!\"");
                }
                Console.ReadLine();
            }
        }
    }
}