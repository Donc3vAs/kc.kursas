using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_10uzd
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new Random();

            var b = a.Next(1, 11);

            Console.WriteLine("atspekit slapta skaiciu 1 - 10");
            var c = Convert.ToInt32(Console.ReadLine());
            while (c!=b)
            {
                if (c>b)
                {
                    Console.WriteLine("skaicius yra mazesnis bandykite dar kart");
                    c = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("skaicius yra didesnis bandykite dar kart");
                    c = Convert.ToInt32(Console.ReadLine());
                }      
            }
            Console.WriteLine("jus esate teisus skacius buvo "+b);


        }
    }
}
