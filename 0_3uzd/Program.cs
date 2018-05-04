using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_3uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pirmi metai: " + (suma+(suma*0.02)));
            Console.WriteLine("antri metai " + (suma + (suma * 0.04)));
        }
    }
}
