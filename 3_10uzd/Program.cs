using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10uzd
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = "t";
            while (a == "t")
            {
                var b = Convert.ToInt32(Console.ReadLine());
                var c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(b + c);
                Console.WriteLine(b - c);
                Console.WriteLine(b * c);
                Console.WriteLine(b / c);
                Console.WriteLine("ar norite testi t\n");
                a = Console.ReadLine();

            }
        }
    }
}
