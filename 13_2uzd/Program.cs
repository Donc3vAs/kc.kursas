using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite listo dydi: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var lst = new List<int>();
            var avr = 0;

            for (int i = 0; i < a; i++)
            {
                Console.Write("iveskite pazimius: ");
                lst.Add(Convert.ToInt32(Console.ReadLine()));
            }
            var min = lst[0];
            var max = lst[0];
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] < min)
                {
                    min = lst[i];
                }
                if (lst[i] > max)
                {
                    max = lst[i];
                }
                avr += lst[i];
            }
            avr = avr / lst.Count;
            Console.WriteLine("minimalus " + min);
            Console.WriteLine("maksimalus " + max);
            Console.WriteLine("vidurkis " + avr);
            Random alf = new Random();
            Console.WriteLine(lst[alf.Next(lst.Count)]); 

        }
    }
}
