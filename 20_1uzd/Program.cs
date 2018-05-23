using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1uzd
{

    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("dalyviai.txt");
            List<Dalyviai> dalyviuSarasas = new List<Dalyviai>();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    string[] data = line.Split(' ');
                    Dalyviai dalyvis = new Dalyviai(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]));
                    if (dalyvis.KiekSuvalge > dalyvis.KiekTelpa)
                        throw new PersivalgeException(dalyvis.KiekSuvalge);
                    dalyviuSarasas.Add(dalyvis);
                }
                catch (PersivalgeException ex)
                {
                    Console.WriteLine("PERSIVAGE");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("nezinoma klaida");
                }
            }
            int max = int.MinValue;
            Dalyviai maxDalyvis = new Dalyviai(null, null, 0, 0);
            foreach (var item in dalyviuSarasas)
            {
                if (item.KiekSuvalge > max)
                {
                    max = item.KiekSuvalge;
                    maxDalyvis = item;
                }
            }
            Console.WriteLine("Laimejo {0), suvalge {1} ", maxDalyvis.Vardas, maxDalyvis.KiekSuvalge);



        }
    }
}
