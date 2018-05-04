using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_8uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            for (int i = 1; i < 101; i++)
            {
                a = a + i;
                Console.WriteLine(a);
            }
            Console.WriteLine(a);
        }
    }
}
