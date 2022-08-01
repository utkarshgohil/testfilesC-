using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testoperatorover
{
    class Program
    {
        static void Main(string[] args)
        {
            Cpoint p1 = new Cpoint();
            p1.X = 10;
            p1.Y = 20;
            Cpoint p2 = new Cpoint(30,40);
            p1.prnt();
            p2.prnt();
            Cpoint p3 = new Cpoint();
            p3 = p1 + p2;
            p3.prnt();

            p1 = 100;
            p1.prnt();
            double d = (double)p1;
            Console.WriteLine(d);
        }
    }
}
