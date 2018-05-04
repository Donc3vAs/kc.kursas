using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3uzduot
{
    class Program
    {
        static void Main(string[] args)
        {
            var sand = 8;
            int[] km = new int[] { 200, 50, 110, 40, 80 };
            var il = 0;
            var trp = 0;
            var vid = 0;
            for (int i = 0; i < km.Length; i++)
            {
                if (km[i] > il)
                {
                    il = km[i];
                }
                if (km[i] < trp)
                {
                    trp = km[i];
                }
                vid = vid + km[i];
            }
            vid = vid / km.Length;
            Console.WriteLine("trumpaise kelion: " + trp);
            Console.WriteLine("ilgaiuse kelione: " + il);
            Console.WriteLine("vidutiniskai nuvaziuota: " + vid);
            Console.WriteLine("vidutiniskai sunaudojamos kuro sanaudos: " + (double)(vid * sand / 100));
        }
    }
}
