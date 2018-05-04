using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var vid = (a + b + c) / 3;
            if (vid>= 8 && vid <= 10)
            {
                Console.WriteLine("8-10");
            }
            else if (vid >= 5 && vid < 8 )
            {
                Console.WriteLine("5-8");
            }
            else
            {
                Console.WriteLine("<5");
            }
            

        }
    }
}
