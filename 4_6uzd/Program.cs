using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tirs skaicius");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Round((a+c+c)/3, 2));
        }
    }
}
