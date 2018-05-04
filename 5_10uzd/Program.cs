using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_10uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            while (a%9!=0)
            {
                Console.Write("iveskite skaiciu");
                a = Convert.ToInt32(Console.ReadLine());                 
            }
            Console.WriteLine("jusu skaicius dalijasi is 9");
            

        }
    }
}
