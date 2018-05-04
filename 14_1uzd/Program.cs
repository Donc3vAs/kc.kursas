using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var pr = new Program();
            pr.sk();
        }
        public void sk()
        {
            var pr = new Program();
            Console.WriteLine("skaicius1");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("skaicius1");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pr.skaic(a, b));

        }
        public int skaic(int c, int v)
        {
            int k = c + v;
            return k;
        }


    }
}
