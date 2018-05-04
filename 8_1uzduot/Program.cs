using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1uzduot
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("vanduo");
                    break;
                case 2:
                    Console.WriteLine("kava");
                    break;
                case 3:
                    Console.WriteLine("arbata");
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;
            }
        }
    }
}
