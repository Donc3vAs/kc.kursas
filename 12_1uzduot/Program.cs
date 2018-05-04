using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1uzduot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tmp = new int[] { 10, 12, 15, 11, 5, 8, 19 };
            var min = tmp[0];
            var max = tmp[0];
            int avr = 0;
            int minavr = 0;
            int maxavr = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] < min)
                {
                    min = tmp[i];
                }
                if (tmp[i] > max)
                {
                    max = tmp[i];
                }
                avr = avr + tmp[i];
            }
            avr = avr / tmp.Length;
            Console.WriteLine("maziause: " + min);
            Console.WriteLine("didziause: " + max);
            Console.WriteLine("vidurkis: " + avr);
            Console.Write("zemesnes temperaturos: ");
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] < avr)
                {
                    Console.Write(tmp[i] + " ");
                }
            }
            Console.WriteLine();
            Console.Write("didesnes temperaturos: ");
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] > avr)
                {
                    Console.Write(tmp[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
