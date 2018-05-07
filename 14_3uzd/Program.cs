using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_3uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var pr = new Program();
            var skaic = pr.listas();
            var suma = pr.suma(skaic);
            Console.Write("[");
            /*foreach (var sk in skaic)
            {
                Console.Write(sk + " ");
            }*/
            for (int i = 0; i < skaic.Count; i++)
            {
                Console.Write(skaic[i]);
                if (i != skaic.Count-1)
                {
                    Console.Write(", ");
                }

            }
            Console.Write("]");
            Console.WriteLine();
            pr.avr(suma, skaic);
        }
        public List<int> listas()
        {
            var lst = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ivest skaiciu");
                lst.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return lst;
        }
        public int suma(List<int> a)
        {
            int sum = a.Sum();
            Console.WriteLine("Bendra suma: " + a.Sum());
            return sum;
        }
        public void avr(int a, List<int> b)
        {
            Console.WriteLine("vidurkis: " + (double)a/b.Count());
        }
    }
}
