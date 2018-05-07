using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Class
{
    class Auto
    {
        public int GimMetai;
        public string Spalva;
        public string Marke;
        public int VIN;
        public int VNr;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.GimMetai = 2010;
            auto.Spalva = "zalia";
            Console.WriteLine(auto.Spalva);
        }
    }
}
