using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            string a= "";
            string c = "";
            while (c != "exit")
            {
                //a = a + c + " ";
                Console.Write("iveskite zodi ");
                c = Console.ReadLine();
                a += (c != "exit") ? c+ " " : "";
            }
            Console.WriteLine(a);
        }
    }
}
