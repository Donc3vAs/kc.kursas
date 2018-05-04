using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > a)
            {
                Console.WriteLine(c);
            }
            else 
            {
                Console.WriteLine(c);
            }

        }
    }
}
