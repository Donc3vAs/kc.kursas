using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 6; i++)
            {
                int a = sk * i;
                Console.WriteLine("5*{0}={1}", i, a);
            }
        }
    }
}
