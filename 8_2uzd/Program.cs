using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 stacionarus kompas");
            Console.WriteLine("2 nesiojamas kompas");
            Console.WriteLine("3 plancete");
            var a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("stacionarus kompas");
                    break;
                case 2:
                    Console.WriteLine("esiojamas kompas");
                    break;
                case 3:
                    Console.WriteLine("plancete");
                    break;
                default:
                    Console.WriteLine("siulyciau perskaityti dar kart");
                    break;
            }
        }
    }
}
