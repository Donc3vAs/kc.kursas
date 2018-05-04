using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var listas = new List<int>();
            Random atsob = new Random();
                      
            for (int i = 0; i < 10; i++)
            {
                var ab = atsob.Next(1, 101);
                listas.Add(ab);
            }
            var min = listas[0];
            var max = listas[0];
            var avr = 0;
            var kiekmaz = 0;
            var sumlyg = 0;
            for (int i = 0; i < listas.Count; i++)
            {
                if (listas[i] < min)
                {
                    min = listas[i];
                }
                if (listas[i] > max)
                {
                    max = listas[i];
                }
                if (listas[i] % 2 ==0)
                {
                    sumlyg += listas[i];
                }
                avr += listas[i];

            }
            avr = avr / listas.Count;
            for (int i = 0; i < listas.Count; i++)
            {
                if (listas[i]<avr)
                {
                    kiekmaz++;
                }
            }
            Console.WriteLine("minimalus " + min);
            Console.WriteLine("maksimalus " + max);
            Console.WriteLine("vidurkis " + avr);
            Console.WriteLine("kiek maziau uz vidurki " + kiekmaz);
            Console.WriteLine("lyginiu sk suma " + sumlyg);
        }
    }
}
