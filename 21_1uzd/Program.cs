using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_1uzd
{    
    class Program
    {
        public delegate int Mathd(int a, int b);

        static int Add(int a, int b)
        {
            Console.WriteLine(a+b);
            return (a + b);
        }
        static int Subs(int a, int b)
        {
            Console.WriteLine(a-b);
            return (a - b);
        }
        static void Main(string[] args)
        {
            Mathd sprend = Add;
            int a = 10;
            int b = 5;
            int sum = sprend(a, b);
            //Console.WriteLine(sprend(a,b));
            sprend += Subs;
            int sub = sprend(a, b);
            sprend -= Add;
            int ad = sprend(a, b);
            //Console.WriteLine(sprend(a,b));
        }
    }
}
