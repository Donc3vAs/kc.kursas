using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ue3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 149;
            var b = 0;
            var c = 1;
            while (a > 1)
            {

                for (int i = 2; i < 10; i++)
                {
                    if (a % i == 0)
                    {
                        b = a / i;
                        c = c * i;
                        a = b;
                        break;
                    }


                }
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            Console.WriteLine(c=c*b);

        }
    }
}
