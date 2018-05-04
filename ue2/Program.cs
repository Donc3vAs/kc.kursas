using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ue2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 0;
            var c = 0;
            for (int i = 0; i < 101; i++)
            {
                a = a + (i * i);
                b += i;
            }
            c = (b * b) - a;
            Console.WriteLine(c);
        }
    }
}
