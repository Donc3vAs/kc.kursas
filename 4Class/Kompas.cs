using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Class
{
    class Kompas
    {
        //prop
        public string Vaizduske { get; private set; }
        public string Motinine { get; private set; }
        public int DiskoTalpa { get; private set; }
        



        public Kompas (string vaizduske, string motinine, int diskoTalpa)
        {
            Vaizduske = vaizduske;
            Motinine = motinine;
            DiskoTalpa = diskoTalpa;
        }

        public Kompas() { }

        public void isvedimas()
        {
            Console.WriteLine(Vaizduske + " " + Motinine + " " + DiskoTalpa);
        }
    }
}
