using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testinter
{
    interface Imyint1
    {
        void fn1();
        void fn2();

    }
    class Class1:Imyint1
    {
       void Imyint1.fn1()
        {
            Console.WriteLine("interface-fn1");
        }
        void Imyint1.fn2()
        {
            Console.WriteLine("interface-fn2");
        }
        public void fn1()
        {
            Console.WriteLine("fn1");
        }
    }
}
