using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_2uzd
{
    class Photo
    {
        public delegate void PhotoFilerDelegate();



        public void ApplyFilter(PhotoFilerDelegate photoFilter)
        {
            photoFilter();
        }
    }
}
