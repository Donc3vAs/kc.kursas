using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            if (a==b)
            {
                Console.WriteLine("1 tiesa");
            }
            if (b==c)
            {
                Console.WriteLine("2 tiesa");
            }
            if (a==b)
            {
                Console.WriteLine("3 tiesa");
            }
            if (b > c * 2)
            {
                Console.WriteLine(" 4tiesa");
            }
            if (a % 2 == 0)
            {
                Console.WriteLine(" 5tiesa");
            }
            if (b % 2 !=0)
            {
                Console.WriteLine(" 6tiesa");
            }
            if (c>0)
            {
                Console.WriteLine(" 7tiesa");
            }
            if (c<0)
            {
                Console.WriteLine(" 8tiesa");
            }
        }
    }
}
