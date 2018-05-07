using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_4uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            var cars = pr.masiniukai(); // masinos ir ju max greitis;
            pr.masiniuku_sarasas(cars);
        }


        public void masiniuku_sarasas(Dictionary<string, int> cars)
        {
            Console.WriteLine("Visi masiniukai;");
            foreach (var c in cars)
            {
                Console.WriteLine(c.Key + " " + c.Value);
            }
        }

        public Dictionary<string, int> masiniukai()
        {
            var cars = new Dictionary<string, int>();
            var masina = "";
            var greitis = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("iveskite auto pavadinima");
                masina = Console.ReadLine();
                Console.WriteLine("iveskis auto max greiti");
                greitis = Convert.ToInt32(Console.ReadLine());
                cars.Add(masina, greitis);
            }
            
            return cars;
        }
    }
}
