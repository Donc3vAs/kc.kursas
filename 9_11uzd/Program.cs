using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_11uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i%3 ==0 || i % 5 == 0)
                {
                    a = a + i;
                }
            }
            Console.WriteLine(a);
        }
    }
}
