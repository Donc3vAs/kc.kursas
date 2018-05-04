using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            for (int i = 30; i < 60; i++)
            {
                if (i % 2 != 0)
                {
                    a = a + i;
                }
            }
            Console.WriteLine(a);
        }
    }
}
