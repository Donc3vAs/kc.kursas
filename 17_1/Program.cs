using System;
using System.Collections.Generic;

namespace _17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> client = new List<Client>
            {
                new VIP(1, "Jurgis"),
                new Silver(2, "Antanas"),
                new Basic(3, "Petras")
            };
            foreach (var item in client)
            {
                item.skaic();
                Console.WriteLine(item.Vardas + " moketi reikia " + item.MS);
            }
        }
    }
}
