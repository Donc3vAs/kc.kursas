using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_4uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = Convert.ToInt32(Console.ReadLine());
            var m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("viso minuciu " + (h*60+m) + " sekundziu " + ((h * 60 + m)*60));

        }
    }
}
