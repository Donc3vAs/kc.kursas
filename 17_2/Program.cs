using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_2_figure
{
    abstract class Figura
    {
        public abstract double Plotas();
    }

    class Trikampis: Figura
    {
        public int A { get; }
        public int B { get; }

        public override double Plotas()
        {
            return (A * B * 0.5);
        }
    }
    class Apstrakti: Figura
    {
        public int r { get; set; }
        public override double Plotas()
        {
            return (Math.PI * Math.Pow(r, 2));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Figura f = new Apstrakti();
            f.
        }
    }
}
