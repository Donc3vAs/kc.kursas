using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 5 azymius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var d = Convert.ToInt32(Console.ReadLine());
            var e = Convert.ToInt32(Console.ReadLine());
            if ((a+b+c+d+e)/5>=5)
            {
                Console.WriteLine("wuhu tavo vidurkis neblogas");
            }
        }
    }
}
