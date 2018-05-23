using System;
using System.Collections.Generic;
using System.Text;

namespace _17_1
{
    class VIP : Client
    {
        public override void skaic()
        {
            base.skaic();
            MS = MS - 2;
        }
        public VIP(int ID, string Vardas) : base(ID, Vardas)
        {

        }
    }
}
