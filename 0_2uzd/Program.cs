using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_2uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var ilgis = Convert.ToInt32(Console.ReadLine());
            var plotis = Convert.ToInt32(Console.ReadLine());
            var kaina = Convert.ToDouble(Console.ReadLine());
            var sum = Convert.ToDouble((ilgis * plotis*kaina));
            Console.WriteLine(sum);
            Console.WriteLine(sum+(sum*0.05));



        }
    }
}
