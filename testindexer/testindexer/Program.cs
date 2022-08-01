using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testindexer
{
    class Program
    {
        static void Main(string[] args)
        {
            testind t=new testind();
            t[0] = "abc";
            t[1] = "xyz";
            Console.WriteLine(t[0]);
            Console.WriteLine(t[1]);
        }
    }
}
