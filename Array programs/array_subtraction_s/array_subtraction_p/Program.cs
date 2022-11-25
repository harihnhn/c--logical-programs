using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_subtraction_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //find the difference of two array (a-b)
            int[] arr1, arr2, a;
            int n1, n2, i,j;
            bool flag;

            //get input of array 1
            Console.Write("\nEnter the size of array1 :");
            n1 = int.Parse(Console.ReadLine());
            arr1 = new int[n1];
            a = new int[n1];
            Console.WriteLine("\nEnter the elements of array1");
            for(i = 0; i < n1; i++)
            {
                Console.Write("\nEnter the element of arr1[" + i + "] : ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            //get input of array2
            Console.Write("\nEnter the size of array2 :");
            n2 = Convert.ToInt32(Console.ReadLine());
            arr2 = new int[n2];
            Console.WriteLine("\nEnter the elements of array1");
            for (i = 0; i < n2; i++)
            {
                Console.Write("\nEnter the element of arr2[" + i + "] : ");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            //arr1 - arr2
            int k = 0;
            for(i = 0; i < n1; i++)
            {
                flag = true;
                for(j = 0; j < n2; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    a[k++] = arr1[i];
            }

            Console.Write("\n(arr1 - arr2) = { ");            
            for (i = 0; i < k; i++)            
                Console.Write(a[i] + " ");            
            Console.Write("}");

            Console.Read();
        }
    }
}
