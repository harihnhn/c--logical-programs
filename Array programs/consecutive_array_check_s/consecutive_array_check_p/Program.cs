using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consecutive_array_check_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //check the given array is consecutive array or not
            int[] arr;
            int n, i;
            bool flag = true;
            Console.WriteLine("\nEnter the array size:  ");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            Console.WriteLine("\nEnter the array elements");
            for(i = 0; i < n; i++)
            {
                Console.Write("\narr[" + i + "] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(i = 1; i < n; i++)            
                if (arr[i] != (arr[i-1] + 1))
                {
                    flag = false;
                    break;
                }
            
            string str = (flag) ? "Given array is consecutive array" : "Given array is not consecutive array";
            Console.WriteLine(str);

            Console.Read();
        }
    }
}