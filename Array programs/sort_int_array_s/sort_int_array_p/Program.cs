using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_int_array_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sort int array
            int n, i;
            bool flag = true;
            Console.Write("\nEnter the size of the array : ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];  
            for(i = 0; i < n; i++)
            {
                Console.Write("\nEnter the element of position\"" + i + "\" : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //sorting
            while(flag)
            {
                flag = false;
                for (i = 0; i < n - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        arr[i] += arr[i + 1];
                        arr[i + 1] = arr[i] - arr[i + 1];
                        arr[i] = arr[i] - arr[i + 1];
                        flag = true;
                    }
                }
            }

            for(i=0; i < n; i++)
            {
                Console.Write(arr[i]+ "\t");
            }

            Console.Read();
        }
    }
}
