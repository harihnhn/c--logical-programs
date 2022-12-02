using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_array_merge_and_sort_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j=0;
            bool flag = true;
            int[] arr1, arr2, arr3;
            arr1 = new int[] { 0, 2, 4, 6, 8 };
            arr2 = new int[] { 1, 3, 5, 7, 9 };
            arr3 = new int[arr1.Length + arr2.Length];
            
            //merge two array
            for(i = 0; i<arr1.Length; i++)            
                arr3[j++] = arr1[i]; 
            
            for (i = 0; i < arr2.Length; i++)
                arr3[j++] = arr2[i];

            //sort array
            while(flag)
            {
                flag = false;
                for (i = 0; i < arr3.Length - 1; i++)
                {
                    if (arr3[i] > arr3[i + 1])
                    {
                        //arr3[i] = arr3[i + 1] + arr3[i];
                        //arr3[i + 1] = arr3[i] - arr3[i + 1];
                        //arr3[i] = arr3[i] - arr3[i + 1];

                        arr3[i] = (arr3[i] * arr3[i + 1]) / (arr3[i + 1] = arr3[i]);
                        flag = true;
                    }
                }
            }

            //print output
            Console.Write("C = [ ");
            for (i = 0; i< arr3.Length;i++)
            {
                Console.Write(arr3[i]+ " ");
            }
            Console.Write("]");
            Console.Read();

            
        }
    }
}
