using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Class_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var prieglauda = new Prieglauda("5kt koja", "Ten",
                new List<Suo>
                {
                    new Suo(10, " dadw", "hgh/"),
                    new Suo(5, " bgfbgf", "hliul,uk"),
                    new Suo(10, " bgfngfh", "hsafewfc"),
                    new Suo(5, " dfgdrgdf", " jhmgh gf"),
                    new Suo(10, " bfdbfdb", "SArwefveshte")
                });
            prieglauda.pinfo();
        }
    }
}
