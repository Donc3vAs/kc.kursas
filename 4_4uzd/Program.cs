using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaisius");
            var a = Convert.ToInt32( Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0}+{1}+{2}=", a, b, c);
            Console.WriteLine(a + b + c);
            Console.Write("{0}-{1}-{2}=", a, b, c);
            Console.WriteLine(a - b - c);
            Console.Write("{0}/{1}/{2}=", a, b, c);
            Console.WriteLine(a / b / c);

        }
    }
}
