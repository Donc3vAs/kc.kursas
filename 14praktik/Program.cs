using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14praktik
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program(); //objektas
            var vv = programa.vv();
            var va = programa.amz();
            programa.Pasisveiktinit(vv, va);
            

        }
        public void Pasisveiktinit(string vardas, int amzius)
        {
            Console.WriteLine("labas " + vardas + " amzius " + amzius );
        }

        public string vv()
        {
            Console.WriteLine("iveskite vardas ");
            var vardas = Console.ReadLine();
            return vardas;
        }
        public int amz()
        {
            Console.WriteLine("iveskite amziu ");
            var a = Convert.ToInt32(Console.ReadLine());
            return a;
        }

    }
}
