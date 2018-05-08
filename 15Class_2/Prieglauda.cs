using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Class_2
{
    class Prieglauda
    {
        public string Pavadinimas;
        public string Adresas;
        // List<Suo> Sunys = new List<Suo>();
        public List<Suo> Sunys;
        public Prieglauda(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Sunys = new List<Suo>();
        }

        public Prieglauda(string pavadinimas, string adresas, List<Suo> sunys)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Sunys = sunys;
        }
        public void pinfo()
        {
            Console.WriteLine(Pavadinimas + " " + Adresas + ":");

            foreach (var c in Sunys)
            {
                c.sinfo();
            }
            Console.Write("vyriauses suo yra: ");
            VyriausesSuo().sinfo();
            Console.WriteLine();
            Console.WriteLine("amziaus vidurkis "+ SunuVidurkis());
            
        }
        public void Checkin()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(i + 1 + " suns duomenys:");
                Sunys.Add(new Suo());
            }
        }
        public Suo VyriausesSuo()
        {
            var vyriauses = Sunys.First();

            foreach (var s in Sunys)
            {
                if (s.Amzius > vyriauses.Amzius)
                {
                    vyriauses = s;

                }
            }
            return vyriauses;
        }
        public double SunuVidurkis()
        {
            double vid = 0;
            double sum = 0;
            foreach (var s in Sunys)
            {
                sum += s.Amzius;
            }
            vid = sum / Sunys.Count;

            return vid;
        }
    }
}
