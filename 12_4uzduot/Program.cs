using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4uzduot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fb = new int[10];
            var a = 1;
            var b = 1;
            var c = 1;
            fb[0] = a;
            fb[1] = b;
            for (int i = 0; i < 8; i++)
            {
                c = a + b;
                a = b;
                b = c;
                fb[i+2] = c;
            }
            foreach (var s in fb)
            {
                Console.Write(s + " ");
            }
        }
    }
}
