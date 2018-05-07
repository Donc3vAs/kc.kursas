using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            // eurovizijos balai
            Program pr = new Program();
            var balai2016 = pr.Ivedimas();
            var balai2017 = pr.Ivedimas();
            pr.balai(balai2016);
            //pr.balai(balai2017);
            var blsum2016 = pr.blsum(balai2016);
            Console.WriteLine("2016 balu suma " + blsum2016);
            //var blsum2017 = pr.blsum(balai2017);
            var maz2016 = pr.maziauses(balai2016);
            var did2016 = pr.didziauses(balai2016);
            Console.WriteLine("maziauses " + balai2016.ElementAt(maz2016).Value);
            Console.WriteLine("didziauses " + balai2016.ElementAt(did2016).Value);
            Console.WriteLine("vidurkis: " + pr.vid(balai2016));
            pr.Palyginimas(balai2016, balai2016);
            
        }


        public void Palyginimas (Dictionary<string, int> bl1, Dictionary<string, int> bl2)
        {
            Program pr = new Program();
            var vid1 = pr.vid(bl1);
            var vid2 = pr.vid(bl2);
            if (vid1 > vid2)
            {
                Console.WriteLine("2016 balu vidurkis didesnis");
            }
            else
            {
                Console.WriteLine("2017 balu vidurkis didesnis");
            }

        }

        public double vid(Dictionary<string, int> bal)
        {
            Program pr = new Program();
            var vid = (double)pr.blsum(bal)/bal.Count;            
            return vid;
        }

        public int didziauses(Dictionary<string, int> did)
        {
            var indx = 0;
            var didb = did.ElementAt(0).Value;
            for (int i = 0; i < did.Count; i++)
            {
                if (did.ElementAt(i).Value > didb)
                {
                    indx = i;
                }
            }
            return indx;
        }

        public int maziauses(Dictionary<string, int> maz)
        {
            var indx = 0;
            var mazb = maz.ElementAt(0).Value;
            for (int i = 0; i < maz.Count; i++)
            {
                if (maz.ElementAt(i).Value < mazb)
                {
                    indx = i;
                }
            }
            return indx;
        }

        public int blsum(Dictionary<string, int> balai)
        {
            var sum = 0;
            foreach (var bl in balai)
            {
                sum += bl.Value;
            }

            return sum;
        }

        public void balai(Dictionary<string, int> balai)
        {
            foreach (var bls in balai)
            {
                Console.WriteLine("salis ir jos balai: " + bls.Key + " " + bls.Value);
            }
        }


        public Dictionary<string, int> Ivedimas()
        {
            var balai = new Dictionary<string, int>();
            Console.WriteLine("kiek norite ivest domenu");
            var c = Convert.ToInt32(Console.ReadLine());
            var salis = "";
            var balas = 0;
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("Iveskite sali");
                salis = Console.ReadLine();
                Console.WriteLine("Iveskite bala");
                balas = Convert.ToInt32(Console.ReadLine());
                balai.Add(salis, balas);
            }
            return balai;

        }



    }
}
