using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 3 skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("tiesa1");
            }
            else if (b > c)
            {
                Console.WriteLine("tiesa2");
            }
            else if (c > a)
            {
                Console.WriteLine("tiesa3");
            }
            else if (a == b)
            {
                Console.WriteLine("tiesa4");
            }
        }
    }
}
