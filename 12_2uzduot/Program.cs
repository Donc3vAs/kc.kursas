using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2uzduot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mok = new int[] { 10, 9, 4, 10, 5, 8, 10 };
            var geriauses = mok[0];
            var great = 0;
            var sad = 0;
            var avr = 0;
            for (int i = 0; i < mok.Length; i++)
            {
                if (mok[i] > geriauses)
                {
                    geriauses = mok[i];
                }
                if (mok[i]==10)
                {
                    great++;
                }
                if (mok[i] <= 4)
                {
                    sad++;
                }
                avr += mok[i];
            }
            Console.WriteLine("geriauses pazymis " + geriauses);
            Console.WriteLine("10 gavo " + great + " mokiniu");
            Console.WriteLine("4 ir maziau gavo " + sad + " mokiniu");
            Console.WriteLine("Pazimiu vidurkis: " + (avr/mok.Length));

        }
    }
}
