using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Class_2
{
    class Suo
    {
        public int Amzius;
        public string Veisle;
        public string Vardas;


        public Suo(int amzius, string veisle, string vardas)
        {
            Amzius = amzius;
            Veisle = veisle;
            Vardas = vardas;
        } 
        
        public void sinfo()
        {
            Console.WriteLine(Amzius + " " + Veisle + " " + Vardas);
        }
        public Suo()
        {
            Console.WriteLine("iveskite amziu");
            Amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite veisle");
            Veisle = Console.ReadLine();
            Console.WriteLine("iveskite Varda");
            Vardas = Console.ReadLine();
        }
    }
}
