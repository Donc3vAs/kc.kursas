using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_1_uzduot
{
    public class Taskas
    {
        public int x { get; }
        public int y { get; }
        public Taskas(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Taskas> taskai = new List<Taskas>();
            Random rng = new Random();
            for (int i = 0; i < rng.Next(); i++)
            {
                taskai.Add(new Taskas(rng.Next(-10, -10), rng.Next(-10, -10)));
            }
            int xc = 2;
            int yc = 3;
            int r = 10;

            foreach (var item in taskai)
            {
                if (r > (Math.Sqrt(Math.Pow(item.x - xc, 2) + Math.Pow(item.y - yc, 2))))
                {
                    Console.WriteLine("Taskas {0} {1} yra apskritime", item.x, item.y);
                }  
            }
           
        }
    }
}
