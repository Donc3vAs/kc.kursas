using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Class_3
{
    class Prekes
    {
        public string Pavadinimas;
        public int Kaina;
        public int Savikaina;
        public int Kiekis;
        
        public Prekes (string pavadinimas, int kaina, int savikaina, int kiekis)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            Savikaina = savikaina;
            Kiekis = kiekis;
        }
        public void Prinfo()
        {
            Console.WriteLine(Pavadinimas + " " + Kaina + " " + Savikaina + " " + Kiekis);
        }

    }
}
