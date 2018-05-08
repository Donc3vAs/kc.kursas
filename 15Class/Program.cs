using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Class
{
    class Auto
    {
        //public AbcAbc - pascal case
        // private _abcAbc - camel case
        public int GimMetai;
        public string Spalva;
        public string Marke;
        public long VIN;
        public int VNr;
        Program pr = new Program();
        public Auto()
        {

        }

        public Auto(int gimMetai, string spalva, string marke, long vIN, int VNr)
        {
            GimMetai = gimMetai;
            Spalva = spalva;
            Marke = marke;
            VIN = vIN;
            VNr = VNr;
        }

        public void info()
        {
            Console.WriteLine("m " + GimMetai + " s " + Spalva);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var auto = new Auto();
            auto.GimMetai = 2010;
            auto.Spalva = "zalia";
            //Console.WriteLine(auto.Spalva);

            var auto2 = new Auto()
            {
                GimMetai = 2001,
                Spalva = "geltona",
                Marke = "aaa"
            };
            var auto3 = new Auto(2005, "geltona", "aaa", 5355551544524, 5684);
            Program pr = new Program();
            auto3.info();
        }
    }
}
