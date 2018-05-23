using System;
using System.Collections.Generic;
using System.Text;

namespace _17_1
{
    class Silver : Client
    {
        public override void skaic()
        {
            base.skaic();
            MS = MS - 1;
        }
        public Silver(int ID, string Vardas) : base(ID, Vardas)
        {

        }
    }
}
