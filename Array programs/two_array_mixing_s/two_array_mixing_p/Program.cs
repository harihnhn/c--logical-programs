using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_array_mixing_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1, arr2, arr_op;
            int i = 0, j = 0, k = 0;
            arr1 = new int[] { 10, 20, 30, 40, 50 };
            arr2 = new int[] { 1, 2, 3, 4, 5 };
            arr_op = new int[arr1.Length + arr2.Length];

            for (i = 0; i < arr_op.Length; i++)
            {
                if (i % 2 == 0)                
                    arr_op[i] = arr1[j++];                                    
                else
                    arr_op[i] = arr2[k++];
            }
            foreach (int elements in arr_op)
                Console.Write(elements + " ");

            Console.ReadLine();
        }
    }
}
