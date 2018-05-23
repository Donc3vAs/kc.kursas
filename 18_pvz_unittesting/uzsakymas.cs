using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_pvz_unittesting
{
    public class Siuntimas : ISiuntimas
    {
        public bool IsShipped { get; }
        public int SiuntosSkaiciuotuvas()
        {
            if (IsShipped == false)
            {
                throw new Exception(message: "Siunta jau isiusta");
            }
            // Do something
            return 20;
        }
        public Siuntimas (bool IsShipped)
        {
            this.IsShipped = IsShipped;
        }

    }

    public interface ISiuntimas
    {
        bool IsShipped { get; }
        int SiuntosSkaiciuotuvas();

    }

    public class Uzsakymas
    {
        public int Kaina { get; set; }
        public ISiuntimas Siunta { get; set; }    
        public string Client { get; set; }

        public void PO()
        {
            Kaina = Siunta.SiuntosSkaiciuotuvas() + 20;
        }

        public Uzsakymas(ISiuntimas Siunta)
        {
            this.Siunta = Siunta;
        }

    }
}
