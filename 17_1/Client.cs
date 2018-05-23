using System;
using System.Collections.Generic;
using System.Text;

namespace _17_1
{
    class Client
    {
        public int ID { get; }
        public string Vardas { get; set; }
        public int MS { get; protected set; }
        public Client(int ID, string Vardas)
        {
            this.ID = ID;
            this.Vardas = Vardas;            
        }

        public virtual void skaic()
        {
            MS = 2 + 2;
        }


    }
}
