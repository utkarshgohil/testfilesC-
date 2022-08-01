using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testgeneric
{
    class Classd<T1,T2>
    {
        public delegate void mydel(T1 a, T2 b);

        public void fn1(T1 i, T2 j,mydel d)
        {
            d(i, j);
        }
    }
}
