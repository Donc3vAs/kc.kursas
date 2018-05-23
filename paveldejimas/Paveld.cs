using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paveldejimas
{
    class Paveld: Alko
    {
        public string Rusis { get; }
        public string KilmesS { get; }

        public Paveld()
        {

        }
        public Paveld(double Laipsniai, int Turis, string Spalva, string Rusis)
            :base(Laipsniai, Turis, Spalva)
        {
            this.Rusis = Rusis;
        }
    }
}
