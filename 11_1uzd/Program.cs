using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var gyvunas = "";
            do
            {
                Console.WriteLine("Rinkites lape, kate, meska");
                gyvunas = Console.ReadLine();
                if(gyvunas != "lape" && gyvunas != "kate" && gyvunas != "meska")
                {
                    Console.WriteLine("jus pasirinkote blogai");
                }
            } while (gyvunas != "lape" && gyvunas != "kate" && gyvunas != "meska");
            Console.WriteLine("pasirinkote: "+ gyvunas);
        }
    }
}
