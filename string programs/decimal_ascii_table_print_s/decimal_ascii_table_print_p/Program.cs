using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimal_ascii_table_print_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print ascii table            
            for (int i = 0; i <= 127; i++)
            {                
                char c = (char)i;
                Console.WriteLine(i + "\t" + c);
            }

            /*            
            for (int i = 0; i < 32; i++)
            {
                /*
                char c1 = (char)i;
                char c2 = (char)(i+32);
                char c3 = (char)(i+64);
                char c4 = (char)(i+96);
                Console.WriteLine(i +"\t"+ c1 + "\t\t" + (i+32) +"\t"+c2 + "\t\t" + (i + 64) + "\t" + c3 + "\t\t" + (i + 96) + "\t" + c4);                
            }
            Console.ReadLine();
            */
        }
    }
}
