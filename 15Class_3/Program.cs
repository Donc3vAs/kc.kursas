using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var parduotuve = new Parduotuve("iki", "J.K 105-18", 200,
                new List<Prekes>
                {
                    new Prekes("Duona", 100, 60, 20),
                    new Prekes("Batonas", 90, 50, 30),
                    new Prekes("Grietine", 150, 100, 20),
                    new Prekes("Druska", 40, 10, 15),
                    new Prekes("Cukrus", 170, 90, 10),
                });
            parduotuve.Painfo();

        }
    }
}
