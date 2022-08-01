using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testgeneric
{
    class X
    {

    }
    class Y
    {

    }
    class W:Y
    {

    }

    class Z<T1, T2>
        where T1 : X
        where T2 : Y
    {
        public static implicit operator Z<T1, T2>(Z<X, Y> v)
        {
            throw new NotImplementedException();
        }
    }
}
