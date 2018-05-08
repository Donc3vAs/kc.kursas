using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Class_3
{
    class Parduotuve
    {
        public string Pavadinimas;
        public string Adresas;
        public int Plotas;
        public List<Prekes> Prek;

        public Parduotuve(string pavadinimas, string adresas, int plotas, List<Prekes> prek)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Plotas = plotas;
            Prek = prek;
        }
        //*****************************************************
        public void Painfo()
        {
            Console.WriteLine(Pavadinimas + " " + Adresas + " " + Plotas);
            foreach (var pr in Prek)
            {
                pr.Prinfo();
            }
            Console.WriteLine();
            PrekiuPelnas();
        }
        //***********************************************************
        public void PrekiuPelnas()
        {
            var daug_pr = Prek.First();
            var did_kain = Prek.First();
            var visaspelnas = 0;
            foreach (var pr in Prek)
            {
                // pelno isvedimas *******
                Console.Write(pr.Pavadinimas + " pelnas: ");
                Console.Write((pr.Kaina - pr.Savikaina) * pr.Kiekis);
                visaspelnas += (pr.Kaina - pr.Savikaina) *pr.Kiekis;
                Console.WriteLine();
                // likucio tikrinimas*****
                if (pr.Kiekis < 5)
                {
                    Console.Write("likutis per mažas");
                }
                else
                {
                    Console.WriteLine("likutis pakankamas");
                }
                // prekiu daugiause
                if (daug_pr.Kiekis < pr.Kiekis)
                {
                    daug_pr = pr;
                }                
                // didziause kaina 
                if(did_kain.Kaina < pr.Kaina)
                {
                    did_kain = pr;
                }                
            }
            Console.WriteLine("Daugiause yra: " + daug_pr.Pavadinimas);
            Console.WriteLine("Didziause kaina yra: " + did_kain.Pavadinimas);
            Console.WriteLine("Visas pelnas bus: " + visaspelnas);
        }
        //****************************************************************

    }
}
