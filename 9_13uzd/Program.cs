using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_13uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 1;
            var c = 1;
            Console.Write(a + ", " + b + ", ");
            for (int i = 0; i < 20; i++)
            {
                c = a + b;                
                a = b;
                b = c;
                Console.Write(c + ", ");
            }
        }
    }
}
