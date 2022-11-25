using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_position_swap_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //swap the value in array
            int[] arr = new int[] {10, 20, 30, 40, 50};
            arr[2] = arr[2] + arr[4];
            arr[4] = arr[2] - arr[4];
            arr[2] = arr[2] - arr[4];
            foreach(int i in arr)
                Console.Write(i + "\t");
            Console.Read();
        }
    }
}
