using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paveldejimas
{
    class Alko
    {
        private double Laipsniai { get; }
        public int Turis { get; }
        public string Spalva { get; }

        public Alko()
        {

        }

        public double getLaipsniai()
        {
            return Laipsniai;
        }

        /*public void SetLaipsniai(double Laipsniai)
        {
            this.Laipsniai = Laipsniai;
        }*/


        
        /// <summary>
        /// suskaiciuoja gaminio amzius
        /// </summary>
        /// <param name="gamybMet"></param>
        /// <returns></returns>
        public int Amzius(DateTime gamybMet)
        {
            return (DateTime.Today.Year - gamybMet.Year);
        }
        public Alko(double Laipsniai, int Turis, string Spalva)
        {
            this.Laipsniai = Laipsniai;
            this.Turis = Turis;
            this.Spalva = Spalva;
        }
    }
}
