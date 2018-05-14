using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16GUI_failas
{
    public class Auto
    {
        public string Marke { get; private set; }
        public string Modelis { get; private set; }
        public int Metai { get; private set; }


        public Auto(string marke, string modelis, int matai)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = Metai;
        }
        public Auto(string eilute)
        {
            var duomenys = eilute.Split(';');
            Marke = duomenys[0];
            Modelis = duomenys[1];
            Metai = Convert.ToInt32(duomenys[2]);
        }
    }

    
}
