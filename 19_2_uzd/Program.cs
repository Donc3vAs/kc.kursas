using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_2_uzd
{
    class skirtingiTipai<T,K, A> where T: IEnumerable<int>
    {
        public List<T> vienasTipas { get; set; }
        public List<K> antrasTipas { get; set; }
        public List<A> treciasTipas { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
           /* System.IO.StreamReader reader = new System.IO.StreamReader("vidurkis.txt");
            List<List<int>> sarasas = new List<List<int>>();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(' ');
                List<int> tempData = new List<int>();

                foreach (var item in data)
                {
                    tempData.Add(int.Parse(item));
                }
                sarasas.Add(tempData);
            }

            foreach (var item in sarasas)
            {
                Console.WriteLine("mokiniu vidurkis yra {0:0.00}", item.Average());
            }
            Console.WriteLine();
            /*var laikinakopija = sarasas.ToArray();
            for (int i = 0; i < laikinakopija[0].Count(); i++)
            {
                int suma = 0;
                int divider = 0;
                for (int j = 0; j < laikinakopija.Length; j++)
                {
                    suma += laikinakopija[j].ElementAt(i);
                    Console.WriteLine("mokiniu vidurkis yra {0:0.00}", ((double)suma divider));
        }
            List<List<int>> surikiuotassrasas = new List<List<int>>();
            while (sarasas.Count!=0)
            {
                List<int> maxmember = new List<int>();
            }*/
            List<skirtingiTipai<IEnumerable<int>, string, char>> kazkas = new List<skirtingiTipai<IEnumerable<int>, string, char>>();
        }

        
    }
}



