using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            var darbsk = Convert.ToInt32(Console.ReadLine());
            var darbpajeg = Convert.ToInt32(Console.ReadLine());
            var ksavik = Convert.ToInt32(Console.ReadLine());
            var kkaina = Convert.ToInt32(Console.ReadLine());
            var uzsak = Convert.ToInt32(Console.ReadLine());
            var kepalusk = darbsk * darbpajeg * 8;
            var visasavik = uzsak * ksavik;
            var pajamos = uzsak * kkaina;
            var pelnas = pajamos - visasavik;
            var nespejo = uzsak - kepalusk;
            Console.WriteLine("iskeps "+kepalusk );
            Console.WriteLine("visu kepalu savikaina " + (kepalusk * ksavik));
            Console.WriteLine("pajamos " + (kepalusk * kkaina));
            Console.WriteLine("pelnas " + ((kepalusk * kkaina) - (kepalusk * ksavik)));
            if (kepalusk < uzsak )
            {
                Console.WriteLine("nespes "+(uzsak-kepalusk) + " kepalu reikia");
                            }
            else
            {
                Console.WriteLine("spes");
                Console.WriteLine("visu kepalu savikaina " + visasavik);
                Console.WriteLine("pajamos " + pajamos);
                Console.WriteLine("pelnas " + pelnas);
            }
            Console.WriteLine();

        }
    }
}
