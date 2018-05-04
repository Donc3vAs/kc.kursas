using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("blogai ivesta");
            }
            else
            {
                for (int i = a; i < b; i++)
                {
                    Console.WriteLine(i + " " + (i*i));
                }
            }  
        }
    }
}
