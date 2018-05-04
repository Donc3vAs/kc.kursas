using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = Convert.ToInt32( Console.ReadLine());
            string[] masyvas = new string[c];
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write("ivesk gyvunus: ");
                masyvas[i] = Console.ReadLine();
            }
            Console.Write("[");
            foreach (var b in masyvas)
            {
                Console.Write(b + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
