using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite teigiama skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a<0)
            {
                Console.WriteLine("ismok skaityti");
            }
            if (a>0)
            {
                Console.WriteLine("sveikinu");
            }
            if (a%2==0)
            {
                Console.WriteLine("lyginis");
            }
            if (a%4==0)
            {
                Console.WriteLine("dalinasi is 4");
            }
            if (a>10)
            {
                Console.WriteLine("daugiau uz 10");
            }
        }
    }
}
