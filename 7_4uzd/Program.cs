using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_4uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            if (a>b || a ==0)
            {
                Console.WriteLine("pirmas");
            }
            if (b>a || b ==5)
            {
                Console.WriteLine("antras");
            }
            if (a>b && a==20)
            {
                Console.WriteLine("trecias");
            }
            if (b>a && b <100)
            {
                Console.WriteLine("ketvirtas");
            }
        }
    }
}
