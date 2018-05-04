using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = new int[] { 4, 5, 6, 8, 6, 3};
            /* sumos
            var sm = 0;
            foreach (var s in sk)
            {
                sm +=s;
            }
            Console.WriteLine(sm);
            Console.WriteLine(sk.Sum()); */

            /* maximumas
            var max = sk[0];
            foreach (var s in sk)
            {
                if (s > max)
                {
                    max = s;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(sk.Max()); */


        }
    }
}
