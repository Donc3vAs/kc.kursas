using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1uzd
{
    class Dalyviai
    {
        public string Vardas { get; set; }
        public int KiekSuvalge { get; set; }
        public int KiekTelpa { get; set; }

        public Dalyviai(string Vardas, int KiekSuvalge, int KiekTelpa)
        {
            this.Vardas = Vardas;
            this.KiekSuvalge = KiekSuvalge;
            this.KiekTelpa = KiekTelpa;
        }
    }

    class PersivalgeException: Exception 
    {
        public int KiekSuvalgyta { get; set; }
        public PersivalgeException(int KiekSuvalgyta)
        {
            this.KiekSuvalgyta = KiekSuvalgyta;
        }
    }
}
