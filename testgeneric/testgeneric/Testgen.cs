using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testgeneric
{
    class Testgen<T1,T2>
    {
        T1 a;
        T2 b;
        public void setdata(T1 para)
        {
            a = para;
        }
        public T1 getdata()
        {
            return a;
        }

        public T2 bprop
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
    }
}
