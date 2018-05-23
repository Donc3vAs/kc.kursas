using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_2uzd
{
    class Program
    {   
        /*public delegate void Action();
        public delegate void Action<T>(T arg);

        public delegate T Func<T>();
        public delegate T Func<T, K>(K arg);*/
        static void Main(string[] args)
        
        {
            Photo photo = new Photo();

            Action virt = RemoveRedEye;
            Action<int, int> math = Add;

            Func<string> pvzdys = A;
            Func<int, string> pvz = B;

            string result = pvzdys();
            string res = pvz(1);

            PhotoFiltras filtras = new PhotoFiltras();
            photo.ApplyFilter(filtras.Sepia);
            photo.ApplyFilter(RemoveRedEye);
        }

        static string A()
        {
            return "A";
        }
        static string B(string K)
        {
            return "B";
        }

        static void Add(int a, int b)
        {

        }


        static void RemoveRedEye()
        {
            Console.WriteLine("Pritaikomas Remove Red Eye filtras");
        }
    }
}
