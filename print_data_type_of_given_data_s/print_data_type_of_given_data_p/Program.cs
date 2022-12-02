using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_data_type_of_given_data_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine();
            int d1 = int.Parse(data);
            float d2 = float.Parse(data);

            if ((d2 / d1) > 1) Console.WriteLine("float");
            else if(d1-d1 == 0) Console.WriteLine("int");
            else if(data.Length == 1) Console.WriteLine("char");
            else Console.WriteLine("string");

            Console.Read();
        }
    }
}
