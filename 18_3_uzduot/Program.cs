using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_3_uzduot
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite id ir vardas");
            string[] data = Console.ReadLine().Split(' ');

            Darbuotojas zmog = new Darbuotojas(int.Parse(data[0]), data[1]);
            zmog.DarbuotInfo();
        }
    }
}
