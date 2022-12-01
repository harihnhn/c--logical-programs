using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merge_array_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //merge two array
            int n1, n2, n3, i, j;

            Console.Write("\nEnter the size of first array : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            char[] arr1 = new char[n1];
            Console.WriteLine("\nEnter the elements of first array : ");
            for (i = 0; i < n1; i++)
            {
                Console.Write("\nEnter the element of position \"" + i +"\" : ");
                arr1[i] = Char.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter the size of second array : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            char[] arr2 = new char[n2];
            Console.WriteLine("\nEnter the elements of second array : ");
            for (i = 0; i < n2; i++)
            {
                Console.Write("\nEnter the element of position \"" + i + "\" : ");
                arr2[i] = Char.Parse(Console.ReadLine());
            }

            n3 = n1 + n2; 
            char[] arr3 = new char[n3];
            i = 0;
            for (j = 0; j < n1; j++)            
                arr3[i++] = arr1[j];                     

            for (j = 0; j < n2; j++)            
                arr3[i++] = arr2[j];                       

            Console.WriteLine("\nMerged array : ");
            for (i = 0; i<n3; i++)            
                Console.Write(arr3[i]);            
            Console.Read();
        }
    }
}
